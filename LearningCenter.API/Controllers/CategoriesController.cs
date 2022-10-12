using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCenter.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryDomain _categoryDomain; 
        
        public CategoriesController(ICategoryDomain categoryDomain)
        {
            _categoryDomain = categoryDomain;
        }
        
        // GET: api/Categories
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = _categoryDomain.getAll();
            return result;
        }

        // GET: api/Categories/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            var result = _categoryDomain.getCategoryById(id);
            return result;
        }

        // POST: api/Categories
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var result = _categoryDomain.createCategory(value);
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var result = _categoryDomain.updateCategory(value);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var result = _categoryDomain.deleteCategory(id);
        }
    }
}
