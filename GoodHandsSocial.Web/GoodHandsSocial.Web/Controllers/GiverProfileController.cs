using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GoodHands.Domain.Model.Models;
using GoodHands.Infra.Data.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace GoodHandsSocial.Web.Controllers
{
    [Authorize]
    public class GiverProfileController : Controller
    {
        private readonly GoodHandsSocialWebContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public GiverProfileController(GoodHandsSocialWebContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: GiverProfile
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);

            var profile = await _context.Profiles.Where(x => x.UserId == userId).ToListAsync();
            return View(profile);
        }

        // GET: GiverProfile/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giverProfile = await _context.Profiles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (giverProfile == null)
            {
                return NotFound();
            }

            return View(giverProfile);
        }

        // GET: GiverProfile/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GiverProfile/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GiverProfile giverProfile, IFormCollection form,
                                            [FromServices] IHttpClientFactory clientFactory)
        {
            if (ModelState.IsValid)
            {
                using var content = new MultipartFormDataContent();

                foreach (var file in form.Files)
                {
                    content.Add(CreateFileContent(file.OpenReadStream(), file.FileName, file.ContentType));
                }

                var httpClient = clientFactory.CreateClient();
                var response = await httpClient.PostAsync("api/image", content);

                response.EnsureSuccessStatusCode();
                var responseResult = await response.Content.ReadAsStringAsync();

                var uriImage = JsonConvert.DeserializeObject<string[]>(responseResult).FirstOrDefault();

                var userId = _userManager.GetUserId(User);
                giverProfile.UserId = userId;
                giverProfile.ImageUri = uriImage;

                _context.Add(giverProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(giverProfile);
        }

        private StreamContent CreateFileContent(Stream stream, string fileName, string contentType)
        {
            var fileContent = new StreamContent(stream);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"files\"",
                FileName = "\"" + fileName + "\""
            };

            fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
            return fileContent;
        }

        // GET: GiverProfile/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giverProfile = await _context.Profiles.FindAsync(id);
            if (giverProfile == null)
            {
                return NotFound();
            }
            return View(giverProfile);
        }

        // POST: GiverProfile/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(GiverProfile giverProfile, IFormCollection form,
            [FromServices] IHttpClientFactory clientFactory, int id)
        {
            if (id != giverProfile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    using var content = new MultipartFormDataContent();

                    foreach (var file in form.Files)
                    {
                        content.Add(CreateFileContent(file.OpenReadStream(), file.FileName, file.ContentType));
                    }

                    var httpClient = clientFactory.CreateClient();
                    var response = await httpClient.PostAsync("api/image", content);

                    response.EnsureSuccessStatusCode();
                    var responseResult = await response.Content.ReadAsStringAsync();

                    var uriImage = JsonConvert.DeserializeObject<string[]>(responseResult).FirstOrDefault();

                    var userId = _userManager.GetUserId(User);
                    giverProfile.UserId = userId;
                    giverProfile.ImageUri = uriImage;
                    _context.Update(giverProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GiverProfileExists(giverProfile.Id))
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
            return View(giverProfile);
        }

        // GET: GiverProfile/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giverProfile = await _context.Profiles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (giverProfile == null)
            {
                return NotFound();
            }

            return View(giverProfile);
        }

        // POST: GiverProfile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var giverProfile = await _context.Profiles.FindAsync(id);
            _context.Profiles.Remove(giverProfile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GiverProfileExists(int id)
        {
            return _context.Profiles.Any(e => e.Id == id);
        }
    }
}
