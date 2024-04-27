using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers;   
public class HelloController : Controller   
{      
    [HttpGet] 
    [Route("")] 
    public string Index()        
    {            
      return "This is my Index!";        
    }    

    [HttpGet("projects")]
    public string Projects()        
    {            
      return "These are my projects!";        
    }    
    [HttpGet("contact")] 
    public string Contact()        
    {            
      return "This is my Contact!";        
    }    
}

