using HaatBazar.Data;
using HaatBazar.Models.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HaatBazar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("getAllCategory")]
        public IActionResult GetCategories()
        {
            var categories = _context.categoryMaster.ToList();
            return Ok(categories);
        }


        [HttpPost("saveCategory")]
        public IActionResult SaveCategory([FromBody] CategoryMaster obj)
        {
           _context.categoryMaster.Add(obj);
            _context.SaveChanges();
            return Ok(obj);
        }

        [HttpPut("updateCategory")]
        public IActionResult UpdateCategory([FromBody] CategoryMaster obj)
        {
            var existingCategory = _context.categoryMaster.Find(obj.CategoryId);
            if(existingCategory==null)
            {
                return NotFound("Category not found");
            }
            else
            {
                existingCategory.imageName = obj.imageName;
                existingCategory.categoryName = obj.categoryName;
                _context.SaveChanges();
                return Ok(obj);
            }
               
        }

        [HttpDelete]
        public IActionResult DeleteCategoryById(int id)
        {
            var existingCategory = _context.categoryMaster.Find(id);
            if (existingCategory == null)
            {
                return NotFound("Category not found");
            }
            else
            {
                _context.categoryMaster.Remove(existingCategory);
                _context.SaveChanges();
                return Ok("Category deleted successfully");
            }
        }


    }
}
