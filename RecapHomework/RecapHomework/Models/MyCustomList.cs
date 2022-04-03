using System;
using System.Collections.Generic;
using System.Text;

namespace RecapHomework.Models
{
    public class MyCustomList<T>
    {
        private T[]? _list = new T[0];

        public T this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

        public MyCustomList() { }
        public MyCustomList(int length)
        {
            Array.Resize(ref _list, length);
        }

        public void Add(T value)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[^1] = value;
        }
        public int Count()
        {
            T[]? nullArray = Array.FindAll<T>(_list, n => n == null);
            return _list.Length - nullArray.Length;
        }
        public void AddRange(T[] collection)
        {
            foreach (T item in collection)
            {
                Array.Resize(ref _list, _list.Length + 1);
                _list[^1] = item;
            }
        }
        public void Clear()
        {
            Array.Clear(_list, 0, _list.Length);
        }
        public T[] ToArray()
        {
            return _list;
        }
        public void AsReadOnly()
        {
            Array.AsReadOnly(_list);
        }
        public void BinarySearch(T item)
        {
            Array.BinarySearch(_list, item);
        }
        public int Capacity()
        {
            return _list.Length;
        }
        public bool Contains(T item)
        {
            if (Array.BinarySearch(_list, item) < 0) return false;
            else return true;
        }
        public TOutput[] ConvertAll<TInput, TOutput>(Converter<TInput, TOutput> converter)
        {
            TInput[] array = _list as TInput[];
            return Array.ConvertAll<TInput, TOutput>(array, converter);
        }
        public void CopyTo(ref T[] array)
        {
            array = _list;
        }
        public bool Equals(T[] array)
        {
            if (_list == array) return true;
            else return false;
        }
        public bool Exists(Predicate<T> predicate)
        {
            if (Array.Exists<T>(_list, predicate) is true) return true;
            else return false;
        }
        public T Find(Predicate<T> predicate)
        {
            return Array.Find<T>(_list, predicate);
        }
        public T[] FindAll(Predicate<T> predicate)
        {
            return Array.FindAll<T>(_list, predicate);
        }
        public int FindIndex<T>(T[] array, Predicate<T> predicate)
        {
            return Array.FindIndex<T>(_list as T[], predicate);
        }
        public int FindLastIndex<T>(T[] array, Predicate<T> predicate)
        {
            return Array.FindLastIndex<T>(_list as T[], predicate);
        }
        public void ForEach<T>(T[] array, Action<T> action)
        {
            Array.ForEach<T>(_list as T[], action);
        }
        public T[] GetRange(int down, int up)
        {
            T[] rangeArr = new T[up - down];
            int temp = 0;
            for (int i = down; i < up; i++)
            {
                rangeArr[temp] = _list[i];
                temp++;
            }
            return rangeArr;
        }
        public int IndexOf(T item)
        {
            return Array.IndexOf(_list, item);
        }
        public void Insert(int index, T item)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[^1] = _list[index];
            _list[index] = item;
        }
        public void InsertRange(int index, T[] collection)
        {
            foreach (T item in collection)
            {
                Array.Resize(ref _list, _list.Length + 1);
                _list[^1] = _list[index];
                _list[index] = item;
            }
        }
        public int LastIndexOf(T item)
        {
            return Array.LastIndexOf<T>(_list, item);
        }
        public void Remove(T item)
        {
            _list[Array.IndexOf(_list, item)] = default(T);
        }
        public void RemoveAll(int down, int up)
        {
            Array.Clear(_list, down, up);
        }
        public void RemoveAt(int index)
        {
            _list[index] = default(T);
        }
        public void RemoveRange(int index, int count)
        {
            Array.Clear(_list, index, index + count);
        }
        public void Reverse()
        {
            Array.Reverse(_list);
        }
        public void Sort()
        {
            Array.Sort(_list);
        }
        public void TrimExcess()
        {
            int n = 1;
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i] == null)
                {
                    _list[i] = _list[^n];
                    n++;
                }
            }
            T[]? nullArray = Array.FindAll<T>(_list, n => n == null);
            Array.Resize(ref _list, _list.Length - nullArray.Length);
        }
        public bool TrueForAll(Predicate<T> predicate)
        {
            return Array.TrueForAll<T>(_list as T[], predicate);
        }
}
}
