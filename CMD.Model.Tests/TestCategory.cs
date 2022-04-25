using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Model.Tests
{
    public class TestCategory
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
