using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ardicil
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n = 100;
            int m = 500;
            string a = Convert.ToString(n);
            string b = Convert.ToString(m);
            char c = a[0];
            char d = b[0];
            char yoxlama = b[1];
            int yoxlama1 = yoxlama - '0';
            int f = c - '0';
            int g = d - '0';
            int on = (int)Math.Pow(10, a.Length-1);
            int result = 0;
            int sum = 0;
            if(a.Length!=b.Length){
                Console.WriteLine("her iki deyisheni eyni mertebeli olaraq daxil edin!!!");
            }else{
            for (int j = f; j < g; j++)
            {
                for (int i = j; i <= g+a.Length-2; i++)
                {
                    if (on >= 1)
                    {
                        result = on * i;
                        sum += result;
                       
                    }
                    

                    on = on / 10;
                }
                if (sum>n && sum <m && sum%10!=0)
                {
                    Console.WriteLine(sum);
                }
                on = (int)Math.Pow(10, a.Length - 1);
                sum = 0;
            }
            }
            

            Console.ReadLine();
        }
    }
}
