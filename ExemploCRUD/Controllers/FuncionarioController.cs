using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExemploCRUD.Models;

namespace ExemploCRUD.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Funcionario f)
        {
            if (ModelState.IsValid)
            {
                Repositorio.Instance().IncluirFuncionario(f);

                return RedirectToAction("Listar");
            }

            return View(f);
        }

        public ActionResult Listar()
        {
            var funcionarios = Repositorio.Instance().ListarFuncionarios();

            return View(funcionarios);
        }

        public ActionResult Excluir(int id)
        {
            Repositorio.Instance().ExcluirFuncionario(id);

            return RedirectToAction("Listar");
        }

        public ActionResult Editar(int id)
        {
            var funcionario = Repositorio.Instance().ListarFuncionario(id);

            return View("Cadastrar", funcionario);
        }

        [HttpPost]
        public ActionResult Editar(Funcionario f)
        {
            if (ModelState.IsValid)
            {
                Repositorio.Instance().AlterarFuncionario(f);

                return RedirectToAction("Listar");
            }

            return View("Cadastrar", f);
        }
    }
}