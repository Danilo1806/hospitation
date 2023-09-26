using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hospitation.API.Controllers;

[ApiController]
[Route("[controller]")]
public class FlachwitzController : ControllerBase
{
    [HttpGet(Name = "flachwitz")]
    public IActionResult GetJoke()
    {
        string Witz = "Dies ist ein Witz.";
        return Ok(Witz);
    }
}

