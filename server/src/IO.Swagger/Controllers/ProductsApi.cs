/*
 * H Plus Sports Company API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ProductsApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageNumber">Page number to return</param>
        /// <param name="pageSize">Number of results in the page</param>
        /// <response code="200">List of products in catalog</response>
        /// <response code="500">Unexpected error</response>
        [HttpGet]
        [Route("/product")]
        [ValidateModelState]
        [SwaggerOperation("ProductGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Product>), description: "List of products in catalog")]
        [SwaggerResponse(statusCode: 500, type: typeof(InlineResponse500), description: "Unexpected error")]
        public virtual IActionResult ProductGet([FromQuery]int? pageNumber, [FromQuery]int? pageSize)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Product>));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(InlineResponse500));
            string exampleJson = null;
            exampleJson = "[ {\n  \"imageLink\" : \"https://images.pexels.com/photos/2477379/pexels-photo-2477379.jpeg\",\n  \"name\" : \"Lemon Water\",\n  \"description\" : \"I am tasty water\",\n  \"id\" : 121,\n  \"imageTitle\" : \"Image of Lemon Water\"\n}, {\n  \"imageLink\" : \"https://images.pexels.com/photos/2477379/pexels-photo-2477379.jpeg\",\n  \"name\" : \"Lemon Water\",\n  \"description\" : \"I am tasty water\",\n  \"id\" : 121,\n  \"imageTitle\" : \"Image of Lemon Water\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Product>>(exampleJson)
                        : default(List<Product>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Add a product to catalog</remarks>
        /// <param name="body"></param>
        /// <response code="200">The product has been created</response>
        /// <response code="500">Unexpected error</response>
        [HttpPost]
        [Route("/product")]
        [ValidateModelState]
        [SwaggerOperation("ProductPost")]
        [SwaggerResponse(statusCode: 500, type: typeof(InlineResponse500), description: "Unexpected error")]
        public virtual IActionResult ProductPost([FromBody]Product body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(InlineResponse500));

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="customerSecurityHeader"></param>
        /// <response code="200">Specific product in catalog</response>
        /// <response code="500">Unexpected error</response>
        [HttpGet]
        [Route("/product/{productId}")]
        [ValidateModelState]
        [SwaggerOperation("ProductProductIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Product), description: "Specific product in catalog")]
        [SwaggerResponse(statusCode: 500, type: typeof(InlineResponse500), description: "Unexpected error")]
        public virtual IActionResult ProductProductIdGet([FromRoute][Required]int? productId, [FromHeader]int? customerSecurityHeader)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Product));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(InlineResponse500));
            string exampleJson = null;
            exampleJson = "{\n  \"imageLink\" : \"https://images.pexels.com/photos/2477379/pexels-photo-2477379.jpeg\",\n  \"name\" : \"Lemon Water\",\n  \"description\" : \"I am tasty water\",\n  \"id\" : 121,\n  \"imageTitle\" : \"Image of Lemon Water\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Product>(exampleJson)
                        : default(Product);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
