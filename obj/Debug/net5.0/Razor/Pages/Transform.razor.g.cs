#pragma checksum "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eaaa22b278ab486561127f2b259bc1ace3bb8d2"
// <auto-generated/>
#pragma warning disable 1591
namespace StandardNomenclatureApp.Pages
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\_Imports.razor"
using StandardNomenclatureApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\_Imports.razor"
using StandardNomenclatureApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
using QueryTreatment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
using MissenseVariantInfoSeparation;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transform")]
    public partial class Transform : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Standard nomencluture for missense (from .p to c.)</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "size", "100");
            __builder.AddAttribute(3, "placeholder", "Write missense variant separated by semicolons (;)");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
                         missenseVariantQuery

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => missenseVariantQuery = __value, missenseVariantQuery));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
                  QueryMissense

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Query");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "ol");
#nullable restore
#line 14 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
     if (toView)
    {
            
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
             foreach(KeyValuePair<GetMissenseInfos, List<string>> item in listOfEachMissenseForNomenclature)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "li");
            __builder.AddContent(13, 
#nullable restore
#line 19 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
                     item.Key.missensePNomenclature

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "ul");
#nullable restore
#line 21 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
                     foreach(string nomenclature in item.Value)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "li");
            __builder.AddContent(17, 
#nullable restore
#line 23 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
                             nomenclature

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
             

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\ufes\Desktop\Dev\StandardNomenclatureApp\Pages\Transform.razor"
       
    
    static string missenseVariantQuery;
    static string[] listMissenseQuery;
    static bool isListValid; 
    static bool toView = false;
    static List<GetMissenseInfos> missenseVariantsObjectToView = new List<GetMissenseInfos>();
    static Dictionary<GetMissenseInfos, List<string>> listOfEachMissenseForNomenclature = new Dictionary<GetMissenseInfos, List<string>>();

    static void QueryMissense()
    {
        listMissenseQuery = MissenseVariant.MissenseVariantToList(missenseVariantQuery);
        isListValid = MissenseVariant.MisseseValidation(listMissenseQuery);
        if (isListValid)
        {
            List<GetMissenseInfos> missenseVariantsObject = new List<GetMissenseInfos>();
            foreach (string missenseVariant in listMissenseQuery)
            {
                GetMissenseInfos missenseObject = new GetMissenseInfos(missenseVariant);
                missenseVariantsObject.Add(missenseObject);
            }
            
            missenseVariantsObjectToView = missenseVariantsObject;
            listOfEachMissenseForNomenclature = GetMissenseInfos.GetCodonsCompared(missenseVariantsObject);
            toView = true;
        } 
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
