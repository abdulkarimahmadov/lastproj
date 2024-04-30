﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using riode_backend.Areas.ViewModel;
using riode_backend.Contexts;
using riode_backend.Models;
using System;

namespace riode_backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly RiodeDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BrandController(RiodeDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var brand = _context.Brands.ToList();

            return View(brand);
        }


        public async Task<IActionResult> Create()
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BrandViewModel brand)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Brand newbrand = new()
            {
                BrandName = brand.BrandName

            };
            await _context.Brands.AddAsync(newbrand);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Detail(int id)
        {

            var brand = await _context.Brands.FirstOrDefaultAsync(c => c.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            return View(brand);
        }


        public async Task<IActionResult> Delete(int id)
        {

            var brand = await _context.Brands.FirstOrDefaultAsync(c => c.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            return View(brand);
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteProduct(int id)
        {

            var brand = await _context.Brands.FirstOrDefaultAsync(c => c.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            _context.Remove(brand);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Update(int id)
        {
            var brand = await _context.Brands.FirstOrDefaultAsync(c => c.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            return View(brand);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id, BrandViewModel brand)
        {
            if (brand == null)
            {
                return NotFound();
            }
            var updatecategory = await _context.Brands.FirstOrDefaultAsync(c => c.Id == id);
            if (!ModelState.IsValid)
            {
                return View();
            }

            updatecategory.BrandName = brand.BrandName;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
