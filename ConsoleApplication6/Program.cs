using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
             List<string[]> str1 = new List<string[]> { };
             List<string[]> str2 = new List<string[]> { };
             string[] class1 = { "牛连山", "数学成绩", "58" };
             string[] class2 = { "孙少华", "数学成绩", "37" };
             string[] class3 = { "蒋大帅", "数学成绩", "45" };
             string[] class4 = new string[20];
             //str1.AddRange(str2);
             str1.Add(class1);
             str1.Add(class2);
             str1.Add(class3);
             Console.WriteLine("输出1:"+str1.Count());//结果是3
             Console.WriteLine("输出2:"+str1[0][0]);
             Console.WriteLine("输出3:"+(str1.OrderBy(s => s[2]).ToList())[2][2]);
       

            List<string> lists = new List<string> { };
            lists.Add("str");
            lists.Add("hello");
            string[] str = lists.ToArray();
            foreach(string aa in str)
            {
                Console.WriteLine(aa);
            }

            List<byte[]> byt1 = new List<byte[]> { };
            List<byte[]> byt2 = new List<byte[]> { };
            List<byte> byt3 = new List<byte> { };
            byte[] by1 = { 0x11, 0x03, 0x05 ,0x24};
            byte[] by2 = { 0xA9, 0x01, 0x56 };
            byte[] by3 = { 0x04, 0x02, 0x07 };
            byte[,] by4 = new byte[9,2];
            byte[] by5 = new byte[20];
            byte zijie;
            Double tep;
            tep = 0.1256;
            
            byt1.Add(by1);
            byt1.Add(by2);
            byt1.Add(by3);
            byt2.Add(by1);
            StringBuilder sNeed = new StringBuilder();
            sNeed.Append(BitConverter.ToString(by1).Replace("-", "").Substring(0).ToUpper());
            sNeed.Append(tep);
            Console.WriteLine(sNeed);

            Console.WriteLine("输出4:" + byt1[0].Count());
            Console.WriteLine("输出5:" + byt1.Count());
            byt2 = byt1.OrderBy(s => s[1]).ToList();
            Console.WriteLine("输出字节：{0}-{1}-{2}", byt2[0][0],byt2[0][1],byt2[0][2]);
            zijie = byt2[0][0];
            Console.WriteLine("输出6:" + zijie);
            by4[0,1] = 0x11;
            Console.WriteLine(by4[0, 1].ToString());
            Console.WriteLine(byt2.ToArray()[0][0].ToString());
            foreach(byte[] item in byt2)
            {
              var  listdata = item.ToList();
                   foreach(var item1 in item)
                    Console.Write("--"+item1.ToString());
                Console.Write("--"+listdata.Count().ToString());
            }

            int count = 0;
            foreach(var item in byt2)
                foreach(var item1 in item)
                {
                    by5[count] = item1;
                    count++;
                }
            Console.WriteLine("\r");
            foreach (var item in by5)
                Console.Write("--"+item.ToString());


            
            Console.ReadKey();

        }
    }
}
