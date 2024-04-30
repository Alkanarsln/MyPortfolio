using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.LayoutViewComponent
{
	public class _LayoutSidebarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
