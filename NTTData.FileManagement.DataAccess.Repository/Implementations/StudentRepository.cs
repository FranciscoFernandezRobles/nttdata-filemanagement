using NTTData.FileManagement.Common.Model;
using NTTData.FileManagement.DataAccess.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace NTTData.FileManagement.DataAccess.Repository.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        public bool Add(Student student)
        {
            string path = ConfigurationManager.AppSettings.Get("StudentsFilePath");


            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(student.ToString());
                }
            } else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(student.ToString());
                }
            }

            return true;
        }
    }
}
