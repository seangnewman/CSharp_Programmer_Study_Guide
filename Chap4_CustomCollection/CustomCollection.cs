using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4_CustomCollection
{
    class CustomCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>
    {
        List<T> list = new List<T>();

        public T this[int index] { get => list[index]; set => list[index] = value; }

        public int Count => list.Count();

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

       

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
