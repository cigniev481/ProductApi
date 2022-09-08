using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductApi.Controllers.V1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductDbContext context;
        private readonly ILogger<ProductsController> logger;

        public ProductsController( ILogger<ProductsController> logger, ProductDbContext context)
        {
            this.context = context;
            this.logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            logger.LogInformation("successful");
            return Ok(context.Products);
        }

        [HttpGet]
        [Route("{Id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Product> GetById(string Id)
        {
            if (Id == null)
            {
                logger.LogError("Id is null, Error");
                return BadRequest();
            }
            var product =  context.Products.FirstOrDefault(x => x.Id == Id);

            if (product == null)
            {
                logger.LogError("Product not found, Error");
                return NotFound();
            }

            logger.LogInformation("successful");
            return Ok(product);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<Product> Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                logger.LogError("Create Error");
                return BadRequest();
            }
            try
            {
                context.Products.Add(product);
                context.SaveChanges();

            }
            catch (Exception)
            {
                logger.LogError("Create Error");
                return BadRequest();
            }

            logger.LogInformation("Create, successful");
            return Created($"/api/v1/contacts/" ,product);
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                logger.LogError("id is null, Error");
                return BadRequest();
            }
            var product = context.Products.Find(id);

            if (product == null)
            {
                logger.LogError("Product not found, Error");
                return NotFound();
            }

            try
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
            catch (Exception)
            {
                logger.LogError("delete, Error");
                return BadRequest();
            }
            logger.LogInformation("delete, successful");
            return NoContent();
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Update(string id, Product product)
        {
            if (id == null || product == null || product.Id != id)
            {
                logger.LogError("not found, Error");
                return BadRequest();
            }
            try
            {
                context.Products.Update(product);
                context.SaveChanges();
            }
            catch (Exception)
            {
                logger.LogError("update, Error");
                return BadRequest();
            }

            logger.LogInformation("update, successful");
            return Ok(product);
        }


        [HttpPatch]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Patch(string id, JsonPatchDocument<Product> productPatch)
        {
            if (id == null || productPatch == null)
                return BadRequest();

            var product = context.Products.Find(id);

            if (product == null)
                return NotFound();

            productPatch.ApplyTo(product);

            try
            {
                context.Products.Update(product);
                context.SaveChanges();
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return Ok(product);
        }
    }
}

