using Microsoft.AspNetCore.Mvc;
using Virtuous.Data;
using Virtuous.Web.Models;

namespace Virtuous.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDonationRepository _donationRepository;

        public HomeController(IDonationRepository donationRepository)
        {
            _donationRepository = donationRepository;
        }

        // GET: Donations
        public async Task<IActionResult> Index()
        {
            return View(await _donationRepository.GetDonations());
            //return View("Donate");
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        // GET: Donations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donation = await _donationRepository.GetDonationById(id.Value);
            if (donation == null)
            {
                return NotFound();
            }

            return View(donation);
        }

        // GET: Donations/Create
        public IActionResult Donate()
        {
            return View();
        }

        // POST: Donations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Donate(Donation donation)
        {
            if (ModelState.IsValid)
            {
                await _donationRepository.AddDonation(donation);
                return View("ThankYou");
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
