﻿using System.Web;
using System.Web.Mvc;

namespace DNS_GUI_REQ
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
