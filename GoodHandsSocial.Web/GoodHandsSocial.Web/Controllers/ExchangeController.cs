using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GoodHands.Domain.Model.Models;
using GoodHands.Infra.Data.Data;
using Microsoft.AspNetCore.Authorization;

namespace GoodHandsSocial.Web.Controllers
{
    [Authorize]
    public class ExchangeController : Controller
    {
        private readonly GoodHandsSocialWebContext _context;

        public ExchangeController(GoodHandsSocialWebContext context)
        {
            _context = context;
        }

        // GET: Exchange
        public async Task<IActionResult> Index()
        {
            return View(await _context.Exchanges.ToListAsync());
        }

        // GET: Exchange/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exchange = await _context.Exchanges
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exchange == null)
            {
                return NotFound();
            }

            return View(exchange);
        }

        // GET: Exchange/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Exchange/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DonationName,Description,HaveCourier,Quantity,MaximumDate")] Exchange exchange)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exchange);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exchange);
        }

        // GET: Exchange/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exchange = await _context.Exchanges.FindAsync(id);
            if (exchange == null)
            {
                return NotFound();
            }
            return View(exchange);
        }

        // POST: Exchange/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DonationName,Description,HaveCourier,Quantity,MaximumDate")] Exchange exchange)
        {
            if (id != exchange.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exchange);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExchangeExists(exchange.Id))
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
            return View(exchange);
        }

        // GET: Exchange/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exchange = await _context.Exchanges
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exchange == null)
            {
                return NotFound();
            }

            return View(exchange);
        }

        // POST: Exchange/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exchange = await _context.Exchanges.FindAsync(id);
            _context.Exchanges.Remove(exchange);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExchangeExists(int id)
        {
            return _context.Exchanges.Any(e => e.Id == id);
        }
    }
}
