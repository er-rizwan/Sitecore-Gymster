﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYMSTER.Project.Models
{
    public class CarouselModel
    {
       public List<SlideModel> Slides { get; set; }
    }

    public class SlideModel
    {
        public MvcHtmlString SlideTitle { get; set; }
        public MvcHtmlString SubSlideTitle { get; set; }
        public MvcHtmlString SlideImage { get; set; }
        public MvcHtmlString PrimaryLink { get; set; }
        public MvcHtmlString SecondaryLink { get; set; }
        public bool IsActive { get; set; }
    }
}