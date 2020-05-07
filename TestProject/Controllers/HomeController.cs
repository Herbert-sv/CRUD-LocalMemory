using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProject.Models;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        List<Students> StudentsInfo = new List<Students>();
        Students student1 = new Students()
        { StudentId = 1, FirstName = "John", LastName = "Smith", Career = "Laws", Institution = "Harvard", YearlyCost = 55000 };
        Students student2 = new Students()
        { StudentId = 2, FirstName = "Gerard", LastName = "Julians", Career = "Business", Institution = "San Francisco College", YearlyCost = 45000 };
        Students student3 = new Students()
        { StudentId = 3, FirstName = "George", LastName = "Martin", Career = "Nursing", Institution = "Umass", YearlyCost = 45000 };

       public ActionResult Index()
        {
            StudentsInfo.Add(student1);
            StudentsInfo.Add(student2);
            StudentsInfo.Add(student3);
            return View(StudentsInfo.ToList()) ;
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(IFormCollection value, Students student4)
        {
            StudentsInfo.Add(student1);
            StudentsInfo.Add(student2);
            StudentsInfo.Add(student3);         
            student4.StudentId = int.Parse(value["StudentId"]);
            student4.FirstName = value["FirstName"];
            student4.LastName = value["LastName"];
            student4.Career = value["Career"];
            student4.Institution = value["Institution"];
            student4.YearlyCost = int.Parse(value["YearlyCost"]);
            StudentsInfo.Add(student4);
                                       
           return View("Index", StudentsInfo.ToList());
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            StudentsInfo.Add(student1);
            StudentsInfo.Add(student2);
            StudentsInfo.Add(student3);
            var EdituserGet = StudentsInfo.ToList().Find(x => x.StudentId == id);

            return View(EdituserGet);
        }
        [HttpPost]
        public IActionResult Update(IFormCollection Formvalue)
        {
            Students studentUpdate1 = new Students();
            Students studentUpdate2 = new Students();
            Students studentUpdate3 = new Students();
            if (student1.StudentId == int.Parse(Formvalue["StudentId"])) {
                studentUpdate1.StudentId = int.Parse(Formvalue["studentId"]);
                studentUpdate1.FirstName = Formvalue["FirstName"];
                studentUpdate1.LastName = Formvalue["LastName"];
                studentUpdate1.Career = Formvalue["Career"];
                studentUpdate1.Institution = Formvalue["Institution"];
                studentUpdate1.YearlyCost = int.Parse(Formvalue["YearlyCost"]);

                StudentsInfo.Add(studentUpdate1); StudentsInfo.Add(student2);
                StudentsInfo.Add(student3); var info1 = from GroupIdasc in StudentsInfo.ToList()
                                                        orderby GroupIdasc.StudentId ascending
                                                        select GroupIdasc;
                return View("Index", info1);
            }
           if (student2.StudentId == int.Parse(Formvalue["StudentId"])){
                
                    studentUpdate2.StudentId = int.Parse(Formvalue["studentId"]);
                    studentUpdate2.FirstName = Formvalue["FirstName"];
                    studentUpdate2.LastName = Formvalue["LastName"];
                    studentUpdate2.Career = Formvalue["Career"];
                    studentUpdate2.Institution = Formvalue["Institution"];
                    studentUpdate2.YearlyCost = int.Parse(Formvalue["YearlyCost"]);
                StudentsInfo.Add(studentUpdate2); StudentsInfo.Add(student1);
                StudentsInfo.Add(student3); var info2 = from GroupIdasc in StudentsInfo.ToList()
                                                        orderby GroupIdasc.StudentId ascending
                                                        select GroupIdasc;
                return View("Index", info2);
            }
           if (student3.StudentId == int.Parse(Formvalue["StudentId"])){
                studentUpdate3.StudentId = int.Parse(Formvalue["studentId"]);
                studentUpdate3.FirstName = Formvalue["FirstName"];
                studentUpdate3.LastName = Formvalue["LastName"];
                studentUpdate3.Career = Formvalue["Career"];
                studentUpdate3.Institution = Formvalue["Institution"];
                studentUpdate3.YearlyCost = int.Parse(Formvalue["YearlyCost"]);
                StudentsInfo.Add(studentUpdate3); StudentsInfo.Add(student1);
                StudentsInfo.Add(student2); var info3 = from GroupIdasc in StudentsInfo.ToList()
                                                        orderby GroupIdasc.StudentId ascending
                                                        select GroupIdasc;
                return View("Index", info3);
            }
         return View("Index",StudentsInfo.ToList());
        }

        [HttpGet]
        public IActionResult Display(int id)
        {
            
            StudentsInfo.Add(student1);
            StudentsInfo.Add(student2);
            StudentsInfo.Add(student3);
            var DisplayUserGet = StudentsInfo.ToList().Find(x => x.StudentId == id);

            return View(DisplayUserGet);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            StudentsInfo.Add(student1);
            StudentsInfo.Add(student2);
            StudentsInfo.Add(student3);
            var deleteGet = (from Deletequery in StudentsInfo.ToList()
                             where Deletequery.StudentId == id
                             select Deletequery).FirstOrDefault();


            return View(deleteGet);
        }
        [HttpPost]
        public IActionResult Delete(IFormCollection compareDel)
        {
            if (student1.StudentId == int.Parse(compareDel["StudentId"]))
            {
                StudentsInfo.Add(student2);
                StudentsInfo.Add(student3);
                var DeleteitemUpdated1 = from itemdelete in StudentsInfo.ToList()
                                       orderby itemdelete.StudentId ascending
                                       select itemdelete;

                return View("Index", DeleteitemUpdated1.ToList());
            }
            if (student2.StudentId == int.Parse(compareDel["StudentId"]))
            {
                StudentsInfo.Add(student1);
                StudentsInfo.Add(student3);
                var Deleteitem_Updated2 = from itemdelete in StudentsInfo.ToList()
                                        orderby itemdelete.StudentId ascending
                                        select itemdelete;
                return View("Index", Deleteitem_Updated2.ToList());
            }
            if (student3.StudentId == int.Parse(compareDel["StudentId"]))
            {
                StudentsInfo.Add(student1);
                StudentsInfo.Add(student2);
                var Deleteitem_Updated3 = from itemdelete in StudentsInfo.ToList()
                                          orderby itemdelete.StudentId ascending
                                          select itemdelete;
                return View("Index", Deleteitem_Updated3.ToList());
            }

            return View("Index", StudentsInfo.ToList());
        }  
          

     
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
