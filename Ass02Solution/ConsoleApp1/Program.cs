using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.EntitiesModels;
using BusinessObject;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            FStoreContext fStore = new FStoreContext();
            var members = from m in fStore.Members
                          select new { m.Email, m.CompanyName };
            foreach (var member in members)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("hi");
            Console.ReadLine();
        }


    }
}
