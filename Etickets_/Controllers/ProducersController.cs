using Etickets_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Etickets_.Controllers
{
    public class ProducersController : Controller
    {
        private readonly Eco_Context _Context;

        public ProducersController(Eco_Context context)
        {
            _Context = context;
        }

        public  IActionResult Index()
        {
            var allProducers = _Context.Producers.ToList();
            return View("indexnew",allProducers);
        }
    }
}
