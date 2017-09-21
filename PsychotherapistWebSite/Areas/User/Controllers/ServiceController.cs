﻿using PsychotherapistWebSite.Core.Repositories;
using System.Web.Mvc;
using PsychotherapistWebSite.Areas.User.Models;

namespace PsychotherapistWebSite.Areas.User.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: User/Service
        public ActionResult Index()
        {
            var viewModel = _unitOfWork.Service.GetServices();
            return View(viewModel);
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Yeni Alan Ekle";
            ViewBag.Action = ActionType.Save;
            return View("Create", null);
        }

        public ActionResult Edit(int id)
        {
            var service = _unitOfWork.Service.GetService(id);
            ViewBag.Title = "Alan Düzenle";
            ViewBag.Action = ActionType.Edit;
            return View("Create", service);
        }

    }
}