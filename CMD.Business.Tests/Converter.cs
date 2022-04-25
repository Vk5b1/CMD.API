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
        public List<TestsDTO> ToTestDTOList(List<Test> tests)
        {
            if (tests == null)
            {
                return null;
            }
            List<TestsDTO> testDTOs = new List<TestsDTO>();
            foreach (Test test in tests)
            {
                testDTOs.Add(ToTestDTO(test));
            }
            return testDTOs;
        }

        public TestsDTO ToTestDTO(Test test)
        {
            if (test == null)
            {
                return null;
            }
            TestsDTO testDTO = new TestsDTO
            {
                Id = test.Id,
                TestName = test.Name,
                CategoryID = test.Category.Id,
            };
            return testDTO;
        }

        public RecommendedTest ToTest(TestsDTO testDTO)//, ITestRepository appointmentRepo)
        {
            if (testDTO == null)
            {
                return null;
            }
            RecommendedTest test = new RecommendedTest
            {
                TestId = testDTO.Id,
                TestName = testDTO.TestName,
            };

            return test;
        }

        public List<RecommendedTestDTO> ToRecommendedTestDTOList(List<RecommendedTest> tests)
        {
            if (tests == null)
            {
                return null;
            }
            List<RecommendedTestDTO> testDTOs = new List<RecommendedTestDTO>();
            foreach (RecommendedTest test in tests)
            {
                testDTOs.Add(ToRecommendedTestDTO(test));
            }
            return testDTOs;
        }

        public RecommendedTestDTO ToRecommendedTestDTO(RecommendedTest test)
        {
            if (test == null)
            {
                return null;
            }
            RecommendedTestDTO testDTO = new RecommendedTestDTO
            {
                Id = test.TestId,
                Name = test.TestName,
            };
            return testDTO;
        }
    }
}
