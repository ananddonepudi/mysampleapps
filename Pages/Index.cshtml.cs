using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class IndexModel : PageModel
{
    [BindProperty]
    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }

    public string Message { get; set; }

    public void OnGet()
    {
        // Initial load
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Dummy authentication
        if (Username == "admin" && Password == "password")
        {
            // Redirect to Dashboard page
            return RedirectToPage("/Dashboard");
        }
        else
        {
            Message = "Invalid credentials.";
            return Page();
        }

    }
}
