using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BANHANG.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BANHANG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CTHDController : ControllerBase
    {
        private readonly DataContext _context;
        public CTHDController(DataContext context)
        {
            _context = context;
        }
        // GET: api/Todo
        [HttpGet]
        public ActionResult<List<CT_GIOHANG>> Get()
        {
            return _context.chitiet.Include(x => x.sp).ToList();
        }
        // GET: api/Todo/5
        [HttpGet("{id}")]
        public ActionResult<CT_GIOHANG> Get(long id)
        {
            var item = _context.chitiet.Find(id);
            if (item == null)
            {
                return NoContent();
            }
            return item;
        }
        // POST api/Todo
        [HttpPost]
        public IActionResult Create(CT_GIOHANG item)
        {
            _context.chitiet.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("Get", new { id = item.IDGH }, item);
        }

        // PUT api/Todo/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, CT_GIOHANG item)
        {
            var todo = _context.chitiet.Find(id);
            if (todo == null)
            {
                return NotFound();
            }
            todo = item;

            _context.chitiet.Update(todo);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/Todo/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.chitiet.Find(id);
            if (todo == null)
            {
                return NoContent();
            }
            _context.chitiet.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
