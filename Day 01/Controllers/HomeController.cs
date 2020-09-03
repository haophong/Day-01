using Day_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
        
            return View();
        }

        public ActionResult About()
        {
            var booklist = new List<Book> {
            new Book() {Id=1,Title="tim e noi day",ImageUrl="http://300b5338.vws.vegacdn.vn/image/img.media/Gullible-du-ky-Tony.jpg",Authors="phong",Summary="1",ISBN="12200",Publisher="phong",Price=113,Category="1"},
            new Book() {Id=2,Title="Can lam",ImageUrl="https://localhost:44334/Content/Images/1.png",Authors="phong1",Summary="2",ISBN="1000",Publisher="phong1",Price=322,Category="2"},
            new Book() {Id=3,Title="cuon theo chieu gio",ImageUrl="https://localhost:44334/Content/Images/1.jpg",Authors="phong2",Summary="3",ISBN="2200",Publisher="phong2",Price=344,Category="3"}
            };

            return View(booklist);
        }


    }
}