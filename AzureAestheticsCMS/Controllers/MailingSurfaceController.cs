using AzureAestheticsCMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace AzureAestheticsCMS.Controllers
{
    public class MailingSurfaceController : SurfaceController
    {
        //
        // GET: /MailingSurface/

        public ActionResult Index()
        {
            return PartialView("MailingFormPartial",new MailingViewModel());
        }

        [HttpPost]
        public ActionResult FormPost(MailingViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks");
            }
            else
            {
               return RedirectToCurrentUmbracoPage();
            }

            
        }

    }
}
