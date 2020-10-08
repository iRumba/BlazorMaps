﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisSst.Maps.Models
{
    public class Marker : InteractiveLayer
    {
        internal Marker(JSObjectReference jsReference)
        {
            JsReference = jsReference;
        }
    }
}