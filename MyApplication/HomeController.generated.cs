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
namespace MyApplication.Controllers
{
    public partial class HomeController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected HomeController(Dummy d) { }

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


        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public HomeController Actions { get { return MVC.Home; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Home";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Home";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Learn_0100 = "Learn_0100";
            public readonly string Learn_0200 = "Learn_0200";
            public readonly string Learn_0300 = "Learn_0300";
            public readonly string Learn_0400 = "Learn_0400";
            public readonly string Learn_0500 = "Learn_0500";
            public readonly string Learn_0600 = "Learn_0600";
            public readonly string Learn_0700 = "Learn_0700";
            public readonly string Learn_0800 = "Learn_0800";
            public readonly string Learn_0900 = "Learn_0900";
            public readonly string Learn_1000 = "Learn_1000";
            public readonly string Learn_1100 = "Learn_1100";
            public readonly string Learn_1200 = "Learn_1200";
            public readonly string Learn_1300 = "Learn_1300";
            public readonly string Learn_1400 = "Learn_1400";
            public readonly string Learn_1500 = "Learn_1500";
            public readonly string Learn_1600 = "Learn_1600";
            public readonly string Learn_1700 = "Learn_1700";
            public readonly string Learn_1800 = "Learn_1800";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Learn_0100 = "Learn_0100";
            public const string Learn_0200 = "Learn_0200";
            public const string Learn_0300 = "Learn_0300";
            public const string Learn_0400 = "Learn_0400";
            public const string Learn_0500 = "Learn_0500";
            public const string Learn_0600 = "Learn_0600";
            public const string Learn_0700 = "Learn_0700";
            public const string Learn_0800 = "Learn_0800";
            public const string Learn_0900 = "Learn_0900";
            public const string Learn_1000 = "Learn_1000";
            public const string Learn_1100 = "Learn_1100";
            public const string Learn_1200 = "Learn_1200";
            public const string Learn_1300 = "Learn_1300";
            public const string Learn_1400 = "Learn_1400";
            public const string Learn_1500 = "Learn_1500";
            public const string Learn_1600 = "Learn_1600";
            public const string Learn_1700 = "Learn_1700";
            public const string Learn_1800 = "Learn_1800";
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
                public readonly string Index = "Index";
                public readonly string Learn_0100 = "Learn_0100";
                public readonly string Learn_0200 = "Learn_0200";
                public readonly string Learn_0300 = "Learn_0300";
                public readonly string Learn_0400 = "Learn_0400";
                public readonly string Learn_0500 = "Learn_0500";
                public readonly string Learn_0600 = "Learn_0600";
                public readonly string Learn_0700 = "Learn_0700";
                public readonly string Learn_0800 = "Learn_0800";
                public readonly string Learn_0900 = "Learn_0900";
                public readonly string Learn_1000 = "Learn_1000";
                public readonly string Learn_1100 = "Learn_1100";
                public readonly string Learn_1200 = "Learn_1200";
                public readonly string Learn_1300 = "Learn_1300";
                public readonly string Learn_1400 = "Learn_1400";
                public readonly string Learn_1500 = "Learn_1500";
                public readonly string Learn_1600 = "Learn_1600";
                public readonly string Learn_1700 = "Learn_1700";
                public readonly string Learn_1800 = "Learn_1800";
            }
            public readonly string Index = "~/Views/Home/Index.cshtml";
            public readonly string Learn_0100 = "~/Views/Home/Learn_0100.cshtml";
            public readonly string Learn_0200 = "~/Views/Home/Learn_0200.cshtml";
            public readonly string Learn_0300 = "~/Views/Home/Learn_0300.cshtml";
            public readonly string Learn_0400 = "~/Views/Home/Learn_0400.cshtml";
            public readonly string Learn_0500 = "~/Views/Home/Learn_0500.cshtml";
            public readonly string Learn_0600 = "~/Views/Home/Learn_0600.cshtml";
            public readonly string Learn_0700 = "~/Views/Home/Learn_0700.cshtml";
            public readonly string Learn_0800 = "~/Views/Home/Learn_0800.cshtml";
            public readonly string Learn_0900 = "~/Views/Home/Learn_0900.cshtml";
            public readonly string Learn_1000 = "~/Views/Home/Learn_1000.cshtml";
            public readonly string Learn_1100 = "~/Views/Home/Learn_1100.cshtml";
            public readonly string Learn_1200 = "~/Views/Home/Learn_1200.cshtml";
            public readonly string Learn_1300 = "~/Views/Home/Learn_1300.cshtml";
            public readonly string Learn_1400 = "~/Views/Home/Learn_1400.cshtml";
            public readonly string Learn_1500 = "~/Views/Home/Learn_1500.cshtml";
            public readonly string Learn_1600 = "~/Views/Home/Learn_1600.cshtml";
            public readonly string Learn_1700 = "~/Views/Home/Learn_1700.cshtml";
            public readonly string Learn_1800 = "~/Views/Home/Learn_1800.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_HomeController : MyApplication.Controllers.HomeController
    {
        public T4MVC_HomeController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_0100Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_0100()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_0100);
            Learn_0100Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_0200Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_0200()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_0200);
            Learn_0200Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_0300Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_0300()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_0300);
            Learn_0300Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_0400Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_0400()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_0400);
            Learn_0400Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_0500Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_0500()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_0500);
            Learn_0500Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_0600Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_0600()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_0600);
            Learn_0600Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_0700Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_0700()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_0700);
            Learn_0700Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_0800Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_0800()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_0800);
            Learn_0800Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_0900Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_0900()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_0900);
            Learn_0900Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_1000Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_1000()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_1000);
            Learn_1000Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_1100Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_1100()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_1100);
            Learn_1100Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_1200Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_1200()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_1200);
            Learn_1200Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_1300Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_1300()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_1300);
            Learn_1300Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_1400Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_1400()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_1400);
            Learn_1400Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_1500Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_1500()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_1500);
            Learn_1500Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_1600Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_1600()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_1600);
            Learn_1600Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_1700Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_1700()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_1700);
            Learn_1700Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Learn_1800Override(T4MVC_System_Web_Mvc_ViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ViewResult Learn_1800()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ViewResult(Area, Name, ActionNames.Learn_1800);
            Learn_1800Override(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
