﻿using System.Web;
using System.Web.Mvc;

namespace Slider.MVC.WebApplication2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
