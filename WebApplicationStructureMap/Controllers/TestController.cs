using System.Web.Http;
using ClassLibrary1;

namespace WebApplicationStructureMap.Controllers
{
    public class TestController : ApiController
    {
        private readonly IBar _b;
        private readonly IFoo _f;

        public TestController(IBar b, IFoo f)
        {
            _b = b;
            _f = f;
        }

        [HttpGet]
        public int Get()
        {
            return 42 + _b.Calc();
        }
    }
}