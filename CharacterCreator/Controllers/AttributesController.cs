using CharacterCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharacterCreator.Controllers
{
    public class AttributesController : Controller
    {
        // GET: Attributes
        public ViewResult Index()
        {
            var model = new AttributesViewModel();
            model.Agility = 5;
            model.Awareness = 5;
            model.Coordination = 5;
            model.Intelligence = 5;
            model.Mental = 5;
            model.Personality = 5;
            model.Physique = 5;
            model.Strength = 5;

            return View(model);
        }
    }
}