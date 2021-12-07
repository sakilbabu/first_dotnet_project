using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstWebApplication.Pages;

public class About : PageModel
{
    public string Name { get; set; }
    public void OnGet(string name)
    {
        Name = name;
    }
}