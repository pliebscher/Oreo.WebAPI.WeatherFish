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

    public abstract class Animal
    {

        private string _name = "";

        protected Animal(string name) { 
            _name = string.IsNullOrEmpty(name) ? "I dont have a name :^(" : name;
        }

        public abstract string Speak();

        public string Name { get { return _name; } }

    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) {
            
        }

        public override string Speak()
        {
            return "Woof";
        }

    }

    public class Cat : Animal
    {

        public Cat(string name) : base(name)
        {

        }

        public override string Speak()
        {
            return "meeeooowwww";
        }
    }

}