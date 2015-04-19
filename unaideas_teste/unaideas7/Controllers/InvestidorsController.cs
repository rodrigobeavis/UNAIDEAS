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
    public class InvestidorsController : Controller
    {
        private ApplicationDataContext db = new ApplicationDataContext();

        // GET: Investidors
        public ActionResult Index()
        {
            var investidors = db.Investidors.Include(i => i.Autenticacao).Include(i => i.EntidadeDeEnsino);
            return View(investidors.ToList());
        }

        // GET: Investidors/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Investidor investidor = db.Investidors.Find(id);
            if (investidor == null)
            {
                return HttpNotFound();
            }
            return View(investidor);
        }

        // GET: Investidors/Create
        public ActionResult Create()
        {
            ViewBag.id_autenticacao = new SelectList(db.Autenticacaos, "id_autenticacao", "login");
            ViewBag.id_entidade_ensino = new SelectList(db.EntidadeDeEnsinoes, "id_entidade_ensino", "nome_entidade_ensino");
            return View();
        }

        // POST: Investidors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_investidor,nome_investidor,rg_investidor,cod_investidor,email_investidor,id_entidade_ensino,id_autenticacao,telefone_investidor")] Investidor investidor)
        {
            if (ModelState.IsValid)
            {
                db.Investidors.Add(investidor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_autenticacao = new SelectList(db.Autenticacaos, "id_autenticacao", "login", investidor.id_autenticacao);
            ViewBag.id_entidade_ensino = new SelectList(db.EntidadeDeEnsinoes, "id_entidade_ensino", "nome_entidade_ensino", investidor.id_entidade_ensino);
            return View(investidor);
        }

        // GET: Investidors/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Investidor investidor = db.Investidors.Find(id);
            if (investidor == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_autenticacao = new SelectList(db.Autenticacaos, "id_autenticacao", "login", investidor.id_autenticacao);
            ViewBag.id_entidade_ensino = new SelectList(db.EntidadeDeEnsinoes, "id_entidade_ensino", "nome_entidade_ensino", investidor.id_entidade_ensino);
            return View(investidor);
        }

        // POST: Investidors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_investidor,nome_investidor,rg_investidor,cod_investidor,email_investidor,id_entidade_ensino,id_autenticacao,telefone_investidor")] Investidor investidor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(investidor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_autenticacao = new SelectList(db.Autenticacaos, "id_autenticacao", "login", investidor.id_autenticacao);
            ViewBag.id_entidade_ensino = new SelectList(db.EntidadeDeEnsinoes, "id_entidade_ensino", "nome_entidade_ensino", investidor.id_entidade_ensino);
            return View(investidor);
        }

        // GET: Investidors/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Investidor investidor = db.Investidors.Find(id);
            if (investidor == null)
            {
                return HttpNotFound();
            }
            return View(investidor);
        }

        // POST: Investidors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Investidor investidor = db.Investidors.Find(id);
            db.Investidors.Remove(investidor);
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
