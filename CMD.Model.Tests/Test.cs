using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Model.Tests
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public TestCategory Category { get; set; }
    }
}
