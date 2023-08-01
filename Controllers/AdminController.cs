using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicManagement_hk3.Models;
using AccountCoreMVCApp.Repositories;

namespace ClinicManagement.Controllers
{
    public class AdminController : Controller
    {
        private readonly Projecthk3Context _context;
        private IAccountServices services;

        public AdminController(Projecthk3Context context, IAccountServices services)
        {
            _context = context;
            this.services = services;
        }

        // GET: Admin/Account
        public async Task<IActionResult> Index()
        {
            var projecthk3Context = _context.Accounts.ToListAsync();
            return View(await projecthk3Context);
        }

        public async Task<IActionResult> Login()
        {
            return View("Login");
        }


        [HttpPost]
        [ActionName("Login")]
        public IActionResult checkLogin(string accNo, string pinCode)
        {
            try
            {
                Account account = services.checkLogin(accNo, pinCode);
                if (account != null)
                {
                    HttpContext.Session.SetString("Email", accNo);
                    if (account.RoleId == 1)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View("Details", account);
                    }
                }
                else
                {
                    ViewBag.message = "Invalid account!!!";
                }
            }
            catch (Exception e)
            {

                ViewBag.message = e.Message;
            }
            return View();
        }

        // GET: DrugCategories
        public async Task<IActionResult> DrugCategoriesIndex()
        {
            var projecthk3Context = _context.DrugCategories.ToListAsync();
            return View(await projecthk3Context);
        }

        // GET: MachineCategories
        public async Task<IActionResult> MachineCategoriesIndex()
        {
            var projecthk3Context = _context.MachineCategories.ToListAsync();
            return View(await projecthk3Context);
        }

        // GET: Education
        public async Task<IActionResult> EducationIndex()
        {
            var projecthk3Context = _context.Educations.ToListAsync();
            return View(await projecthk3Context);
        }

        // GET: Admin/Education/Details
        public async Task<IActionResult> EducationDetails(int? id)
        {
            if (id == null || _context.Educations == null)
            {
                return NotFound();
            }

            var account = await _context.Educations
                .Include(a => a.EduDetails)
                .FirstOrDefaultAsync(m => m.EduId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Admin/Education/Delete
        public async Task<IActionResult> EducationDelete(int? id)
        {
            if (id == null || _context.Educations == null)
            {
                return NotFound();
            }

            var account = await _context.Educations
                .Include(a => a.EduDetails)
                .FirstOrDefaultAsync(m => m.EduId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Storages
        public async Task<IActionResult> StoragesIndex()
        {
            var projecthk3Context = _context.Storages.ToListAsync();
            return View(await projecthk3Context);
        }

        // GET: Order
        public async Task<IActionResult> OrderIndex()
        {
            var projecthk3Context = _context.Orders.ToListAsync();
            return View(await projecthk3Context);
        }

        // GET: Buniness
        public async Task<IActionResult> Buniness()
        {

            return View();
        }
        // GET: Admin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId");
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,FullName,UserName,Email,PassWord,Phone,State,RoleId")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", account.RoleId);
            return View(account);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", account.RoleId);
            return View(account);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,FullName,UserName,Email,PassWord,Phone,State,RoleId")] Account account)
        {
            if (id != account.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", account.RoleId);
            return View(account);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Accounts == null)
            {
                return Problem("Entity set 'Projecthk3Context'  is null.");
            }
            var account = await _context.Accounts.FindAsync(id);
            if (account != null)
            {
                _context.Accounts.Remove(account);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
          return (_context.Accounts?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
