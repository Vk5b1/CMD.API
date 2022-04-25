using CMD.Model.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.DTO.Tests
{
    public class TestsDTO
    {
        
        public int Id { get; set; }
        public string TestName { get; set; }
        public int CategoryID { get; set; }
    }
}
