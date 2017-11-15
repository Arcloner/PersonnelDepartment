using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartmentsClasses
{
    public class AboutWithAuthorName:IAbout
    {
        private readonly string AuthorName = "Valery Piniazik";

        public string GetAboutInfo(string info)
        {
            return ParseWithAuthor(info);
        }
        private string ParseWithAuthor(string info)
        {
            string Result = info + ";" + "Author:" + AuthorName;
            return Result;
        }
    }
}
