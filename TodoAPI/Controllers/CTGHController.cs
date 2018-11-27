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
    public class CTGHController : ControllerBase
    {
        private readonly DataContext _context;
        public CTGHController(DataContext context)
        {
            _context = context;
        }
        // GET: api/Todo
        [HttpGet]
        public ActionResult<List<CT_GIOHANG>> Get()
        {
            return _context.ChiTiets.Include(x => x.sp).ToList();
        }
        // GET: api/Todo/5
        [HttpGet("{id}")]
        public ActionResult<CT_GIOHANG> Get(long id)
        {
            var item = _context.ChiTiets.Find(id);
            if (item == null)
            {
                return NoContent();
            }
            return item;
        }
        // GET: api/Todo
        [HttpGet("{idgh}", Name = "ctsp")]
        public ActionResult<List<CT_GIOHANG>> GetList(long idgh)
        {
            return _context.ChiTiets.Include(x => x.giohang)
                .Where(x => (x.giohang.IDGIOHANG == idgh))
                .AsNoTracking().ToList();
        }
        // POST api/Todo
        [HttpPost]
        public IActionResult Create(CT_GIOHANG item)
        {
            _context.ChiTiets.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("Get", new { id = item.IDGH }, item);
        }

        // PUT api/Todo/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, CT_GIOHANG item)
        {
            var todo = _context.ChiTiets.Find(id);
            if (todo == null)
            {
                return NotFound();
            }
            todo = item;

            _context.ChiTiets.Update(todo);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/Todo/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.ChiTiets.Find(id);
            if (todo == null)
            {
                return NoContent();
            }
            _context.ChiTiets.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
