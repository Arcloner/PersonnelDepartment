using PersonnelDepartment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.Data.DataLogic
{
    class DataManipulator : IDataAvailable
    {
        public static Employee employee;
        public DataManipulator()
        {
            employee.Betrothed = true;
            employee.Name = "Valery";
            employee.LastName = "Piniazik";
            employee.Patronymic = "Vitalievich";
             
        }
        public void Change()
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
