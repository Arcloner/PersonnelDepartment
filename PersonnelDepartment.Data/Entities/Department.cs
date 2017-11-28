using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.Data.Entities
{
    class Department
    {
        public string DepartmentName { get;  set; }
        public List<string> DepartmentPhones { get;  set; }
        public string DepartmentAdress { get;  set; }
        public string DepartmentDetails { get;  set; }
    }
}
