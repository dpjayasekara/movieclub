﻿using MovieClub.CustomAttributes;
using System.Web;
using System.Web.Mvc;

namespace MovieClub
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new RequireMembershipAttribute());
            //filters.Add(new RequireAdminAttribute());
        }
    }
}