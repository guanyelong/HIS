﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHM.IBLL
{
    public interface IBLLSessionFactory
    {
        IBLLSession GetBLLSesson();
    }
}
