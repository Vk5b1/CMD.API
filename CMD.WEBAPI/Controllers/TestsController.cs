using CMD.Business.Tests;
using CMD.DTO.Tests;    
using CMD.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CMD.WEBAPI.Controllers
{
    [RoutePrefix("api")]
    public class TestsController : ApiController
    {
        private ITestManager manager = null;

        public TestsController(ITestManager manager)
        {
            this.manager = manager;
        }

        [HttpPost]
        public IHttpActionResult AddTest(TestsDTO test)
        {
            if (test == null)
                return BadRequest("Invalid input");

            this.manager.AddTest(test);

            return Created($"api/tests/{test.Id}", test);
        }
        [Route("test")]
        [HttpGet]
        public IQueryable<TestsDTO> GetTests()
        {
            var tests = this.manager.GetTests();
            //if (tests == null || tests.Count == 0)
            //{
            //    return 
            //}

            return tests.AsQueryable();
        }

        [Route("recommendedtest")]
        [HttpGet]
        public IHttpActionResult GetRecommendedTest()
        {

            var tests = this.manager.GetRecommendedTests();
            
            return Ok(tests);
        }
        [HttpDelete]
        public IHttpActionResult RemoveTest(int id)
        {
            if(id < 0)
            {
                return BadRequest("Invalid input");
            }
            this.manager.DeleteTest(id);    
            return Ok();
        }
    }
}
