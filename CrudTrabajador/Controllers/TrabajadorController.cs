using CrudTrabajador.Data;
using CrudTrabajador.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTrabajador.Controllers
{
    public class TrabajadorController : Controller
    {
        private readonly ApplicationDbContext appdbcontext;

        public TrabajadorController(ApplicationDbContext appcontext)
        {
            appdbcontext = appcontext;
        }
        public IActionResult Index()
        {
            var listTrabajador = appdbcontext.spListarTrabajador.FromSqlRaw("spListarTrabajador").ToList();
            return View(listTrabajador);
        }

        public IActionResult Create()
        {
            var ListSex = new List<Select>();
            ListSex.Add( new Select
            {
                value = "S",
                descripcion = "Seleccione"
            });
            ListSex.Add(new Select
            {
                value = "M",
                descripcion = "Masculino"
            });
            ListSex.Add(new Select
            {
                value = "F",
                descripcion = "Femenino"
            });
            ViewData["ListSexos"] = new SelectList(ListSex, "value", "descripcion");

            var listDepar = new List<Departamentos>();
            listDepar.Add(new Departamentos { 
                Id = 0,
                NombreDepartamento = "Seleccione"
            }); 
            listDepar.AddRange(appdbcontext.Departamentos.ToList()); 
            ViewData["ListaDepar"] = new SelectList(listDepar, "Id", "NombreDepartamento");
            return PartialView();
            
        }
        public IActionResult Delete( int id)
        {
            var Traba = appdbcontext.Trabajador.Find(id); 
            return PartialView(Traba);

        }
        public IActionResult Edit(int IdTraba)
        {
            var ListSex = new List<Select>();
            ListSex.Add(new Select
            {
                value = "S",
                descripcion = "Seleccione"
            });
            ListSex.Add(new Select
            {
                value = "M",
                descripcion = "Masculino"
            });
            ListSex.Add(new Select
            {
                value = "F",
                descripcion = "Femenino"
            });
            ViewData["ListSexos"] = new SelectList(ListSex, "value", "descripcion");
            var traba = appdbcontext.Trabajador.Find(IdTraba);
            var listDepar = new List<Departamentos>();
            listDepar.Add(new Departamentos
            {
                Id = 0,
                NombreDepartamento = "Seleccione"
            });

            listDepar.AddRange(appdbcontext.Departamentos.ToList()); 
            ViewData["ListaDepar"] = new SelectList(listDepar, "Id", "NombreDepartamento");

            var ListProv = new List<Provincias>();
            ListProv.Add(new Provincias
            {
                Id = 0,
                NombreProvincia  = "Seleccione"
            });
            
            ListProv.AddRange(appdbcontext.Provincias.Where(provi => provi.IdDepartamento == traba.IdDepartamento).ToList()); 
            ViewData["ListarProvi"] = new SelectList(ListProv, "Id", "NombreProvincia");  

            var ListDistr = new List<Distritos>();
            ListDistr.Add(new Distritos
            {
                Id = 0,
                NombreDistrito = "Seleccione"
            });
             
            ListDistr.AddRange(appdbcontext.Distrito.Where(distrit => distrit.IdProvincia == traba.IdProvincia).ToList());
            
            ViewData["ListarDistr"] = new SelectList(ListDistr, "Id", "NombreDistrito");   

            return PartialView(traba);

        }
        public JsonResult ListProvincias (int IdDepar)
        {
            var Listprov = appdbcontext.Provincias.Where(prov => prov.IdDepartamento == IdDepar).ToList();
            return Json(Listprov);
        }
        public JsonResult ListDistritos(int idProvi)
        {
            var ListDistr = appdbcontext.Distrito.Where(prov => prov.IdProvincia == idProvi).ToList();
            return Json(ListDistr);
        }
        [HttpPost] 
        public async Task<IActionResult> Create(Trabajador ModelTraba)
        { 
                appdbcontext.Add(ModelTraba);
                await appdbcontext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));  
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Trabajador ModelTraba)
        {
            appdbcontext.Update(ModelTraba);
            await appdbcontext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteTraba(int idtrabajador)
        {
            var trava =  appdbcontext.Trabajador.Find(idtrabajador);
            appdbcontext.Trabajador.Remove(trava);
            await appdbcontext.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); 
        } 
    }
}
