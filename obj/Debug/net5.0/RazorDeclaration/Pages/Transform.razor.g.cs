// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
