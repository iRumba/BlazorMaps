﻿using FisSst.BlazorComponents.Core;
using FisSst.BlazorComponents.Core.JsInterops;
using FisSst.Maps.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FisSst.Maps
{
    public partial class Map : ComponentBase
    {
        [Inject]
        public IJSRuntime JsRuntime { get; set; }

        [Parameter]
        public MapOptions MapOptions { get; set; }        

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await MapJsInterop.Initialize(this.JsRuntime, this.MapOptions);
        }
    }
}