using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEnitites;
namespace Interfaces
{
    public interface IcatMStr
    {
        IEnumerable<CatMasters> GetALL();
        CatMasters GetById(int Id);
        void AddCategories(CatMasters Ct);
    }
}
