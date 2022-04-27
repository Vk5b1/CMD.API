using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Model.Tests
{
    public class PatientDetail
    {
        public PatientDetail()
        {
            TestReports = new HashSet<TestReport>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TestReport> TestReports { get; set; }
    }
}
