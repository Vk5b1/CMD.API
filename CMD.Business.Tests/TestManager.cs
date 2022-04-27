using CMD.DTO.Tests;
using CMD.Model.Tests;
using CMD.Repository.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMD.Business.Tests
{
    public class TestManager : ITestManager
    {
        ITestRepository repository = null;
        Converter converter = null;

        public TestManager(TestRepository repository)
        {
            this.repository = repository;
            converter = new Converter();
        }
        public TestReport AddTest(Test test, int appointmentId) // Adding Testreport to the ICollection<TestReport>                   // done
        {
            // Validate with buisiness Rules.
            try
            {
                // save the data into DB.
                return this.repository.AddTest(test,appointmentId);
            }
            catch (Exception e)
            {
                throw new Exception("Invalid data" + e.Message);
            }
        }

        public List<Test> GetAllTests()  //Getting master data from the database.                                                             //done
        { 
            return this.repository.GetAllTests();
        }

        public List<Test> GetRecommendedTests(int appointmentId) //Getting recommended tests from the ICollection<TestReport>               // done
        {
            return this.repository.GetRecommendedTests(appointmentId).Select(t => t.Test).ToList();
        }

        public TestReport DeleteTest(int appointmentId, int testReportId)  // Removing the testreport from the ICollection<TestReport>              // done
        {
            //try
            //{
                return this.repository.DeleteTest(appointmentId, testReportId);
            //}
            //catch(ArgumentNullException e)
            //{
            //    throw new TestNotFoundException("Invalid data" + e.Message);
            //}
            
        }

        public List<TestReportDTO> GetTestReports()
        {
            return this.converter.ToTestReportDTOList(this.repository.GetTestReports());
        }


















        //private ITestRepository testRepo = null;
        //private TestConverter converter = null;

        //public TestManager(TestRepository repo)
        //{
        //    this.testRepo = repo;
        //    this.converter = new TestConverter();
        //}
        //public void AddTest(RecomendedTest test)
        //{
        //    testRepo.AddTest(test);
        //}

        //public List<Test> GetTestNames()
        //{
        //    return testRepo.GetTestNames();
        //}

        //public void DeleteTest(int id)
        //{
        //    testRepo.DeleteTest(id);
        //}

        //public List<RecomendedTest> GetTests()
        //{
        //    return testRepo.GetTests();
        //}

        //public List<TestsDTO> GetTestsDTO()
        //{
        //    return this.converter.ToTestDTOList(GetTestNames());
        //}

    }
}
