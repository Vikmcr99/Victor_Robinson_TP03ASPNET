using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Victor_Robinson_TP03ASPNET.Models;

namespace Victor_Robinson_TP03ASPNET.Controllers
{
    public class AniversarianteController : Controller
    {
        // GET: AniversarianteController
        public ActionResult Index()
        {
            return View(Repositorio.listaAniversariantes);
        }

        // GET: AniversarianteController/Details/5
        public ActionResult Details(int id)
        {
            return View(Repositorio.GetId(id));
        }

        // GET: AniversarianteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AniversarianteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aniversariante novoAniversariante)
        {
            Repositorio.Adicionar(novoAniversariante);
            return View("Index", Repositorio.listaAniversariantes);
        }

        // GET: AniversarianteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repositorio.GetId(id));
        }

        // POST: AniversarianteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Aniversariante aniversariante)
        {
            try
            {
                Repositorio.Editar(id, aniversariante);

                return RedirectToAction(nameof(Index));
            }

            catch
            {
                return View();
            }
        }

        // GET: AniversarianteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repositorio.GetId(id));
        }

        // POST: AniversarianteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Aniversariante aniversariante, int id)
        {
            try
            {
                Repositorio.Deletar(aniversariante);
                return RedirectToAction(nameof(Index));
            }

            catch
            {
                return View();
            }
        }

        public ActionResult Buscar(int id)
        {
            return View(Repositorio.GetId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Buscar(string aniversariante)
        {

            try
            {
                Repositorio.AchaAniversariante(aniversariante);

                return RedirectToAction(nameof(Details));
            }

            catch
            {
                return View();
            }

        }
    }
}

