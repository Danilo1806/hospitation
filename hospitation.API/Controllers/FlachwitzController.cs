using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace hospitation.API.Controllers;

[ApiController]
[Route("[controller]")]
public class FlachwitzController : ControllerBase
{
    [HttpGet(Name = "flachwitz")]
    public IActionResult GetJoke()
    {
        List<String> flachwitze = new List<String>()
                    {
                        "Witz 1",
                        "Witz 2",
                        "Witz 3",
                        "Witz 4",
                        "Witz 5"                   
                    };

        Random rnd = new Random();
        var index = rnd.Next(5);

        return Ok(flachwitze[index]);
    }
}

