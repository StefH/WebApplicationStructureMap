using System.Web.Http;
using ClassLibrary1;

namespace WebApplicationStructureMap.Controllers
{
    [SomeFilter]
    public class TestController : ApiController
    {
        private readonly ILogger _logger;
        private readonly IBar _b;
        private readonly IFoo _f;

        public TestController(ILogger logger, IBar b, IFoo f)
        {
            _logger = logger;
            _b = b;
            _f = f;

            _logger.W("TestController");
        }

        [HttpGet]
        public int Get()
        {
            _logger.W("Get");
            return 42 + _b.Calc();
        }
    }
}