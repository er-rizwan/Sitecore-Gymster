using Sitecore.Data.Fields;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYMSTER.Project.Controllers
{
    public class CarouselController : Controller
    {
        // GET: Carousel
        public ActionResult Index()
        {
            var carouselItems = RenderingContext.Current.Rendering.Item;
            var slidesField =(MultilistField) carouselItems.Fields["Slides"];
            var slides = slidesField.GetItems();
            return View(slides);
        }
    }
}