﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSys.Domain.Entities
{
    public class ExamCategory
    {
        public int TrueCounter { get; set; }
        public int FalseCounter { get; set; }
        public int CategoryId { get; set; }
        public int ExamId { get; set; }
    }
}
