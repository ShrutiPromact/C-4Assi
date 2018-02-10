using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignment
{
    class HRClass : employee
    {
        //int salOfHr { get; set; }

        public override void calSalary(int Annual_salary, int Experience)
        {
           int salOfHr = Annual_salary + (1000 * Experience);
          Console.WriteLine("HR have" + " " + salOfHr + "RS basic salary and having" + " " + Experience + "year exp");

        }
    }
}
