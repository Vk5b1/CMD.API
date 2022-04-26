using CMD.DTO.Tests;
using CMD.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Business.Tests
{
    public interface ITestManager
    {
        void AddTest(TestsDTO testsDTO);
        List<TestsDTO> GetTests();
        List<RecommendedTestDTO> GetRecommendedTests();
        void DeleteTest(int id);



        //void AddTest(RecomendedTest test);
        //List<Test> GetTestNames();
        //void DeleteTest(int id);
        //List<RecomendedTest> GetTests();
        //List<TestsDTO> GetTestsDTO();
    }
}
