#pragma checksum "D:\Projects\pasotracker\pasotracker\pasotracker\Pages\HorseDataDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25bb5701a74f808589b15be3697eb32aef45fe8d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace pasotracker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\pasotracker\pasotracker\pasotracker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\pasotracker\pasotracker\pasotracker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\pasotracker\pasotracker\pasotracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\pasotracker\pasotracker\pasotracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\pasotracker\pasotracker\pasotracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\pasotracker\pasotracker\pasotracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\pasotracker\pasotracker\pasotracker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\pasotracker\pasotracker\pasotracker\_Imports.razor"
using pasotracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\pasotracker\pasotracker\pasotracker\_Imports.razor"
using pasotracker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\pasotracker\pasotracker\pasotracker\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\pasotracker\pasotracker\pasotracker\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\pasotracker\pasotracker\pasotracker\Pages\HorseDataDetails.razor"
using pasotracker.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\pasotracker\pasotracker\pasotracker\Pages\HorseDataDetails.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class HorseDataDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "D:\Projects\pasotracker\pasotracker\pasotracker\Pages\HorseDataDetails.razor"
       

    IList<IDictionary<string, object>> selectedItems;

    public IEnumerable<IDictionary<string, object>> data { get; set; }

    public IDictionary<string, Type> columns { get; set; }

    private HorseCast[] forecasts;

    private HorseDBDetails[] horseDBDetails;

    public string GetColumnPropertyExpression(string name, Type type)
    {
        var expression = $@"it[""{name}""].ToString()";

        if (type == typeof(int))
        {
            return $"int.Parse({expression})";
        }
        else if (type == typeof(DateTime))
        {
            return $"DateTime.Parse({expression})";
        }

        return expression;
    }

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        horseDBDetails = await ForecastService.GetHorseDetailsAsync();

        columns = new Dictionary<string, Type>()
{
            { "Reg#", typeof(string) },
            { "Horse Name", typeof(string) },
            { "DOB", typeof(string) },
            { "Age", typeof(string) },
            { "Owner Name", typeof(string) },
            { "Origin", typeof(string) },
            { "Other Details", typeof(string) }
    };

        data = Enumerable.Range(0, horseDBDetails.Count()).Select(i =>
        {
            var row = new Dictionary<string, object>();

            foreach (var column in columns)
            {
                if (column.Key == "Reg#")
                {
                    row.Add(column.Key, horseDBDetails[i].Registration);
                }
                else if (column.Key == "Horse Name")
                {
                    row.Add(column.Key, horseDBDetails[i].HorseName);
                }
                else if (column.Key == "DOB")
                {
                    row.Add(column.Key, horseDBDetails[i].DOB);
                }
                else if (column.Key == "Age")
                {
                    row.Add(column.Key, horseDBDetails[i].Age);
                }
                else if (column.Key == "Owner Name")
                {
                    row.Add(column.Key, horseDBDetails[i].OwnerName);
                }
                else if (column.Key == "Origin")
                {
                    row.Add(column.Key, horseDBDetails[i].Origin);
                }
                else if (column.Key == "Other Details")
                {
                    row.Add(column.Key, horseDBDetails[i].OtherDetails);
                }
                else
                {
                    row.Add(column.Key, horseDBDetails[i].HorseName);

                }
            }

            return row;
        });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HorseService ForecastService { get; set; }
    }
}
#pragma warning restore 1591