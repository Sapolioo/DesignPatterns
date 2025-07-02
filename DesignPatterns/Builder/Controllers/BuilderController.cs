using Microsoft.AspNetCore.Mvc;

namespace Builder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuilderController : ControllerBase
    {
     
        public BuilderController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            director.BuildMinimalViableProduct();
            var StandardBasicProduct = builder.GetProduct().ListParts();

            director.BuildFullFeaturedProduct();
            var FullProduct = builder.GetProduct().ListParts();

            builder.BuildPartA();
            builder.BuildPartC();
            var WithOutDirector = builder.GetProduct().ListParts();
            var result = new {
                StandardBasicProduct,
                FullProduct,
                WithOutDirector
            };
            return this.Ok(result);
        }
    }
}
