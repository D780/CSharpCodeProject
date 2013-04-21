using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Experiment_02_ConsoleApp_RN
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer1 = new Stopwatch();//计时器类 
            timer1.Start();//开始计时

            HashSet<string> hs = new HashSet<string>();
            string strTableChar = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ";
            long tick = DateTime.Now.Ticks;
            Random random = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            StringBuilder sb = new StringBuilder();
            int len = Convert.ToInt32(args[0]);
            int count = Convert.ToInt32(args[1]);
            int mycount = 0;
            while (mycount < count)
            {
                sb.Remove(0, sb.Length);
                for (int i = 0; i < len; i++)
                {
                    sb.Append(strTableChar[random.Next(34)]);
                }
                if (!hs.Add(sb.ToString()))
                {
                    continue;
                }
                mycount++;
            }

            timer1.Stop();//停止计时 
            double dMilliseconds = timer1.Elapsed.TotalMilliseconds;
            Console.WriteLine("生成个数为：{0}，运行时间为：{1}", mycount, dMilliseconds);
            Console.ReadKey();
        }
    }
}
