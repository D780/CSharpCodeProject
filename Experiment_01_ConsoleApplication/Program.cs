using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment_01_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp;
            int m, n;
            bool flagM = false, flagN = false;
            m = input("m", 0, 999);
            n = input("n", m, 1000);
            long max = n * n;
            int bit = 0; ;
            while (max  > 0)
            {
                max /= 10;
                bit++;
            }
            StringBuilder formatStr=new StringBuilder("{0:");
            formatStr.Append(string.Format("D{0}", bit));
            formatStr.Append("}  ");
            /*Console.WriteLine(formatStr);*/
            for (int i = m; i <= n; i++)
            {
                for (int j = m; j <= n; j++)
                {
                    Console.Write(formatStr.ToString(), i * j);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
       
        /// <summary>
        /// 输入一个left到right的整数并返回(不取边界值)
        /// </summary>
        /// <param name="str">提示输入,("请输入"+str+"值:")</param>
        /// <param name="left">最小值</param>
        /// <param name="right">最大值</param>
        /// <returns>left到right的整数</returns>
        static int input(string str,int left,int right){
            int num=0;
            while (true)
            {
                Console.Write("请输入{0}值:",str);
                string tmp = Console.ReadLine();
                if (int.TryParse(tmp, out num) && safe(num, left, right))
                {
                    return num;
                }
                Console.WriteLine("Error!!请输入"+left+"到"+right +"的整数!!");
            }

        }


        /// <summary>
        /// 判断一个整数是否在一个范围内(不取边界值)
        /// </summary>
        /// <param name="num">要检查的整数</param>
        /// <param name="left">最小值</param>
        /// <param name="right">最大值</param>
        static bool safe(int num,int left,int right){
            if (num <= left || num >= right) return false;
            return true;
        }
    }
}
