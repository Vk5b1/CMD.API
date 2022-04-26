using CMD.Model.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Repository.Tests
{
    public class TestRepository : ITestRepository
    {
        private CMDDBContext cmd = new CMDDBContext();
        //public TestRepository()
        //{
        //    cmd = new CMDDBContext();
        //}
        public void AddTest(RecommendedTest test)
        {
            cmd.recomendedTests.Add(test);
            cmd.SaveChanges();
        }

        public void DeleteTest(int id)
        {
            cmd.recomendedTests.Remove(cmd.recomendedTests.Find(id));
            cmd.SaveChanges();
        }

        public List<Test> GetTestNames() //master data
        {
            return cmd.tests.Include("Category").ToList();
        }

        public List<RecommendedTest> GetTests() // recomended tests
        {
            return cmd.recomendedTests.ToList();
        }
    }
}
