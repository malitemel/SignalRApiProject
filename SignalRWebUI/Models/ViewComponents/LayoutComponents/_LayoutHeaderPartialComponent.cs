using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Models.ViewComponents.LayoutComponents
{
	public class _LayoutHeaderPartialComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

		return View(); 
		
		}
	}
}
