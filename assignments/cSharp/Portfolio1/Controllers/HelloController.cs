// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 

namespace Portfolio1.Controllers;   
public class HelloController : Controller   // Remember inheritance?    
{      
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page

    [HttpGet] // We will go over this in more detail on the next page    
    [Route("Projects")] // We will go over this in more detail on the next page

    [HttpGet] // We will go over this in more detail on the next page    
    [Route("Contacts")] // We will go over this in more detail on the next page
    public string Index()        
    {            
    	return "Hello World from HelloController!";        
    }    
}

