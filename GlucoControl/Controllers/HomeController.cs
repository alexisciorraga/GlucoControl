using AutoMapper;
using GlucoControl.Application.Services;
using GlucoControl.Controllers.Base;
using System.Web.Mvc;

namespace GlucoControl.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IControlApplication _controlApplication;

        public HomeController(IMapper mapper, IControlApplication controlApplication) : base(mapper)
        {
            _controlApplication = controlApplication;
        }

        public ActionResult Index()
        {
            // var controls = _controlApplication.GetAll();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}