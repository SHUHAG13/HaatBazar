
using HaatBazar.Data;
using HaatBazar.Models.DTO;
using HaatBazar.Models.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HaatBazar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildCategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ChildCategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all child categories
        [HttpGet("list-with-category")]
        public  IActionResult GetAllWithCategory()
        {

            var data = (from c in _context.categoryMaster 
                        join cc in _context.childCategoryMaster
                        on c.CategoryId equals cc.categoryId
                        select new ChildCategoryDto
                        {
                            ChildCategoryId = cc.childCategoryId,
                            ChildCategoryName = cc.childCategoryName,
                            CategoryId = cc.categoryId,
                            CategoryName = c.categoryName,
                            imageName = c.imageName
                        }).ToList();


                return Ok(data);
           
            
        }


        // Save a new child category
        [HttpPost("saveChildCategory")]
        public IActionResult SaveChildCategory([FromBody] ChildCategoryMaster obj)
        {
            if (_context.childCategoryMaster
                .Any(c => c.categoryId == obj.categoryId && c.childCategoryName.ToLower() == obj.childCategoryName.ToLower()))
            {
                return BadRequest("Child category name already exists in this category.");
            }

            _context.childCategoryMaster.Add(obj);
            _context.SaveChanges();
            return Ok(obj);
        }

        // Update a child category
        [HttpPut("updateChildCategory")]
        public IActionResult UpdateChildCategory([FromBody] ChildCategoryMaster obj)
        {
            var existingChild = _context.childCategoryMaster.Find(obj.childCategoryId);
            if (existingChild == null)
            {
                return NotFound("Child category not found");
            }

            // Check for duplicate name in the same category
            if (_context.childCategoryMaster
                .Any(c => c.categoryId == obj.categoryId
                          && c.childCategoryName.ToLower() == obj.childCategoryName.ToLower()
                          && c.childCategoryId != obj.childCategoryId))
            {
                return BadRequest("Another child category with the same name exists in this category.");
            }

            existingChild.categoryId = obj.categoryId;
            existingChild.childCategoryName = obj.childCategoryName;

            _context.SaveChanges();
            return Ok(existingChild);
        }

        // Delete a child category
        [HttpDelete("deleteChildCategory")]
        public IActionResult DeleteChildCategory(int id)
        {
            var existingChild = _context.childCategoryMaster.Find(id);
            if (existingChild == null)
            {
                return NotFound("Child category not found");
            }

            _context.childCategoryMaster.Remove(existingChild);
            _context.SaveChanges();
            return Ok("Child category deleted successfully");
        }
    }
}
