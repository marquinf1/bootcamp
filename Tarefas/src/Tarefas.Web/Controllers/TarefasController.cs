
using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers;

public class TarefasController : Controller 
{
    public IActionResult Create () {
        return View();
    }

    public IActionResult Index () 
    {
        var listaDeTarefas = new List<TarefaViewModel>()
        {
            new TarefaViewModel() { Titulo = "Escovar os dentes", Descricao = "Usar Sensodine de manhã e não de noite"},
            new TarefaViewModel() { Titulo = "Arrumar a cama", Descricao = "Usar inteligencia"},
            new TarefaViewModel() { Titulo = "Colocar lixo pra fora", Descricao = "Usar Luvas"},
        };
        return View(listaDeTarefas);
    }
}