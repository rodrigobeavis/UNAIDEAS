using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using unaideas7.Context;
using unaideas7.Models;

namespace unaideas7.Controllers
{
    public class TurmasController : Controller
    {
        private ApplicationDataContext db = new ApplicationDataContext();

        // GET: Turmas
        public ActionResult Index()
        {
            var turmas = db.Turmas.Include(t => t.EntidadeDeEnsino).Include(t => t.Professor);
            return View(turmas.ToList());
        }

        // GET: Turmas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turma turma = db.Turmas.Find(id);
            if (turma == null)
            {
                return HttpNotFound();
            }
            return View(turma);
        }

        // GET: Turmas/Create
        public ActionResult Create()
        {
            ViewBag.id_entidade_ensino = new SelectList(db.EntidadeDeEnsinoes, "id_entidade_ensino", "nome_entidade_ensino");
            ViewBag.id_professor = new SelectList(db.Professors, "id_professor", "email_professor");
            return View();
        }

        // POST: Turmas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_turma,nome_turma,periodo_turma,id_entidade_ensino,id_professor,ano_turma")] Turma turma)
        {
            if (ModelState.IsValid)
            {
                db.Turmas.Add(turma);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_entidade_ensino = new SelectList(db.EntidadeDeEnsinoes, "id_entidade_ensino", "nome_entidade_ensino", turma.id_entidade_ensino);
            ViewBag.id_professor = new SelectList(db.Professors, "id_professor", "email_professor", turma.id_professor);
            return View(turma);
        }

        // GET: Turmas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turma turma = db.Turmas.Find(id);
            if (turma == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_entidade_ensino = new SelectList(db.EntidadeDeEnsinoes, "id_entidade_ensino", "nome_entidade_ensino", turma.id_entidade_ensino);
            ViewBag.id_professor = new SelectList(db.Professors, "id_professor", "email_professor", turma.id_professor);
            return View(turma);
        }

        // POST: Turmas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_turma,nome_turma,periodo_turma,id_entidade_ensino,id_professor,ano_turma")] Turma turma)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turma).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_entidade_ensino = new SelectList(db.EntidadeDeEnsinoes, "id_entidade_ensino", "nome_entidade_ensino", turma.id_entidade_ensino);
            ViewBag.id_professor = new SelectList(db.Professors, "id_professor", "email_professor", turma.id_professor);
            return View(turma);
        }

        // GET: Turmas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turma turma = db.Turmas.Find(id);
            if (turma == null)
            {
                return HttpNotFound();
            }
            return View(turma);
        }

        // POST: Turmas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Turma turma = db.Turmas.Find(id);
            db.Turmas.Remove(turma);
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
