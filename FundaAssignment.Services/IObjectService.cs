﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FundaAssignment.Services
{
    public interface IObjectService
    {
       Task< IEnumerable<Entities.Object>> GetTop10MakelaarsInAmsterdam();
    }
}
