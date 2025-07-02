using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using SingletonTest;

namespace Singleton.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ISingleton singleton;
        private readonly IScope scope;
        private readonly IScope scope2;
        private readonly ITransient transient;
        private readonly ITransient transient2;

        public TestController(ISingleton singleton, IScope scope, IScope scope2, ITransient transient, ITransient transient2)
        {
            this.singleton = singleton;
            this.scope = scope;
            this.transient = transient;
            this.transient2 = transient2;
            this.scope2 = scope2;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            object res = new {
                singleton = await this.singleton.GetRandom(),
                scope = await this.scope.GetRandom(),
                scope2 = await this.scope2.GetRandom(),
                transient = await this.transient.GetRandom(),
                transient2 = await this.transient2.GetRandom(),
            };
            return this.Ok(res);
        }
    }
}
