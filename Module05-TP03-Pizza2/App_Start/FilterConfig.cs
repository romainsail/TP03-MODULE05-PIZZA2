﻿using System.Web;
using System.Web.Mvc;

namespace Module05_TP03_Pizza2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
