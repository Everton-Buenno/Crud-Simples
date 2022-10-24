using Crud_Simples.Models;
using Crud_Simples.Repositories.Abstracao;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Simples.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUserService service;

        public UsuarioController(IUserService service)
        {
            this.service = service;
        }


        public IActionResult ListUser()
        {
            var data = service.ListUser();
            return View(data);
        }


        public IActionResult Add()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Add(Usuario model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var response = service.Add(model);
            if(response)
            {
                TempData["msg"] = "Usuario Adicionado com sucesso";
                return RedirectToAction(nameof(ListUser));
            }
            TempData["msg"] = "Erro ao cadastrar usuario!";
            return View();
        }


        public IActionResult Update(int Id)
        {
            var record = service.ListById(Id);
            return View(record);
        }
        [HttpPost]
        public IActionResult Update(Usuario model)
        { 
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var response = service.Update(model);
                if(response)
            {
                TempData["msg"] = "Edição feita com sucesso";
                return RedirectToAction(nameof(ListUser));
            }

            TempData["msg"] = "Houve algum erro na edição, tente novamente";
            return View();

        }



        public IActionResult Delete(int id)
        {
            var response = service.Delete(id);
            return RedirectToAction("ListUser");
        }
    }
}
