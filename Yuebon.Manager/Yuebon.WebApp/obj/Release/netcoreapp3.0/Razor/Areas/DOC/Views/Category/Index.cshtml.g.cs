#pragma checksum "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c845a74d691e20576a4ba3fe461ef156e2673e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DOC_Views_Category_Index), @"mvc.1.0.view", @"/Areas/DOC/Views/Category/Index.cshtml")]
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
#line 7 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
using Yuebon.WebApp.Commons;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c845a74d691e20576a4ba3fe461ef156e2673e0", @"/Areas/DOC/Views/Category/Index.cshtml")]
    public class Areas_DOC_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-treegrid/css/jquery.treegrid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap-table/extensions/treegrid/bootstrap-table-treegrid.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-treegrid/js/jquery.treegrid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "文库管理-文库类型";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.CurrentMenuP = "Document";
    ViewBag.CurrentMenu = "Category/List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <div id=\"toolbar\" class=\"btn-group\">\r\n");
#nullable restore
#line 13 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanInsert)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <button id=""btn_add"" type=""button"" class=""btn btn-primary"" data-toggle=""modal"" onclick=""ShowEditOrViewDialog()"" data-whatever=""新增"">
                            <i class=""fas fa-plus"" aria-hidden=""true""></i>新增
                        </button>
");
#nullable restore
#line 18 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanUpdate)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <button id=""btn_edit"" type=""button"" class=""btn btn-info"" data-toggle=""modal"" onclick=""ShowEditOrViewDialog('edit')"" data-whatever=""修改"">
                            <i class=""fas fa-edit"" aria-hidden=""true""></i>修改
                        </button>
");
#nullable restore
#line 24 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanUpdateEnable)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <button type=""button"" class=""btn btn-secondary"" onclick=""EnableByIds('0','/Doc/Category')""><i class="" fa fa-stop-circle""></i>禁用</button>
                        <button type=""button"" class=""btn btn-success"" onclick=""EnableByIds('1','/Doc/Category')""><i class="" fa fa-play-circle""></i>启用</button>
");
#nullable restore
#line 29 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanDeleteSoft)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <button id=""btn_delete"" type=""button"" class=""btn btn-warning"" onclick=""DeleteByIds('/Doc/Category/DeleteSoftByIds')"">
                            <i class=""fas fa-trash-alt"" aria-hidden=""true""></i>软删除
                        </button>
");
#nullable restore
#line 35 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanDelete)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <button id=""btn_delete"" type=""button"" class=""btn btn-danger"" onclick=""DeleteByIds('/Doc/Category/DeleteByIds')"">
                            <i class=""fas fa-trash-alt"" aria-hidden=""true""></i>删除
                        </button>
");
#nullable restore
#line 41 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\DOC\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <table id=\"tbGrid\"></table>\r\n            </div>\r\n            <!-- /.card-body -->\r\n        </div>\r\n        <!-- /.card -->\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0c845a74d691e20576a4ba3fe461ef156e2673e09059", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c845a74d691e20576a4ba3fe461ef156e2673e010174", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c845a74d691e20576a4ba3fe461ef156e2673e011214", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- page script -->
<script>
    $(function () {
        //1.初始化Table
        var oTable = new TableInit();
        oTable.Init();

        InitDictItem();
    });

    //加载数据表格
    var $table = $('#tbGrid');
    var TableInit = function () {
        var oTableInit = new Object();
        var keywords = """";
        //初始化Table
        oTableInit.Init = function () {
            $table.bootstrapTable({
                url: '/Doc/Category/GetAll',         //请求后台的URL（*）
                method: 'get',                      //请求方式（*）
                toolbar: '#toolbar',                //工具按钮用哪个容器
                striped: true,
                sidePagination: 'server',
                sortable: false,
                queryParams: oTableInit.queryParams,//传递参数（*）
                //search: true,                       //是否显示表格搜索，此搜索是客户端搜索，不会进服务端，所以，个人感觉意义不大
                //strictSearch: true,
                showColumns: true,                  //是否显示所有的列
                showRefresh: true");
            WriteLiteral(@",                  //是否显示刷新按钮
                minimumCountColumns: 2,             //最少允许的列数
                clickToSelect: true,                //是否启用点击选中行
                search: true,
                searchOnEnterKey: true,
                searchText: keywords,
                idField: 'Id',
                columns: [
                    {
                        checkbox: true
                    }, {
                        field: 'Title',
                        title: '标题',
                        sortable: true,
                        searchable: true,
                    }, {
                        field: 'ImgUrl',
                        title: '图片',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return '<img  src=\""' + value + '\"" width=""150"" height=""50""/>'
                        }
                    }, {
                        field: 'CreatorTi");
            WriteLiteral(@"me',
                        title: '创建时间',
                        sortable: true,
                        align: ""center"",
                    }, {
                        field: 'SortCode',
                        title: '排序',
                        sortable: true
                    },
                    {
                        field: 'EnabledMark',
                        title: '状态',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#28a745\"">启用</i>' : ""<i class=\""fas fa-toggle-off\"" >禁用</i>"";
                        }
                    }, {
                        field: 'DeleteMark',
                        title: '删除',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                           ");
            WriteLiteral(@" return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#ff0000\"">是</i>' : ""<i class=\""fas fa-toggle-off\"">否</i>"";
                        }
                    }
                ],
                treeShowField: 'Title',
                parentIdField: 'ParentId',
                onLoadSuccess: function (data) {
                    $table.treegrid({
                        treeColumn: 1,
                        onChange: function () {
                            $table.bootstrapTable('resetWidth');
                        }
                    });
                },
                onSearch: function (text) {
                    keywords = text;
                    return true;
                },
            });
        };

        //得到查询的参数
        oTableInit.queryParams = function (params) {
            var temp = {   //这里的键的名字和控制器的变量名必须一直，这边改动，控制器也需要改成一样的
                limit: params.limit,   //页面大小
                offset: params.offset,  //页码
                order: params.o");
            WriteLiteral(@"rder,
                sort: params.sort,
                search: $(""input[ name='search_text' ] "").val(), //定义传输的搜索参数
            };
            return temp;
        };
        return oTableInit;
    };


    //初始化数据字典
    function InitDictItem() {

    }
    //新增、修改或查看明细信息（绑定显示数据）
    function ShowEditOrViewDialog(view) {
        if (view != null) {
            //首先取出来用户选择的数据的ID
            var rows = $table.bootstrapTable('getSelections');
            //首先取出来值判断用户只能选择一个
            if (rows.length == 0) {
                toastr.warning(""请选择一条记录"");
                return;
            }
            else if (rows.length > 1) {
                toastr.warning(""每次只能修改/查看一条记录，你已经选择了<font color='red'  size='6'>"" + rows.length + ""</font>条"");
                return;
            }
        }
        if (view == null) {
            //处理修改的信息
            window.location.href =""/Doc/Category/Edit""
        } else if (view == ""edit"") {
            //处理修改的信息
            //$('#addFormModal').");
            WriteLiteral(@"modal('show');  //手动显示
            //$('#addFormModal').find('.modal-title').text(""编辑"");
            ////绑定修改详细信息的方法
            //BindEditInfo();
            var ID = $table.bootstrapTable('getSelections')[0].Id;  //获取到了用用户选择的ID
            window.location.href = ""/Doc/Category/Edit/?id="" + ID;
        }
    }
</script>");
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
