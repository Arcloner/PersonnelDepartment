using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.Data.Entities
{
    class Employee
    {
        public string Name { get;  set; }
        public string LastName { get;  set; }
        public string Patronymic { get;  set; }
        public Department Department { get;  set; }
        public EmployeeContacts EmployeeContacts { get;  set; }
        public string HomeAdress { get;  set; }
        public bool Betrothed { get;  set; }
        public string Photo { get;  set; }
        public string WorkPeriod { get;  set; }
    }
}
