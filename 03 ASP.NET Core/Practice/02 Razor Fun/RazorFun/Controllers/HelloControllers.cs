using Microsoft.AspNetCore.Mvc;
namespace RazorFun.Controllers;   
public class HelloController : Controller   
{      
    [HttpGet] 
    [Route("")] 
    public ViewResult Index()        
    {            
      return View("Index");        
    }    

}

