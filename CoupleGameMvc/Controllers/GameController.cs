using Microsoft.AspNetCore.Mvc;

namespace CoupleGameMvc.Controllers;

public class GameController : Controller
{
    private static int Points = 0;
    private static int Level = 1;
    private static int Arousal = 1;
    private static Random random = new();

    public IActionResult Index()
    {
        ViewBag.Points = Points;
        ViewBag.Level = Level;
        ViewBag.Arousal = Arousal;
        return View();
    }

    public IActionResult Roll()
    {
        int dice = random.Next(1, 7);
        int earned = dice switch
        {
            1 => 10,
            2 => 12,
            3 => 15,
            4 => 18,
            5 => 20,
            6 => 25,
            _ => 10
        };

        Points += earned;
        Arousal += 1;

        if (Points >= 300) Level = 5;
        else if (Points >= 200) Level = 4;
        else if (Points >= 120) Level = 3;
        else if (Points >= 50) Level = 2;

        TempData["Dice"] = dice;
        TempData["Earned"] = earned;

        return RedirectToAction("Index");
    }
}