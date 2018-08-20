using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message greet = new Message();
            Console.WriteLine(greet.GetHelloMessage());

            Console.ReadLine();

        }
    }   
}
