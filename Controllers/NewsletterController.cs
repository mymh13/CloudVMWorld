using CloudVMWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudVMWorld.Controllers
{
    public class NewsletterController : Controller
    {
        // GET: Newsletter/Subscribe
        public IActionResult Subscribe()
        {
            return View();
        }

        // POST: Newsletter/Subscribe
        [HttpPost]
        public IActionResult Subscribe(Subscriber subscriber)
        {
            // Add subscription logic below:
            // ...

            Console.WriteLine($"New subscription - Name: {subscriber.Name}, Email: {subscriber.Email}. Welcome to the Jungle!");

            ViewBag.Message = $"Thank you {subscriber.Name} subscribing to our newsletter!";

            return View();
        }
    }
}