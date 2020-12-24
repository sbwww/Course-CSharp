using System;

namespace ex1_3 {
    class ex1_3 {
        public static void swap(int x, int y) {
            int t = x;
            x = y;
            y = t;
        }
        public static void swap(ref int x, ref int y) {
            int t = x;
            x = y;
            y = t;
        }
        public static void change(int[] arr) {
            for (int i = 0; i < arr.Length; ++i)
                arr[i] = i;
        }
        public static int TestOut(out char i) {
            i = 'b';
            return -1;
        }
        static void Main(string[] args) {
            int a = 1;
            int b = 2;
            System.Console.WriteLine("before swap:    a={0}, b={1}", a, b);
            swap(a, b);
            System.Console.WriteLine("after swap:     a={0}, b={1}", a, b);
            swap(ref a, ref b);
            System.Console.WriteLine("after ref swap: a={0}, b={1}", a, b);

            int[] arr = new int[10];
            System.Console.Write("before change: ");
            foreach (var i in arr) {
                System.Console.Write("{0} ", i);
            }
            change(arr);
            System.Console.Write("\nafter change:  ");
            foreach (var i in arr) {
                System.Console.Write("{0} ", i);
            }
            System.Console.WriteLine();

            char t;
            TestOut(out t);
            System.Console.WriteLine("out variable t='{0}'", t);

        }
    }
}