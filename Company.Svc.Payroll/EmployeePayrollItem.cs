﻿using Company.Svc.Payroll.CustomAttribute;
using Company.Svc.Payroll.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Svc.Payroll
{
    public class EmployeePayrollItem: IInput
    {
        [MaxLength(250)]
        public string FirstName { get; set; }

        [MaxLength(250)]
        public string LastName { get; set; }

        public decimal AnnualSalary { get; set; }

        [PercentInput]
        public string SuperRate { get; set; }

        [DateRangeInput]
        public string DateInput { get; set; }
    }
}
