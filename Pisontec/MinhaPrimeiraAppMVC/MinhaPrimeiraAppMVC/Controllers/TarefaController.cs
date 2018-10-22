using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MinhaPrimeiraAppMVC.Models;

namespace MinhaPrimeiraAppMVC.Controllers
{
    public class TarefaController : Controller
    {
        private TarefaContexto db = new TarefaContexto();

        // GET: Tarefa
        public ActionResult Index()
        {
            var tarefas = db.Tarefas.Include(t => t.Lista);
            return View(tarefas.ToList());
        }

        // GET: Tarefa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarefas tarefas = db.Tarefas.Find(id);
            if (tarefas == null)
            {
                return HttpNotFound();
            }
            return View(tarefas);
        }

        // GET: Tarefa/Create
        public ActionResult Create()
        {
            ViewBag.ListaId = new SelectList(db.Listas, "Id", "Nome");
            return View();
        }

        // POST: Tarefa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TarefaId,Nome,Concluida,Ativa,ListaId")] Tarefas tarefas)
        {
            if (ModelState.IsValid)
            {
                db.Tarefas.Add(tarefas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ListaId = new SelectList(db.Listas, "Id", "Nome", tarefas.ListaId);
            return View(tarefas);
        }

        // GET: Tarefa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarefas tarefas = db.Tarefas.Find(id);
            if (tarefas == null)
            {
                return HttpNotFound();
            }
            ViewBag.ListaId = new SelectList(db.Listas, "Id", "Nome", tarefas.ListaId);
            return View(tarefas);
        }

        // POST: Tarefa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TarefaId,Nome,Concluida,Ativa,ListaId")] Tarefas tarefas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tarefas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ListaId = new SelectList(db.Listas, "Id", "Nome", tarefas.ListaId);
            return View(tarefas);
        }

        // GET: Tarefa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarefas tarefas = db.Tarefas.Find(id);
            if (tarefas == null)
            {
                return HttpNotFound();
            }
            return View(tarefas);
        }

        // POST: Tarefa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tarefas tarefas = db.Tarefas.Find(id);
            db.Tarefas.Remove(tarefas);
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
