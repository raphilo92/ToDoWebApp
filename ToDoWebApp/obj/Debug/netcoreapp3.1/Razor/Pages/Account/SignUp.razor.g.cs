#pragma checksum "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\Account\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "111933a3666aa41b301b4d115b23dda0083e0aa3"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoWebApp.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using ToDoWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using ToDoWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\Account\SignUp.razor"
using ToDoWebApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\Account\SignUp.razor"
using ToDoWebApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginDisplay))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"css/login.css\" rel=\"stylesheet\">\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\Account\SignUp.razor"
                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "input");
                __builder2.AddAttribute(5, "type", "text");
                __builder2.AddAttribute(6, "id", "login");
                __builder2.AddAttribute(7, "class", "fadeIn second");
                __builder2.AddAttribute(8, "name", "login");
                __builder2.AddAttribute(9, "placeholder", "Email Address");
                __builder2.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\Account\SignUp.razor"
                                                                                                         user.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.EmailAddress = __value, user.EmailAddress));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "text");
                __builder2.AddAttribute(15, "id", "password");
                __builder2.AddAttribute(16, "class", "fadeIn third");
                __builder2.AddAttribute(17, "name", "login");
                __builder2.AddAttribute(18, "placeholder", "Password");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\Account\SignUp.razor"
                                                                                                      user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "id", "password");
                __builder2.AddAttribute(25, "class", "fadeIn third");
                __builder2.AddAttribute(26, "name", "login");
                __builder2.AddAttribute(27, "placeholder", "Confirm Password");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\Account\SignUp.razor"
                                                                                                              user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "type", "submit");
                __builder2.AddAttribute(33, "class", "fadeIn fourth");
                __builder2.AddAttribute(34, "value", "Sign up");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\Account\SignUp.razor"
                                                                         ValidateUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(37, "<div id=\"formFooter\"><a class=\"underlineHover\" href=\"#\">Forgot Password?</a>\r\n    <br>\r\n    <a class=\"underlineHover\" href=\"#\"> Sign in</a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\Account\SignUp.razor"
       
    public User user { get; set; } = new User();


    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }


    private async Task<bool> ValidateUser()
    {
        ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsAuthenticated(user.EmailAddress);
        NavigationManager.NavigateTo("signin");

        // store state
        await sessionStorage.SetItemAsync("emailAddress", user.EmailAddress);

        return await Task.FromResult(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
