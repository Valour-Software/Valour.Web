﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Valour.Web.Models;

namespace Valour.Web.Controllers;

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
    
    [HttpGet("/userCount")]
    public IActionResult UserCount()
    {
        return View();
    }
    
    [HttpGet("/faq")]
    public IActionResult Faq()
    {
        return View();
    }
    
    [HttpGet("/web3")]
    public IActionResult Web3()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}