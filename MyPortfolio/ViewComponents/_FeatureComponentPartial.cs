using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext PortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = PortfolioContext.Features.ToList();
            return View(values);
        }
    }
}
