﻿using ContosoUniversityTARpe21.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ContosoUniversityTARpe21.Controllers
{
    public class Studentcontroller : Controller
    {
        private readonly SchoolContext _context;

        public Studentcontroller(SchoolContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }
    }
}