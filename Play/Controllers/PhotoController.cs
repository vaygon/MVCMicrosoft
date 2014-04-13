using Play.Domain;
using Play.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Play.Controllers
{
    public class PhotoController : Controller
    {

        private PhotoSharingDB db = new PhotoSharingDB();

        public ActionResult Index()
        {
            return View("Index", db.Photos.ToList());
        }
        
        //
        // GET: /Photo/

        public ActionResult Details(int id = 0)
        {
            Photo photo = db.Photos.Find(id);

            if (photo != null)
                return View("DisplayView", photo);


            return HttpNotFound();

        }

        [HttpGet]
        public ActionResult Create()
        {

            return View(new Photo() { CreatedDate = DateTime.Now });
        }

        [HttpPost]
        public ActionResult Create(Photo photo, HttpPostedFileBase file)
        {
            if (file == null)
                throw new Exception("Bad File");

            MemoryStream target = new MemoryStream();
            file.InputStream.CopyTo(target);

            photo.PhotoFile = target.ToArray(); 

            db.Photos.Add(photo);
            db.SaveChanges();

            ViewBag.Message = "Photo Saved";

            return View(photo);
        }

    }
}
