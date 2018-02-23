

using System;
using Root.Code.Exts.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections.Generic;

namespace Root.Code.Api.E01D.Core.Sorting
{
    public class QuicksortApi
    {
        

        public void QuickSort(int[] data, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            var num = data[start];
            var i = start;
            var j = end;

            while (i < j)
            {
                while (i < j && data[j] > num)
                {
                    j--;
                }

                data[i] = data[j];

                while (i < j && data[i] < num)
                {
                    i++;
                }

                data[j] = data[i];
            }

            data[i] = num;
            QuickSort(data, start, i - 1);
            QuickSort(data, i + 1, end);
        }

        public void QuickSort(string[] data, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            var num = data[start];
            var i = start;
            var j = end;

            while (i < j)
            {
                var compare = string.CompareOrdinal(data[j], num);

                while (i < j && compare > 0)
                {
                    j--;
                }

                data[i] = data[j];

                compare = string.CompareOrdinal(data[i], num);

                while (i < j && compare < 0)
                {
                    i++;
                }

                data[j] = data[i];
            }

            data[i] = num;
            QuickSort(data, start, i - 1);
            QuickSort(data, i + 1, end);
        }


        public void Sort(System.Collections.Generic.List<string> items)
        {
            Sort(items, 0, items.Count - 1);
        }

        public void Sort(System.Collections.Generic.List<string> items, int start, int end)
        {
            if (start >= end) return;

            var p = Partition(items, start, end);

            Sort(items, start, p - 1);

            Sort(items, p + 1, end);
        }

        public int Partition(System.Collections.Generic.List<string> items, int lowerLimit, int upperLimit)
        {
            int i = lowerLimit;
            int j = upperLimit;
            
            while (j != i)
            {
                var compareValue = string.CompareOrdinal(items[i], items[j]);

                if (compareValue <= 0)
                {
                    i++;
                }
                else
                {
                    Swap(items, i, j);
                    Swap(items, i, j - 1);
                    j--;
                }
            }
            return i;
        }

        public void Swap(System.Collections.Generic.List<string> items, int p, int s)
        {
            string tmp = items[p];
            items[p] = items[s];
            items[s] = tmp;
        }

        public void Sort(List<string> items)
        {
            Sort(items, 0, items.Count - 1);
        }

        public void Sort(List<string> items, int start, int end)
        {
            if (start >= end) return;

            var p = Partition(items, start, end);

            Sort(items, start, p - 1);

            Sort(items, p + 1, end);
        }

        public int Partition(List<string> items, int lowerLimit, int upperLimit)
        {
            int i = lowerLimit;
            int j = upperLimit;

            while (j != i)
            {
                var compareValue = string.CompareOrdinal(items.GetItem(i), items.GetItem(j));

                if (compareValue <= 0)
                {
                    i++;
                }
                else
                {
                    Swap(items, i, j);
                    Swap(items, i, j - 1);
                    j--;
                }
            }
            return i;
        }

        public void Swap(List<string> items, int p, int s)
        {
            var tmp = items.GetItem(p);
            items.SetItem(p, items.GetItem(s));
            items.SetItem(s, tmp);
        }

        public void Sort<T>(List<T> items, Func<T, T, long> compare)
        {
            Sort(items, compare, 0, items.Count - 1);
        }

        public void Sort<T>(List<T> items, Func<T, T, long> compare, int start, int end)
        {
            if (start >= end) return;

            var p = Partition(items, compare, start, end);

            Sort(items, compare, start, p - 1);

            Sort(items, compare, p + 1, end);
        }

        public int Partition<T>(List<T> items, Func<T, T, long> compare, int lowerLimit, int upperLimit)
        {
            int i = lowerLimit;
            int j = upperLimit;

            while (j != i)
            {
                var compareValue = compare(items.GetItem(i), items.GetItem(j));

                if (compareValue <= 0)
                {
                    i++;
                }
                else
                {
                    Swap(items, i, j);
                    Swap(items, i, j - 1);
                    j--;
                }
            }
            return i;
        }

        public void Swap<T>(List<T> items, int p, int s)
        {
            var tmp = items.GetItem(p);
            items.SetItem(p, items.GetItem(s));
            items.SetItem(s, tmp);
        }

        public void Sort<T>(System.Collections.Generic.List<T> items, Func<T, T, long> compare)
        {
            Sort(items, compare, 0, items.Count - 1);
        }

        public void Sort<T>(System.Collections.Generic.List<T> items, Func<T, T, long> compare, int start, int end)
        {
            if (start >= end) return;

            var p = Partition(items, compare, start, end);

            Sort(items, compare, start, p - 1);

            Sort(items, compare, p + 1, end);
        }

        public int Partition<T>(System.Collections.Generic.List<T> items, Func<T, T, long> compare, int lowerLimit, int upperLimit)
        {
            int i = lowerLimit;
            int j = upperLimit;

            while (j != i)
            {
                var compareValue = compare(items[i], items[j]);

                if (compareValue <= 0)
                {
                    i++;
                }
                else
                {
                    Swap(items, i, j);
                    Swap(items, i, j - 1);
                    j--;
                }
            }
            return i;
        }

        public void Swap<T>(System.Collections.Generic.List<T> items, int p, int s)
        {
            var tmp = items[p];
            items[p] = items[s];
            items[s] = tmp;
        }
    }
}
