using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Data;
using Logic.Service;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {

            var db = new EKAEntities();
            var x = db.CreateUnitGroup(3, "hi");
            if (Service.UserService.Login("zahra", "ab148%11").Status == ResultStatus.Ok)
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
