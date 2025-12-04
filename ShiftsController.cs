using Microsoft.AspNetCore.Mvc;
using SmartShift.Infrastructure.Data;
using SmartShift.Domain.Entities;

namespace SmartShift.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ShiftsController:ControllerBase {
 private readonly AppDbContext _db;
 public ShiftsController(AppDbContext db){_db=db;}
 [HttpGet] public IActionResult Get()=>Ok(_db.Shifts.ToList());
 [HttpPost] public IActionResult Post(Shift s){_db.Shifts.Add(s);_db.SaveChanges();return Ok(s);}
}