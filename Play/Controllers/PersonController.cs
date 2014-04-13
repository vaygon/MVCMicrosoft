using Play.CustomBinders;
using Play.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Play.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        [HttpGet]
        public ActionResult Create()
        {
            Person newPerson = new Person();
            
            return View(newPerson);
        }

        [HttpPost]
        public ActionResult Create([ModelBinder(typeof(PersonModelBinder))] Person model)
        { 
            if(ModelState.IsValid)
            {
                
            }
            return View(model);
        }

    }
}
