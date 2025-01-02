using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;
using System.Numerics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Humanizer;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Net.Sockets;
using System.Security.Policy;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {

        public IActionResult CalculateQuote(Insuree insuree)
        {


           /* insuree.Quote = 50.0m; *///Start with a base of $50 / month.

            //DateOnly today = DateOnly.FromDateTime(DateTime.Today);
            if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 18) //If the user is 18 or under, add $100 to the monthly total.
            {
                insuree.Quote += 100m;
            }
            if (DateTime.Now.Year - insuree.DateOfBirth.Year >= 19 && DateTime.Now.Year - insuree.DateOfBirth.Year <= 25) //If the user is from 19 to 25, add $50 to the monthly total.

            {
                insuree.Quote += 50m;
            }
            if (DateTime.Now.Year - insuree.DateOfBirth.Year >= 26) //If the user is 26 or older, add $25 to the monthly total
            {
                insuree.Quote += 25m;
            }
            if (Convert.ToInt32(insuree.CarYear) < 2000) //If the car's year is before 2000, add $25 to the monthly total.
            {
                insuree.Quote += 25m;
            }
            if (Convert.ToInt32(insuree.CarYear) > 2015) //If the car's year is after 2015, add $25 to the monthly total.
            {
                insuree.Quote += 25m;
            }
            if (insuree.CarMake == "Porche" && insuree.CarModel == "911 Carrera") //If the car's Make is a Porsche, add $25 to the price.
            {
                insuree.Quote += 25m;
            }
           
            //Add $10 to the monthly total for every speeding ticket the user has.
            for (int i = 0; i < insuree.SpeedingTickets; i++)
            {
                insuree.Quote += 25m;
            }
            if (insuree.DUI == true) //If the user has ever had a DUI, add 25% to the total.
            {
                insuree.Quote *= 1.25m;
            }
            if (insuree.CoverageType == "full coverage")
            {
                insuree.Quote *= 1.5m;
            }

            return Content(insuree.Quote.ToString());

        }
        private readonly InsuranceContext _context;

        public InsureesController(InsuranceContext context)
        {
            _context = context;

        }

        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insuree.ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Id = Guid.NewGuid();
                CalculateQuote(insuree);
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
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
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree != null)
            {
                _context.Insuree.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(Guid id)
        {
            return _context.Insuree.Any(e => e.Id == id);
        }


    }



}
