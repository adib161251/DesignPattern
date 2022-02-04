using Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class GenericService<T>: IGenericService<T> where T : class
    {
    }
}
