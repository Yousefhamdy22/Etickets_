using DocumentFormat.OpenXml.InkML;
using Etickets_.Data;
using Etickets_.Data.services;
using Etickets_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Etickets_.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActor _service; 

        public ActorController(IActor service)
        {
            _service = service;
        }


        //public IActionResult Getall()
        //{
        //    ViewBag.Econ_db = _context;
        //    return View();
        //}

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetallAsyc();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost] //?
        public async Task<IActionResult> Create([Bind("FullName , profilepicitureurl, Bio")] Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.AddAsyc(actor);
            return RedirectToAction(nameof(Index));
        }




        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetbyidAsyc(id);

            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetbyidAsyc(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
             _service.UpdateAsyc(id, actor);
            return RedirectToAction(nameof(Index));
        }


        //public async Task<IActionResult> Delete(int id)
        //{
        //    var Detdata = _context.Actors.ToArrayAsync();
        //    return View();
        //}



    }
}
