﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0104.使用委托求数组的最大值
{
    public delegate int DelCompare(object o1,object o2);
    class Program
    {
        static void Main(string[] args)
        {
            //object[] o = { 1, 2, 9, 4, 5, 6 };
            object[] o = { "fasdafd", "fasd", "", "dafsasdfafdgh", "asd" };
            object result = GetMax(o, Compare2);
            Console.WriteLine(result);
        }
        public static object GetMax(object[] nums,DelCompare del)
        {
            object max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                //要传一个比较的方法
                if (del(max,nums[i])<0)
                {
                    max = nums[i];
                }
            }
            return max;
        }
        public static int Compare1(object o1,object o2)
        {
            int n1 = (int)o1;
            int n2 = (int)o2;
            return n1-n2;
        }
        public static int Compare2(object o1,object o2)
        {
            string s1 = (string)o1;
            string s2 = (string)o2;
            return s1.Length - s2.Length;
        }
        //public static string GetMax(string[] names)
        //{
        //    string max = names[0];
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (max.Length<names[i].Length)
        //        {
        //            max = names[i];
        //        }
        //    }
        //    return max;
        //}
    }
}
