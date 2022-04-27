using CMD.Business.Tests;
using CMD.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CMD.WEBAPI.Controllers
{
    [RoutePrefix("api/tests")]
    public class TestsController : ApiController
    {
        private ITestManager manager = null;

        public TestsController(ITestManager manager)
        {
            this.manager = manager;
        }

        [Route("{appointmnetId}")]
        [HttpPost]
        public IHttpActionResult AddTest(int appointmnetId,Test test) // Adding Testreport to the ICollection<TestReport>                   done
        {
            if (test == null)
                return BadRequest("Invalid input");
            if(appointmnetId < 0)
            { 
                return BadRequest("Invalid input");
            }

            return Ok(this.manager.AddTest(test, appointmnetId));
        }

        //[Route("api/GetTests")]
        [HttpGet]
        public IHttpActionResult GetTests() //Getting master data from the database.                                                              done
        {
            var tests = this.manager.GetAllTests();
            return Ok(tests);
        }

        [Route("GetRecommendedTest/{appointmentId}")]
        [HttpGet]
        public IHttpActionResult GetRecommendedTest(int appointmentId) // Getting recommended tests from the ICollection<TestReport>               done
        {
            var tests = this.manager.GetRecommendedTests(appointmentId);
            return Ok(tests);
        }

        [Route("RemoveTest/testReportid/{testReportId}/appointmentid/{appointmentId}")]
        [HttpDelete]
        public IHttpActionResult RemoveTest(int testReportId, int appointmentId) // Removing the testreport from the ICollection<TestReport>        done
        {
            var result = this.manager.DeleteTest(appointmentId, testReportId);
            return Ok(result);
        }

        [Route("GetTestReports")]
        [HttpGet]
        public IHttpActionResult GetTestReports()
        {
            return Ok(this.manager.GetTestReports());
        }
    }
}
