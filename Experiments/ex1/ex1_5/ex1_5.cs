using System;
using System.Collections.Generic;
using System.Linq;

namespace ex1_5 {
    public class MyVector<T> {
        private T[] val;
        private int size;
        private int length;

        public int Size { get => size; set => size = value; }
        public int Length { get => length; set => length = value; }

        public MyVector(int size) {
            this.size = size;
            val = new T[size];
            for (int i = 0; i < size; ++i) {
                Add(default);
            }
        }
        override public string ToString() {
            string res = "[";
            for (int i = 0; i < length; ++i) {
                res += " " + val[i];
            }
            res += " ]";
            return res;
        }

        public void Expand() {
            size = size << 1;
            T[] tmp = new T[size];
            Array.Copy(val, 0, tmp, 0, val.Length);
            val = tmp;
        }
        public void Add(T e) {
            if (length >= size) {
                Expand();
            }
            val[length++] = e;
        }
        public T Get(int index) {
            T res;
            try {
                res = val[index];
            } catch (IndexOutOfRangeException) {
                System.Console.WriteLine("Error: Index {0} out of range.", index);
                res = default;
            }
            return res;
        }
        public void Set(int index, T e) {
            try {
                val[index] = e;
            } catch (IndexOutOfRangeException) {
                System.Console.WriteLine("Error: Index {0} out of range.", index);
            }
        }
        public void Remove(int index) {
            try {
                List<T> tmp = val.ToList();
                tmp.RemoveAt(index);
                val = tmp.ToArray();
                --length;
            } catch (ArgumentOutOfRangeException) {
                System.Console.WriteLine("Error: Index {0} out of range.", index);
            }
        }
        public T this[int index] {
            get => Get(index);
            set => Set(index, value);
        }

    }

    class ex1_5 {
        static void Main(string[] args) {
            MyVector<double> v = new MyVector<double>(5);
            System.Console.WriteLine("Original:\t {0}", v.ToString());
            for (int i = 0; i < v.Length; ++i) {
                v.Set(i, i);
            }
            System.Console.WriteLine("Set initial:\t {0}", v.ToString());
            System.Console.WriteLine("Get v[2]:\t {0}", v.Get(2));
            System.Console.WriteLine("Get v[10]:\t {0}", v.Get(10));
            v.Add(10.1);
            System.Console.WriteLine("Add '10.1':\t {0}", v.ToString());
            v.Remove(0);
            System.Console.WriteLine("Remove v[0]:\t {0}", v.ToString());
            System.Console.WriteLine("Get v[2] by index: {0}", v[2]);
        }
    }
}