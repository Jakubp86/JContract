using JContract.Application.Contract;
using JContract.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using JContract.Domain;

namespace JContract.Mvc.Controllers
{
    public class ContractController : Controller
    {
        private readonly IContractServices _contractService;
        public ContractController(IContractServices contractService)
        {
            _contractService = contractService;
            
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var contracts = await _contractService.GetAll();
            return View(contracts);
        }
    

        public ActionResult Create()
        {
            return View();
        }
        //public async Task<ActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var contract = await _contractService.Details()

        //       .FirstOrDefaultAsync(c => c.id == id);
        //    if (contract == null)
        //    {
        //        return NotFound();
        //    }
        //    return View();

        //}
        public ActionResult Edit(int id)
        {
            
            return View();
           
        }
        [HttpPost]
        //public ActionResult Delete(int id)
        //{
          
        //}

        [HttpPost]
        public async Task<IActionResult> Create(ContractDto contract)
        {
            if (!ModelState.IsValid)
            {
                return View(contract);
            }
            await _contractService.Create(contract);
            return RedirectToAction(nameof(Index)); 
        }
    }
}
