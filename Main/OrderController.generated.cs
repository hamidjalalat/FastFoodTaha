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
namespace HJ_Template_MVC.Controllers
{
    public partial class OrderController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public OrderController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected OrderController(Dummy d) { }

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
        public virtual System.Web.Mvc.JsonResult GetProduct()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetProduct);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult DeleteProduct()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DeleteProduct);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult GetInfoEdit()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetInfoEdit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult Edit()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.Edit);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public OrderController Actions { get { return MVC.Order; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Order";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Order";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string GetProduct = "GetProduct";
            public readonly string DeleteProduct = "DeleteProduct";
            public readonly string Create = "Create";
            public readonly string GetInfoEdit = "GetInfoEdit";
            public readonly string Edit = "Edit";
            public readonly string OrederCustomer = "OrederCustomer";
            public readonly string GetListProduct = "GetListProduct";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string GetProduct = "GetProduct";
            public const string DeleteProduct = "DeleteProduct";
            public const string Create = "Create";
            public const string GetInfoEdit = "GetInfoEdit";
            public const string Edit = "Edit";
            public const string OrederCustomer = "OrederCustomer";
            public const string GetListProduct = "GetListProduct";
        }


        static readonly ActionParamsClass_GetProduct s_params_GetProduct = new ActionParamsClass_GetProduct();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetProduct GetProductParams { get { return s_params_GetProduct; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetProduct
        {
            public readonly string product = "product";
            public readonly string pageIndex = "pageIndex";
            public readonly string pageSize = "pageSize";
        }
        static readonly ActionParamsClass_DeleteProduct s_params_DeleteProduct = new ActionParamsClass_DeleteProduct();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteProduct DeleteProductParams { get { return s_params_DeleteProduct; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteProduct
        {
            public readonly string idDelete = "idDelete";
        }
        static readonly ActionParamsClass_Create s_params_Create = new ActionParamsClass_Create();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Create CreateParams { get { return s_params_Create; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Create
        {
            public readonly string product = "product";
            public readonly string file = "file";
        }
        static readonly ActionParamsClass_GetInfoEdit s_params_GetInfoEdit = new ActionParamsClass_GetInfoEdit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetInfoEdit GetInfoEditParams { get { return s_params_GetInfoEdit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetInfoEdit
        {
            public readonly string idEdit = "idEdit";
        }
        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit
        {
            public readonly string product = "product";
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
                public readonly string Create = "Create";
                public readonly string Index = "Index";
                public readonly string OrederCustomer = "OrederCustomer";
            }
            public readonly string Create = "~/Views/Order/Create.cshtml";
            public readonly string Index = "~/Views/Order/Index.cshtml";
            public readonly string OrederCustomer = "~/Views/Order/OrederCustomer.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_OrderController : HJ_Template_MVC.Controllers.OrderController
    {
        public T4MVC_OrderController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetProductOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, ViewModels.Orders.ProductsViewModel product, int pageIndex, int pageSize);

        [NonAction]
        public override System.Web.Mvc.JsonResult GetProduct(ViewModels.Orders.ProductsViewModel product, int pageIndex, int pageSize)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetProduct);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "product", product);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "pageIndex", pageIndex);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "pageSize", pageSize);
            GetProductOverride(callInfo, product, pageIndex, pageSize);
            return callInfo;
        }

        [NonAction]
        partial void DeleteProductOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, int idDelete);

        [NonAction]
        public override System.Web.Mvc.JsonResult DeleteProduct(int idDelete)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DeleteProduct);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "idDelete", idDelete);
            DeleteProductOverride(callInfo, idDelete);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            CreateOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Models.Product product, System.Web.HttpPostedFileBase file);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create(Models.Product product, System.Web.HttpPostedFileBase file)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "product", product);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "file", file);
            CreateOverride(callInfo, product, file);
            return callInfo;
        }

        [NonAction]
        partial void GetInfoEditOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, int idEdit);

        [NonAction]
        public override System.Web.Mvc.JsonResult GetInfoEdit(int idEdit)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetInfoEdit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "idEdit", idEdit);
            GetInfoEditOverride(callInfo, idEdit);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, ViewModels.Orders.ProductsViewModel product);

        [NonAction]
        public override System.Web.Mvc.JsonResult Edit(ViewModels.Orders.ProductsViewModel product)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "product", product);
            EditOverride(callInfo, product);
            return callInfo;
        }

        [NonAction]
        partial void OrederCustomerOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult OrederCustomer()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.OrederCustomer);
            OrederCustomerOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetListProductOverride(T4MVC_System_Web_Mvc_JsonResult callInfo);

        [NonAction]
        public override System.Web.Mvc.JsonResult GetListProduct()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetListProduct);
            GetListProductOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114