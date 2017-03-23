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
    public class SLV_TB_FIN_GARA_IMOVEISController : Controller
    {
        private AcordosViewContexto db = new AcordosViewContexto();

        // GET: SLV_TB_FIN_GARA_IMOVEIS
        public ActionResult Index()
        {
            return View(db.SLV_TB_FIN_GARA_IMOVEIS.ToList());
        }

        // GET: SLV_TB_FIN_GARA_IMOVEIS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SLV_TB_FIN_GARA_IMOVEIS sLV_TB_FIN_GARA_IMOVEIS = db.SLV_TB_FIN_GARA_IMOVEIS.Find(id);
            if (sLV_TB_FIN_GARA_IMOVEIS == null)
            {
                return HttpNotFound();
            }
            return View(sLV_TB_FIN_GARA_IMOVEIS);
        }

        // GET: SLV_TB_FIN_GARA_IMOVEIS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SLV_TB_FIN_GARA_IMOVEIS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NR_CARGA,DT_CARGA,DT_PROCESSAMENTO,CD_CHAVE_KOPE_IMOVEIS,CD_SOLVERE_GARA,CD_SOLVERE_OPER,NR_SEQ_GARA,DS_TP_GRAVAME,CD_GRAU_HIPOTECA,NR_MATRICULA,NR_CARTORIO_REGISTRO,NM_CARTORIO_REGISTRO,CD_CEP,NM_LOGRADOURO,NR_LOGRADOURO,NM_COMPLEMENTO,NM_BAIRRO,NM_CIDADE,SG_UF,CD_TIPO_IMOVEL,VL_AREA,NR_IPTU,VL_REGISTRO_MATRICULA,DS_OBSERVACOES,IC_PESQUISA_REALIZADA,DS_PESQUISA_DETALHES,DT_PESQUISA,IC_IMOVEL_FORMALIZADO,DS_IMOVEL_FORMALIZADO,DT_IMOVEL_FORMALIZADO,IC_IMOVEL_TOMADO,DS_IMOVEL_TOMADO,DT_IMOVEL_TOMADO,IC_IMOVEL_VENDIDO_BAIXADO,DS_IMOVEL_VENDIDO_BAIXADO,DT_IMOVEL_VENDIDO_BAIXADO,DT_AVALIACAO,VL_GARANTIA,VL_VENDA_FORCADA,VL_VENDA_MERCADO,CD_CPF_CNPJ,SG_TP_PESSOA")] SLV_TB_FIN_GARA_IMOVEIS sLV_TB_FIN_GARA_IMOVEIS)
        {
            if (ModelState.IsValid)
            {
                db.SLV_TB_FIN_GARA_IMOVEIS.Add(sLV_TB_FIN_GARA_IMOVEIS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sLV_TB_FIN_GARA_IMOVEIS);
        }

        // GET: SLV_TB_FIN_GARA_IMOVEIS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SLV_TB_FIN_GARA_IMOVEIS sLV_TB_FIN_GARA_IMOVEIS = db.SLV_TB_FIN_GARA_IMOVEIS.Find(id);
            if (sLV_TB_FIN_GARA_IMOVEIS == null)
            {
                return HttpNotFound();
            }
            return View(sLV_TB_FIN_GARA_IMOVEIS);
        }

        // POST: SLV_TB_FIN_GARA_IMOVEIS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NR_CARGA,DT_CARGA,DT_PROCESSAMENTO,CD_CHAVE_KOPE_IMOVEIS,CD_SOLVERE_GARA,CD_SOLVERE_OPER,NR_SEQ_GARA,DS_TP_GRAVAME,CD_GRAU_HIPOTECA,NR_MATRICULA,NR_CARTORIO_REGISTRO,NM_CARTORIO_REGISTRO,CD_CEP,NM_LOGRADOURO,NR_LOGRADOURO,NM_COMPLEMENTO,NM_BAIRRO,NM_CIDADE,SG_UF,CD_TIPO_IMOVEL,VL_AREA,NR_IPTU,VL_REGISTRO_MATRICULA,DS_OBSERVACOES,IC_PESQUISA_REALIZADA,DS_PESQUISA_DETALHES,DT_PESQUISA,IC_IMOVEL_FORMALIZADO,DS_IMOVEL_FORMALIZADO,DT_IMOVEL_FORMALIZADO,IC_IMOVEL_TOMADO,DS_IMOVEL_TOMADO,DT_IMOVEL_TOMADO,IC_IMOVEL_VENDIDO_BAIXADO,DS_IMOVEL_VENDIDO_BAIXADO,DT_IMOVEL_VENDIDO_BAIXADO,DT_AVALIACAO,VL_GARANTIA,VL_VENDA_FORCADA,VL_VENDA_MERCADO,CD_CPF_CNPJ,SG_TP_PESSOA")] SLV_TB_FIN_GARA_IMOVEIS sLV_TB_FIN_GARA_IMOVEIS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sLV_TB_FIN_GARA_IMOVEIS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sLV_TB_FIN_GARA_IMOVEIS);
        }

        // GET: SLV_TB_FIN_GARA_IMOVEIS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SLV_TB_FIN_GARA_IMOVEIS sLV_TB_FIN_GARA_IMOVEIS = db.SLV_TB_FIN_GARA_IMOVEIS.Find(id);
            if (sLV_TB_FIN_GARA_IMOVEIS == null)
            {
                return HttpNotFound();
            }
            return View(sLV_TB_FIN_GARA_IMOVEIS);
        }

        // POST: SLV_TB_FIN_GARA_IMOVEIS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SLV_TB_FIN_GARA_IMOVEIS sLV_TB_FIN_GARA_IMOVEIS = db.SLV_TB_FIN_GARA_IMOVEIS.Find(id);
            db.SLV_TB_FIN_GARA_IMOVEIS.Remove(sLV_TB_FIN_GARA_IMOVEIS);
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
