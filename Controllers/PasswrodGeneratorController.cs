using Microsoft.AspNetCore.Mvc;
using ProjectPasswordgenerator.Models;

namespace ProjectPasswordgenerator.Controllers
{
    public class PasswordGeneratorController : Controller
    {
        public IActionResult Index()
        {
            PasswordGeneratorViewModel model = new PasswordGeneratorViewModel();
            return View(model);
        }
        public IActionResult GeneratePassword(PasswordGeneratorViewModel model)
        {
            Random rnd = new Random();

            string uppercaseOption = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            string specialCharacters = "!@#$%^&*";
            string result = "";
            string defaultPassword = "abcdefghijklmnopqrstuvwxyz";
            string currentPassword = "";


            if (model.Numbers && model.SpecialCharacters && model.Uppercase)
            {
                currentPassword = defaultPassword + uppercaseOption + numbers + specialCharacters;

            }
            else if (model.Numbers)
            {
                currentPassword = defaultPassword + numbers;
            }
            else if (model.SpecialCharacters)
            {
                currentPassword = defaultPassword + specialCharacters;
            }
            else if (model.Uppercase)
            {
                currentPassword = defaultPassword + uppercaseOption;
            }
            else
            {
                currentPassword = defaultPassword;
            }
            for (int i = 0; i < model.PasswordLength; i++)
            {
                int intCharValue = rnd.Next(0, currentPassword.Length);
                char character = currentPassword[intCharValue];
                result += character;
            }
            model.PasswordResult = result;

            return View("Index", model);
        }
    }
}
