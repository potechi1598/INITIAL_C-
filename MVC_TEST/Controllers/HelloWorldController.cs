using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_TEST.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_TEST.Controllers
{
    public class HelloWorldController : Controller
    {
        // IActionResultを戻り値の型にしているのは作法
        public IActionResult Index()
        {
            return View();
        }
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public string Welcome(bool kimari, string partyJob = "summoner")
        {
            if(kimari == true)
            {
                return "きまりは通さない";
            }
            else
            {
                return $"{partyJob}は通さない";
            }
        }


        public IActionResult ModelTest()
        {
            var ramens = RamenFactory.MakeRamens();
            //第一引数に実行Viewのパスを指定することが可能。
            return View("~/Views/HelloWorld/ModelTest.cshtml", ramens);
        }



    }
}

