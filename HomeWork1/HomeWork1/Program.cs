using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
/*            25.С начала суток прошло N секунд(N — целое).Найти количество полных минут, прошедших с начала последнего часа.*/
           
            
            int x, N;

            Console.OutputEncoding = Encoding.UTF7;

            Console.Write("количество секунд, прошедших с начала дня: ");         
            N = int.Parse(Console.ReadLine());
            x  = (N - (3600 * (N / 3600))) / 60;
            Console.WriteLine("количество полных минут, прошедших с начала последнего часа = {0}", x);
            
            Console.ReadKey();
            
        }
    }
}
