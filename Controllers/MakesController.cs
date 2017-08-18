using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.Controllers.Resources;
using App.Models;
using App.Persistence;

namespace App.Controllers
{
  [Route("[controller]")]
  public class MakesController : Controller
  {
    private readonly AppDbContext context;

    private readonly IMapper mapper;

    public MakesController(AppDbContext context, IMapper mapper)
    {
      this.context = context;
      this.mapper = mapper;
    }

    [Route("all")]
    [HttpGet("")]
    public async Task<IEnumerable<MakeResource>> GetAll()
    {
        System.Console.WriteLine("get all");
        var makes = await context.Makes
            .Include(m => m.Models)
            .ToListAsync();

        return mapper.Map<List<Make>, List<MakeResource>>(makes);
    }

    [HttpPost("add")]
    public IActionResult Add(int id, [FromQuery] int index) {
      System.Console.WriteLine(id);
      System.Console.WriteLine(index);
      return Ok();
    }
  }
}