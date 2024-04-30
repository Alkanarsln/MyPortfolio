using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.LayoutViewComponent
{
	public class _LayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
