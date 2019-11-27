#pragma checksum "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22065b4451244d69ea1e17fa486599098f0bda32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Security_Views_Menu_Index), @"mvc.1.0.view", @"/Areas/Security/Views/Menu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Security/Views/Menu/Index.cshtml", typeof(AspNetCore.Areas_Security_Views_Menu_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22065b4451244d69ea1e17fa486599098f0bda32", @"/Areas/Security/Views/Menu/Index.cshtml")]
    public class Areas_Security_Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-treegrid/css/jquery.treegrid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap-table/extensions/treegrid/bootstrap-table-treegrid.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-treegrid/js/jquery.treegrid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\Menu\Index.cshtml"
   
    ViewData["Title"] = "系统菜单-系统管理";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.CurrentMenuP = "Security";
    ViewBag.CurrentMenu = "Menu/List";

#line default
#line hidden
            BeginContext(173, 164, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <div id=\"toolbar\" class=\"btn-group\">\r\n");
            EndContext();
#line 12 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\Menu\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanInsert)
                    {

#line default
#line hidden
            BeginContext(419, 270, true);
            WriteLiteral(@"                        <button id=""btn_add"" type=""button"" class=""btn btn-primary"" data-toggle=""modal"" onclick=""ShowEditOrViewDialog()"" data-whatever=""新增"">
                            <i class=""fas fa-plus"" aria-hidden=""true""></i>新增
                        </button>
");
            EndContext();
#line 17 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\Menu\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(712, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 18 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\Menu\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanUpdate)
                    {

#line default
#line hidden
            BeginContext(794, 279, true);
            WriteLiteral(@"                        <button id=""btn_edit"" type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" onclick=""ShowEditOrViewDialog('edit')"" data-whatever=""修改"">
                            <i class=""fas fa-edit"" aria-hidden=""true""></i>修改
                        </button>
");
            EndContext();
#line 23 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\Menu\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1096, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 24 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\Menu\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanDelete)
                    {

#line default
#line hidden
            BeginContext(1178, 257, true);
            WriteLiteral(@"                        <button id=""btn_delete"" type=""button"" class=""btn btn-danger"" onclick=""DeleteByIds('/Security/Menu/DeleteByIds')"">
                            <i class=""fas fa-trash-alt"" aria-hidden=""true""></i>删除
                        </button>
");
            EndContext();
#line 29 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\Menu\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1458, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 30 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\Menu\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanUpdateEnable)
                    {

#line default
#line hidden
            BeginContext(1546, 322, true);
            WriteLiteral(@"                        <button type=""button"" class=""btn btn-warning"" onclick=""EnableByIds('0','/Security/Menu')""><i class="" fa fa-stop-circle""></i>禁用</button>
                        <button type=""button"" class=""btn btn-success"" onclick=""EnableByIds('1','/Security/Menu')""><i class="" fa fa-play-circle""></i>启用</button>
");
            EndContext();
#line 34 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\Menu\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1891, 8868, true);
            WriteLiteral(@"                </div>
                <table id=""tbGrid""></table>
            </div>
            <!-- /.card-body -->
        </div>
        <!-- /.card -->
    </div>
</div>

<!-- 添加/编辑信息的弹出层 -->
<div class=""modal fade"" id=""addFormModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addFormModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <form class=""form-horizontal"" id=""frmSubmit"" method=""post"" enctype=""multipart/form-data"">
                <div class=""modal-header bg-primary"">
                    <h5 class=""modal-title"" id=""addFormModalLabel"">新增</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""row"">
                        <div class=""col-6"">
                 ");
            WriteLiteral(@"           <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""FullName"" class=""col-form-label col-2"">名称:</label>
                                    <input type=""text"" class=""form-control col-10"" name=""FullName"" id=""FullName"" placeholder=""请输入菜单名称"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""EnCode"" class=""col-form-label col-2"">编码:</label>
                                    <input type=""text"" class=""form-control col-10"" name=""EnCode"" id=""EnCode"" placeholder=""请输入菜单功能编码"">
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div cl");
            WriteLiteral(@"ass=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""SystemTypeId"" class=""col-form-label col-2"">系统:</label>
                                    <select class=""form-control select2  col-10"" name=""SystemTypeId"" id=""SystemTypeId"">
                                        <option value="""">==请选择所属系统==</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""ParentId"" class=""col-form-label col-2"">上级:</label>
                                    <select class=""form-control select2  col-10"" name=""ParentId"" id=""ParentId"">
                                        <option value="""">==请选择上级菜单==</option>
    ");
            WriteLiteral(@"                                </select>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""UrlAddress"" class=""col-form-label col-2"">链接:</label>
                                    <input type=""text"" class=""form-control col-10"" name=""UrlAddress"" id=""UrlAddress"" placeholder=""请输入链接地址"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""slcTarget"" class=""col-form-label col-2"">目标:</label>
                                    <div class=""inpu");
            WriteLiteral(@"t-group col-10"">
                                        <select class=""form-control select2 "" name=""Target"" id=""Target"">
                                            <option value="""">=请选择链接打开方式=</option>
                                            <option value=""expand"">无页面</option>
                                            <option value=""iframe"">框架页</option>
                                            <option value=""blank"">新窗口</option>
                                            <option value=""openmodal"">弹出层</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""txtIcon"" class=""col-f");
            WriteLiteral(@"orm-label col-2"">图标:</label>
                                    <div class=""input-group col-10"">
                                        <input type=""text"" class=""form-control "" name=""Icon"" id=""Icon"">
                                        <span class=""input-group-append"">
                                            <button type=""button"" onclick=""SelectIcon()"" class=""btn btn-primary btn-flat"">...</button>
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""SortCode"" class=""col-form-label col-2"">排序:</label>
                                    <input type=""number"" class=""form-control col-10"" name=""SortCode"" id=""SortCode"" placeholder=""请输入排序号"">
                   ");
            WriteLiteral(@"             </div>
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-1""><label for=""recipient-name"" class=""col-form-label"">选项:</label></div>
                            <div class=""col-11"">
                                <label for=""IsMenu"">
                                    <input type=""checkbox"" class=""flat-red"" name=""IsMenu"" id=""IsMenu"">
                                    菜单
                                </label>
                                <label for=""IsPublic"">
                                    <input type=""checkbox"" class=""flat-red"" name=""IsPublic"" id=""IsPublic"">
                                    公共
                                </label>
                                <label for=""IsExpand"">
                                    <input type=""checkbox"" class=""flat-red"" name=""IsExpand"" id=""IsExpand"">");
            WriteLiteral(@"
                                    展开
                                </label>
                                <label for=""EnabledMark"">
                                    <input type=""checkbox"" class=""flat-red"" checked=""checked"" name=""EnabledMark"" id=""EnabledMark"">
                                    有效
                                </label>
                                <label for=""AllowEdit"">
                                    <input type=""checkbox"" class=""flat-red"" name=""AllowEdit"" id=""AllowEdit"">
                                    允许编辑
                                </label>
                                <label for=""AllowDelete"">
                                    <input type=""checkbox"" class=""flat-red"" name=""AllowDelete"" id=""AllowDelete"">
                                    允许删除
                                </label>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                  ");
            WriteLiteral(@"      <label for=""Description"" class=""col-form-label"">描述:</label>
                        <textarea class=""form-control"" id=""Description"" name=""Description""></textarea>
                    </div>
                    <input type=""hidden"" id=""Id"" name=""Id"" value="""" />
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-primary btnSave"" id=""btnSaveOK""><i class=""fa fa-save""></i>保存</button>
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal""><i class=""fa fa-close""></i>关闭</button>
                </div>
            </form>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(10759, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22065b4451244d69ea1e17fa486599098f0bda3217941", async() => {
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
            EndContext();
            BeginContext(10835, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(10839, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22065b4451244d69ea1e17fa486599098f0bda3219203", async() => {
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
            EndContext();
            BeginContext(10936, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(10938, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22065b4451244d69ea1e17fa486599098f0bda3220385", async() => {
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
            EndContext();
            BeginContext(11005, 13729, true);
            WriteLiteral(@"
<!-- page script -->
<script>
    $(function () {
        //iCheck for checkbox and radio inputs
        $('input[type=""checkbox""].flat-red').iCheck({
            checkboxClass: 'icheckbox_minimal-blue',
            radioClass: 'iradio_minimal',
        })
        //1.初始化Table
        var oTable = new TableInit();
        oTable.Init();

        InitDictItem();
        BindSaveEvent();
    });

    //加载数据表格
    var $table = $('#tbGrid');
    var TableInit = function () {
        var oTableInit = new Object();
        var keywords = """";
        //初始化Table
        oTableInit.Init = function () {
            $table.bootstrapTable({
                url: '/Security/Menu/GetAll',         //请求后台的URL（*）
                method: 'get',                      //请求方式（*）
                toolbar: '#toolbar',                //工具按钮用哪个容器
                striped: true,
                sidePagination: 'server',
                sortable: false,
                queryParams: oTableInit.queryParams,//传");
            WriteLiteral(@"递参数（*）
                //search: true,                       //是否显示表格搜索，此搜索是客户端搜索，不会进服务端，所以，个人感觉意义不大
                //strictSearch: true,
                showColumns: true,                  //是否显示所有的列
                showRefresh: true,                  //是否显示刷新按钮
                minimumCountColumns: 2,             //最少允许的列数
                clickToSelect: true,                //是否启用点击选中行
                search:true,
                searchOnEnterKey: true,
                searchText: keywords,
                idField: 'Id',
                columns: [
                    {
                        checkbox: true
                    }, {
                        field: 'FullName',
                        title: '名称',
                        sortable: true,
                        searchable: true,
                    }, {
                        field: 'EnCode',
                        title: '功能编码',
                        sortable: true,
                        searchable: true,
         ");
            WriteLiteral(@"           }, {
                        field: 'Icon',
                        title: '图标',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return '<i class=""' + value + '""></i>'
                        }
                    }, {
                        field: 'UrlAddress',
                        title: 'Url地址',
                        sortable: true,
                        searchable: true,
                    }, {
                        field: 'Target',
                        title: '目标',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            var showName = """";
                            if (value == ""iframe"") {
                                showName = ""框架页"";
                            }
                            if (value == ""expan");
            WriteLiteral(@"d"") {
                                showName = ""无页面"";
                            }
                            if (value == ""blank"") {
                                showName = ""新窗口"";
                            }
                            return showName;
                        }
                    }, {
                        field: 'SortCode',
                        title: '排序',
                        sortable: true,
                    }, {
                        field: 'IsMenu',
                        title: '菜单',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#28a745\""></i>' : ""<i class=\""fas fa-toggle-off\""></i>""
                        }
                    }, {
                        field: 'IsExpand',
                        title: '展开',
                        sortable: true,
 ");
            WriteLiteral(@"                       align: ""center"",
                        formatter: function (value, row, index) {
                            return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#28a745\""></i>' : ""<i class=\""fas fa-toggle-off\""></i>""
                        }
                    }, {
                        field: 'IsPublic',
                        title: '公共',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#28a745\""></i>' : ""<i class=\""fas fa-toggle-off\""></i>""
                        }
                    }, {
                        field: 'EnabledMark',
                        title: '有效',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return value ? '<i class=");
            WriteLiteral(@"\""fas fa-toggle-on\"" style=\""color:#28a745\""></i>' : ""<i class=\""fas fa-toggle-off\""></i>""
                        }
                    }, {
                        field: 'SystemTypeName',
                        title: '所属系统'
                    },{
                        field: 'CreatorTime',
                        title: '创建时间',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return value.substring(0, 10);
                        }
                    }
                ],
                treeShowField: 'FullName',
                parentIdField: 'ParentId',
                onLoadSuccess: function (data) {
                    $table.treegrid({
                        treeColumn: 1,
                        onChange: function () {
                            $table.bootstrapTable('resetWidth');
                        }
                    });
              ");
            WriteLiteral(@"  },
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
                order: params.order,
                sort: params.sort,
                search: $(""input[ name='search_text' ] "").val(), //定义传输的搜索参数
            };
            return temp;
        };
        return oTableInit;
    };


    //初始化数据字典
    function InitDictItem() {
        $(""#ParentId"").bindSelect({
            url: ""/Security/Menu/FindTreeSelectJson"",
        });
        $(""#SystemTypeId"").bindSelect({
            url: ""/Security/SystemType/FindTreeSelectJson"",
        });
        
    }
    //选择图标
    function SelectIcon() {
        window.open(""https://fontawesome.com/ic");
            WriteLiteral(@"ons?d=gallery&m=free"");
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
            $('#addFormModal').modal('show');  //手动显示
            $('#addFormModal').find('.modal-title').text(""新增"");
            $(""#Id"").val("""");
        } else if (view == ""edit"") {
            //处理修改的信息
            $('#addFormModal').modal('show');  //手动显示
            $('#addFormModal').find('.modal-title').text(""编辑"");
            //绑定修改详细信息的方法
            BindEditInfo();
");
            WriteLiteral(@"        }
    }

    //绑定编辑详细信息的方法
    function BindEditInfo() {
        //首先用户发送一个异步请求去后台实现方法
        var ID = $table.bootstrapTable('getSelections')[0].Id;  //获取到了用用户选择的ID
        $.getJSON(""/Security/Menu/GetById?r="" + Math.random() + ""&id="" + ID, function (info) {
            //赋值有几种方式：.datebox('setValue', info.Birthday);.combobox('setValue', info.Status);.val(info.Name);
            $(""#Id"").val(info.ResData.Id);
            $(""#frmSubmit"").formSerialize(info.ResData);
        });
    }
    //绑定保存按钮的事件
    function BindSaveEvent() {
        $(""#btnSaveOK"").click(function () {
            $(""#frmSubmit"").validate({
                rules: {
                    FullName: {
                        required: true,
                        minlength: 2
                    },
                    EnCode: {
                        required: true,
                        minlength: 2
                    },
                    SystemTypeId: {
                        required: true
       ");
            WriteLiteral(@"             },
                    Target: {
                        required: true
                    }
                },
                messages: {
                    FullName: {
                        required: ""请输入菜单名称"",
                        minlength: ""菜单名称至少2个字符""
                    },
                    EnCode: {
                        required: ""请输入菜单功能编码"",
                        minlength: ""功能编码至少2个字符""
                    },
                    SystemTypeId: {
                        required: ""请选择所属系统""
                    },
                    Target: {
                        required: ""请选择链接打开方式""
                    }
                },
                errorClass: 'help-block help-block-error',
                focusInvalid: true,
                //unhighlight: function (element, errorClass, validClass) { //验证通过
                //    $(element).tooltip('destroy').removeClass(errorClass);
                //},
                highlight: function (element) {//验证未");
            WriteLiteral(@"通过
                    $(element).closest('.form-group').addClass('has-error');
                },
                success: function (label, element) {
                    $(element).closest('.form-group').removeClass('has-error');
                    //label.remove();
                    $(element).attr(""title"", """").tooltip(""hide"");
                    //alert(element);
                },
                errorPlacement: function (error, element) {
                    //element.parent('div').append(error);
                    if ($(element).next(""div"").hasClass(""tooltip"")) {
                        $(element).attr(""data-original-title"", $(error).text()).tooltip(""show"");
                    } else {
                        $(element).attr(""title"", $(error).text()).tooltip(""show"");
                    }
                },
                submitHandler: function (form) {
                    var postData = {
                        ""Id"": $(""#Id"").val(),
                        ""FullName"": $(""#");
            WriteLiteral(@"FullName"").val(),
                        ""EnCode"": $(""#EnCode"").val(),
                        ""SystemTypeId"": $(""#SystemTypeId"").val(),
                        ""ParentId"": $(""#ParentId"").val(),
                        ""SortCode"": $(""#SortCode"").val(),
                        ""UrlAddress"": $(""#UrlAddress"").val(),
                        ""Target"": $(""#Target"").val(),
                        ""Icon"": $(""#Icon"").val(),
                        ""IsMenu"": $(""#IsMenu"").is(':checked'),
                        ""IsExpand"": $(""#IsExpand"").is(':checked'),
                        ""IsPublic"": $(""#IsPublic"").is(':checked'),
                        ""EnabledMark"": $(""#EnabledMark"").is(':checked'),
                        ""AllowEdit"": $(""#AllowEdit"").is(':checked'),
                        ""AllowDelete"": $(""#AllowDelete"").is(':checked'),
                        ""Description"": $(""#Description"").val()
                    };
                    var keyValue = $(""#Id"").val();
                    var reqUrl = ""/Sec");
            WriteLiteral(@"urity/Menu/Insert"";
                    if (keyValue != """" && keyValue != null && keyValue != ""null"") {
                        reqUrl = ""/Security/Menu/Update?id="" + keyValue;
                    }
                    $.ajax({
                        url: reqUrl,
                        data: postData,
                        dataType: 'json',//服务器返回json格式数据
                        type: 'post',//HTTP请求类型
                        timeout: 100000,//超时时间设置为10秒；
                        success: function (data) {
                            //服务器返回响应，根据响应结果，分析是否登录成功；
                            if (data.Success) {
                                $('#addFormModal').modal('hide');  //手动关闭
                                $(""#frmSubmit"")[0].reset();
                                toastr.success(""操作成功"");
                                setTimeout(function () {
                                    $table.bootstrapTable('refresh');
                                }, 1500);
                            ");
            WriteLiteral(@"} else {
                                toastr.warning(""操作失败："" + data.ErrMsg);
                            }
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            toastr.warning(""操作失败："" + errorThrown);
                        }
                    });
                }
            });
        });
    }
    
</script>");
            EndContext();
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
