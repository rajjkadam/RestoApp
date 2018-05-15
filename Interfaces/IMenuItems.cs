using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEnitites;
namespace Interfaces
{
    public interface IMenuItems
    {
        IEnumerable<MenuItems> GetALL();
        MenuItems GetById(int Id);
        List<MenuItems> GetByCatId(int CatID);
        int Create(MenuItems menu);
        bool Update(int ItemId, MenuItems menu);
        bool Delete(int ItemId);

    }
}
