using CMD.DTO.Tests;
using CMD.Model.Tests;
using CMD.Repository.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsConverter;


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
        public void AddTest(TestsDTO testsDTO)
        {
            // Validate with buisiness Rules.
            try
            {
                //convert DTO into Model
                var test = this.converter.ToTest(testsDTO);
                // save the data into DB.
                this.repository.AddTest(test);
            }
            catch (Exception e)
            {
                throw new Exception("Invalid data" + e.Message);
            }
        }

        public List<TestsDTO> GetTests()
        {
            return this.converter.ToTestDTOList(this.repository.GetTestNames());
        }

        public List<RecommendedTestDTO> GetRecommendedTests()
        {
            return this.converter.ToRecommendedTestDTOList(this.repository.GetTests());
        }

        public void DeleteTest(int id)
        {
            try
            {
                this.repository.DeleteTest(id);
            }
            catch(ArgumentNullException e)
            {
                throw new TestNotFoundException("Invalid data" + e.Message);
            }
            
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
