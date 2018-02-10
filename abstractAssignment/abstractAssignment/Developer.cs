using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignment
{
    class Developer : employee
    {
        //int salOfemp { get; set; }

        public override void calSalary(int Annual_salary, int Experience)
        {
           int salOfemp = Annual_salary + (2000 * Experience);
            
            Console.WriteLine("Developer have" + " " + salOfemp + "RS basic salary and having" + " "+ Experience + "year exp");
            
        }
    }
}
