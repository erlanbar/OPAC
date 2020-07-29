using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OPAC.Data;
using OPAC.Models;

namespace OPAC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BookContext _context;

        public CategoryController(BookContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.LoadingData = true;

            try
            {
                var data = await (
                    from datas in _context.Categories
                    where datas.Status == true
                    select datas
                ).ToListAsync();

                ViewBag.Data = data;
                ViewBag.Mode = "View";

                return PartialView();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public IActionResult Create()
        {
            ViewBag.LoadingData = true;

            try
            {
                ViewBag.Mode = "Create";

                return PartialView("Index");
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        // POST: Book/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(category);
                    await _context.SaveChangesAsync();

                    ViewBag.ResultCode = 1;
                    ViewBag.ResultMessage = "Data berhasil disimpan";
                    ViewBag.Mode = "Edit";

                    return PartialView(category);
                }
                return PartialView(category);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.LoadingData = true;

            try
            {
                var data = await (
                    from datas in _context.Categories
                    where datas.ID == id
                    select datas
                ).FirstAsync();

                ViewBag.Data = data;
                ViewBag.Mode = "Edit";

                return PartialView("Index");
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        // POST: Book/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            if (id != category.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (!IsExist(category.Description))
                    {
                        _context.Update(category);
                        await _context.SaveChangesAsync();

                        ViewBag.ResultCode = 1;
                        ViewBag.ResultMessage = "Data berhasil disimpan";
                    }
                    else
                    {
                        ViewBag.ResultCode = 0;
                        ViewBag.ResultMessage = "Data sudah ada. Mohon input data lain";
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return PartialView(category);
            }

            return PartialView(category);
        }

        // POST: Book/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var data = await _context.Categories.FindAsync(id);
                _context.Categories.Remove(data);
                await _context.SaveChangesAsync();

                ViewBag.ResultCode = 1;
                ViewBag.ResultMessage = "Data berhasil dihapus";

                return PartialView(data);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        private bool IsExist(string description)
        {
            return _context.Categories.Any(e => e.Description == description);
        }
    }
}
