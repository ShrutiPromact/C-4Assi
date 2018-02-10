using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new Developer();
            employee emp1 = new HRClass();

            emp.calSalary(2000,5);
             
            emp1.calSalary(2000, 4);

            Console.ReadKey();
        }
    }
}
