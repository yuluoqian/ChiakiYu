// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace ChiakiYu.Web.Areas.Blog.Controllers
{
    public partial class BlogController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected BlogController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Detail()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Detail);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult _CommentList()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames._CommentList);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public BlogController Actions { get { return MVC.Blog.Blog; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Blog";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Blog";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Blog";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Home = "Home";
            public readonly string _ListHotBlogs = "_ListHotBlogs";
            public readonly string Detail = "Detail";
            public readonly string Edit = "Edit";
            public readonly string _CommentList = "_CommentList";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Home = "Home";
            public const string _ListHotBlogs = "_ListHotBlogs";
            public const string Detail = "Detail";
            public const string Edit = "Edit";
            public const string _CommentList = "_CommentList";
        }


        static readonly ActionParamsClass_Home s_params_Home = new ActionParamsClass_Home();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Home HomeParams { get { return s_params_Home; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Home
        {
            public readonly string pageSize = "pageSize";
            public readonly string pageIndex = "pageIndex";
        }
        static readonly ActionParamsClass_Detail s_params_Detail = new ActionParamsClass_Detail();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Detail DetailParams { get { return s_params_Detail; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Detail
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit
        {
            public readonly string id = "id";
            public readonly string model = "model";
        }
        static readonly ActionParamsClass__CommentList s_params__CommentList = new ActionParamsClass__CommentList();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass__CommentList _CommentListParams { get { return s_params__CommentList; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass__CommentList
        {
            public readonly string id = "id";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _CommentList = "_CommentList";
                public readonly string _ListHotBlogs = "_ListHotBlogs";
                public readonly string _Sidebar = "_Sidebar";
                public readonly string Detail = "Detail";
                public readonly string Edit = "Edit";
                public readonly string Home = "Home";
            }
            public readonly string _CommentList = "~/Areas/Blog/Views/Blog/_CommentList.cshtml";
            public readonly string _ListHotBlogs = "~/Areas/Blog/Views/Blog/_ListHotBlogs.cshtml";
            public readonly string _Sidebar = "~/Areas/Blog/Views/Blog/_Sidebar.cshtml";
            public readonly string Detail = "~/Areas/Blog/Views/Blog/Detail.cshtml";
            public readonly string Edit = "~/Areas/Blog/Views/Blog/Edit.cshtml";
            public readonly string Home = "~/Areas/Blog/Views/Blog/Home.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_BlogController : ChiakiYu.Web.Areas.Blog.Controllers.BlogController
    {
        public T4MVC_BlogController() : base(Dummy.Instance) { }

        [NonAction]
        partial void HomeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int pageSize, int pageIndex);

        [NonAction]
        public override System.Web.Mvc.ActionResult Home(int pageSize, int pageIndex)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Home);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "pageSize", pageSize);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "pageIndex", pageIndex);
            HomeOverride(callInfo, pageSize, pageIndex);
            return callInfo;
        }

        [NonAction]
        partial void _ListHotBlogsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult _ListHotBlogs()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames._ListHotBlogs);
            _ListHotBlogsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void DetailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Detail(long id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Detail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            DetailOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long? id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(long? id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            EditOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, ChiakiYu.Web.Areas.Blog.ViewModels.BlogEditModel model);

        [NonAction]
        public override System.Web.Mvc.JsonResult Edit(ChiakiYu.Web.Areas.Blog.ViewModels.BlogEditModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            EditOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void _CommentListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long id);

        [NonAction]
        public override System.Web.Mvc.ActionResult _CommentList(long id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames._CommentList);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            _CommentListOverride(callInfo, id);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
