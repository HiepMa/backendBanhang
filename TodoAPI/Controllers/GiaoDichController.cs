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
    public class GiaoDichController : ControllerBase
    {
        private readonly DataContext _context;
        public GiaoDichController(DataContext context)
        {
            _context = context;
        }
        // GET: api/Todo
        [HttpGet]
        public ActionResult<List<GIAODICH>> Get()
        {
            return _context.Giaodiches.Include(x=>x.Giohang).ToList();
        }
        // GET: api/Todo/5
        [HttpGet("{id}")]
        public ActionResult<GIAODICH> Get(long id)
        {
            var item = _context.Giaodiches.Find(id);
            if (item == null)
            {
                return NoContent();
            }
            return item;
        }
        // POST api/Todo
        [HttpPost]
        public IActionResult Create(GIAODICH item)
        {
            _context.Giaodiches.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("Get", new { id = item.IDGIAODICH }, item);
        }

        // PUT api/Todo/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, GIAODICH item)
        {
            var todo = _context.Giaodiches.Find(id);
            if (todo == null)
            {
                return NotFound();
            }
            todo = item;

            _context.Giaodiches.Update(todo);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/Todo/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.Giaodiches.Find(id);
            if (todo == null)
            {
                return NoContent();
            }
            _context.Giaodiches.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
