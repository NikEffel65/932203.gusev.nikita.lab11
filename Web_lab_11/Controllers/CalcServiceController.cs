using Microsoft.AspNetCore.Mvc;
using Web_lab_11.Models;

namespace Web_lab_11.Controllers
{
    public class CalcServiceController : Controller
    {
        private Random rand = new Random();

        [ViewData]
        public required CalcServiceModel injectedCalc { get; set; }

        public IActionResult PassUsingModel()
        {
            int randValueFirst = rand.Next(1, 10);
            int randValueSecond = rand.Next(1, 10);
            var viewModel = new CalcServiceModel()
            {
                RandValueFirst = randValueFirst.ToString(),
                RandValueSecond = randValueSecond.ToString(),
                Add = randValueFirst.ToString() + " + " + randValueSecond.ToString() + " = " + (randValueFirst + randValueSecond).ToString(),
                Sub = randValueFirst.ToString() + " - " + randValueSecond.ToString() + " = " + (randValueFirst - randValueSecond).ToString(),
                Mult = randValueFirst.ToString() + " * " + randValueSecond.ToString() + " = " + (randValueFirst * randValueSecond).ToString(),
                Div = randValueSecond == 0 ? "Ошибка второй параметр 0. Деление на 0." : randValueFirst.ToString() + " / " + randValueSecond.ToString() + " = " + (randValueFirst / randValueSecond).ToString()

            };
            return View(viewModel);
        }

        public IActionResult PassUsingViewData()
        {
                int randValueFirst = rand.Next(0, 10);
                int randValueSecond = rand.Next(0, 10);
                ViewData["Calc"] = new CalcServiceModel()
                {
                    RandValueFirst = randValueFirst.ToString(),
                    RandValueSecond = randValueSecond.ToString(),
                    Add = randValueFirst.ToString() + " + " + randValueSecond.ToString() + " = " + (randValueFirst + randValueSecond).ToString(),
                    Sub = randValueFirst.ToString() + " - " + randValueSecond.ToString() + " = " + (randValueFirst - randValueSecond).ToString(),
                    Mult = randValueFirst.ToString() + " * " + randValueSecond.ToString() + " = " + (randValueFirst * randValueSecond).ToString(),
                    
                    Div = randValueSecond == 0 ? "Ошибка второй параметр 0. Деление на 0.":randValueFirst.ToString() + " / " + randValueSecond.ToString() + " = " + (randValueFirst / randValueSecond).ToString()

                };
                return View();
        }
        public IActionResult PassUsingViewBag() {
            int randValueFirst = rand.Next(0, 10);
            int randValueSecond = rand.Next(0, 10);
            ViewBag.Calc = new CalcServiceModel()
            {
                RandValueFirst = randValueFirst.ToString(),
                RandValueSecond = randValueSecond.ToString(),
                Add = randValueFirst.ToString() + " + " + randValueSecond.ToString() + " = " + (randValueFirst + randValueSecond).ToString(),
                Sub = randValueFirst.ToString() + " - " + randValueSecond.ToString() + " = " + (randValueFirst - randValueSecond).ToString(),
                Mult = randValueFirst.ToString() + " * " + randValueSecond.ToString() + " = " + (randValueFirst * randValueSecond).ToString(),
                Div = randValueSecond == 0 ? "Ошибка второй параметр 0. Деление на 0." : randValueFirst.ToString() + " / " + randValueSecond.ToString() + " = " + (randValueFirst / randValueSecond).ToString()

            };
            return View();
        }


        public IActionResult AccessServiceDirectly()
        {
            int randValueFirst = rand.Next(0, 10);
            int randValueSecond = rand.Next(0, 10);
            injectedCalc = new CalcServiceModel()
            {
                RandValueFirst = randValueFirst.ToString(),
                RandValueSecond = randValueSecond.ToString(),
                Add = randValueFirst.ToString() + " + " + randValueSecond.ToString() + " = " + (randValueFirst + randValueSecond).ToString(),
                Sub = randValueFirst.ToString() + " - " + randValueSecond.ToString() + " = " + (randValueFirst - randValueSecond).ToString(),
                Mult = randValueFirst.ToString() + " * " + randValueSecond.ToString() + " = " + (randValueFirst * randValueSecond).ToString(),
                Div = randValueSecond == 0 ? "Ошибка второй параметр 0. Деление на 0." : randValueFirst.ToString() + " / " + randValueSecond.ToString() + " = " + (randValueFirst / randValueSecond).ToString()

            };
            return View();
        }
    }
}
