﻿using BilgeHotel.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Queries.GetById
{
    public class GetEmployeeByIdQueryResponse : SingleResponseParameters
    {
        public EmployeeDto Employee { get; set; }
    }
}