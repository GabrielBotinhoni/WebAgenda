using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAgenda.Data.Interfaces;
using WebAgenda.Domain.Entities;

namespace WebAgenda.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contactRepository.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Contact model)
        {

            if (!_contactRepository.ValidMail(model.Email))
            {
                TempData["Danger"] = "Erro ao cadastrar contato";
                ModelState.AddModelError("", "Email inválido");
                return View(model);
            }
            if (!_contactRepository.ValidPhone(model.PhoneNumber))
            {
                TempData["Danger"] = "Erro ao cadastrar contato";
                ModelState.AddModelError("", "Número de telefone inválido");
                return View(model);
            }
            if(!_contactRepository.validDate(model.BirthDate))
            {
                TempData["Danger"] = "Erro ao cadastrar contato";
                ModelState.AddModelError("", "Data de nascimento inválida");
                return View(model);
            }
            if (!ModelState.IsValid)
            {
                TempData["Danger"] = "Erro ao cadastrar contato";
                return View(model);
            }

            await _contactRepository.Create(model);
            TempData["Success"] = "Usuário cadastrado com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int ID)
        {
            return View(await _contactRepository.GetByID(ID));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Contact model)
        {
            if (!_contactRepository.ValidMail(model.Email))
            {
                TempData["Danger"] = "Erro ao atualizar contato";
                ModelState.AddModelError("", "Email inválido");
                return View(model);
            }
            if (!_contactRepository.ValidPhone(model.PhoneNumber))
            {
                TempData["Danger"] = "Erro ao atualizar contato";
                ModelState.AddModelError("", "Número de telefone inválido");
                return View(model);
            }
            if (!ModelState.IsValid)
            {
                TempData["Danger"] = "Erro ao atualizar contato";
                return View(model);
            }

            await _contactRepository.EditByContact(model);
            TempData["Success"] = "Usuário atualizado com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int ID)
        {
            return View(await _contactRepository.GetByID(ID));
        }

        public async Task<JsonResult> Delete(int ID)
        {
            await _contactRepository.DeleteByID(ID);
            return Json("OK");
        }

    }
}
