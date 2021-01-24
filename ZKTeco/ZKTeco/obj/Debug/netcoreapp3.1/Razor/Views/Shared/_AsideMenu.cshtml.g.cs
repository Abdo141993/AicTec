#pragma checksum "C:\Users\zkteco-2\Desktop\ZKTeco\ZKTeco\Views\Shared\_AsideMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df57e8f2a4e931468cc625efbd9367c7985ec8c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AsideMenu), @"mvc.1.0.view", @"/Views/Shared/_AsideMenu.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\zkteco-2\Desktop\ZKTeco\ZKTeco\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zkteco-2\Desktop\ZKTeco\ZKTeco\Views\_ViewImports.cshtml"
using ZKTeco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df57e8f2a4e931468cc625efbd9367c7985ec8c1", @"/Views/Shared/_AsideMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e98e0da57c97cc5c6a29ca18d62c848cb61d2a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AsideMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<aside class=""aside-menu"">
    <ul class=""nav nav-tabs"" role=""tablist"">
        <li class=""nav-item"">
            <a class=""nav-link active"" data-toggle=""tab"" href=""#timeline"" role=""tab"">
                <i class=""icon-list""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#messages"" role=""tab"">
                <i class=""icon-speech""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#settings"" role=""tab"">
                <i class=""icon-settings""></i>
            </a>
        </li>
    </ul>
    <!-- Tab panes-->
    <div class=""tab-content"">
        <div class=""tab-pane active"" id=""timeline"" role=""tabpanel"">
            <div class=""list-group list-group-accent"">
                <div class=""list-group-item list-group-item-accent-secondary bg-light text-center font-weight-bold text-muted text-uppercase small"">Today</div>
                <div clas");
            WriteLiteral(@"s=""list-group-item list-group-item-accent-warning list-group-item-divider"">
                    <div class=""avatar float-right"">
                        <img class=""img-avatar"" src=""/img/avatars/7.jpg"" alt=""admin@bootstrapmaster.com"">
                    </div>
                    <div>
                        Meeting with
                        <strong>Lucas</strong>
                    </div>
                    <small class=""text-muted mr-3"">
                        <i class=""icon-calendar""></i>  1 - 3pm
                    </small>
                    <small class=""text-muted"">
                        <i class=""icon-location-pin""></i>  Palo Alto, CA
                    </small>
                </div>
                <div class=""list-group-item list-group-item-accent-info"">
                    <div class=""avatar float-right"">
                        <img class=""img-avatar"" src=""/img/avatars/4.jpg"" alt=""admin@bootstrapmaster.com"">
                    </div>
                    <div>
   ");
            WriteLiteral(@"                     Skype with
                        <strong>Megan</strong>
                    </div>
                    <small class=""text-muted mr-3"">
                        <i class=""icon-calendar""></i>  4 - 5pm
                    </small>
                    <small class=""text-muted"">
                        <i class=""icon-social-skype""></i>  On-line
                    </small>
                </div>
                <div class=""list-group-item list-group-item-accent-secondary bg-light text-center font-weight-bold text-muted text-uppercase small"">Tomorrow</div>
                <div class=""list-group-item list-group-item-accent-danger list-group-item-divider"">
                    <div>
                        New UI Project -
                        <strong>deadline</strong>
                    </div>
                    <small class=""text-muted mr-3"">
                        <i class=""icon-calendar""></i>  10 - 11pm
                    </small>
                    <small class=""te");
            WriteLiteral(@"xt-muted"">
                        <i class=""icon-home""></i>  creativeLabs HQ
                    </small>
                    <div class=""avatars-stack mt-2"">
                        <div class=""avatar avatar-xs"">
                            <img class=""img-avatar"" src=""/img/avatars/2.jpg"" alt=""admin@bootstrapmaster.com"">
                        </div>
                        <div class=""avatar avatar-xs"">
                            <img class=""img-avatar"" src=""/img/avatars/3.jpg"" alt=""admin@bootstrapmaster.com"">
                        </div>
                        <div class=""avatar avatar-xs"">
                            <img class=""img-avatar"" src=""/img/avatars/4.jpg"" alt=""admin@bootstrapmaster.com"">
                        </div>
                        <div class=""avatar avatar-xs"">
                            <img class=""img-avatar"" src=""/img/avatars/5.jpg"" alt=""admin@bootstrapmaster.com"">
                        </div>
                        <div class=""avatar avatar-xs"">
        ");
            WriteLiteral(@"                    <img class=""img-avatar"" src=""/img/avatars/6.jpg"" alt=""admin@bootstrapmaster.com"">
                        </div>
                    </div>
                </div>
                <div class=""list-group-item list-group-item-accent-success list-group-item-divider"">
                    <div>
                        <strong>#10 Startups.Garden</strong> Meetup
                    </div>
                    <small class=""text-muted mr-3"">
                        <i class=""icon-calendar""></i>  1 - 3pm
                    </small>
                    <small class=""text-muted"">
                        <i class=""icon-location-pin""></i>  Palo Alto, CA
                    </small>
                </div>
                <div class=""list-group-item list-group-item-accent-primary list-group-item-divider"">
                    <div>
                        <strong>Team meeting</strong>
                    </div>
                    <small class=""text-muted mr-3"">
                       ");
            WriteLiteral(@" <i class=""icon-calendar""></i>  4 - 6pm
                    </small>
                    <small class=""text-muted"">
                        <i class=""icon-home""></i>  creativeLabs HQ
                    </small>
                    <div class=""avatars-stack mt-2"">
                        <div class=""avatar avatar-xs"">
                            <img class=""img-avatar"" src=""/img/avatars/2.jpg"" alt=""admin@bootstrapmaster.com"">
                        </div>
                        <div class=""avatar avatar-xs"">
                            <img class=""img-avatar"" src=""/img/avatars/3.jpg"" alt=""admin@bootstrapmaster.com"">
                        </div>
                        <div class=""avatar avatar-xs"">
                            <img class=""img-avatar"" src=""/img/avatars/4.jpg"" alt=""admin@bootstrapmaster.com"">
                        </div>
                        <div class=""avatar avatar-xs"">
                            <img class=""img-avatar"" src=""/img/avatars/5.jpg"" alt=""admin@bootstrapmas");
            WriteLiteral(@"ter.com"">
                        </div>
                        <div class=""avatar avatar-xs"">
                            <img class=""img-avatar"" src=""/img/avatars/6.jpg"" alt=""admin@bootstrapmaster.com"">
                        </div>
                        <div class=""avatar avatar-xs"">
                            <img class=""img-avatar"" src=""/img/avatars/7.jpg"" alt=""admin@bootstrapmaster.com"">
                        </div>
                        <div class=""avatar avatar-xs"">
                            <img class=""img-avatar"" src=""/img/avatars/8.jpg"" alt=""admin@bootstrapmaster.com"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""tab-pane p-3"" id=""messages"" role=""tabpanel"">
            <div class=""message"">
                <div class=""py-3 pb-5 mr-3 float-left"">
                    <div class=""avatar"">
                        <img class=""img-avatar"" src=""/img/avatars/7.jpg"" alt=""admin@bootstrapmas");
            WriteLiteral(@"ter.com"">
                        <span class=""avatar-status badge-success""></span>
                    </div>
                </div>
                <div>
                    <small class=""text-muted"">Lukasz Holeczek</small>
                    <small class=""text-muted float-right mt-1"">1:52 PM</small>
                </div>
                <div class=""text-truncate font-weight-bold"">Lorem ipsum dolor sit amet</div>
                <small class=""text-muted"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...</small>
            </div>
            <hr>
            <div class=""message"">
                <div class=""py-3 pb-5 mr-3 float-left"">
                    <div class=""avatar"">
                        <img class=""img-avatar"" src=""/img/avatars/7.jpg"" alt=""admin@bootstrapmaster.com"">
                        <span class=""avatar-status badge-success""></span>
                    </div>
                </div>
                <div>
                    ");
            WriteLiteral(@"<small class=""text-muted"">Lukasz Holeczek</small>
                    <small class=""text-muted float-right mt-1"">1:52 PM</small>
                </div>
                <div class=""text-truncate font-weight-bold"">Lorem ipsum dolor sit amet</div>
                <small class=""text-muted"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...</small>
            </div>
            <hr>
            <div class=""message"">
                <div class=""py-3 pb-5 mr-3 float-left"">
                    <div class=""avatar"">
                        <img class=""img-avatar"" src=""/img/avatars/7.jpg"" alt=""admin@bootstrapmaster.com"">
                        <span class=""avatar-status badge-success""></span>
                    </div>
                </div>
                <div>
                    <small class=""text-muted"">Lukasz Holeczek</small>
                    <small class=""text-muted float-right mt-1"">1:52 PM</small>
                </div>
                <div class");
            WriteLiteral(@"=""text-truncate font-weight-bold"">Lorem ipsum dolor sit amet</div>
                <small class=""text-muted"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...</small>
            </div>
            <hr>
            <div class=""message"">
                <div class=""py-3 pb-5 mr-3 float-left"">
                    <div class=""avatar"">
                        <img class=""img-avatar"" src=""/img/avatars/7.jpg"" alt=""admin@bootstrapmaster.com"">
                        <span class=""avatar-status badge-success""></span>
                    </div>
                </div>
                <div>
                    <small class=""text-muted"">Lukasz Holeczek</small>
                    <small class=""text-muted float-right mt-1"">1:52 PM</small>
                </div>
                <div class=""text-truncate font-weight-bold"">Lorem ipsum dolor sit amet</div>
                <small class=""text-muted"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmo");
            WriteLiteral(@"d tempor incididunt...</small>
            </div>
            <hr>
            <div class=""message"">
                <div class=""py-3 pb-5 mr-3 float-left"">
                    <div class=""avatar"">
                        <img class=""img-avatar"" src=""/img/avatars/7.jpg"" alt=""admin@bootstrapmaster.com"">
                        <span class=""avatar-status badge-success""></span>
                    </div>
                </div>
                <div>
                    <small class=""text-muted"">Lukasz Holeczek</small>
                    <small class=""text-muted float-right mt-1"">1:52 PM</small>
                </div>
                <div class=""text-truncate font-weight-bold"">Lorem ipsum dolor sit amet</div>
                <small class=""text-muted"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt...</small>
            </div>
        </div>
        <div class=""tab-pane p-3"" id=""settings"" role=""tabpanel"">
            <h6>Settings</h6>
            <div");
            WriteLiteral(@" class=""aside-options"">
                <div class=""clearfix mt-4"">
                    <small>
                        <b>Option 1</b>
                    </small>
                    <label class=""switch switch-label switch-pill switch-success switch-sm float-right"">
                        <input class=""switch-input"" type=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 11607, "\"", 11617, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""switch-slider"" data-checked=""On"" data-unchecked=""Off""></span>
                    </label>
                </div>
                <div>
                    <small class=""text-muted"">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</small>
                </div>
            </div>
            <div class=""aside-options"">
                <div class=""clearfix mt-3"">
                    <small>
                        <b>Option 2</b>
                    </small>
                    <label class=""switch switch-label switch-pill switch-success switch-sm float-right"">
                        <input class=""switch-input"" type=""checkbox"">
                        <span class=""switch-slider"" data-checked=""On"" data-unchecked=""Off""></span>
                    </label>
                </div>
                <div>
                    <small class=""text-muted"">Lorem ipsum dolor sit amet, consect");
            WriteLiteral(@"etur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</small>
                </div>
            </div>
            <div class=""aside-options"">
                <div class=""clearfix mt-3"">
                    <small>
                        <b>Option 3</b>
                    </small>
                    <label class=""switch switch-label switch-pill switch-success switch-sm float-right"">
                        <input class=""switch-input"" type=""checkbox"">
                        <span class=""switch-slider"" data-checked=""On"" data-unchecked=""Off""></span>
                    </label>
                </div>
            </div>
            <div class=""aside-options"">
                <div class=""clearfix mt-3"">
                    <small>
                        <b>Option 4</b>
                    </small>
                    <label class=""switch switch-label switch-pill switch-success switch-sm float-right"">
                        <input class=""switch-input"" t");
            WriteLiteral("ype=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 13680, "\"", 13690, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""switch-slider"" data-checked=""On"" data-unchecked=""Off""></span>
                    </label>
                </div>
            </div>
            <hr>
            <h6>System Utilization</h6>
            <div class=""text-uppercase mb-1 mt-4"">
                <small>
                    <b>CPU Usage</b>
                </small>
            </div>
            <div class=""progress progress-xs"">
                <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            </div>
            <small class=""text-muted"">348 Processes. 1/4 Cores.</small>
            <div class=""text-uppercase mb-1 mt-2"">
                <small>
                    <b>Memory Usage</b>
                </small>
            </div>
            <div class=""progress progress-xs"">
                <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 70%"" aria-valuenow=""70"" aria-valuem");
            WriteLiteral(@"in=""0"" aria-valuemax=""100""></div>
            </div>
            <small class=""text-muted"">11444GB/16384MB</small>
            <div class=""text-uppercase mb-1 mt-2"">
                <small>
                    <b>SSD 1 Usage</b>
                </small>
            </div>
            <div class=""progress progress-xs"">
                <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 95%"" aria-valuenow=""95"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            </div>
            <small class=""text-muted"">243GB/256GB</small>
            <div class=""text-uppercase mb-1 mt-2"">
                <small>
                    <b>SSD 2 Usage</b>
                </small>
            </div>
            <div class=""progress progress-xs"">
                <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            </div>
            <small class=""text-muted"">25GB/256GB</small>
        </div>
");
            WriteLiteral("    </div>\r\n</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591