using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimeraPruebaMVC.Models;

namespace PrimeraPruebaMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult DegreeList()
    {
        DegreeModel carreras = new DegreeModel();
        carreras.Nombre = "Sistemas";
        carreras.Maestro = "Tere Escobar";
        return View(carreras);
    }

    public IActionResult StudentList()
    {
        StudentModel estudiante = new StudentModel();
        estudiante.Nombre = "Pedrito";
        estudiante.Carrera = "Ing. Software";
        return View(estudiante);
    }


     public IActionResult TeacherList()
    {
        TeacherModel maestro = new TeacherModel();
        maestro.Nombre = "Edgar Martinez";
        maestro.Carrera = "Ing. Software";
        maestro.Matricula = 44444;
        maestro.Edad = 40;
        maestro.Sexo = "Masculino";
        return View(maestro);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
