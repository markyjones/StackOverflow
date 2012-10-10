using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMvc4WithNinject.Controllers
{

    public interface IToInject
    {
        string ExamplePropery { get; set; }
    }

    public class ExampleToInject : IToInject
    {

        public string ExamplePropery
        {
            get { return "Hiya"; }
            set{ }
        }
    }

    public class HomeController : Controller
    {
        private readonly IToInject _toInject;

        public HomeController(IToInject injected)
        {
            _toInject = injected;
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            this.ViewBag.ExampleProperty = _toInject.ExamplePropery;
            return View();
        }

      
    }
}
