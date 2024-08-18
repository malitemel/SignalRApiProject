using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Models.ViewComponents.LayoutComponents
{
	public class _LayoutFooterComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	
	}
}
