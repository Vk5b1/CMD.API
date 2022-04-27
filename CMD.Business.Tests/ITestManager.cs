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
        TestReport AddTest(Test test, int appointmentId);                                                     // done
        List<Test> GetAllTests();                                                                             // done
        List<Test> GetRecommendedTests(int appointmentId);                                                    // done
        TestReport DeleteTest(int testReportId, int appointmentId);
        List<TestReportDTO> GetTestReports();



        //void AddTest(RecomendedTest test);
        //List<Test> GetTestNames();
        //void DeleteTest(int id);
        //List<RecomendedTest> GetTests();
        //List<TestsDTO> GetTestsDTO();
    }
}
