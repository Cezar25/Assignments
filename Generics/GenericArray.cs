using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //Generic array class
    public class GenericArray<T> : IEnumerable<T>
    {
        private int count;
        public T[] Items;

        public GenericArray(T[] items)
        {
            count = items.Length;
            Items = items;
        }
        public T GetByIndex(int index)
        {
            return Items[index];
        }
        public void SetByIndex(int index,T key)
        {
            Items[index] = key;
        }

        public void SwapItems(int index1, int index2)
        {
            (Items[index1], Items[index2]) = (Items[index2], Items[index1]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Items)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
