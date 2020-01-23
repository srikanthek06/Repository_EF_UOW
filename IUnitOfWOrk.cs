using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_EF_UOW
{
    public interface IUnitOfWOrk: IDisposable
    {
        IAcademyRepository Academies { get; }
        ILectureRepository Lecutures { get; }
        int Complete();
    }
}
