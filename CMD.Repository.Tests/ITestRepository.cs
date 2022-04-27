using CMD.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Repository.Tests
{
    public interface ITestRepository
    {
        TestReport AddTest(Test test, int appointmentId);                                         // done
        List<Test> GetAllTests();                                                                 // done
        TestReport DeleteTest(int appointmnetId, int testReportId);
        ICollection<TestReport> GetRecommendedTests(int appointmentId);
        List<TestReport> GetTestReports();

        // fetching the tests that are added by doctor.            // done
        //ICollection<TestReport> GetTestsByPatientId(int id);
    }
}
