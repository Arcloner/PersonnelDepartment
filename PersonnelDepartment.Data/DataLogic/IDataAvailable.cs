using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.Data.DataLogic
{
    public interface IDataAvailable
    {
        void Create();
        void Change();
        void Delete();            
    }
}
