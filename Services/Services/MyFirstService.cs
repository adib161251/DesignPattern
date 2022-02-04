using Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MyFirstService : IMyFirstService
    {
        public async Task<string> TestApi()
        {
            return await Task.FromResult("Data is being redirected");
        }
    }
}
