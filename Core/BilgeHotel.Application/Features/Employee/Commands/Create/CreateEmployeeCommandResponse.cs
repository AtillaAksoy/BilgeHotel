﻿using BilgeHotel.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Commands.Create
{
    public class CreateEmployeeCommandResponse : SingleResponseParameters
    {
        public Guid? Id { get; set; }
    }
}
