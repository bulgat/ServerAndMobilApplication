using MobAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobAPI.Controllers
{
    

    public class HomeController : Controller
    {
        DatabaseReglamentCon context = new DatabaseReglamentCon();

        public ActionResult Index()
        {

            ViewBag.DateTime = ServerReglament.CountServerReglament();
            ViewBag.Status = ServerReglament.Status;

            return View();
        }

        /// <summary>
        /// API. Мобильное устройство обращается по этому адресу и получает Json. 
        /// </summary>
        /// <returns></returns>
        public JsonResult GetInfo()
        {
            var statusServer = new StatusServer() {  DateTime = ServerReglament.CountServerReglament(), Status = ServerReglament.Status };

            return Json(statusServer, JsonRequestBehavior.AllowGet);
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var ListReg = (from a in context.ReglamentTable select a).ToList();
        
            return View(ListReg);
        }

        public ActionResult Details(int id)
        {
            var cardReglament = (from a in context.ReglamentTable where a.Id == id select a).First();
            return View(cardReglament);
        }

        /// <summary>
        /// Создать новые регламентные работы.
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            ReglamentTable cardReglament = new ReglamentTable();
            return View(cardReglament);
        }
        /// <summary>
        /// Сохранить новые регламентные работы.
        /// </summary>
        /// <param name="cardReglament"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(ReglamentTable cardReglament)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.ReglamentTable.Add(cardReglament);
                    context.SaveChanges();
                }

            }
            catch (Exception ex){
                ModelState.AddModelError("Error", ex);
            }
            return RedirectToAction("About");
            //return View(cardReglament);
        }


        /// <summary>
        /// Первый заход. Edit.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {

            var cardReglament = (from a in context.ReglamentTable where a.Id == id select a).First();
            return View(cardReglament);
        }

        /// <summary>
        /// Сохранение Tdit.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {

            var cardReglament = (from a in context.ReglamentTable where a.Id == id select a).First();
            try {
                UpdateModel(cardReglament);
                context.SaveChanges();
                return RedirectToAction("About");

            } catch {
                return View(cardReglament);
            }

        }
        /// <summary>
        /// Удалить регламентные работы.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {

            var cardReglament = (from a in context.ReglamentTable where a.Id == id select a).First();
            return View(cardReglament);
        }
        /// <summary>
        /// Команда удалить регламентные работы.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            var cardReglament = (from a in context.ReglamentTable where a.Id == id select a).First();
            try
            {
                context.ReglamentTable.Remove(cardReglament);
                context.SaveChanges();
                return RedirectToAction("About");

            }
            catch
            {
                return View(cardReglament);
            }

        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}