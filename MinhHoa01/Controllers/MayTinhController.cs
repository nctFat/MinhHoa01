using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinhHoa01.Models;
namespace MinhHoa01.Controllers
{
    public class MayTinhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult XuLy( MayTinhModel mt)
        {
            double ketqua = 0;
            switch (mt.PhepTinh)
            {
                case "+": ketqua = mt.So1 + mt.So2; break;
                case "-": ketqua = mt.So1 - mt.So2; break;
                case "*": ketqua = mt.So1 * mt.So2; break;
                case "/": ketqua = mt.So1 / mt.So2; break;
            }
            ViewBag.KQ = ketqua;
            return View("Index");
        }
    }
}
