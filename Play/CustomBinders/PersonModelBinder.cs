using Play.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Play.CustomBinders
{
    public class PersonModelBinder :  IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext modelBindingContext)
        {
            return new Person()
            {
                Name = "Replaced by PersonModelBinder",
                EmailAddress = controllerContext.HttpContext.Request.Form["emailaddress"]
            };

        }
    }
}