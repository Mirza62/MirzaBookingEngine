#pragma checksum "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c9293fb47435318658b9dc8f726b7e692361459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MirzaBookingEngine.Pages.Pages_RoomDetail), @"mvc.1.0.razor-page", @"/Pages/RoomDetail.cshtml")]
namespace MirzaBookingEngine.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\_ViewImports.cshtml"
using MirzaBookingEngine.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c9293fb47435318658b9dc8f726b7e692361459", @"/Pages/RoomDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a1f2048f74674654176a784de0216f1407a63c9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RoomDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/HotelImage.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "BookRoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .grid-container {
        display: grid;
        grid-template-columns: 700px 300px;
        grid-auto-rows: minmax(200px,auto);
        grid-row-gap: 10px;
        grid-column-gap: 20px;
        text-align: justify;
        justify-content: center;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c9293fb47435318658b9dc8f726b7e6923614595729", async() => {
                WriteLiteral("\r\n    <div class=\"grid-container\">\r\n        <div class=\"grid-item grid-item-1\">\r\n            <span>Room Id :");
#nullable restore
#line 21 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
                      Write(Model.Room.RoomId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            <br />\r\n            <span>");
#nullable restore
#line 23 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
             Write(Model.Room.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" /Per Night</span>\r\n            <br />\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c9293fb47435318658b9dc8f726b7e6923614596724", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <br />\r\n            <span><h4>Room Description</h4></span>\r\n            <br />\r\n            <span><h6>");
#nullable restore
#line 29 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
                 Write(Model.Room.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></span>\r\n            <br />\r\n        </div>\r\n        <div class=\"grid-item grid-item-2\">\r\n            <span><h5>Reservation Details</h5></span>\r\n            <span><h6>CheckIn Date</h6></span>\r\n            <span>");
#nullable restore
#line 35 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
             Write(Model.Reservation.CheckInDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            <br />\r\n            <span><h6>CheckOutDate</h6></span>\r\n            <span>");
#nullable restore
#line 38 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
             Write(Model.Reservation.CheckOutDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            <br />\r\n            <table>\r\n                <tbody>\r\n                    <tr>\r\n                        <td>Number of Guest</td>\r\n                        <td>");
#nullable restore
#line 44 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
                       Write(Model.Reservation.NoOfAdults);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>No of nights to stay</td>\r\n                        <td>");
#nullable restore
#line 48 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
                       Write(Model.Reservation.Nights);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Total Stay Price</td>\r\n                        <td>");
#nullable restore
#line 52 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
                       Write(Model.Invoice.TotalStayPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Taxes(18%)</td>\r\n                        <td>");
#nullable restore
#line 56 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
                       Write(Model.Invoice.Tax);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Total Cost</td>\r\n                        <td>");
#nullable restore
#line 60 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
                       Write(Model.Invoice.TotalRoomCost);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c9293fb47435318658b9dc8f726b7e69236145911363", async() => {
                    WriteLiteral("\r\n                        <input type=\"hidden\"");
                    BeginWriteAttribute("value", " value=\"", 2206, "\"", 2258, 1);
#nullable restore
#line 63 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
WriteAttributeValue("", 2214, JsonSerializer.Serialize(Model.Reservation), 2214, 44, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"reservation\" />\r\n                        <input type=\"hidden\"");
                    BeginWriteAttribute("value", " value=\"", 2327, "\"", 2372, 1);
#nullable restore
#line 64 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
WriteAttributeValue("", 2335, JsonSerializer.Serialize(Model.Room), 2335, 37, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"room\" />\r\n                        <input type=\"hidden\"");
                    BeginWriteAttribute("value", " value=\"", 2434, "\"", 2482, 1);
#nullable restore
#line 65 "D:\Github\MirzaBookingEngine\MirzaBookingEngine\MirzaBookingEngine\Pages\RoomDetail.cshtml"
WriteAttributeValue("", 2442, JsonSerializer.Serialize(Model.Invoice), 2442, 40, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"invoice\" />\r\n                        <button type=\"submit\">Book Room</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n            <br />\r\n            \r\n");
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MirzaBookingEngine.Pages.RoomDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MirzaBookingEngine.Pages.RoomDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MirzaBookingEngine.Pages.RoomDetailModel>)PageContext?.ViewData;
        public MirzaBookingEngine.Pages.RoomDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591