using GYMSTER.Project.Models;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYMSTER.Project.Controllers
{
    public class HeaderNavigationController : Controller
    {
        // GET: HeaderNavigation
        public ActionResult Index()
        {
            List<Navigation> navigations = new List<Navigation>();
            List<Item> navigationItems = new List<Item>();
            var homeItem = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);
            navigationItems.Add(homeItem);
            navigations.Add(new Navigation
            {

            });

            foreach (Item childItem in homeItem.Children)
            {
                navigationItems.Add(childItem);
            }

            return View(navigationItems);
        }
    }
}