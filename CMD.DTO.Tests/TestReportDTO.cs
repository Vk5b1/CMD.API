using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.DTO.Tests
{
    public class TestReportDTO
    {
        public int Id { get; set; }
        public int? TestId { get; set; }
    }
}
