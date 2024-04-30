using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolio = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolio.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSunDescription = portfolio.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetails = portfolio.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}
