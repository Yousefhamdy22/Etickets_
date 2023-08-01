using Etickets_.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace Etickets_.Controllers
{
    public class CineamaController : Controller
    {
        private readonly Eco_Context _Context;

        public CineamaController(Eco_Context context)
        {
            _Context = context;
        }
        public async Task< IActionResult> Index()
        {
            var allProducers = await _Context.Cinemas.ToListAsync();
             return  View(allProducers);
        }

        public async Task<IActionResult> Create()
        {
            var allProducers = await _Context.Cinemas.ToListAsync();
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            var Editdata = await _Context.Cinemas.ToListAsync();
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var Deleteitem = await _Context.Cinemas.ToListAsync();
            return View();
        }

        //public async Task<IActionResult> Details(int id)
        //{
        //    var Det_Data = await _Context.cinemas.ToListAsync();
        //    return View();
        //}

        //Get: Cinemas/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _Context.Cinemas.FindAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }


    }
}
