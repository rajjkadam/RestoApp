using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataBase;
using BussinesEnitites;
using Interfaces;
namespace WebApp.Repository
{
    public class CategoriesRepo : IcatMStr
    {
        MySqlCon con = new MySqlCon();
        public void AddCategories(CatMasters Ct)
        {

            con.CategoriesMasters.Add(Ct);
            con.SaveChanges();
        }

        public IEnumerable<CatMasters> GetALL()
        {
            var categories = con.CategoriesMasters.ToList();
            return categories;
        }

        public CatMasters GetById(int Id)
        {
            var CatId = con.CategoriesMasters.Where(c => c.CatId == Id).FirstOrDefault();
            return CatId;
        }
    }
}