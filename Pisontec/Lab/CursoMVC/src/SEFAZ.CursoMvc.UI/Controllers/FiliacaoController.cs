using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SEFAZ.CursoMvc.Application.ViewModels;
using SEFAZ.CursoMvc.UI.Models;

namespace SEFAZ.CursoMvc.UI.Controllers
{
    public class FiliacaoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Filiacao
        public ActionResult Index()
        {
            return View(db.ClienteViewModels.ToList());
        }

        // GET: Filiacao/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteViewModel clienteViewModel = db.ClienteViewModels.Find(id);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }

        // GET: Filiacao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filiacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClienteId,Nome,CPF,Email,DataCadastro,DataNascimento,Ativo")] ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                clienteViewModel.ClienteId = Guid.NewGuid();
                db.ClienteViewModels.Add(clienteViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clienteViewModel);
        }

        // GET: Filiacao/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteViewModel clienteViewModel = db.ClienteViewModels.Find(id);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }

        // POST: Filiacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClienteId,Nome,CPF,Email,DataCadastro,DataNascimento,Ativo")] ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clienteViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clienteViewModel);
        }

        // GET: Filiacao/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteViewModel clienteViewModel = db.ClienteViewModels.Find(id);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }

        // POST: Filiacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            ClienteViewModel clienteViewModel = db.ClienteViewModels.Find(id);
            db.ClienteViewModels.Remove(clienteViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
