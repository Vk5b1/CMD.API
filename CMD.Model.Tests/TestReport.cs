using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Model.Tests
{
    public class TestReport
    {
        public int Id { get; set; }
        [ForeignKey("Test")]
        public int? TestId { get; set; }
        public Test Test { get; set; }
        public string Report { get; set; }
        public float Value { get; set; }
    }
}
