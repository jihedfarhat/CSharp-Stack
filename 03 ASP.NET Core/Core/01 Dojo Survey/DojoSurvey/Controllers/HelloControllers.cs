using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;   
public class HelloController : Controller   
{      
    [HttpGet("")] 
    public IActionResult Index()        
    {            
    return View();        
    }

    [HttpPost("result")] 
    public IActionResult Result(string name, string location, string language, string comments)        
    { 
      ViewBag.name = name;
      ViewBag.location = location;
      ViewBag.language = language;
      ViewBag.comments = comments;
    return View();        
    }    
}
