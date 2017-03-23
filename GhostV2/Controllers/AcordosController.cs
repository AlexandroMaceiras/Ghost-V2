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
    public class AcordosController : Controller
    {
        private AcordosViewContexto db = new AcordosViewContexto();

        [Authorize, ActionName("Teste"), HttpPost]
        public ActionResult Teste2()
        {
            return View();
        }

        public ActionResult Teste()
        {
            return View();
        }


        public ActionResult Index()
        {

            return View(db.SLV_VW_ACRD_PESQUISAS.OrderBy(x => x.CD_CPF_CNPJ));
        }

        [Authorize, ActionName("Index"), HttpPost]
        public ActionResult Index2(string cliente, string cpfcnpj, string codAcordo,
                            string grupoEconomico, string nomeAdvogado, string codOpSolvere, string codCausa,
                            string statusAcordo)
        {
            if (statusAcordo == "")
                statusAcordo = string.Empty;

            var model =
            db.SLV_VW_ACRD_PESQUISAS.OrderBy(x => x.CD_CPF_CNPJ)
            .Where(x => x.NM_CLIENTE.Contains(cliente))
            .Where(x => x.CD_CPF_CNPJ.Contains(cpfcnpj))
            .Where(x => x.CD_ACORDO.ToString().Contains(codAcordo))
            .Where(x => x.NM_GRUPO_ECONOMICO.Contains(grupoEconomico))

            //.Where(x => x.NM_GESTOR.Contains(nomeAdvogado))

            .Where(x => x.CD_SOLVERE_OPER.ToString().Contains(codOpSolvere))
            .Where(x => x.CD_CAUSA.Contains(codCausa))
            .Where(x => x.IC_STATUS_ACORDO.ToString().Contains(statusAcordo))
            ;
        
            if (cliente != "" || cpfcnpj != "" || codAcordo != "" ||
                grupoEconomico != "" || nomeAdvogado != "" || codOpSolvere != "" ||
                codCausa != "" || statusAcordo != "") //gestorsolve    !="")
            {
                return View("Index", model);
            }
            return RedirectToAction("Index");
        }


        // GET: Acordos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Acordos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Acordos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// GET: Acordos/Edit/5
        //public ActionResult Edit(string cpfcnpj)
        //{
        //    return View();
        //}

        //// POST: Acordos/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int cpfcnpj)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("EditParcelas");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        // GET: SLV_VW_ACRD_PESQUISAS/Edit/5
        public ActionResult Edit(int? CD_SOLVERE_OPER)
        {
            if (CD_SOLVERE_OPER == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SLV_VW_ACRD_PESQUISAS sLV_VW_ACRD_PESQUISAS = db.SLV_VW_ACRD_PESQUISAS.Find(CD_SOLVERE_OPER);
            if (sLV_VW_ACRD_PESQUISAS == null)
            {
                return HttpNotFound();
            }
            return View(sLV_VW_ACRD_PESQUISAS);
        }

        // POST: SLV_VW_ACRD_PESQUISAS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NR_CARGA,DT_CARGA,DT_PROCESSAMENTO,CD_CHAVE_KOPE_IMOVEIS,CD_SOLVERE_GARA,CD_SOLVERE_OPER,NR_SEQ_GARA,DS_TP_GRAVAME,CD_GRAU_HIPOTECA,NR_MATRICULA,NR_CARTORIO_REGISTRO,NM_CARTORIO_REGISTRO,CD_CEP,NM_LOGRADOURO,NR_LOGRADOURO,NM_COMPLEMENTO,NM_BAIRRO,NM_CIDADE,SG_UF,CD_TIPO_IMOVEL,VL_AREA,NR_IPTU,VL_REGISTRO_MATRICULA,DS_OBSERVACOES,IC_PESQUISA_REALIZADA,DS_PESQUISA_DETALHES,DT_PESQUISA,IC_IMOVEL_FORMALIZADO,DS_IMOVEL_FORMALIZADO,DT_IMOVEL_FORMALIZADO,IC_IMOVEL_TOMADO,DS_IMOVEL_TOMADO,DT_IMOVEL_TOMADO,IC_IMOVEL_VENDIDO_BAIXADO,DS_IMOVEL_VENDIDO_BAIXADO,DT_IMOVEL_VENDIDO_BAIXADO,DT_AVALIACAO,VL_GARANTIA,VL_VENDA_FORCADA,VL_VENDA_MERCADO,CD_CPF_CNPJ,SG_TP_PESSOA")] SLV_VW_ACRD_PESQUISAS sLV_VW_ACRD_PESQUISAS)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(sLV_VW_ACRD_PESQUISAS).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View(sLV_VW_ACRD_PESQUISAS);
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("EditParcelas");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditParcelas()
        {
            return View();
        }


        // GET: Acordos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Acordos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
