﻿using System.Web;
using System.Web.Mvc;

namespace C_CumulativeAssign
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
