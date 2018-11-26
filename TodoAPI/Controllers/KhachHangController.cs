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
    public class KhachHangController : ControllerBase
    {
        private readonly DataContext _context;
        public KhachHangController(DataContext context)
        {
            _context = context;
        }
        // GET: api/Todo
        [HttpGet]
        public ActionResult<List<KHACHHANG>> Get()
        {
            return _context.khachhang.ToList();
        }
        // GET: api/Todo/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<KHACHHANG> Get(long id)
        {
            var item = _context.khachhang.Find(id);
            if (item == null)
            {
                return NoContent();
            }
            return item;
        }
        // POST api/Todo
        [HttpPost]
        public IActionResult Create(KHACHHANG item)
        {
            _context.khachhang.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("Get", new { id = item.IDKH }, item);
        }

        // PUT api/Todo/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, KHACHHANG item)
        {
            var todo = _context.khachhang.Find(id);
            if (todo == null)
            {
                return NotFound();
            }
            todo = item;

            _context.khachhang.Update(todo);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/Todo/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.khachhang.Find(id);
            if (todo == null)
            {
                return NoContent();
            }
            _context.khachhang.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
