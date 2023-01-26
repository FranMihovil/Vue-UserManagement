


using Microsoft.AspNetCore.Mvc;

public class UsersController : Controller
{
    [HttpGet]
    public ActionResult GetData()
    {
        var data = new Users { Id = 1, Name = "TestUser" };
       
        return Json(data);
    }
}