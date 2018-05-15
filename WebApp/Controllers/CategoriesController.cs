using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBase;
using BussinesEnitites;
using WebApp.Repository;
using WebApp.ViewModel;

namespace WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        private CategoriesRepo categoriesRepo = new CategoriesRepo();
      
        public ActionResult Index()
        {
            return View();
        }
        
        public JsonResult GetCategories()
        {
            
            try
            {
                //catMasters = categoriesRepo.GetALL().ToList();
            }
            catch (Exception)
            {

                throw;
            }
            var data = categoriesRepo.GetALL().ToList();
            //Returning Json Data    
            return Json(new { data = data });

        }
        public ActionResult AddCategories()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategories(CategoriesView catMasters)
        {
            CatMasters catMaster = new CatMasters();
            catMaster.CatId = 0;
            catMaster.CatName = catMasters.CatName;
            catMaster.DateAdded = catMasters.AddedDate;
            categoriesRepo.AddCategories(catMaster);
           
            return View();
        }
        public ActionResult LoadData()
        {
            try
            {
                //Creating instance of DatabaseContext class  
                MySqlCon _context = new MySqlCon();
                {
                    var draw = Request.Form.GetValues("draw").FirstOrDefault();
                    var start = Request.Form.GetValues("start").FirstOrDefault();
                    var length = Request.Form.GetValues("length").FirstOrDefault();
                    var sortColumn = Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
                    var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();
                    var searchValue = Request.Form.GetValues("search[value]").FirstOrDefault();


                    //Paging Size (10,20,50,100)    
                    int pageSize = length != null ? Convert.ToInt32(length) : 0;
                    int skip = start != null ? Convert.ToInt32(start) : 0;
                    int recordsTotal = 0;

                    // Getting all Customer data    
                    var catData = (from tempcat in _context.CategoriesMasters
                                        select tempcat);

                    ////Sorting    
                    //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
                    //{
                    //    catData = catData.OrderBy(sortColumn + " " + sortColumnDir);
                    //}
                    ////Search    
                    //if (!string.IsNullOrEmpty(searchValue))
                    //{
                    //    customerData = customerData.Where(m => m.CompanyName == searchValue);
                    //}

                    ////total number of rows count     
                    //recordsTotal = customerData.Count();
                    ////Paging     
                    var data = catData.ToList();
                    //Returning Json Data    
                    return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
} 