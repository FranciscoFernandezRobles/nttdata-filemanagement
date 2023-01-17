using NTTData.FileManagement.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTTData.FileManagement.Business.Logic.Contracts
{
    public interface IStudentService
    {
        bool Add(Student student);
    }
}
