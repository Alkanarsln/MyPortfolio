using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Testimonials.Count();
            ViewBag.v2 = context.Portfolios.Count();
            ViewBag.v3 = context.Skills.Count();
            ViewBag.v4 = context.Experiences.Count();
            return View();
        }
    }
}
