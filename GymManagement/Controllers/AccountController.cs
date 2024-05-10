using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Signup()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Signup(SignupViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Perform signup logic (e.g., save to database)
            // Here you can implement your own logic to store user data

            // Redirect to a success page or login page
            return RedirectToAction("Login", "Account");
        }

        return View(model); // If model state is invalid, return the view with errors
    }
}