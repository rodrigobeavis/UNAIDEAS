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
    public class AutenticacaosController : Controller
    {
        private ApplicationDataContext db = new ApplicationDataContext();

        // GET: Autenticacaos
        public ActionResult Index()
        {
            return View(db.Autenticacaos.ToList());
        }

        // GET: Autenticacaos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autenticacao autenticacao = db.Autenticacaos.Find(id);
            if (autenticacao == null)
            {
                return HttpNotFound();
            }
            return View(autenticacao);
        }

        // GET: Autenticacaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autenticacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_autenticacao,login,pw,area_user,acesso_user")] Autenticacao autenticacao)
        {
            if (ModelState.IsValid)
            {
                db.Autenticacaos.Add(autenticacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(autenticacao);
        }

        // GET: Autenticacaos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autenticacao autenticacao = db.Autenticacaos.Find(id);
            if (autenticacao == null)
            {
                return HttpNotFound();
            }
            return View(autenticacao);
        }

        // POST: Autenticacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_autenticacao,login,pw,area_user,acesso_user")] Autenticacao autenticacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autenticacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(autenticacao);
        }

        // GET: Autenticacaos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autenticacao autenticacao = db.Autenticacaos.Find(id);
            if (autenticacao == null)
            {
                return HttpNotFound();
            }
            return View(autenticacao);
        }

        // POST: Autenticacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Autenticacao autenticacao = db.Autenticacaos.Find(id);
            db.Autenticacaos.Remove(autenticacao);
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
