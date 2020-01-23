using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_EF_UOW
{
    public class AcademyRepository : Repository<Academy>, IAcademyRepository
    {
        public AcademyRepository(AcademyContext context): base(context)
        {

        }
        public AcademyContext AcademyContext
        {
            get
            {
                return Context as AcademyContext;
            }
        }
        public IEnumerable<Academy> GetAllAcademyRecord(int recordId)
        {
            return AcademyContext.Academies.OrderByDescending(c => c.cost).Take(recordId).ToList();
        }

        public IEnumerable<Academy> GetAllAcademyRecords()
        {
            return AcademyContext.Academies
                 .Include(a => a.Lecture)
                 .OrderBy(a => a.Name);
        }
    }
}
