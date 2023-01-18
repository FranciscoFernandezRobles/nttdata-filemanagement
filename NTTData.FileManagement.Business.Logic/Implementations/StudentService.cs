using NTTData.FileManagement.Business.Logic.Contracts;
using NTTData.FileManagement.Common.Model;
using NTTData.FileManagement.DataAccess.Repository.Contracts;
using NTTData.FileManagement.DataAccess.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTTData.FileManagement.Business.Logic.Implementations
{
    public class StudentService : IStudentService
    {
        public bool Add(Student student)
        {
            student.Age = CalculateAge(student.Birthday);
            IStudentRepository studentRepository = new StudentRepository();
            studentRepository.Add(student);
            return true;
        }

        private int CalculateAge(DateTime birthday)
        {
            var days = (DateTime.Now - birthday).TotalDays;
            return (int)Math.Floor(days / 365.25);
        }
    }
}
