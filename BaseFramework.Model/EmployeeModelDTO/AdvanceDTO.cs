﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework.Model.EmployeeModelDTO
{
    public class AdvanceDTO
    {
        public int Id { get; set; }
        public int Sum { get; set; }
        public DateTime Date { get; set; }
        public string Installment { get; set; }
        public string Description { get; set; }

        public List<EmployeeDTO> Employees { get; set; }
    }
}
