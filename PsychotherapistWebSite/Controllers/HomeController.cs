﻿using System.Web.Mvc;
using PsychotherapistWebSite.Core.Repositories;
using PsychotherapistWebSite.Core.ViewModels;

namespace PsychotherapistWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: Home
        public ActionResult Index()
        {
            var services = _unitOfWork.Service.GetServices();
            var slides = _unitOfWork.Slide.GetSlides();
            var viewModel = new HomeViewModel()
            {
                Services = services,
                Slides =  slides
            };
            return View(viewModel);
        }
    }
}