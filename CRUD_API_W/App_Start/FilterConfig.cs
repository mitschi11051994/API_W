﻿using System.Web;
using System.Web.Mvc;

namespace CRUD_API_W
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}