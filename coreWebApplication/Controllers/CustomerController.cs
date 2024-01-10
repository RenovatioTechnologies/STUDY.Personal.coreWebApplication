﻿using coreWebApplication.Models;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace coreWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        // Implement an instance of Customer Class from .Models
        public static List<Customer> customers = new List<Customer>()
        {
            // For each customer we need to pass on the details an id, name and customer amount!
            new Customer() { Id = 101, Name = "Nah", Amount = 12000},
            new Customer() { Id = 102, Name = "King", Amount = 12000},
        };
        public IActionResult Index()
        {
            //Passing some data from Index IAction and to view
            ViewBag.Message = "Customer Management System";

            // Add Customer to our ViewBag
            ViewBag.CustomerCount = customers.Count();
            //Creating a customer list which will be storing the complete customers list!
            ViewBag.CustomerList = customers;   


            return View();
        }

        //  Action view with Views/Shared/_Layout.cshtml
        public IActionResult Details()
        {
            return View();
        }

        // Modiflying attribute route, when accessing the below Message() this message will be access first. With IActionResult return a specific message 
        // attribute routing will override conventional routes 
        [Route("~/")]
        [Route("/sample/message")]
        // Action view without a layout
        public IActionResult Message()
        {
            return View();  
        }
    }
}
