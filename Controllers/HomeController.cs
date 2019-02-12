using System;
using System.Web.Mvc;
using System.Net;
using System.Threading.Tasks;
using SabinoFarma.Models;
using Newtonsoft.Json.Linq;
using System.Net.Mail;
namespace SabinoFarma.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Página Inicial";
            return View();
        }

        public ActionResult Empresa()
        {
            ViewBag.Title = "Empresa";

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Title = "Contato";

            return View(new Email());
      
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<PartialViewResult> Submit(Email model)
        {
            bool isMessageSent = true;

            if (ModelState.IsValid)
            {

                var response = Request["g-recaptcha-response"];
                string secretKey = "6LdZ-A8UAAAAALbNCuqGabhROFlroR61TFIQ2aNg";
                var client = new WebClient();
                var result = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, response));
                var obj = JObject.Parse(result);
                var status = (bool)obj.SelectToken("success");
                ViewBag.Message = status ? "Google reCaptcha validation success" : "Google reCaptcha validation failed";

           

                try
                {
                    await DadosEmail.Envio(model);
                }
                catch (Exception ex)
                {
                    isMessageSent = false;

                }
            }
            else
            {
                isMessageSent = false;
            }
            return PartialView("_SubmitMessage", isMessageSent);
        }


        public ActionResult Beneficio()
        {
            ViewBag.Title = "Benéficios";

            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Convenio()
        {
            ViewBag.Title = "Convênios";

            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FarmaciaPopular()
        {
            ViewBag.Title = "Farmacia Popular";

            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PBM()
        {
            ViewBag.Title = "PBM";

            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Generico()
        {
            ViewBag.Title = "Genéricos";

            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Duvidas()
        {
            ViewBag.Title = "Dúvidas";

            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Enviar_Receita()
        {
            ViewBag.Title = "Mande Sua Receita";

            return View(new Email());
        }
    }
}