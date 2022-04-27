using CMD.DTO.Tests;
using CMD.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Business.Tests
{
    public class Converter
    {
        public List<TestReportDTO> ToTestReportDTOList(List<TestReport> testReports)  // converting the Test list to TestDTO list
        {
            if (testReports == null)
            {
                return null;
            }
            List<TestReportDTO> testReportDTO = new List<TestReportDTO>();
            foreach (TestReport report in testReports)
            {
                testReportDTO.Add(ToTestReportDTO(report));
            }
            return testReportDTO;
        }

        public TestReportDTO ToTestReportDTO(TestReport testReport) // Converting the Test To TestDTO
        {
            if (testReport == null)
            {
                return null;
            }
            TestReportDTO testReportDTO = new TestReportDTO
            {
                Id = testReport.Id,
                TestId = testReport.TestId,
            };
            return testReportDTO;
        }

        //public RecommendedTest ToTest(TestsDTO testDTO) // converting the TestDTO To Test
        //{
        //    if (testDTO == null)
        //    {
        //        return null;
        //    }
        //    RecommendedTest test = new RecommendedTest
        //    {
        //        TestId = testDTO.Id,
        //        TestName = testDTO.TestName,
        //    };

        //    return test;
        //}

        //public List<RecommendedTestDTO> ToRecommendedTestDTOList(List<RecommendedTest> tests) // Cpnverting the RecomendedTest to RecomendedTestDTO
        //{
        //    if (tests == null)
        //    {
        //        return null;
        //    }
        //    List<RecommendedTestDTO> testDTOs = new List<RecommendedTestDTO>();
        //    foreach (RecommendedTest test in tests)
        //    {
        //        testDTOs.Add(ToRecommendedTestDTO(test));
        //    }
        //    return testDTOs;
        //}

        //public RecommendedTestDTO ToRecommendedTestDTO(RecommendedTest test)
        //{
        //    if (test == null)
        //    {
        //        return null;
        //    }
        //    RecommendedTestDTO testDTO = new RecommendedTestDTO
        //    {
        //        Id = test.TestId,
        //        Name = test.TestName,
        //    };
        //    return testDTO;
        //}
    }
}
