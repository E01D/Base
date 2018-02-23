using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using Root.Coding.Code.Domains.E01D;


namespace Root.Code.Api.E01D.Core.Collections
{
    public class SortingApi
    {
        // This is the threshold where Introspective sort switches to Insertion sort.
        // Imperically, 16 seems to speed up most cases without slowing down others, at least for integers.
        // Large value types may benefit from a smaller number.
        public const int IntrosortSizeThreshold = 16;

        public const int QuickSortDepthThreshold = 32;

        public void Sort<T>(T[] keys, int index, int length, IComparer<T> comparer)
        {
            Debug.Assert(keys != null, "Check the arguments in the caller!");
            Debug.Assert(index >= 0 && length >= 0 && (keys.Length - index >= length), "Check the arguments in the caller!");

            // Add a try block here to detect IComparers (or their
            // underlying IComparables, etc) that are bogus.
            try
            {
                if (comparer == null)
                {
                    comparer = Comparer<T>.Default;
                }

                IntrospectiveSort(keys, index, length, comparer.Compare);
            }
            catch (IndexOutOfRangeException)
            {
                ThrowOrIgnoreBadComparer(comparer);
            }
            catch (System.Exception)
            {
                throw XExceptions.InvalidOperation.ComparerFailed();
            }
        }

        public void ThrowOrIgnoreBadComparer(Object comparer)
        {
            throw XExceptions.InvalidOperation.InconsistentResultsFromICompare(comparer);
        }

        public int FloorLog2(int n)
        {
            int result = 0;

            while (n >= 1)
            {
                result++;
                n = n / 2;
            }
            return result;
        }

        public int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer)
        {
            try
            {
                if (comparer == null)
                {
                    comparer = Comparer<T>.Default;
                }

                return InternalBinarySearch<T>(array, index, length, value, comparer);
            }
            catch (System.Exception e)
            {
                XLog.LogException(e);

                throw XExceptions.InvalidOperation.FailedToCompareTwoElementsInArray();
            }
        }

        public static int InternalBinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer)
        {
            Contract.Requires(array != null, "Check the arguments in the caller!");
            Contract.Requires(index >= 0 && length >= 0 && (array.Length - index >= length), "Check the arguments in the caller!");

            int lo = index;
            int hi = index + length - 1;
            while (lo <= hi)
            {
                int i = lo + ((hi - lo) >> 1);
                int order = comparer.Compare(array[i], value);

                if (order == 0) return i;
                if (order < 0)
                {
                    lo = i + 1;
                }
                else
                {
                    hi = i - 1;
                }
            }

            return ~lo;
        }

        public void Sort<T>(T[] keys, int index, int length, Comparison<T> comparer)
        {
            Debug.Assert(keys != null, "Check the arguments in the caller!");
            Debug.Assert(index >= 0 && length >= 0 && (keys.Length - index >= length), "Check the arguments in the caller!");
            Debug.Assert(comparer != null, "Check the arguments in the caller!");

            // Add a try block here to detect bogus comparisons
            try
            {
                IntrospectiveSort(keys, index, length, comparer);
            }
            catch (IndexOutOfRangeException)
            {
                ThrowOrIgnoreBadComparer(comparer);
            }
            catch (System.Exception e)
            {
                XLog.LogException(e);

                throw XExceptions.InvalidOperation.FailedToCompareTwoElementsInArray();
            }
        }

        private void SwapIfGreater<T>(T[] keys, Comparison<T> comparer, int a, int b)
        {
            if (a != b)
            {
                if (comparer(keys[a], keys[b]) > 0)
                {
                    T key = keys[a];
                    keys[a] = keys[b];
                    keys[b] = key;
                }
            }
        }

        private void Swap<T>(T[] a, int i, int j)
        {
            if (i != j)
            {
                T t = a[i];
                a[i] = a[j];
                a[j] = t;
            }
        }

        internal void IntrospectiveSort<T>(T[] keys, int left, int length, Comparison<T> comparer)
        {
            Contract.Requires(keys != null);
            Contract.Requires(comparer != null);
            Contract.Requires(left >= 0);
            Contract.Requires(length >= 0);
            Contract.Requires(length <= keys.Length);
            Contract.Requires(length + left <= keys.Length);

            if (length < 2)
                return;

            IntroSort(keys, left, length + left - 1, 2 * FloorLog2(keys.Length), comparer);
        }

        public void IntroSort<T>(T[] keys, int lo, int hi, int depthLimit, Comparison<T> comparer)
        {
            Contract.Requires(keys != null);
            Contract.Requires(comparer != null);
            Contract.Requires(lo >= 0);
            Contract.Requires(hi < keys.Length);

            while (hi > lo)
            {
                int partitionSize = hi - lo + 1;
                if (partitionSize <= IntrosortSizeThreshold)
                {
                    if (partitionSize == 1)
                    {
                        return;
                    }
                    if (partitionSize == 2)
                    {
                        SwapIfGreater(keys, comparer, lo, hi);
                        return;
                    }
                    if (partitionSize == 3)
                    {
                        SwapIfGreater(keys, comparer, lo, hi - 1);
                        SwapIfGreater(keys, comparer, lo, hi);
                        SwapIfGreater(keys, comparer, hi - 1, hi);
                        return;
                    }

                    InsertionSort(keys, lo, hi, comparer);
                    return;
                }

                if (depthLimit == 0)
                {
                    Heapsort(keys, lo, hi, comparer);
                    return;
                }
                depthLimit--;

                int p = PickPivotAndPartition(keys, lo, hi, comparer);
                // Note we've already partitioned around the pivot and do not have to move the pivot again.
                IntroSort(keys, p + 1, hi, depthLimit, comparer);
                hi = p - 1;
            }
        }

        public int PickPivotAndPartition<T>(T[] keys, int lo, int hi, Comparison<T> comparer)
        {
            Contract.Requires(keys != null);
            Contract.Requires(comparer != null);
            Contract.Requires(lo >= 0);
            Contract.Requires(hi > lo);
            Contract.Requires(hi < keys.Length);
            Contract.Ensures(Contract.Result<int>() >= lo && Contract.Result<int>() <= hi);

            // Compute median-of-three.  But also partition them, since we've done the comparison.
            int middle = lo + ((hi - lo) / 2);

            // Sort lo, mid and hi appropriately, then pick mid as the pivot.
            SwapIfGreater(keys, comparer, lo, middle);  // swap the low with the mid point
            SwapIfGreater(keys, comparer, lo, hi);   // swap the low with the high
            SwapIfGreater(keys, comparer, middle, hi); // swap the middle with the high

            T pivot = keys[middle];
            Swap(keys, middle, hi - 1);
            int left = lo, right = hi - 1;  // We already partitioned lo and hi and put the pivot in hi - 1.  And we pre-increment & decrement below.

            while (left < right)
            {
                while (comparer(keys[++left], pivot) < 0) ;
                while (comparer(pivot, keys[--right]) < 0) ;

                if (left >= right)
                    break;

                Swap(keys, left, right);
            }

            // Put pivot in the right location.
            Swap(keys, left, (hi - 1));
            return left;
        }

        public void Heapsort<T>(T[] keys, int lo, int hi, Comparison<T> comparer)
        {
            Contract.Requires(keys != null);
            Contract.Requires(comparer != null);
            Contract.Requires(lo >= 0);
            Contract.Requires(hi > lo);
            Contract.Requires(hi < keys.Length);

            int n = hi - lo + 1;
            for (int i = n / 2; i >= 1; i = i - 1)
            {
                DownHeap(keys, i, n, lo, comparer);
            }
            for (int i = n; i > 1; i = i - 1)
            {
                Swap(keys, lo, lo + i - 1);
                DownHeap(keys, 1, i - 1, lo, comparer);
            }
        }

        public void DownHeap<T>(T[] keys, int i, int n, int lo, Comparison<T> comparer)
        {
            Contract.Requires(keys != null);
            Contract.Requires(comparer != null);
            Contract.Requires(lo >= 0);
            Contract.Requires(lo < keys.Length);

            T d = keys[lo + i - 1];
            int child;
            while (i <= n / 2)
            {
                child = 2 * i;
                if (child < n && comparer(keys[lo + child - 1], keys[lo + child]) < 0)
                {
                    child++;
                }
                if (!(comparer(d, keys[lo + child - 1]) < 0))
                    break;
                keys[lo + i - 1] = keys[lo + child - 1];
                i = child;
            }
            keys[lo + i - 1] = d;
        }

        public void InsertionSort<T>(T[] keys, int lo, int hi, Comparison<T> comparer)
        {
            Contract.Requires(keys != null);
            Contract.Requires(lo >= 0);
            Contract.Requires(hi >= lo);
            Contract.Requires(hi <= keys.Length);

            int i, j;
            T t;
            for (i = lo; i < hi; i++)
            {
                j = i;
                t = keys[i + 1];
                while (j >= lo && comparer(t, keys[j]) < 0)
                {
                    keys[j + 1] = keys[j];
                    j--;
                }
                keys[j + 1] = t;
            }
        }
    }
}
