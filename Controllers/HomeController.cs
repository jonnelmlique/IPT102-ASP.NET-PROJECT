using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Jonnel Lique", StudentId = "S001", StudentAge = "21" },
            new StudentInfoModel { Name = "Rudy Lique", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Sonia Lique", StudentId = "S003", StudentAge = "31" },
            new StudentInfoModel { Name = "John James Lique", StudentId = "S004", StudentAge = "25" },
            new StudentInfoModel { Name = "David Lee", StudentId = "S005", StudentAge = "24" },
            new StudentInfoModel { Name = "Olivia Wilson", StudentId = "S006", StudentAge = "19" },
            new StudentInfoModel { Name = "Sophia Anderson", StudentId = "S007", StudentAge = "23" },
            new StudentInfoModel { Name = "William Harris", StudentId = "S008", StudentAge = "28" },
            new StudentInfoModel { Name = "Ella Davis", StudentId = "S009", StudentAge = "21" },
            new StudentInfoModel { Name = "Liam Martinez", StudentId = "S010", StudentAge = "27" }

        };

        return View(studentInfoArray);
    }
}
