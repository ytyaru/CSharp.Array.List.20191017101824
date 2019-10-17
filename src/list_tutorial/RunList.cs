using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class RunList
    {
        public void Run()
        {
            Console.WriteLine("===== RunList.cs =====");
            code0();
            code1();
            code2();
            code3();
            code4();
        }
        private void code0()
        {
            List<int> nums = new List<int>() {2,4,6};
            foreach (int i in nums) { Console.WriteLine($"{i}"); }
        }
        private void code1()
        {
            List<string> strs = new List<string>() {"abc", "123", "あいう"};
            foreach (string str in strs) { Console.WriteLine($"{str}"); }
        }
        private void code2()
        {
            List<string> strs = new List<string>() {"abc", "123", "あいう"};
            foreach (string str in strs) { Console.WriteLine($"{str.ToUpper()}"); } // 文字列補完
        }
        private void code3()
        {
            List<string> strs = new List<string>() {"xyz", "abc", "123", "あいう"};
            strs.Sort();
            foreach (string str in strs) { Console.WriteLine($"{str.ToUpper()}"); } // 文字列補完
        }
        private void code4()
        {
            List<string> strs = new List<string>();
            strs.Add("xyz");
            strs.Add("abc");
            strs.Add("123");
            strs.Add("だだだ");
            strs.Add("あいう");
            strs.Remove("だだだ");
            strs.Sort();
            Console.WriteLine($"Count: {strs.Count}");
            Console.WriteLine($"strs[2]: {strs[2]}");
            int index = strs.IndexOf("abc");
            Console.WriteLine($"strs[index]: {strs[index]}");
            Console.WriteLine($"strs[index]: {strs.IndexOf("abc")}");
            foreach (string str in strs) { Console.WriteLine($"{str.ToUpper()}"); }
        }
    }
}
