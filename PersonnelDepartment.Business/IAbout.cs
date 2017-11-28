using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonnelDepartment.Data.DataLogic;

namespace PersonnelDepartment.Business
{
    public interface IAbout
    {
        //IDataAvailable DataProvider;
        string GetAboutInfo(string info);
    }
}
