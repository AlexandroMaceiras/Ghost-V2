using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GhostV2.Models;

namespace GhostV2.Controllers
{
    public class TesteModelsController : Controller
    {
        private GerenciamentoViewContexto db = new GerenciamentoViewContexto();

        // GET: TesteModels
        public ActionResult Index()
        {
            return View(db.TesteModels.ToList());
        }

        // GET: TesteModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TesteModel testeModel = db.TesteModels.Find(id);
            if (testeModel == null)
            {
                return HttpNotFound();
            }
            return View(testeModel);
        }

        // GET: TesteModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TesteModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NR_CARGA,NR_SEQ,DT_PROCESSAMENTO,CD_CPF_CNPJ,SG_TP_PESSOA,CD_CPF_CNPJ_PESSOA,PF_PJ_PESSOA,CD_SOLVERE_OPER,DS_PAPEL,NM_PESSOA,NR_DDD,NR_TELEFONE,NR_DDD_CELULAR,NR_CELULAR,NM_EMAIL_SOCIO,NM_CONTATO_SOCIO,NM_GRUPO_ECONOMICO,NM_CONJUGE,NM_LOGRADOURO,NR_LOGRADOURO,NM_COMPLEMENTO,NM_BAIRRO,NM_CIDADE,SG_UF,NM_PAIS")] TesteModel testeModel)
        {
            if (ModelState.IsValid)
            {
                db.TesteModels.Add(testeModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testeModel);
        }

        // GET: TesteModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TesteModel testeModel = db.TesteModels.Find(id);
            if (testeModel == null)
            {
                return HttpNotFound();
            }
            return View(testeModel);
        }

        // POST: TesteModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NR_CARGA,NR_SEQ,DT_PROCESSAMENTO,CD_CPF_CNPJ,SG_TP_PESSOA,CD_CPF_CNPJ_PESSOA,PF_PJ_PESSOA,CD_SOLVERE_OPER,DS_PAPEL,NM_PESSOA,NR_DDD,NR_TELEFONE,NR_DDD_CELULAR,NR_CELULAR,NM_EMAIL_SOCIO,NM_CONTATO_SOCIO,NM_GRUPO_ECONOMICO,NM_CONJUGE,NM_LOGRADOURO,NR_LOGRADOURO,NM_COMPLEMENTO,NM_BAIRRO,NM_CIDADE,SG_UF,NM_PAIS")] TesteModel testeModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testeModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testeModel);
        }

        // GET: TesteModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TesteModel testeModel = db.TesteModels.Find(id);
            if (testeModel == null)
            {
                return HttpNotFound();
            }
            return View(testeModel);
        }

        // POST: TesteModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TesteModel testeModel = db.TesteModels.Find(id);
            db.TesteModels.Remove(testeModel);
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
