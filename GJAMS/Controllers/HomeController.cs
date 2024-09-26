using GJAMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GJAMS.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var table_2s = _context.Table_2.ToList();
            var results = _context.Result.ToList();
            var admit = _context.AdmitCard.ToList();
            var viewModel = new CombinedViewModel
            {
                Table_2 = table_2s,
                Result = results,   
                AdmitCard = admit
            };

            return View(viewModel);
        }
        public IActionResult LatestJob()
        {
            var data = _context.Table_2.ToList();
            return View(data);
        }
        public IActionResult AdmitCard()
        {
            var data = _context.AdmitCard.ToList();
            return View(data);
        }
        public IActionResult Result()
        {
            var data = _context.Result.ToList();
            return View(data);
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult JobDetail(int id)
        {

            var data = _context.Table_2.Find(id);
            return View(data);
        }
        public IActionResult AdmiCardDetail(int id)
        {
            var data = _context.AdmitCard.Find(id);
            return View(data);
        }
        public IActionResult ResultDetail(int id)
        {
            var data = _context.Result.Find(id);
            return View(data);
        }
        public IActionResult JobForm()
        {
            return View();
        }
        public IActionResult ResultForm()
        {
            return View();
        }
        public IActionResult AdmitcardForm()
        {
            return View();
        }
        //Inpute data from AdmitCardForm into Database
        [HttpPost]
        public IActionResult AdmitcardForm( AdmitCard a)
        {
            _context.AdmitCard.Add(a);
            _context.SaveChanges();
            return RedirectToAction("AdmitCardForm");
        }  

        //Inpute data from Form into Database
        [HttpPost]
        public IActionResult ResultForm(Result r)
        {
            _context.Result.Add(r);
            _context.SaveChanges();
            return RedirectToAction("ResultForm");
        }
        //show data in AdminPanel
        public IActionResult AdminPanel()
        {
            if (HttpContext.Session.GetString("user") == null)
            {
                return RedirectToAction("AdminLogin");
            }
            string username = HttpContext.Session.GetString("user");
            var data = _context.AdminTable.FirstOrDefault(s
                 => s.username == username);
            var table_2s = _context.Table_2.ToList();
            var results = _context.Result.ToList();
            var admit = _context.AdmitCard.ToList();
            var viewModel = new CombinedViewModel
            {
                Table_2 = table_2s,
                Result = results,
                AdmitCard = admit,
                TotalTable2Count = table_2s.Count,
                TotalResultsCount = results.Count,
                TotalAdmitCardsCount = admit.Count
            };

            return View(viewModel);

        }
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(string username, string password)
        {
            var data = _context.AdminTable.FirstOrDefault(s => s.username == username && s.password == password);
            if (data != null)
            {
                HttpContext.Session.SetString("user", username);
                return RedirectToAction("AdminPanel");
            }
            else
            {
                TempData["msg"] = "Username or Password is incorrect";
                return RedirectToAction("AdminLogin");
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("AdminLogin");
        }
        //Inpute data from JobForm into Database
        [HttpPost]
        public IActionResult JobForm(Table_2 t)
        {
            _context.Table_2.Add(t);
            _context.SaveChanges();
            return RedirectToAction("Jobform");
        }
        //Delete data from Admin Panel
        public IActionResult Delete(int id)
        {
            var data = _context.Table_2.Find(id);
            _context.Table_2.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("AdminPanel");
        }
        public IActionResult Edit(int id)
        {
            var data = _context.Table_2.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(int id, Table_2 t)
        {
            var data = _context.Table_2.Find(id);
            data.name_of_post = t.name_of_post;
            data.post_date = t.post_date;
            data.short_info = t.short_info;
            data.organization_name = t.organization_name;
            data.advertisement_no = t.advertisement_no;
            data.imp_date1 = t.imp_date1;
            data.imp_date2 = t.imp_date2;
            data.imp_date3 = t.imp_date3;
            data.imp_date4 = t.imp_date4;
            data.imp_date5 = t.imp_date5;
            data.app_fee1 = t.app_fee1;
            data.app_fee2 = t.app_fee2;
            data.app_fee3 = t.app_fee3;
            data.app_fee4 = t.app_fee4;
            data.post_short_name = t.post_short_name;
            data.age_limit_as = t.age_limit_as;
            data.age_limit1 = t.age_limit1;
            data.age_limit2 = t.age_limit2;
            data.age_limit3 = t.age_limit3;
            data.age_limit4 = t.age_limit4;
            data.age_limit5 = t.age_limit5;
            data.online_link = t.online_link;
            data.notification_link = t.notification_link;
            data.official_link = t.official_link;
            data.total_post = t.total_post;
            _context.Table_2.Update(data);
            _context.SaveChanges();
            return RedirectToAction("AdminPanel");
        }
        public IActionResult DeleteAdmitcard(int id)
        {
            var data = _context.AdmitCard.Find(id);
            _context.AdmitCard.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("AdminPanel");
        }
        public IActionResult AdmitCardEdit(int id)
        {
            var data = _context.AdmitCard.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult AdmitCardEdit(int id, AdmitCard t)
        {
            var data = _context.AdmitCard.Find(id);
            data.name_of_post = t.name_of_post;
            data.post_date = t.post_date;
            data.short_info = t.short_info;
            data.organization_name = t.organization_name;
            data.advertisement_no = t.advertisement_no;
            data.imp_date1 = t.imp_date1;
            data.imp_date2 = t.imp_date2;
            data.imp_date3 = t.imp_date3;
            data.imp_date4 = t.imp_date4;
            data.imp_date5 = t.imp_date5;
            data.app_fee1 = t.app_fee1;
            data.app_fee2 = t.app_fee2;
            data.app_fee3 = t.app_fee3;
            data.app_fee4 = t.app_fee4;
            data.age_limit_as = t.age_limit_as;
            data.age_limit1 = t.age_limit1;
            data.age_limit2 = t.age_limit2;
            data.age_limit3 = t.age_limit3;
            data.age_limit4 = t.age_limit4;
            data.age_limit5 = t.age_limit5;
            data.online_link = t.online_link;
            data.notification_link = t.notification_link;
            data.official_link = t.official_link;
            data.total_post = t.total_post;
            data.admitcard_link = t.admitcard_link;
            _context.AdmitCard.Update(data);
            _context.SaveChanges();
            return RedirectToAction("AdminPanel");
        }
        public IActionResult DeleteResult(int id)
        {
            var data = _context.Result.Find(id);
            _context.Result.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("AdminPanel");
        }
        public IActionResult ResultEdit(int id)
        {
            var data = _context.Result.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult ResultEdit(int id, Result t)
        {
            var data = _context.Result.Find(id);
            data.name_of_post = t.name_of_post;
            data.post_date = t.post_date;
            data.short_info = t.short_info;
            data.organization_name = t.organization_name;
            data.advertisement_no = t.advertisement_no;
            data.imp_date1 = t.imp_date1;
            data.imp_date2 = t.imp_date2;
            data.imp_date3 = t.imp_date3;
            data.imp_date4 = t.imp_date4;
            data.imp_date5 = t.imp_date5;
            data.app_fee1 = t.app_fee1;
            data.app_fee2 = t.app_fee2;
            data.app_fee3 = t.app_fee3;
            data.app_fee4 = t.app_fee4;
            data.age_limit_as = t.age_limit_as;
            data.age_limit1 = t.age_limit1;
            data.age_limit2 = t.age_limit2;
            data.age_limit3 = t.age_limit3;
            data.age_limit4 = t.age_limit4;
            data.age_limit5 = t.age_limit5;
            data.online_link = t.online_link;
            data.notification_link = t.notification_link;
            data.official_link = t.official_link;
            data.total_post = t.total_post;
            data.admitcard_link = t.admitcard_link;
            data.result_link = t.result_link;
            _context.Result.Update(data);
            _context.SaveChanges();
            return RedirectToAction("AdminPanel");
        }
    }
}
