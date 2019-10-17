using System;

namespace list_tutorial
{
    class RunArray
    {
        public void Run()
        {
            Console.WriteLine("===== RunArray.cs =====");
            code0();
            code1();
        }
        private void code0()
        {
            int[] nums = new int[3] {2,4,6};
            foreach (int i in nums) { Console.WriteLine($"{i}"); }
        }
        private void code1()
        {
            string[] strs = new string[3] {"abc", "123", "あいう"};
            foreach (string str in strs) { Console.WriteLine($"{str}"); }
        }
    }
}
