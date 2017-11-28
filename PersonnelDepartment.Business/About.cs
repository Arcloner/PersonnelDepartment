using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonnelDepartment.Data.DataLogic;

namespace PersonnelDepartment.Business
{
    public class About : IAbout
    {
        private IDataAvailable DataProvider;        
        public string GetAboutInfo(string info)
        {           
            return info;
        }
    }
}
