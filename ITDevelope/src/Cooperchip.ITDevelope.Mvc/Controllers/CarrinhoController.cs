using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cooperchip.ITDevelope.Mvc.ViewModels;
using Cooperchip.ITDeveloper.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cooperchip.ITDevelope.Mvc.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Produto>();
            for(int i = 1; i<11; i++)
            {
                var n = i < 10 ? "0" + i : i + "";
                produtos.Add(new Produto
                {
                    Nome = "Prod-" + n,
                    Estoque = 3,
                    Validade = DateTime.Now,
                    Valor = 1.13m + i

                });
            }


            var model = new CarrinhoViewModel
            {
                Produtos = produtos,
                //TotalCarrinho = produtos.Sum(p => p.Valor),
                TotalCarrinho =13.27M,
                Mensagem = "Ah!"
            };
            // return View(model);
           return RedirectToAction("Checkout", model);
        }
        public IActionResult Checkout(CarrinhoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                if(ModelState.ErrorCount > 0)
                {
                    ViewData["semerro"] = "OPS!";
                    ModelState.AddModelError(errorMessage:"O MODELO ESTÁ INVALIDO", key:"erro");
                }
                else
                {
                    ViewData["semerro"] = "modelo Ok";
                }
            }

            return View(model);
        }
    }
}