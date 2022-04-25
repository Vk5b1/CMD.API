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
        void AddTest(RecommendedTest test);
        List<Test> GetTestNames();
        void DeleteTest(int id);
        List<RecommendedTest> GetTests(); // fetching the tests that are added by doctor.
    }
}
