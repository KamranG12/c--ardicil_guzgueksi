using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guzgu_eksi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int m = 200;
            string a = Convert.ToString(n);
            string b = Convert.ToString(m);
            char c = a[0];
            char d = b[0];
            int f = c - '0';
            int g = d - '0';
            for (int i = f; i <= g; i++)
            {
                string result ="";
                for (int j = 0; j <=9; j++)
                {
                    string x = Convert.ToString(j);
                    char y = x[0];
                    result = Convert.ToString(i) + y + Convert.ToString(i);
                    int sum = Convert.ToInt32(result);
                    if(sum>n && sum < m)
                    {
                      Console.WriteLine(sum);
                    }
                    sum = 0;
                }
            }
           
            Console.ReadLine();
        }
    }
}
