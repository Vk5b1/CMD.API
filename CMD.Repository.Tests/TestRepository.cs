using CMD.Model.Tests;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Repository.Tests
{
    public class TestRepository : ITestRepository
    {
        private CMDDBContext cmd;
        public TestRepository()
        {
            cmd = new CMDDBContext();
        }

        public TestReport AddTest(Test test,int appointmentId)                                                                              // done
        {
            //var appointment = cmd.Appointments.Include("PatientDetail").Where(p => p.Id == appointmentId).FirstOrDefault();
            //var testReport = new TestReport { Test = test };
            var tr  = cmd.TestsReports.Add(new TestReport());
            tr.TestId = test.Id;
            var appointment = cmd.Appointments.Include("PatientDetail").Where(p => p.Id == appointmentId).FirstOrDefault();
            appointment.PatientDetail.TestReports.Add(tr);  
            cmd.SaveChanges();
            return tr;
        }

        public TestReport DeleteTest(int appointmnetId, int testReportId) // aappointmentId, testReportId                                      done
        {
            //need to check the whether the appointmnetId is present or not.
            var appointment = cmd.Appointments.Find(appointmnetId);
            if(appointment != null)
            {
                var result = cmd.TestsReports.Find(testReportId);
                cmd.TestsReports.Remove(result);
                cmd.SaveChanges();
                return result;
            }
            return null;
        }

        public List<Test> GetAllTests() //master data                                                                                           done
        {
            return cmd.Tests.ToList();
        }

        public ICollection<TestReport> GetRecommendedTests(int appointmentId) // recomended tests,       parameters - appointmentid             done 
        {
            var testReports = cmd.Appointments.Where(p => p.Id == appointmentId).Select(p => p.PatientDetail).SelectMany(t => t.TestReports).Include(d => d.Test).ToList();
            return testReports;
            //return cmd.recomendedTests.ToList();
        }

        public List<TestReport> GetTestReports()
        {
            var testreports = cmd.TestsReports.ToList();
            return testreports;
        }
    }
}
