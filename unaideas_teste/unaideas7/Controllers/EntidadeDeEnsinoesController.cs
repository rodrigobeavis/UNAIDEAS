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
    public class EntidadeDeEnsinoesController : Controller
    {
        private ApplicationDataContext db = new ApplicationDataContext();

        // GET: EntidadeDeEnsinoes
        public ActionResult Index()
        {
            return View(db.EntidadeDeEnsinoes.ToList());
        }

        // GET: EntidadeDeEnsinoes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeDeEnsino entidadeDeEnsino = db.EntidadeDeEnsinoes.Find(id);
            if (entidadeDeEnsino == null)
            {
                return HttpNotFound();
            }
            return View(entidadeDeEnsino);
        }

        // GET: EntidadeDeEnsinoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EntidadeDeEnsinoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_entidade_ensino,nome_entidade_ensino,descricao_entidade_ensino")] EntidadeDeEnsino entidadeDeEnsino)
        {
            if (ModelState.IsValid)
            {
                db.EntidadeDeEnsinoes.Add(entidadeDeEnsino);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entidadeDeEnsino);
        }

        // GET: EntidadeDeEnsinoes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeDeEnsino entidadeDeEnsino = db.EntidadeDeEnsinoes.Find(id);
            if (entidadeDeEnsino == null)
            {
                return HttpNotFound();
            }
            return View(entidadeDeEnsino);
        }

        // POST: EntidadeDeEnsinoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_entidade_ensino,nome_entidade_ensino,descricao_entidade_ensino")] EntidadeDeEnsino entidadeDeEnsino)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entidadeDeEnsino).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entidadeDeEnsino);
        }

        // GET: EntidadeDeEnsinoes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntidadeDeEnsino entidadeDeEnsino = db.EntidadeDeEnsinoes.Find(id);
            if (entidadeDeEnsino == null)
            {
                return HttpNotFound();
            }
            return View(entidadeDeEnsino);
        }

        // POST: EntidadeDeEnsinoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            EntidadeDeEnsino entidadeDeEnsino = db.EntidadeDeEnsinoes.Find(id);
            db.EntidadeDeEnsinoes.Remove(entidadeDeEnsino);
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
