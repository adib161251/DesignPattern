﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IMyFirstService
    {
        Task<string> TestApi();
    }
}
