using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using BlazorCounter;
using BlazorCounter.Shared;
using System.ComponentModel.DataAnnotations;

namespace BlazorCounter.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        [Parameter]
        public int IncreamentAmount { get; set; } = 1;
        private void IncrementCount()
        {
            currentCount += IncreamentAmount;
        }
    }
}