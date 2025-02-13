using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GYMSTER.Project.Models
{
    public class HeaderModel
    {
        List<Navigation> navigations { get; set; }
    }

    public class Navigation
    {
        public string NavigationTitle { get; set; }
        public string NavigationURL { get; set; }
        public string IsActiveLink { get; set; }

        public List<Navigation> Children { get; set; }
    }
}