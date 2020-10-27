using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using routing.Models;

namespace routing.Controllers
{
    [ApiController]
    [Route("foo")]
    public class FooController : ControllerBase {
        private readonly ILogger<FooController> _logger;

        public FooController(ILogger<FooController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public async Task<Foo> GetFoo() {
            var reference = Guid.NewGuid();
            var foo = new Foo(reference.ToString());
            return foo;
        }
    }
}