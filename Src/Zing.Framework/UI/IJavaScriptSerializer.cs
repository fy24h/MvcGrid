﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zing.UI
{
    public interface IJavaScriptSerializer
    {
        string Serialize(object value);
    }
}
