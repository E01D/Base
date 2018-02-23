using System;
using Root.Code.Exts.E01D.Core.Collections;
using ArrayList = Root.Code.Models.E01D.Core.Collections.ArrayList;

namespace Root.Code.Components.E01D.Core.Collections
{
    public class ArrayListEnumeratorSimple: System.Collections.IEnumerator
    {
        private readonly ArrayList list;
        private int index;
        private readonly int version;
        private Object currentElement;
        [NonSerialized]
        private readonly bool isArrayList;
        // this object is used to indicate enumeration has not started or has terminated
        static readonly Object dummyObject = new Object();

        public ArrayListEnumeratorSimple(ArrayList list)
        {
            this.list = list;
            index = -1;
            version = list.Version;
            isArrayList = (list.GetType() == typeof(ArrayList));
            currentElement = dummyObject;
        }

        public Object Clone()
        {
            return MemberwiseClone();
        }

        public bool MoveNext()
        {
            if (version != list.Version)
            {
                throw new InvalidOperationException("InvalidOperation_EnumFailedVersion");
            }

            if (isArrayList)
            {  // avoid calling virtual methods if we are operating on ArrayList to improve performance
                if (index < list.Count - 1)
                {
                    currentElement = list.Items[++index];
                    return true;
                }
                else
                {
                    currentElement = dummyObject;
                    index = list.Count;
                    return false;
                }
            }
            else
            {
                if (index < list.Count - 1)
                {
                    currentElement = list.GetValue(index);
                    return true;
                }
                else
                {
                    index = list.Count;
                    currentElement = dummyObject;
                    return false;
                }
            }
        }

        public Object Current
        {
            get
            {
                object temp = currentElement;
                if (dummyObject == temp)
                { // check if enumeration has not started or has terminated
                    if (index == -1)
                    {
                        throw new InvalidOperationException("InvalidOperation_EnumNotStarted");
                    }
                    else
                    {
                        throw new InvalidOperationException("InvalidOperation_EnumEnded");
                    }
                }

                return temp;
            }
        }

        public void Reset()
        {
            if (version != list.Version)
            {
                throw new InvalidOperationException("InvalidOperation_EnumFailedVersion");
            }

            currentElement = dummyObject;
            index = -1;
        }
    }
}
