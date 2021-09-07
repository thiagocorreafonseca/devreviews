using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevReviews.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevReviews.API.Controllers
{
    [Route("api/products/{productId}/[controller]")]
    [ApiController]
    public class ProductReviewsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById(int productId, int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(int productId, AddProductReviewInputModel model)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1, productId = 2 }, model);
        }

    }
}
