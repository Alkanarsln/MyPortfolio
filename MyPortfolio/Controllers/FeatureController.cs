using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult FeatureList()
        {
            var values = context.Features.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFeature(Feature Feature)
        {
            context.Features.Add(Feature);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        public IActionResult DeleteFeature(int id)
        {
            var values = context.Features.Find(id);
            context.Features.Remove(values);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = context.Features.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature Feature)
        {
            context.Features.Update(Feature);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}
