﻿using Cv.Api.DAL.ApiContext;
using Cv.Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cv.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategoryList()
        {

            using var c = new Context();

            return Ok(c.categories.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult CategoryById(int id)
        {
            using var c = new Context();
            var values = c.categories.Find(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }

        }

        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            using var c = new Context();
            var values = c.categories.Find(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(values);
                c.SaveChanges();
                return NoContent();

            }
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category p)
        {
            using var c = new Context();
            var values = c.Find<Category>(p.CategoryID);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                values.CategoryName = p.CategoryName;
                c.Update(values);
                c.SaveChanges();
                return NoContent();
            }
        }
    }
}
