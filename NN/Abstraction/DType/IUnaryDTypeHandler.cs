﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN.Native.Abstraction.DType
{
    public interface IUnaryDTypeHandler<T> where T: unmanaged
    {
        T Zero { get; }
        T One { get; }
    }
}
