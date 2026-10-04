using Microsoft.AspNetCore.Mvc;

namespace homework3ASP.NET.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            id = Convert.ToInt32(Request.RouteValues["id"]);

            switch (id)
            {
                case 1:
                    {
                        ViewBag.name = "Oily Oaf Brew";
                        ViewBag.price = 25;
                        ViewBag.description = "Густе, злегка олійне та дуже дешеве пиво з насиченим солодовим смаком. Це найпопулярніший напої серед шахтарів для звичайного перекусу чи святкування повернення з місії. Воно не надає баффів і не викликає особливих ефектів, окрім поступового сп'яніння.";
                        ViewBag.imgUrl = "https://ih1.redbubble.net/image.5682943427.2042/fposter,x_small,wall_texture,product,750x1000.2.jpg";
                        break;
                    }
                case 2:
                    {
                        ViewBag.name = "Glyphid Slammer";
                        ViewBag.price = 75;
                        ViewBag.description = "Міцний і різкий напій з вираженим гірким присмаком, який вибирають суворі гноми. Воно сп'яняє відчутно швидше за Oily Oaf і чудово підходить для того, щоб випити за успішне виконання важкої контракту перед тим, як вирушити до наступної печери.";
                        ViewBag.imgUrl = "https://ih1.redbubble.net/image.4916014799.6246/bg,f8f8f8-flat,750x,075,f-pad,750x1000,f8f8f8.jpg";
                        break;
                    }
                case 3:
                    {
                        ViewBag.name = "Leaf Lover's Special";
                        ViewBag.price = 25;
                        ViewBag.description = "Напій, який справжні гноми замовляють хіба що з сорому або за крайньої потреби. Це безалкогольне (або майже безалкогольне) пиво з легким трав'янистим смаком. Його головна властивість — воно миттєво знімає будь-який рівень сп'яніння та повністю протвережує гнома перед вильотом на місію.";
                        ViewBag.imgUrl = "https://ih1.redbubble.net/image.5682934685.1759/st,medium,507x507-pad,600x600,f8f8f8.webp";
                        break;
                    }
            }

            return View();
        }
    }
}
