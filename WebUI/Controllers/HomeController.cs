using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Base;
using Base.Services.Abstract;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBaseObjectService<Sale> _saleService;

        public HomeController(IBaseObjectService<Sale> saleService)
        {
            _saleService = saleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void InitDbHard()
        {
            /*User u1 = new User() { Title = "User1" };
            Client c1 = new Client() { Title = "Client1", ClientProp = "ClientProp1" };
            Partner p1 = new Partner() { Title = "Partner", PartnerProp = "PartnerProp1" };

            _db.Users.Add(u1);
            _db.Clients.Add(c1);
            _db.Partners.Add(p1);
            _db.SaveChanges();*/
        }

        public void InitDb()
        {
           /* Client c1 = _db.Clients.FirstOrDefault(x => x.Id == 2);
            Sale a = new Sale() {Client = c1, Title = "Sale1"};
            _db.Add(a);
            _db.SaveChanges();*/
        }

        public void InitDb1()
        {
            /*Sale s1 = new Sale() {Title = "Sale11"};
            Sale s2 = new Sale() {Title = "Sale12"};
            Client c1 = new Client() {Title = "Client11", Sales = new List<Sale>() {s1, s2}};
            _db.Add(c1);
            _db.SaveChanges();*/
        }

        public void InitDb2()
        {
          /*  Client c2 = new Client() {Title = "Client21"};
            Sale s1 = new Sale() {Title = "Sale21", Client = c2};
            _db.Add(s1);
            _db.SaveChanges();*/
        }

        public void EditUser()
        {
           /* User u1 = _db.Users.FirstOrDefault(x => x.Id == 4);
            u1.Title = "EditUser";
            _db.Entry(u1).State = EntityState.Modified;
            _db.SaveChanges();*/
        }

        public string ClientSale()
        {
            string c = _saleService.Get(1).Title;

            return c;
        }
    }
}
