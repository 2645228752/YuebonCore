#pragma checksum "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\CMS\Views\ArticleComments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a021949a941c0563ae6aa3ece8af7795f26493c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_CMS_Views_ArticleComments_Index), @"mvc.1.0.view", @"/Areas/CMS/Views/ArticleComments/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a021949a941c0563ae6aa3ece8af7795f26493c3", @"/Areas/CMS/Views/ArticleComments/Index.cshtml")]
    public class Areas_CMS_Views_ArticleComments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/daterangepicker/daterangepicker.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/daterangepicker/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/daterangepicker/daterangepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\CMS\Views\ArticleComments\Index.cshtml"
  
    ViewData["Title"] = "文章管理-留言管理";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.CurrentMenuP = "ArticleNews";
    ViewBag.CurrentMenu = "ArticleComments/List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card card-default"">
            <div class=""card-header"">
                <h3 class=""card-title"">查询条件</h3>
                <div class=""card-tools"">
                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse""><i class=""fas fa-minus""></i></button>
                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove""><i class=""fas fa-remove""></i></button>
                </div>
            </div>
            <div class=""card-body collapse show"" id=""searchCondition"">
                <div class=""row"">
                    <div class=""col-2"">
                        <div class=""input-group mb-3"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">分类</span>
                            </div>
                            <select class=""select2"" style=""width: 70%; height:38px;"" name=""CategoryId"" id=""CategoryId"">
      ");
            WriteLiteral("                          <option");
            BeginWriteAttribute("value", " value=\"", 1243, "\"", 1251, 0);
            EndWriteAttribute();
            WriteLiteral(@">==请选择分类==</option>
                            </select>
                        </div>
                    </div>
                    <div class="" col-2"">
                        <div class=""input-group mb-3"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">标题</span>
                            </div>
                            <input type=""text"" name=""Title"" id=""Title"" class=""form-control"" placeholder=""文章标题"">
                        </div>
                    </div>
                    <div class="" col-2"">
                        <div class=""input-group mb-3"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">内容</span>
                            </div>
                            <input type=""text"" name=""Description"" id=""Description"" class=""form-control"" placeholder=""留言内容"">
                        </div>
                    </div>
    ");
            WriteLiteral(@"                <div class=""col-2"">
                        <div class=""input-group mb-3"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">状态</span>
                            </div>
                            <select class=""select2"" style=""width: 70%; height:38px;"" name=""EnabledFlag"" id=""EnabledFlag"">
                                <option");
            BeginWriteAttribute("value", " value=\"", 2704, "\"", 2712, 0);
            EndWriteAttribute();
            WriteLiteral(@">==全部==</option>
                                <option value=""0"">禁用</option>
                                <option value=""1"">启用</option>
                            </select>
                        </div>
                    </div>
                    <div class=""col-2"">
                        <div class=""input-group mb-3"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">删除</span>
                            </div>
                            <select class=""select2"" style=""width: 70%; height:38px;"" name=""DeleteFlag"" id=""DeleteFlag"">
                                <option");
            BeginWriteAttribute("value", " value=\"", 3386, "\"", 3394, 0);
            EndWriteAttribute();
            WriteLiteral(@">==全部==</option>
                                <option value=""0"">未删除</option>
                                <option value=""1"">已删除</option>
                            </select>
                        </div>
                    </div>
                    <div class=""col-3"">
                        <div class=""input-group mb-3"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"">用户信息</span>
                            </div>
                            <input type=""text"" name=""NickName"" id=""NickName"" class=""form-control"" placeholder=""账号/昵称/姓名/手机号"">
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""far fa-clock""></i>发布时间</span>
                            </div>
                         ");
            WriteLiteral(@"   <input type=""text"" class=""form-control float-right"" id=""addTime"">
                            <input type=""hidden"" id=""addstartTime"">
                            <input type=""hidden"" id=""addendTime"">
                        </div>
                    </div>
                    <div class=""col-1"">
                        <button type=""button"" class=""btn btn-primary"" id=""btnSearch""><i class=""fas fa-search""></i>查询</button>
                    </div>
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-body"">

                <div id=""toolbar"">
                    <div class=""btn-group"">
");
#nullable restore
#line 98 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\CMS\Views\ArticleComments\Index.cshtml"
                         if (@ViewBag.AuthorizeKey.CanUpdateEnable)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <button type=""button"" class=""btn btn-secondary"" onclick=""EnableByIds('0','/CMS/ArticleComments')""><i class="" fa fa-stop-circle""></i>禁用</button>
                            <button type=""button"" class=""btn btn-success"" onclick=""EnableByIds('1','/CMS/ArticleComments')""><i class="" fa fa-play-circle""></i>启用</button>
");
#nullable restore
#line 102 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\CMS\Views\ArticleComments\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\CMS\Views\ArticleComments\Index.cshtml"
                         if (@ViewBag.AuthorizeKey.CanDeleteSoft)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <button id=""btn_delete"" type=""button"" class=""btn btn-warning"" onclick=""DeleteByIds('/CMS/ArticleComments/DeleteSoftByIds')"">
                                <i class=""fas fa-trash-alt"" aria-hidden=""true""></i>软删除
                            </button>
");
#nullable restore
#line 108 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\CMS\Views\ArticleComments\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\CMS\Views\ArticleComments\Index.cshtml"
                         if (@ViewBag.AuthorizeKey.CanDelete)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <button id=""btn_delete"" type=""button"" class=""btn btn-danger"" onclick=""DeleteByIds('/CMS/ArticleComments/DeleteByIds')"">
                                <i class=""fas fa-trash-alt"" aria-hidden=""true""></i>删除
                            </button>
");
#nullable restore
#line 114 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\CMS\Views\ArticleComments\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <table id=\"tbGrid\"></table>\r\n            </div>\r\n            <!-- /.card-body -->\r\n        </div>\r\n        <!-- /.card -->\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a021949a941c0563ae6aa3ece8af7795f26493c312864", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a021949a941c0563ae6aa3ece8af7795f26493c313979", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a021949a941c0563ae6aa3ece8af7795f26493c315019", async() => {
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
<script>
    $(function () {
        //iCheck for checkbox and radio inputs
        $('input[type=""checkbox""].flat-red').iCheck({
            checkboxClass: 'icheckbox_minimal-blue',
            radioClass: 'iradio_minimal',
        });
        $('.select2').select2();
        //1.初始化Table
        var oTable = new TableInit();
        oTable.Init();
        InitDictItem();
        $('#addTime').daterangepicker({
            autoUpdateInput: false,
            showDropdowns:true,
            locale: {
                format: 'YYYY/MM/DD',
                applyLabel:""确认"",
                cancelLabel: ""取消"",
                monthNames: [
                    ""1"",
                    ""2"",
                    ""3"",
                    ""4"",
                    ""5"",
                    ""6"",
                    ""7"",
                    ""8"",
                    ""9"",
                    ""10"",
                    ""11"",
                    ""12""
                ]
            }
        }, f");
            WriteLiteral(@"unction (start, end, label) {
           $('#addstartTime').val(start.format('YYYY-MM-DD'));
           $('#addendTime').val(end.format('YYYY-MM-DD'));
        });
         $('#addTime').on('apply.daterangepicker', function(ev, picker) {
            $(this).val(picker.startDate.format('YYYY-MM-DD') + ' - ' + picker.endDate.format('YYYY-MM-DD'));
          });
          $('#addTime').on('cancel.daterangepicker', function(ev, picker) {
              $(this).val('');
          });

        $(""#btnSearch"").click(function () {
            $('#tbGrid').bootstrapTable('refresh');
        });
    });
    var $table = $('#tbGrid');
    var TableInit = function () {
        var oTableInit = new Object();
        var keywords = """";
        //初始化Table
        oTableInit.Init = function () {
            $table.bootstrapTable({
                url: '/CMS/ArticleComments/FindWithPager',         //请求后台的URL（*）
                method: 'get',                      //请求方式（*）
                toolbar: '#tool");
            WriteLiteral(@"bar',                //工具按钮用哪个容器
                striped: true,                      //是否显示行间隔色
                cache: false,                       //是否使用缓存，默认为true，所以一般情况下需要设置一下这个属性（*）
                pagination: true,                   //是否显示分页（*）
                sortable: true,                     //是否启用排序
                sortOrder: ""desc"",                   //排序方式
                queryParams: oTableInit.queryParams,//传递参数（*）
                sidePagination: ""server"",           //分页方式：client客户端分页，server服务端分页（*）
                pageNumber: 1,                       //初始化加载第一页，默认第一页
                pageSize: 25,                       //每页的记录行数（*）
                pageList: [10, 25, 50, 100],        //可供选择的每页的行数（*）
                showColumns: true,                  //是否显示所有的列
                showRefresh: true,                  //是否显示刷新按钮
                minimumCountColumns: 2,             //最少允许的列数
                clickToSelect: true,                //是否启用点击选中行
                //height: $(window)");
            WriteLiteral(@".height(),                        //行高，如果没有设置height属性，表格自动根据记录条数觉得表格高度
                search: false,
                strictSearch: true,
                uniqueId: ""ID"",                     //每一行的唯一标识，一般为主键列
                showToggle: true,                    //是否显示详细视图和列表视图的切换按钮
                cardView: false,                    //是否显示详细视图
                detailView: false,                   //是否显示父子表
                columns: [
                    {
                        checkbox: true
                    },{
                        field: 'Description',
                        title: '留言内容',
                        sortable: true
                    }, {
                        field: 'Title',
                        title: '标题',
                        sortable: true,
                        formatter: function (value, row, index) {
                            var htmlvalue = value;
                            if (row.ImgUrl != """" && row.ImgUrl != null) {
                          ");
            WriteLiteral(@"      htmlvalue += '&nbsp;<img  src=\""' + row.ImgUrl + '\"" width=""20"" height=""20""/>';
                            }
                            if (row.LinkUrl != """" && row.LinkUrl != null) {
                                htmlvalue += '&nbsp;<a  href=\""' + row.LinkUrl + '\"" >外链</a>';
                            }
                            return htmlvalue;
                        }
                    },
                     
                    {
                        field: 'CategoryName',
                        title: '所属分类',
                        sortable: true
                    }, {
                        field: 'NickName',
                        title: '留言人',
                        sortable: true,
                        formatter: function (value, row, index) {
                            var htmlvalue = """";
                            if (row.NickName != """" && row.NickName != null) {
                                htmlvalue += value + ""<br/>"";
                      ");
            WriteLiteral(@"      }
                            if (row.RealName != """" && row.RealName != null) {
                                htmlvalue += row.RealName + ""<br/>"";;
                            }
                            if (row.MobilePhone != """" && row.MobilePhone != null) {
                                htmlvalue += row.MobilePhone;
                            }
                            return htmlvalue;
                        }
                    }, {
                        field: 'CreatorTime',
                        title: '留言时间',
                        sortable: true,
                        align: ""center""
                    }, {
                        field: 'TotalGood',
                        title: '点赞',
                        sortable: true
                    }, {
                        field: 'EnabledMark',
                        title: '状态',
                        sortable: true,
                        align: ""center"",
                        formatter: function");
            WriteLiteral(@" (value, row, index) {
                            return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#28a745\"">启用</i>' : ""<i class=\""fas fa-toggle-off\"">禁用</i>"";
                        }
                    },
                    {
                        field: 'DeleteMark',
                        title: '删除',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#ff0000\"">是</i>' : ""<i class=\""fas fa-toggle-off\"">否</i>"";
                        }
                    }
                ],
                onSearch: function (text) {
                    keywords = text;
                    return true;
                },
            });
        };

        //得到查询的参数
        oTableInit.queryParams = function (params) {
            var temp = {   //这里的键的名字和控制器的变量名必须一直，这边改动，控制器也需要改成一样的
                ");
            WriteLiteral(@"limit: params.limit,   //页面大小
                offset: params.offset,  //页码
                order: params.order,
                sort: params.sort,
                categoryId: $(""#CategoryId"").val(),
                title: $(""#Title"").val(),
                description: $(""#Description"").val(),
                nickName: $(""#NickName"").val(),
                addstartTime: $(""#addstartTime"").val(),
                addendTime: $(""#addendTime"").val(),
                enabledflag: $(""#EnabledFlag"").val(),
                deleteflag: $(""#DeleteFlag"").val()
            };
            return temp;
        };
        return oTableInit;
    };

    //初始化数据字典
    function InitDictItem() {
        BindSelect2(""CategoryId"", ""/CMS/ArticleCategory/FindTreeSelectJson"");
    }
    //新增、修改或查看明细信息（绑定显示数据）
    function ShowEditOrViewDialog(view) {
        if (view != null) {
            //首先取出来用户选择的数据的ID
            var rows = $table.bootstrapTable('getSelections');
            //首先取出来值判断用户只能选择一个
     ");
            WriteLiteral(@"       if (rows.length == 0) {
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
            window.location.href = ""/CMS/ArticleNews/Edit""
        } else if (view == ""edit"") {
            //处理修改的信息
            //$('#addFormModal').modal('show');  //手动显示
            //$('#addFormModal').find('.modal-title').text(""编辑"");
            ////绑定修改详细信息的方法
            //BindEditInfo();
            var ID = $table.bootstrapTable('getSelections')[0].Id;  //获取到了用用户选择的ID
            window.location.href = ""/CMS/ArticleNews/Edit/?id="" + ID;
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
