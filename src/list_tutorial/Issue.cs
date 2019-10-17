using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Issue
    {
        // フィボナッチ数列を20個まで作成せよ。
        public void Run()
        {
            Console.WriteLine("===== Issue.cs =====");
            List<int> fibo = new List<int>() {1,1};
            while (true) {
                if (20 <= fibo.Count) break;
                fibo.Add(fibo[fibo.Count-2] + fibo[fibo.Count-1]);
            }
            for (int i=0; i<fibo.Count; i++) { Console.WriteLine($"{fibo[i]}"); }
        }
    }
}
