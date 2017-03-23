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
    public class GerenciamentoViewModelController : Controller
    {
        private GerenciamentoViewContexto db = new GerenciamentoViewContexto();


        // GET: GerenciamentoView
        public ActionResult Index()
        {
            IEnumerable<GerenciamentoViewModel> model = null;

            model = (from e in db.SLV_VW_GERE_PROCESSOS
                     join j in db.SLV_VW_GERE_DADOS_CADASTRAIS
                     on new { e.CD_CPF_CNPJ, e.SG_TP_PESSOA } equals new { j.CD_CPF_CNPJ, j.SG_TP_PESSOA }
                     select new GerenciamentoViewModel
                     {
                         CD_CPF_CNPJ = e.CD_CPF_CNPJ,
                         SG_TP_PESSOA = e.SG_TP_PESSOA,

                         CD_SOLVERE_OPER = e.CD_SOLVERE_OPER,
                         NM_PESSOA = e.NM_PESSOA,
                         CD_CAUSA = e.CD_CAUSA,
                         NR_PROCESSO = e.NR_PROCESSO,
                         NR_CONTRATO = e.NR_CONTRATO,
                         NM_ESCRITORIO_COBRANCA = e.NM_ESCRITORIO_COBRANCA,
                         IC_STATUS_PROCESSUAL = e.IC_STATUS_PROCESSUAL,
                         IC_STATUS_OPERACIONAL = e.IC_STATUS_OPERACIONAL,
                         NM_PRODUTO = e.NM_PRODUTO,
                         DT_CONTRATO = e.DT_CONTRATO,
                         DT_VENC_DESDE = e.DT_VENC_DESDE,
                         NM_GRUPO_ECONOMICO = e.NM_GRUPO_ECONOMICO,
                         CD_CARTEIRA = e.CD_CARTEIRA,
                         VL_SALDO_CONTABIL_DEVEDOR = e.VL_SALDO_CONTABIL_DEVEDOR,
                         VL_SALDO_GERENCIAL = e.VL_SALDO_GERENCIAL,

                         NR_CARGA = j.NR_CARGA
                     }).ToList();


            return View(model);
        }

        [Authorize, ActionName("Index"), HttpPost]
        public ActionResult Index2(string cliente, string cpfcnpj, string numeroContrato,
                                    string pessoaJuridica1, string pessoaJuridica2, string numeroProcesso, string incluirGrupo,
                                    string grupoEconomico, string carteira, string codOpSolvere,
                                    string escritorio) //,  string gestorSolvere)
        {
            var pessoaJuridica = "";
            if (pessoaJuridica1 != null && pessoaJuridica2 == null)
            {
                pessoaJuridica = "J";
            }
            else if (pessoaJuridica2 != null && pessoaJuridica1 == null)
            {
                pessoaJuridica = "F";
            }
            else
            {
                pessoaJuridica = "";
            }

            IEnumerable<GerenciamentoViewModel> model = null;

            if (incluirGrupo == "on")
            {
                model =
                (from d in db.SLV_VW_GERE_PROCESSOS
                 where
                       (from z in db.SLV_VW_GERE_PROCESSOS
                        where z.NM_GRUPO_ECONOMICO.Contains(grupoEconomico)
                        where z.NM_PESSOA.Contains(cliente)
                        where z.CD_CPF_CNPJ.Contains(cpfcnpj)
                        where z.NR_CONTRATO.Contains(numeroContrato)
                        where z.NR_PROCESSO.Contains(numeroProcesso)
                        where z.CD_CARTEIRA.Contains(carteira)
                        where z.CD_SOLVERE_OPER.ToString().Contains(codOpSolvere)
                        where z.NM_ESCRITORIO_COBRANCA.Contains(escritorio)
                        select new
                        { z.NM_GRUPO_ECONOMICO }).Contains(new { NM_GRUPO_ECONOMICO = d.NM_GRUPO_ECONOMICO })
                 join j in db.SLV_VW_GERE_DADOS_CADASTRAIS
                     on new { d.CD_CPF_CNPJ, d.SG_TP_PESSOA } equals new { j.CD_CPF_CNPJ, j.SG_TP_PESSOA }
                 select new GerenciamentoViewModel
                 {
                     CD_CPF_CNPJ = d.CD_CPF_CNPJ,
                     SG_TP_PESSOA = d.SG_TP_PESSOA,

                     CD_SOLVERE_OPER = d.CD_SOLVERE_OPER,
                     NM_PESSOA = d.NM_PESSOA,
                     CD_CAUSA = d.CD_CAUSA,
                     NR_PROCESSO = d.NR_PROCESSO,
                     NR_CONTRATO = d.NR_CONTRATO,
                     NM_ESCRITORIO_COBRANCA = d.NM_ESCRITORIO_COBRANCA,
                     IC_STATUS_PROCESSUAL = d.IC_STATUS_PROCESSUAL,
                     IC_STATUS_OPERACIONAL = d.IC_STATUS_OPERACIONAL,
                     NM_PRODUTO = d.NM_PRODUTO,
                     DT_CONTRATO = d.DT_CONTRATO,
                     DT_VENC_DESDE = d.DT_VENC_DESDE,
                     NM_GRUPO_ECONOMICO = d.NM_GRUPO_ECONOMICO,
                     CD_CARTEIRA = d.CD_CARTEIRA,
                     VL_SALDO_CONTABIL_DEVEDOR = d.VL_SALDO_CONTABIL_DEVEDOR,
                     VL_SALDO_GERENCIAL = d.VL_SALDO_GERENCIAL,

                     NR_CARGA = j.NR_CARGA
                 }).ToList();
            }
            else
            {
                model = (from e in db.SLV_VW_GERE_PROCESSOS
                         join j in db.SLV_VW_GERE_DADOS_CADASTRAIS
                         on e.CD_CPF_CNPJ equals j.CD_CPF_CNPJ
                         select new GerenciamentoViewModel
                         {
                             CD_CPF_CNPJ = e.CD_CPF_CNPJ,
                             SG_TP_PESSOA = e.SG_TP_PESSOA,

                             CD_SOLVERE_OPER = e.CD_SOLVERE_OPER,
                             NM_PESSOA = e.NM_PESSOA,
                             CD_CAUSA = e.CD_CAUSA,
                             NR_PROCESSO = e.NR_PROCESSO,
                             NR_CONTRATO = e.NR_CONTRATO,
                             NM_ESCRITORIO_COBRANCA = e.NM_ESCRITORIO_COBRANCA,
                             IC_STATUS_PROCESSUAL = e.IC_STATUS_PROCESSUAL,
                             IC_STATUS_OPERACIONAL = e.IC_STATUS_OPERACIONAL,
                             NM_PRODUTO = e.NM_PRODUTO,
                             DT_CONTRATO = e.DT_CONTRATO,
                             DT_VENC_DESDE = e.DT_VENC_DESDE,
                             NM_GRUPO_ECONOMICO = e.NM_GRUPO_ECONOMICO,
                             CD_CARTEIRA = e.CD_CARTEIRA,
                             VL_SALDO_CONTABIL_DEVEDOR = e.VL_SALDO_CONTABIL_DEVEDOR,
                             VL_SALDO_GERENCIAL = e.VL_SALDO_GERENCIAL,

                             NR_CARGA = j.NR_CARGA
                         }).ToList()

                .Where(x => x.NM_PESSOA.Contains(cliente))
                .Where(x => x.CD_CPF_CNPJ.Contains(cpfcnpj))
                .Where(x => x.NR_CONTRATO.Contains(numeroContrato))

                .Where(x => x.SG_TP_PESSOA.Contains(pessoaJuridica))
                .Where(x => x.NR_PROCESSO.Contains(numeroProcesso))
                //incluirGrupo é um campo só usado na decisão acima.

                .Where(x => x.NM_GRUPO_ECONOMICO.Contains(grupoEconomico))
                .Where(x => x.CD_CARTEIRA.Contains(carteira))
                .Where(x => x.CD_SOLVERE_OPER.ToString().Contains(codOpSolvere))

                .Where(x => x.NM_ESCRITORIO_COBRANCA.Contains(escritorio));
                // GESTOR SOLVERE ??????     .Where(x => x.CD_GESTOR.Contains(gestorSolvere))
            }
            ViewBag.Proxima = false;
            ViewBag.Anterior = false;

            if (cliente != "" || cpfcnpj != "" || numeroContrato != "" ||
                pessoaJuridica != "" || numeroProcesso != "" || incluirGrupo != "" ||
                grupoEconomico != "" || carteira != "" || codOpSolvere != "" ||
                escritorio != "") //gestorsolve    !="")
            {
                return View("Index", model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SLV_VW_GERE_DADOS_CADASTRAIS sLV_VW_GERE_DADOS_CADASTRAIS = db.SLV_VW_GERE_DADOS_CADASTRAIS.Find(id);
            if (sLV_VW_GERE_DADOS_CADASTRAIS == null)
            {
                return HttpNotFound();
            }
            return View(sLV_VW_GERE_DADOS_CADASTRAIS);
        }

        public ActionResult SuperDetalhes(string cpfcnpj)
        {
            if (cpfcnpj == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            IEnumerable<DetalhesGerenciamentoViewModel> model = null;

            model = (from a in db.SLV_VW_GERE_DADOS_CADASTRAIS

                     join b in db.SLV_TB_FIN_GERE_SOCIOS
                     on a.CD_CPF_CNPJ equals b.CD_CPF_CNPJ into m
                     from n in m.DefaultIfEmpty()

                     join c in db.SLV_TB_FIN_GARA_IMOVEIS
                     on a.CD_CPF_CNPJ equals c.CD_CPF_CNPJ into aa
                     from cc in aa.DefaultIfEmpty()

                     join d in db.SLV_TB_FIN_GARA_VEIC_MAQ
                     on new { a.CD_CPF_CNPJ, n.CD_SOLVERE_OPER } equals new { d.CD_CPF_CNPJ, d.CD_SOLVERE_OPER }
                     into e
                     from f in e.DefaultIfEmpty()                     

                     where a.CD_CPF_CNPJ == cpfcnpj
                      //&& f.NR_CARGA != null //Ele aqui diz sempre que isto não é necessário pois um int? nunca é nulo, mas no SQL isso não existe e mesmo os nulos acabam vindo no resultado com algum valor!
                     select new
                     {

                         //DADOS PRINCIPAIS

                         CD_CPF_CNPJ                = a.CD_CPF_CNPJ,
                         NR_CARGA                   = a.NR_CARGA,
                         //NR_CARGA_B                 = n.NR_CARGA,
                         SG_TP_PESSOA               = a.SG_TP_PESSOA,
                         NM_PESSOA                  = a.NM_PESSOA,
                         NM_GRUPO_ECONOMICO         = a.NM_GRUPO_ECONOMICO,
                         NM_LOGRADOURO              = a.NM_LOGRADOURO,
                         NR_LOGRADOURO              = a.NR_LOGRADOURO,
                         NM_COMPLEMENTO             = a.NM_COMPLEMENTO,
                         NM_BAIRRO                  = a.NM_BAIRRO,
                         NM_CIDADE                  = a.NM_CIDADE,
                         SG_UF                      = a.SG_UF,
                         CD_CEP                     = a.CD_CEP,
                         NM_PAIS                    = a.NM_PAIS,
                         NR_DDD                     = a.NR_DDD,
                         NR_TELEFONE                = a.NR_TELEFONE,
                         NR_DDD_CELULAR             = a.NR_DDD_CELULAR,
                         NR_CELULAR                 = a.NR_CELULAR,
                         NM_EMAIL                   = a.NM_EMAIL,
                         DT_NASCIMENTO_OU_FUNDACAO  = a.DT_NASCIMENTO_OU_FUNDACAO,
                         NM_CONTATO                 = a.NM_CONTATO,
                         NR_RG                      = a.NR_RG,
                         NM_EMISSOR_RG              = a.NM_EMISSOR_RG,
                         DS_NATURALIDADE            = a.DS_NATURALIDADE,
                         DS_NACIONALIDADE           = a.DS_NACIONALIDADE,
                         NM_PAI                     = a.NM_PAI,
                         NM_MAE                     = a.NM_MAE,
                         NM_CONJUGE                 = a.NM_CONJUGE,
                         CD_ESTADO_CIVIL            = a.CD_ESTADO_CIVIL,
                         DS_ESTADO_CIVIL            = a.DS_ESTADO_CIVIL,
                         CD_REGIME_CIVIL            = a.CD_REGIME_CIVIL,
                         DT_CADASTRO                = a.DT_CADASTRO,
                         DT_ATUALIZACAO             = a.DT_ATUALIZACAO,

                         //DADOS DOS SOCIOS

                         CD_CPF_CNPJ_SOCIO          = n.CD_CPF_CNPJ_PESSOA,
                         NM_SOCIO                   = n.NM_PESSOA,
                         PF_PJ_PESSOA_SOCIO         = n.PF_PJ_PESSOA,
                         CD_SOLVERE_OPER_SOCIO      = n.CD_SOLVERE_OPER,
                         DS_PAPEL_SOCIO             = n.DS_PAPEL,
                         NR_DDD_SOCIO               = n.NR_DDD,
                         NR_TELEFONE_SOCIO          = n.NR_TELEFONE,
                         NR_DDD_CELULAR_SOCIO       = n.NR_DDD_CELULAR,
                         NR_CELULAR_SOCIO           = n.NR_CELULAR,
                         NM_EMAIL_SOCIO             = n.NM_EMAIL_SOCIO,
                         NM_CONTATO_SOCIO           = n.NM_CONTATO_SOCIO,
                         NM_GRUPO_ECONOMICO_SOCIO   = n.NM_GRUPO_ECONOMICO,
                         NM_CONJUGE_SOCIO           = n.NM_CONJUGE,
                         NM_LOGRADOURO_SOCIO        = n.NM_LOGRADOURO,
                         NR_LOGRADOURO_SOCIO        = n.NR_LOGRADOURO,
                         NM_COMPLEMENTO_SOCIO       = n.NM_COMPLEMENTO,
                         NM_BAIRRO_SOCIO            = n.NM_BAIRRO,
                         NM_CIDADE_SOCIO            = n.NM_CIDADE,
                         SG_UF_SOCIO                = n.SG_UF,
                         NM_PAIS_SOCIO              = n.NM_PAIS,

                         //DADOS DOS IMÓVEIS

                         DT_PROCESSAMENTO_IMOV          = cc.DT_PROCESSAMENTO,
                         CD_CHAVE_KOPE_IMOVEIS          = cc.CD_CHAVE_KOPE_IMOVEIS,
                         CD_SOLVERE_GARA_IMOV           = cc.CD_SOLVERE_GARA,
                         CD_SOLVERE_OPER_IMOV           = cc.CD_SOLVERE_OPER,
                         NR_SEQ_GARA_IMOV               = cc.NR_SEQ_GARA,
                         DS_TP_GRAVAME_IMOV             = cc.DS_TP_GRAVAME,
                         CD_GRAU_HIPOTECA_IMOV          = cc.CD_GRAU_HIPOTECA,
                         NR_MATRICULA_IMOV              = cc.NR_MATRICULA,
                         NR_CARTORIO_REGISTRO_IMOV      = cc.NR_CARTORIO_REGISTRO,
                         NM_CARTORIO_REGISTRO_IMOV      = cc.NM_CARTORIO_REGISTRO,
                         CD_CEP_IMOV                    = cc.CD_CEP,
                         NM_LOGRADOURO_IMOV             = cc.NM_LOGRADOURO,
                         NR_LOGRADOURO_IMOV             = cc.NR_LOGRADOURO,
                         NM_COMPLEMENTO_IMOV            = cc.NM_COMPLEMENTO,
                         NM_BAIRRO_IMOV                 = cc.NM_BAIRRO,
                         NM_CIDADE_IMOV                 = cc.NM_CIDADE,
                         SG_UF_IMOV                     = cc.SG_UF,
                         CD_TIPO_IMOVEL                 = cc.CD_TIPO_IMOVEL,
                         VL_AREA_IMOV                   = cc.VL_AREA,
                         NR_IPTU_IMOV                   = cc.NR_IPTU,
                         VL_REGISTRO_MATRICULA_IMOV     = cc.VL_REGISTRO_MATRICULA,
                         DS_OBSERVACOES_IMOV            = cc.DS_OBSERVACOES,
                         IC_PESQUISA_REALIZADA_IMOV     = cc.IC_PESQUISA_REALIZADA,
                         DS_PESQUISA_DETALHES_IMOV      = cc.DS_PESQUISA_DETALHES,
                         DT_PESQUISA_IMOV               = cc.DT_PESQUISA,
                         IC_IMOVEL_FORMALIZADO_IMOV     = cc.IC_IMOVEL_FORMALIZADO,
                         DS_IMOVEL_FORMALIZADO_IMOV     = cc.DS_IMOVEL_FORMALIZADO,
                         DT_IMOVEL_FORMALIZADO_IMOV     = cc.DT_IMOVEL_FORMALIZADO,
                         IC_IMOVEL_TOMADO_IMOV          = cc.IC_IMOVEL_TOMADO,
                         DS_IMOVEL_TOMADO_IMOV          = cc.DS_IMOVEL_TOMADO,
                         DT_IMOVEL_TOMADO_IMOV          = cc.DT_IMOVEL_TOMADO,
                         IC_IMOVEL_VENDIDO_BAIXADO_IMOV = cc.IC_IMOVEL_VENDIDO_BAIXADO,
                         DS_IMOVEL_VENDIDO_BAIXADO_IMOV = cc.DS_IMOVEL_VENDIDO_BAIXADO,
                         DT_IMOVEL_VENDIDO_BAIXADO_IMOV = cc.DT_IMOVEL_VENDIDO_BAIXADO,
                         DT_AVALIACAO_IMOV              = cc.DT_AVALIACAO,
                         VL_GARANTIA_IMOV               = cc.VL_GARANTIA,
                         VL_VENDA_FORCADA_IMOV          = cc.VL_VENDA_FORCADA,
                         VL_VENDA_MERCADO_IMOV          = cc.VL_VENDA_MERCADO,
                         CD_CPF_CNPJ_IMOV               = cc.CD_CPF_CNPJ,
                         SG_TP_PESSOA_IMOV              = cc.SG_TP_PESSOA,

                         //DADOS DOS VEÍCULOS E MÁQUINAS

                        DT_PROCESSAMENTO_MAQ        = f.DT_PROCESSAMENTO,
                        CD_CHAVE_KOPE_VEICULOS_MAQ  = f.CD_CHAVE_KOPE_VEICULOS,
                        CD_CHAVE_KOPE_MAQUINA_MAQ   = f.CD_CHAVE_KOPE_MAQUINA,
                        CD_SOLVERE_GARA_MAQ         = f.CD_SOLVERE_GARA,
                        CD_SOLVERE_OPER_MAQ         = f.CD_SOLVERE_OPER,
                        NR_SEQ_GARA_MAQ             = f.NR_SEQ_GARA,
                        NR_CHASSI_MAQ               = f.NR_CHASSI,
                        CD_TIPO_CHASSI_MAQ          = f.CD_TIPO_CHASSI,
                        SG_UF_LICENCIAMENTO_MAQ     = f.SG_UF_LICENCIAMENTO,
                        SG_UF_PLACA_MAQ             = f.SG_UF_PLACA,
                        NR_PLACA_MAQ                = f.NR_PLACA,
                        NR_RENAVAM_MAQ              = f.NR_RENAVAM,
                        NR_ANO_FABRICACAO_MAQ       = f.NR_ANO_FABRICACAO,
                        NR_ANO_MODELO_MAQ           = f.NR_ANO_MODELO,
                        CD_TP_GRAVAME_MAQ           = f.CD_TP_GRAVAME,
                        DT_GRAVAME_MAQ              = f.DT_BAIXA_GRAVAME,
                        DT_BAIXA_GRAVAME_MAQ        = f.DT_BAIXA_GRAVAME,
                        DS_MODELO_MAQ               = f.DS_MODELO,
                        DS_MARCA_MAQ                = f.DS_MARCA,
                        DS_COR_MAQ                  = f.DS_COR,
                        DS_COMBUSTIVEL_MAQ          = f.DS_COMBUSTIVEL,
                        DS_VEICULO_MAQUINA_MAQ      = f.DS_VEICULO_MAQUINA,
                        NR_SERIE_MAQ                = f.NR_SERIE,
                        DS_FABRICANTE_MAQ           = f.DS_FABRICANTE,
                        DS_TIPO_BEM_MAQ             = f.DS_TIPO_BEM,
                        DS_OBSERVACOES_GERAIS_MAQ   = f.DS_OBSERVACOES_GERAIS,
                        IC_PESQUISA_REALIZADA_MAQ   = f.IC_PESQUISA_REALIZADA,
                        DS_PESQUISA_DETALHES_MAQ    = f.DS_PESQUISA_DETALHES,
                        DT_PESQUISA_MAQ             = f.DT_PESQUISA,
                        IC_BEM_FORMALIZADO_MAQ      = f.IC_BEM_FORMALIZADO,
                        DS_BEM_FORMALIZADO_MAQ      = f.DS_BEM_FORMALIZADO,
                        DT_BEM_FORMALIZADO_MAQ      = f.DT_BEM_FORMALIZADO,
                        IC_BEM_TOMADO_MAQ           = f.IC_BEM_TOMADO,
                        DS_BEM_TOMADO_MAQ           = f.DS_BEM_TOMADO,
                        DT_BEM_TOMADO_MAQ           = f.DT_BEM_TOMADO,
                        IC_BEM_VENDIDO_MAQ          = f.IC_BEM_VENDIDO,
                        DS_BEM_VENDIDO_MAQ          = f.DS_BEM_VENDIDO,
                        DT_BEM_VENDIDO_MAQ          = f.DT_BEM_VENDIDO,
                        VL_GARANTIA_MAQ             = f.VL_GARANTIA,
                        VL_MOLICAR_MAQ              = f.VL_MOLICAR,
                        VL_FORCADA_MAQ              = f.VL_FORCADA,
                         CD_MOLICAR_MAQ             = f.CD_MOLICAR,
                        CD_CPF_CNPJ_MAQ             = f.CD_CPF_CNPJ,
                        SG_TP_PESSOA_MAQ            = f.SG_TP_PESSOA,
                        IC_GARANTIA_MAQ             = f.IC_GARANTIA,
                        QT_MAQUINAS_MAQ             = f.QT_MAQUINAS

                    }).AsEnumerable().Select(x => new DetalhesGerenciamentoViewModel
                     {

                         //DADOS PRINCIPAIS

                         CD_CPF_CNPJ                = x.CD_CPF_CNPJ,
                         NR_CARGA                   = x.NR_CARGA,
                         //NR_CARGA_B                 = x.NR_CARGA,
                         SG_TP_PESSOA               = x.SG_TP_PESSOA,
                         NM_PESSOA                  = x.NM_PESSOA,
                         NM_GRUPO_ECONOMICO         = x.NM_GRUPO_ECONOMICO,
                         NM_LOGRADOURO              = x.NM_LOGRADOURO,
                         NR_LOGRADOURO              = x.NR_LOGRADOURO,
                         NM_COMPLEMENTO             = x.NM_COMPLEMENTO,
                         NM_BAIRRO                  = x.NM_BAIRRO,
                         NM_CIDADE                  = x.NM_CIDADE,
                         SG_UF                      = x.SG_UF,
                         CD_CEP                     = x.CD_CEP,
                         NM_PAIS                    = x.NM_PAIS,
                         NR_DDD                     = x.NR_DDD,
                         NR_TELEFONE                = x.NR_TELEFONE,
                         NR_DDD_CELULAR             = x.NR_DDD_CELULAR,
                         NR_CELULAR                 = x.NR_CELULAR,
                         NM_EMAIL                   = x.NM_EMAIL,
                         DT_NASCIMENTO_OU_FUNDACAO  = x.DT_NASCIMENTO_OU_FUNDACAO,
                         NM_CONTATO                 = x.NM_CONTATO,
                         NR_RG                      = x.NR_RG,
                         NM_EMISSOR_RG              = x.NM_EMISSOR_RG,
                         DS_NATURALIDADE            = x.DS_NATURALIDADE,
                         DS_NACIONALIDADE           = x.DS_NACIONALIDADE,
                         NM_PAI                     = x.NM_PAI,
                         NM_MAE                     = x.NM_MAE,
                         NM_CONJUGE                 = x.NM_CONJUGE,
                         CD_ESTADO_CIVIL            = x.CD_ESTADO_CIVIL,
                         DS_ESTADO_CIVIL            = x.DS_ESTADO_CIVIL,
                         CD_REGIME_CIVIL            = x.CD_REGIME_CIVIL,
                         DT_CADASTRO                = x.DT_CADASTRO,
                         DT_ATUALIZACAO             = x.DT_ATUALIZACAO,

                         //DADOS DOS SOCIOS

                         CD_CPF_CNPJ_SOCIO          = x.CD_CPF_CNPJ_SOCIO,
                         NM_SOCIO                   = x.NM_PESSOA,
                         PF_PJ_PESSOA_SOCIO         = x.PF_PJ_PESSOA_SOCIO,
                         CD_SOLVERE_OPER_SOCIO      = x.CD_SOLVERE_OPER_SOCIO,
                         DS_PAPEL_SOCIO             = x.DS_PAPEL_SOCIO,
                         NR_DDD_SOCIO               = x.NR_DDD,
                         NR_TELEFONE_SOCIO          = x.NR_TELEFONE,
                         NR_DDD_CELULAR_SOCIO       = x.NR_DDD_CELULAR,
                         NR_CELULAR_SOCIO           = x.NR_CELULAR,
                         NM_EMAIL_SOCIO             = x.NM_EMAIL_SOCIO,
                         NM_CONTATO_SOCIO           = x.NM_CONTATO_SOCIO,
                         NM_GRUPO_ECONOMICO_SOCIO   = x.NM_GRUPO_ECONOMICO_SOCIO,
                         NM_CONJUGE_SOCIO           = x.NM_CONJUGE_SOCIO,
                         NM_LOGRADOURO_SOCIO        = x.NM_LOGRADOURO_SOCIO,
                         NR_LOGRADOURO_SOCIO        = x.NR_LOGRADOURO_SOCIO,
                         NM_COMPLEMENTO_SOCIO       = x.NM_COMPLEMENTO_SOCIO,
                         NM_BAIRRO_SOCIO            = x.NM_BAIRRO_SOCIO,
                         NM_CIDADE_SOCIO            = x.NM_CIDADE_SOCIO,
                         SG_UF_SOCIO                = x.SG_UF_SOCIO,
                         NM_PAIS_SOCIO              = x.NM_PAIS_SOCIO,

                         //DADOS DOS IMÓVEIS

                         //DT_PROCESSAMENTO           = x.DT_PROCESSAMENTO,
                         //CD_CHAVE_KOPE_IMOVEIS      = x.CD_CHAVE_KOPE_IMOVEIS,
                         CD_SOLVERE_GARA            = x.CD_SOLVERE_GARA_IMOV,
                         //NR_SEQ_GARA                = x.NR_SEQ_GARA,
                         DS_TP_GRAVAME              = x.DS_TP_GRAVAME_IMOV,
                         CD_GRAU_HIPOTECA           = x.CD_GRAU_HIPOTECA_IMOV,
                         NR_MATRICULA               = x.NR_MATRICULA_IMOV,
                         NR_CARTORIO_REGISTRO       = x.NR_CARTORIO_REGISTRO_IMOV,
                         NM_CARTORIO_REGISTRO       = x.NM_CARTORIO_REGISTRO_IMOV,
                         CD_CEP_IMOV                = x.CD_CEP_IMOV,
                         NM_LOGRADOURO_IMOV         = x.NM_LOGRADOURO_IMOV,
                         NR_LOGRADOURO_IMOV         = x.NR_LOGRADOURO_IMOV,
                         NM_COMPLEMENTO_IMOV        = x.NM_COMPLEMENTO_IMOV,
                         NM_BAIRRO_IMOV             = x.NM_BAIRRO_IMOV,
                         NM_CIDADE_IMOV             = x.NM_CIDADE_IMOV,
                         SG_UF_IMOV                 = x.SG_UF_IMOV,
                         CD_TIPO_IMOVEL             = x.CD_TIPO_IMOVEL,
                         VL_AREA                    = x.VL_AREA_IMOV,
                         NR_IPTU                    = x.NR_IPTU_IMOV,
                         VL_REGISTRO_MATRICULA      = x.VL_REGISTRO_MATRICULA_IMOV,
                         DS_OBSERVACOES_IMOV        = x.DS_OBSERVACOES_IMOV,
                         IC_PESQUISA_REALIZADA      = x.IC_PESQUISA_REALIZADA_IMOV,
                         DS_PESQUISA_DETALHES       = x.DS_PESQUISA_DETALHES_IMOV,
                         DT_PESQUISA                = x.DT_PESQUISA_IMOV,
                         IC_IMOVEL_FORMALIZADO      = x.IC_IMOVEL_FORMALIZADO_IMOV,
                         DS_IMOVEL_FORMALIZADO      = x.DS_IMOVEL_FORMALIZADO_IMOV,
                         DT_IMOVEL_FORMALIZADO      = x.DT_IMOVEL_FORMALIZADO_IMOV,
                         IC_IMOVEL_TOMADO           = x.IC_IMOVEL_TOMADO_IMOV,
                         DS_IMOVEL_TOMADO           = x.DS_IMOVEL_TOMADO_IMOV,
                         DT_IMOVEL_TOMADO           = x.DT_IMOVEL_TOMADO_IMOV,
                         IC_IMOVEL_VENDIDO_BAIXADO  = x.IC_IMOVEL_VENDIDO_BAIXADO_IMOV,
                         DS_IMOVEL_VENDIDO_BAIXADO  = x.DS_IMOVEL_VENDIDO_BAIXADO_IMOV,
                         DT_IMOVEL_VENDIDO_BAIXADO  = x.DT_IMOVEL_VENDIDO_BAIXADO_IMOV,
                         DT_AVALIACAO               = x.DT_AVALIACAO_IMOV,
                         VL_GARANTIA                = x.VL_GARANTIA_IMOV,
                         VL_VENDA_FORCADA           = x.VL_VENDA_FORCADA_IMOV,
                         VL_VENDA_MERCADO           = x.VL_VENDA_MERCADO_IMOV,
                         CD_CPF_CNPJ_IMOV           = x.CD_CPF_CNPJ_IMOV,
                         SG_TP_PESSOA_IMOV          = x.SG_TP_PESSOA_IMOV,

                        //DADOS DOS VEÍCULOS E MÁQUINAS

                        DT_PROCESSAMENTO_MAQ        = x.DT_PROCESSAMENTO_MAQ,
                        CD_CHAVE_KOPE_VEICULOS      = x.CD_CHAVE_KOPE_VEICULOS_MAQ,
                        CD_CHAVE_KOPE_MAQUINA       = x.CD_CHAVE_KOPE_MAQUINA_MAQ,
                        CD_SOLVERE_GARA_MAQ         = x.CD_SOLVERE_GARA_MAQ,
                        CD_SOLVERE_OPER_MAQ         = x.CD_SOLVERE_OPER_MAQ,
                        NR_SEQ_GARA_MAQ             = x.NR_SEQ_GARA_MAQ,
                        NR_CHASSI                   = x.NR_CHASSI_MAQ,
                        CD_TIPO_CHASSI              = x.CD_TIPO_CHASSI_MAQ,
                        SG_UF_LICENCIAMENTO         = x.SG_UF_LICENCIAMENTO_MAQ,
                        SG_UF_PLACA                 = x.SG_UF_PLACA_MAQ,
                        NR_PLACA                    = x.NR_PLACA_MAQ,
                        NR_RENAVAM                  = x.NR_RENAVAM_MAQ,
                        NR_ANO_FABRICACAO           = x.NR_ANO_FABRICACAO_MAQ,
                        NR_ANO_MODELO               = x.NR_ANO_MODELO_MAQ,
                        CD_TP_GRAVAME               = x.CD_TP_GRAVAME_MAQ,
                        DT_GRAVAME                  = x.DT_BAIXA_GRAVAME_MAQ,
                        DT_BAIXA_GRAVAME            = x.DT_BAIXA_GRAVAME_MAQ,
                        DS_MODELO                   = x.DS_MODELO_MAQ,
                        DS_MARCA                    = x.DS_MARCA_MAQ,
                        DS_COR                      = x.DS_COR_MAQ,
                        DS_COMBUSTIVEL              = x.DS_COMBUSTIVEL_MAQ,
                        DS_VEICULO_MAQUINA          = x.DS_VEICULO_MAQUINA_MAQ,
                        NR_SERIE                    = x.NR_SERIE_MAQ,
                        DS_FABRICANTE               = x.DS_FABRICANTE_MAQ,
                        DS_TIPO_BEM                 = x.DS_TIPO_BEM_MAQ,
                        DS_OBSERVACOES_GERAIS_MAQ   = x.DS_OBSERVACOES_GERAIS_MAQ,
                        IC_PESQUISA_REALIZADA_MAQ   = x.IC_PESQUISA_REALIZADA_MAQ,
                        DS_PESQUISA_DETALHES_MAQ    = x.DS_PESQUISA_DETALHES_MAQ,
                        DT_PESQUISA_MAQ             = x.DT_PESQUISA_MAQ,
                        IC_BEM_FORMALIZADO          = x.IC_BEM_FORMALIZADO_MAQ,
                        DS_BEM_FORMALIZADO          = x.DS_BEM_FORMALIZADO_MAQ,
                        DT_BEM_FORMALIZADO          = x.DT_BEM_FORMALIZADO_MAQ,
                        IC_BEM_TOMADO               = x.IC_BEM_TOMADO_MAQ,
                        DS_BEM_TOMADO               = x.DS_BEM_TOMADO_MAQ,
                        DT_BEM_TOMADO               = x.DT_BEM_TOMADO_MAQ,
                        IC_BEM_VENDIDO              = x.IC_BEM_VENDIDO_MAQ,
                        DS_BEM_VENDIDO              = x.DS_BEM_VENDIDO_MAQ,
                        DT_BEM_VENDIDO              = x.DT_BEM_VENDIDO_MAQ,
                        VL_GARANTIA_MAQ             = x.VL_GARANTIA_MAQ,
                        VL_MOLICAR                  = x.VL_MOLICAR_MAQ,
                        VL_FORCADA                  = x.VL_FORCADA_MAQ,
                        CD_MOLICAR                  = x.CD_MOLICAR_MAQ,
                        CD_CPF_CNPJ_MAQ             = x.CD_CPF_CNPJ_MAQ,
                        SG_TP_PESSOA_MAQ            = x.SG_TP_PESSOA_MAQ,
                        IC_GARANTIA                 = x.IC_GARANTIA_MAQ,
                        QT_MAQUINAS                 = x.QT_MAQUINAS_MAQ


                    }).ToList();


            if (model.Count() == 0 || model == null)
            {
                return View();
            }
            return View(model);
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
