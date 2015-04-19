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
    public class QualificacaosController : Controller
    {
        private ApplicationDataContext db = new ApplicationDataContext();

        // GET: Qualificacaos
        public ActionResult Index()
        {
            var qualificacaos = db.Qualificacaos.Include(q => q.Professor).Include(q => q.Projeto);
            return View(qualificacaos.ToList());
        }

        // GET: Qualificacaos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Qualificacao qualificacao = db.Qualificacaos.Find(id);
            if (qualificacao == null)
            {
                return HttpNotFound();
            }
            return View(qualificacao);
        }

        // GET: Qualificacaos/Create
        public ActionResult Create()
        {
            ViewBag.id_professor = new SelectList(db.Professors, "id_professor", "email_professor");
            ViewBag.id_projeto = new SelectList(db.Projetoes, "id_projeto", "tipo_projeto");
            return View();
        }

        // POST: Qualificacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_qualificacao,data_hora_qualificacao,obs_qualificacao,id_professor,id_projeto,valor_qualificacao")] Qualificacao qualificacao)
        {
            if (ModelState.IsValid)
            {
                db.Qualificacaos.Add(qualificacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_professor = new SelectList(db.Professors, "id_professor", "email_professor", qualificacao.id_professor);
            ViewBag.id_projeto = new SelectList(db.Projetoes, "id_projeto", "tipo_projeto", qualificacao.id_projeto);
            return View(qualificacao);
        }

        // GET: Qualificacaos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Qualificacao qualificacao = db.Qualificacaos.Find(id);
            if (qualificacao == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_professor = new SelectList(db.Professors, "id_professor", "email_professor", qualificacao.id_professor);
            ViewBag.id_projeto = new SelectList(db.Projetoes, "id_projeto", "tipo_projeto", qualificacao.id_projeto);
            return View(qualificacao);
        }

        // POST: Qualificacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_qualificacao,data_hora_qualificacao,obs_qualificacao,id_professor,id_projeto,valor_qualificacao")] Qualificacao qualificacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qualificacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_professor = new SelectList(db.Professors, "id_professor", "email_professor", qualificacao.id_professor);
            ViewBag.id_projeto = new SelectList(db.Projetoes, "id_projeto", "tipo_projeto", qualificacao.id_projeto);
            return View(qualificacao);
        }

        // GET: Qualificacaos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Qualificacao qualificacao = db.Qualificacaos.Find(id);
            if (qualificacao == null)
            {
                return HttpNotFound();
            }
            return View(qualificacao);
        }

        // POST: Qualificacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Qualificacao qualificacao = db.Qualificacaos.Find(id);
            db.Qualificacaos.Remove(qualificacao);
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
