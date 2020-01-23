using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_EF_UOW
{
   public interface IAcademyRepository: IRepository<Academy>
    {
        IEnumerable<Academy> GetAllAcademyRecords();
        IEnumerable<Academy> GetAllAcademyRecord(int recordId);

    }
}
