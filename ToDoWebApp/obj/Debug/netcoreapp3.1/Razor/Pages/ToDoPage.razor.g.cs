#pragma checksum "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d88349fe40b70dea419a75d3becd8828ef0bc84c"
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
            __builder.AddMarkupContent(0, "<h3>To Do</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                              _toDoList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(7, "table");
                    __builder3.AddAttribute(8, "class", "table table-hover");
                    __builder3.AddAttribute(9, "Model", 
#nullable restore
#line 13 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                         _toDoList

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(10, @"<thead><tr><th><i class=""oi oi-pencil""></i></th>
                            <th><i class=""oi oi-calendar""></i></th>
                            <th><i class=""oi oi-check""></i></th>
                            <th><i class=""oi oi-trash""></i></th></tr></thead>
                    ");
                    __builder3.OpenElement(11, "tbody");
#nullable restore
#line 23 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                         foreach (var item in _toDoList)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(12, "tr");
                    __builder3.OpenElement(13, "td");
                    __builder3.AddContent(14, 
#nullable restore
#line 27 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                     item.Title

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(15, "\r\n                                ");
                    __builder3.OpenElement(16, "td");
                    __builder3.AddContent(17, 
#nullable restore
#line 30 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                     item.DateTimeCreated.ToString("hh:mm tt")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(18, "\r\n                                ");
                    __builder3.OpenElement(19, "td");
#nullable restore
#line 33 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
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
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(20);
                    __builder3.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                                                     (() => DoneCheck(item))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "class", "custom-checkbox");
                    __builder3.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                                item.done

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.done = __value, item.done))));
                    __builder3.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => item.done));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(26, "\r\n                                ");
                    __builder3.OpenElement(27, "td");
                    __builder3.OpenElement(28, "button");
                    __builder3.AddAttribute(29, "class", "btn btn-outline-primary");
                    __builder3.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                                                      (() => DeleteToDo(item))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(31, " Delete ");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 48 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "form");
                __builder2.AddAttribute(34, "style", "display: flex; justify-content:center; width:80%");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "input-group mb-3");
                __builder2.AddMarkupContent(37, "<div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"basic-addon3\">What do you need to do?</span></div>\r\n                    ");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "text");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "id", "basic-url");
                __builder2.AddAttribute(42, "aria-describedby", "basic-addon3");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                                                                                  _newItemTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newItemTitle = __value, _newItemTitle));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "class", "btn btn-primary");
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
                                                              AddToDo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(49, " Add ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(50, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(51, "\r\n        Please Login\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\JGB\Desktop\Programming\Project\ToDoWebApp\ToDoWebApp\Pages\ToDoPage.razor"
       
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
