using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult SocialMediaList()
        {
            var values = context.SocialMedias.ToList();

            return View(values);
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = context.SocialMedias.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Update(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}
