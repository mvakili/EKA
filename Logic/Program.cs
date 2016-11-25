using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Service.UserService.Login("zahra", "ab148%11") == 0)
            {
                Console.WriteLine("Logged in");
            } else
            {
                Console.WriteLine("Not Loged in");
            }
            Console.ReadKey();
        }
    }
}
