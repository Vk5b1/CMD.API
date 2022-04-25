using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CMD.Model.Tests
{
    public class RecommendedTest
    {
        [Key]
        public int TestId { get; set; }
        public string TestName { get; set; }
    }
}
