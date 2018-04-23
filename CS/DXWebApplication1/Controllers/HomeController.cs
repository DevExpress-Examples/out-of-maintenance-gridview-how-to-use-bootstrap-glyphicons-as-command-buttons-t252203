using System;
using System.Web.Mvc;
using DXWebApplication1.Models;

namespace DXWebApplication1.Controllers {
    public class HomeController : Controller {
        PersonsList list = new PersonsList();

        public ActionResult Index() {
            return View();
        }

        public ActionResult GridViewPartial() {
            return PartialView(list.GetPersons());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult EditingAddNew(Person person) {
            if(ModelState.IsValid)
                list.AddPerson(person);
            return PartialView("GridViewPartial", list.GetPersons());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult EditingUpdate(Person personInfo) {
            if(ModelState.IsValid)
                list.UpdatePerson(personInfo);
            return PartialView("GridViewPartial", list.GetPersons());
        }

        public ActionResult EditingDelete(int personId) {
            list.DeletePerson(personId);
            return PartialView("GridViewPartial", list.GetPersons());
        }
    }
}