using System.Linq;
using System.Web.Mvc;
using XMLProcesser.Interfaces;
using XMLWebClient.Models;
using XMLWebClient.Mappers;


namespace XMLWebClient.Controllers
{
    public class IndexController : Controller
    {
        private IXMLModule _xmlService;         
        // GET: Index

        public IndexController(IXMLModule xmlService)
        {
            _xmlService = xmlService;
            
        }
        public ActionResult Index()
        {                       
            var model = new CountryListViewModel
            {
                Countries = _xmlService
                    .GetAllCountries()
                    .Select(c => CountryMapper.ToViewModel(c))
                    .ToList()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult AddNew(CountryViewModel newCountry)
        {
            if (ModelState.IsValid)
            {
                _xmlService.AddNewCountry(CountryMapper.ToDomainModel(newCountry));
                _xmlService.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}