using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Oreo.WebAPI.WeatherFish.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            this.UserName = "Phil was here!";
        }

        public void OnGet()
        {
            ViewData["a"] = "";
        }

        public string? UserName { get; set; }

    }
}