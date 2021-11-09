﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace College.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return await Task.FromResult(Ok(GetDummyProducts()));
        }

        private static dynamic GetDummyProducts()
        {
            var anonArray = new[]
            {
                    new
                    {
                      id= "d4abad2c-8930-4856-9ce4-a8b5afe7b617",
                      productId= 1,
                      productName= "Leaf Rake",
                      productCode= "GDN-0011",
                      releaseDate= "March 19, 2021",
                      description= "Leaf rake with 48-inch wooden handle.",
                      price= 129.95,
                      starRating= 3.2,
                      imageUrl= "assets/images/products/leaf_rake.png"
                    },
                    new
                    {
                      id= "9103d5ae-5f14-42af-a700-0f87c968c4b6",
                      productId= 2,
                      productName= "Garden Cart",
                      productCode= "GDN-0023",
                      releaseDate= "March 18, 2021",
                      description= "15 gallon capacity rolling garden cart",
                      price= 32.99,
                      starRating= 4.2,
                      imageUrl= "assets/images/products/garden_cart.png"
                    },
                    new
                    {
                      id= "cd337b64-168a-4c3a-879d-d45aa658e4f8",
                      productId= 5,
                      productName= "Hammer",
                      productCode= "TBX-0048",
                      releaseDate= "May 21, 2021",
                      description= "Curved claw steel hammer",
                      price= 8.9,
                      starRating= 4.8,
                      imageUrl= "assets/images/products/hammer.png"
                    },
                    new
                    {
                      id= "3f6b41c7-172e-42ff-8ffc-5e23cc5a1d3f",
                      productId= 8,
                      productName= "Saw",
                      productCode= "TBX-0022",
                      releaseDate= "May 15, 2021",
                      description= "15-inch steel blade hand saw",
                      price= 2211.55,
                      starRating= 3.7,
                      imageUrl= "assets/images/products/saw.png"
                    },
                    new
                    {
                      id= "026eca47-c9b9-41f6-863a-fbf3a0121c92",
                      productId= 10,
                      productName= "Video Game Controller",
                      productCode= "GMG-0042",
                      releaseDate= "October 15, 2020",
                      description= "Standard two-button video game controller",
                      price= 35.95,
                      starRating= 4.6,
                      imageUrl= "assets/images/products/xbox-controller.png"
                    }
            };

            return anonArray;
        }

    }

}
