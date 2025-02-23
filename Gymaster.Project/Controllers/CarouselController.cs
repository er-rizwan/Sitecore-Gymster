using GYMSTER.Project.Models;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
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

            var dataSource = RenderingContext.Current?.Rendering.Item;
            var slideCountParameter = RenderingContext.Current.Rendering.Parameters["Slide Size"];

            int.TryParse(slideCountParameter, out int result);
            int slideCount = result == 0 ? 2 : result;
            int counter = 0;
            MultilistField slidesField = dataSource.Fields["Slides"];
            List<SlideModel> slides = new List<SlideModel>();

            if (slidesField?.Count > 0)
            {
                var slideItems = slidesField.GetItems();
                foreach (var slideItem in slideItems.Take(slideCount))
                {
                    slides.Add(new SlideModel
                    {
                        SlideTitle = new MvcHtmlString(FieldRenderer.Render(slideItem, "Title")),
                        SubSlideTitle = new MvcHtmlString(FieldRenderer.Render(slideItem, "SubTitle")),
                        SlideImage = new MvcHtmlString(FieldRenderer.Render(slideItem, "Image", "class=w-100")),
                        PrimaryLink = new MvcHtmlString(FieldRenderer.Render(slideItem, "PrimaryLink", "class=btn btn-primary py-md-3 px-md-5 me-3")),
                        SecondaryLink = new MvcHtmlString(FieldRenderer.Render(slideItem, "Secondary Link", "class=btn btn-light py-md-3 px-md-5")),
                        IsActive= counter==0 ? true: false
                    });

                }
                counter++;
            }

            return View(new CarouselModel { Slides = slides });
        }
    }
}