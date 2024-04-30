using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    
    public class _ExperienceComponentPartial : ViewComponent
    { 
        MyPortfolioContext PortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        { 
            var values = PortfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
