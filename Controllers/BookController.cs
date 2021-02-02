using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NCC.Models;
using Microsoft.AspNetCore.Mvc;

namespace NCC.Controllers
{
    public class BookController : Controller
    {
        public string Index()
        {
            return "This is a list";
        }
        public ViewResult BookList()
        {
            Book b1 = new Book(1213,"Good Book","Ramro manxe",2200);
            Book b2 = new Book(2002,"Bad Book","Naramro manxe",4200);
            Book b3 = new Book(3975,"Book Book","Ok manxe",1200);
            Book b4 = new Book(4623,"Naya Book","Happy",3200);

            List<Book> bookL = new List<Book>(){b1,b2,b3,b4};

            return View(bookL);
        }
       
    }
}