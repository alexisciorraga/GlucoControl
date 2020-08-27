using AutoMapper;
using GlucoControl.Controllers.Base;
using System.Web.Mvc;
using Unity;

namespace GlucoControl.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IFormatoApplication _formatoApplication;

        [InjectionConstructor]
        public HomeController(IMapper mapper, IFormatoApplication formatoApplication) : base(mapper)
        {
            _formatoApplication = formatoApplication;
        }

        public ActionResult Index()
        {
            var formatos = _formatoApplication.GetAllFormatos();

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