#pragma checksum "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48baccbf5b75955eceec28b41e53ffd853bafbc0"
// <auto-generated/>
#pragma warning disable 1591
namespace imanager.Pages.NewSaas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\_Imports.razor"
using imanager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\_Imports.razor"
using imanager.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newsaas")]
    public partial class NewSaas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Criar novo modulo:</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                 New

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                                Novo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "\r\n\r\n");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row");
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-sm-8");
                __builder2.AddMarkupContent(14, "\r\n\r\n        ");
                __builder2.AddMarkupContent(15, "<label>Usuario:</label>\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                                                      New.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => New.Name = __value, New.Name))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => New.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n        ");
                __builder2.AddMarkupContent(25, "<label>Email:</label>\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "placeholder", "nome@exemplo.com");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                                                      New.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => New.Email = __value, New.Email))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => New.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddMarkupContent(37, "<label>TAG:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                                                          New.TAG

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => New.TAG = __value, New.TAG))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => New.TAG));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        <p></p>");
                __builder2.AddMarkupContent(44, "<div>\r\n    </div>\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n    ");
                __builder2.OpenElement(46, "p");
                __builder2.AddMarkupContent(47, "\r\n    <p></p>\r\n");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "row");
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-sm-4");
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group form-check");
                __builder2.AddMarkupContent(56, "\r\n        <input type=\"checkbox\" class=\"form-check-input\" id=\"CRM_Start\">\r\n        ");
                __builder2.OpenElement(57, "label");
                __builder2.AddAttribute(58, "class", "form-check-label");
                __builder2.AddAttribute(59, "for", 
#nullable restore
#line 32 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                                              New.Crm_START

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(60, "CRM");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n    ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group form-check");
                __builder2.AddMarkupContent(65, "\r\n        <input type=\"checkbox\" class=\"form-check-input\" id=\"Faturamento_Start\" checked disabled>\r\n        ");
                __builder2.OpenElement(66, "label");
                __builder2.AddAttribute(67, "class", "form-check-label");
                __builder2.AddAttribute(68, "for", 
#nullable restore
#line 36 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                                              New.Faturamento_START

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(69, "Faturamento");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group form-check");
                __builder2.AddMarkupContent(74, "\r\n        <input type=\"checkbox\" class=\"form-check-input\" id=\"Vendas_Start\" checked disabled>\r\n        ");
                __builder2.OpenElement(75, "label");
                __builder2.AddAttribute(76, "class", "form-check-label");
                __builder2.AddAttribute(77, "for", 
#nullable restore
#line 40 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                                              New.Vendas_START

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(78, "Vendas");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group form-check");
                __builder2.AddMarkupContent(83, "\r\n                <input type=\"checkbox\" class=\"form-check-input\" id=\"Site_Start\" checked disabled>\r\n                ");
                __builder2.OpenElement(84, "label");
                __builder2.AddAttribute(85, "class", "form-check-label");
                __builder2.AddAttribute(86, "for", 
#nullable restore
#line 44 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                                                      New.Site_START

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(87, "Site");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "  \r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n");
                __builder2.AddMarkupContent(93, "<div class=\"row\">\r\n  </div>\r\n    ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "col-sm-5");
                __builder2.AddMarkupContent(96, "\r\n    ");
                __builder2.AddMarkupContent(97, "<div><label>Numero de licenças de Usuario:</label></div>\r\n\r\n    ");
                __builder2.OpenElement(98, "div");
                __builder2.AddMarkupContent(99, "\r\n        ");
                __Blazor.imanager.Pages.NewSaas.NewSaas.TypeInference.CreateInputNumber_0(__builder2, 100, 101, "form-control", 102, 
#nullable restore
#line 55 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                                                        New.LICENSES

#line default
#line hidden
#nullable disable
                , 103, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => New.LICENSES = __value, New.LICENSES)), 104, () => New.LICENSES);
                __builder2.AddMarkupContent(105, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n    <p></p>\r\n\r\n    ");
                __builder2.OpenElement(107, "div");
                __builder2.AddMarkupContent(108, "\r\n        ");
                __builder2.OpenElement(109, "div");
                __builder2.AddMarkupContent(110, "<label>IP SERVIDOR - \"OBS: CAMPO TEMPORARIO\"</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(111);
                __builder2.AddAttribute(112, "class", "form-control");
                __builder2.AddAttribute(113, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                                                          New.IPV4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => New.IPV4 = __value, New.IPV4))));
                __builder2.AddAttribute(115, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => New.IPV4));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\r\n        <p></p>");
                __builder2.OpenElement(117, "div");
                __builder2.AddMarkupContent(118, "\r\n       ");
                __builder2.OpenElement(119, "div");
                __builder2.AddMarkupContent(120, "<label>PORTA ODOO - \"OBS: CAMPO TEMPORARIO\"</label>    \r\n            ");
                __Blazor.imanager.Pages.NewSaas.NewSaas.TypeInference.CreateInputNumber_1(__builder2, 121, 122, "form-control", 123, 
#nullable restore
#line 64 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
                                                            New.PORT

#line default
#line hidden
#nullable disable
                , 124, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => New.PORT = __value, New.PORT)), 125, () => New.PORT);
                __builder2.AddMarkupContent(126, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n\r\n");
                __builder2.AddMarkupContent(134, "<button class=\"btn btn-danger\" type=\"submit\">Criar modulo</button>\r\n\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\ExpandFlow - Dados\Desktop\Blazor_16062020\master\src\Frontend.imanager\Pages\NewSaas\NewSaas.razor"
      
    private Frontend.imanager.Entities.NewSaas New = new Frontend.imanager.Entities.NewSaas();
    private void Novo()
    {
        Console.WriteLine("Executando criação de modulo SAAS");
        Console.WriteLine($"Usuario: {New.Name}");
    }



#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.imanager.Pages.NewSaas.NewSaas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
