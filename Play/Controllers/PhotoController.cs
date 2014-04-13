using Play.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Play.Controllers
{
    public class PhotoController : Controller
    {
        //
        // GET: /Photo/

        public ActionResult Detail()
        {
            Photo newPhoto = new Photo()
            {
                Title = "This is an Example Photo!",
                Owner = User.Identity.Name,
                CreatedDate = DateTime.Today
            };

            return View("DisplayView", newPhoto);

        }

    }
}
