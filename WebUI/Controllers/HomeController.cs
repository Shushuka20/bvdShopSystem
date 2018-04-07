using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ShopContext _db;

        public HomeController(ShopContext context)
        {
            _db = context;
        }


        public void InitDbHard()
        {
            User u1 = new User() { Title = "User1" };
            Client c1 = new Client() { Title = "Client1", ClientProp = "ClientProp1" };
            Partner p1 = new Partner() { Title = "Partner", PartnerProp = "PartnerProp1" };

            _db.Users.Add(u1);
            _db.Clients.Add(c1);
            _db.Partners.Add(p1);
            _db.SaveChanges();
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
            Sale s1 = new Sale() {Title = "Sale11"};
            Sale s2 = new Sale() {Title = "Sale12"};
            Client c1 = new Client() {Title = "Client11", Sales = new List<Sale>() {s1, s2}};
            _db.Add(c1);
            _db.SaveChanges();
        }

        public void InitDb2()
        {
            Client c2 = new Client() {Title = "Client21"};
            Sale s1 = new Sale() {Title = "Sale21", Client = c2};
            _db.Add(s1);
            _db.SaveChanges();
        }

        public void EditUser()
        {
            User u1 = _db.Users.FirstOrDefault(x => x.Id == 4);
            u1.Title = "EditUser";
            _db.Entry(u1).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public string ClientSales()
        {
            var b = _db.Sales.Where(x => x.ClientId == 2);
            string c = "";
            foreach (var t in b)
            {
                c += t.Title + "; ";
            }

            return c;
        }
    }
}
