using CMD.DTO.Tests;
using CMD.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsConverter
{
    public class TestConverter
    {
        public static List<TestsDTO> ToTestDTOList(List<Test> tests)
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
        
        public static TestsDTO ToTestDTO(Test test)
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

        public static Test ToTest(TestsDTO testDTO)//, ITestRepository appointmentRepo)
        {
            if (testDTO == null)
            {
                return null;
            }
            Test test = new Test
            {
                Id= testDTO.Id,
                Name = testDTO.TestName,
            };

            return test;
        }
    }
}
