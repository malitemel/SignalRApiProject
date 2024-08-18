using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace SignalRWebUI.Models.ViewComponents.LayoutComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
