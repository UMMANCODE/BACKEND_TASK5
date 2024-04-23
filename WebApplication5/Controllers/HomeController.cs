using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Data;
using WebApplication5.Models;
using WebApplication5.ViewModels;

namespace MvcPustok.Controllers;

public class HomeController : Controller {

    AppDbContext _context;

    public HomeController(AppDbContext context) {
        _context = context;
    }
    public IActionResult Index() {
        HomeViewModel hvm = new HomeViewModel() {
            Books = _context.Books.ToList(),
            Authors = _context.Authors.ToList(),
            Sliders = _context.Sliders.OrderBy(x => x.Order).ToList(),
            Genres = _context.Genres.ToList()
        };
        return View(hvm);
    }
}