#pragma checksum "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bebdd528b7cc5c4878922414d1d887ae19eafb46"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoWebApp.Pages
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
#line 2 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
using Microsoft.EntityFrameworkCore.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
using ToDoWebApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
using ToDoWebApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDoPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
                __builder2.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                          _toDoList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(5, "table");
                    __builder3.AddAttribute(6, "class", "table table-hover");
                    __builder3.AddAttribute(7, "Model", 
#nullable restore
#line 11 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                     _toDoList

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(8, @"<thead><tr><th><i class=""oi oi-pencil""></i></th>
                        <th><i class=""oi oi-calendar""></i></th>
                        <th><i class=""oi oi-check""></i></th>
                        <th><i class=""oi oi-trash""></i></th></tr></thead>
                ");
                    __builder3.OpenElement(9, "tbody");
#nullable restore
#line 21 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                     foreach (var item in _toDoList)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(10, "tr");
                    __builder3.OpenElement(11, "td");
                    __builder3.AddContent(12, 
#nullable restore
#line 25 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                 item.Title

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(13, "\r\n                            ");
                    __builder3.OpenElement(14, "td");
                    __builder3.AddContent(15, 
#nullable restore
#line 28 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                 item.DateTimeCreated.ToString("hh:mm tt")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(16, "\r\n                            ");
                    __builder3.OpenElement(17, "td");
#nullable restore
#line 31 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                 if (item.Done == Done.Done)
                                {
                                    item.done = true;
                                }
                                else
                                {
                                    item.done = false;
                                }

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(18);
                    __builder3.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                                                 (() => DoneCheck(item))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "class", "custom-checkbox");
                    __builder3.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                            item.done

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.done = __value, item.done))));
                    __builder3.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => item.done));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(24, "\r\n                            ");
                    __builder3.OpenElement(25, "td");
                    __builder3.OpenElement(26, "button");
                    __builder3.AddAttribute(27, "class", "btn btn-outline-primary");
                    __builder3.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                                                  (() => DeleteToDo(item))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(29, " Delete ");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 46 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n\r\n        \r\n        ");
                __builder2.OpenElement(31, "form");
                __builder2.AddAttribute(32, "style", "display: flex; justify-content:center; width:80%");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "input-group mb-3");
                __builder2.AddMarkupContent(35, "<div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"basic-addon3\">To Do Today</span></div>\r\n                ");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "type", "text");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "id", "basic-url");
                __builder2.AddAttribute(40, "aria-describedby", "basic-addon3");
                __builder2.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                                                                              _newItemTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newItemTitle = __value, _newItemTitle));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "class", "btn btn-primary");
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                          AddToDo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(47, " Add ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(48, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(49, "\r\n        Please Login\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
       
    public IList<ToDoItem> _toDoList = new List<ToDoItem>();
    private string _newItemTitle { get; set; }

    // Page Model Methods
    protected async override Task OnInitializedAsync()
    {
        _toDoList = await ToDoData.GetTodayToDoItem();
    }

    private async Task AddToDo()
    {
        if (!String.IsNullOrEmpty(_newItemTitle))
        {
            var newToDoItem = new ToDoItem(_newItemTitle, DateTime.Now);

            await ToDoData.InsertItem(newToDoItem);

            _newItemTitle = string.Empty;
        }
        _toDoList = await ToDoData.GetTodayToDoItem();
    }

    private async Task DeleteToDo(ToDoItem item)
    {
        await ToDoData.DeleteItem(item);

        _toDoList = await ToDoData.GetTodayToDoItem();
    }

    private async Task DoneCheck(ToDoItem item)
    {
        item.Done = item.Done == Done.NotDone ? Done.Done : Done.NotDone;

        if (item.Done == Done.Done)
        {
            await ToDoData.UpdateToDoneStatus(item);
        }
        else
        {
            await ToDoData.UpdateToUnDoneStatus(item);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToDoData ToDoData { get; set; }
    }
}
#pragma warning restore 1591
