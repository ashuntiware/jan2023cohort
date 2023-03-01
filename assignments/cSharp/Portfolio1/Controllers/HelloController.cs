// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 

namespace Portfolio1.Controllers;   
public class HelloController : Controller   // Remember inheritance?    
{      
    [HttpGet("")] // We will go over this in more detail on the next page    
    public string Index () {
        return "Home";
    }


    [HttpGet("projects")] // We will go over this in more detail on the next page    
        public string Projects (){
        return "Projects";
    }
    
    [HttpGet("contacts")] // We will go over this in more detail on the next page    
 
    public string ContactsForm(string formInput)        
    {            
    	return "Contacts";        
    }    
}

