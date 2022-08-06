using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.MVC.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IAccountGroupsService _service;

        public AccountsController(IAccountGroupsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAccountGroups();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Description,Code")] AccountGroupViewModel account)
        {
            if (ModelState.IsValid)
            {
                _service.Add(account);
                return RedirectToAction(nameof(Index));
            }

            return View(account);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var accountGroupVM = await _service.GetById(id);

            if (accountGroupVM == null)
                return NotFound();

            return View(accountGroupVM);
        }

        [HttpPost]
        public IActionResult Edit([Bind("Id,Name,Description,Code")] AccountGroupViewModel account)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.Update(account);
                }
                catch (Exception)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(account);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var accountGroupVM = await _service.GetById(id);

            if (accountGroupVM == null)
                return NotFound();

            return View(accountGroupVM);
        }

        [HttpGet()]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var accountGroupVM = await _service.GetById(id);

            if (accountGroupVM == null)
                return NotFound();

            return View(accountGroupVM);
        }

        [HttpPost(), ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Remove(id);
            return RedirectToAction("Index");
        }
    }
}