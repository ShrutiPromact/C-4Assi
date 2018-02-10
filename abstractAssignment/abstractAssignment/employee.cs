using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignment
{
   public abstract class employee
  {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Experience { get; set; }
        protected int Annual_salary { get; set; }
        public DateTime joining_date { get; set; }

        public abstract void calSalary(int Annual_salary, int Experience);
    }
}
