using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Jonnel Lique", StudentId = "21-1474", StudentAge = "21" },
            new StudentInfoModel { Name = "Rudy Lique", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Sonia Lique", StudentId = "S003", StudentAge = "31" },
            new StudentInfoModel { Name = "John James Lique", StudentId = "S004", StudentAge = "25" }
        };

        return View(studentInfoArray);
    }
}
