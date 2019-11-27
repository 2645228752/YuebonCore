#pragma checksum "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "174f471fd8ad3111e5104ebc9b1783de260a97dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Security_Views_Function_Index), @"mvc.1.0.view", @"/Areas/Security/Views/Function/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"174f471fd8ad3111e5104ebc9b1783de260a97dd", @"/Areas/Security/Views/Function/Index.cshtml")]
    public class Areas_Security_Views_Function_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml"
  
    ViewData["Title"] = "系统功能-系统管理";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.CurrentMenuP = "Security";
    ViewBag.CurrentMenu = "Function/List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <div id=\"toolbar\" class=\"btn-group\">\r\n");
#nullable restore
#line 12 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml"
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
#line 17 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml"
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
#line 23 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanUpdateEnable)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <button type=""button"" class=""btn btn-secondary"" onclick=""EnableByIds('0','/Security/function')""><i class="" fa fa-stop-circle""></i>禁用</button>
                        <button type=""button"" class=""btn btn-success"" onclick=""EnableByIds('1','/Security/function')""><i class="" fa fa-play-circle""></i>启用</button>
");
#nullable restore
#line 28 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanDeleteSoft)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <button id=""btn_delete"" type=""button"" class=""btn btn-warning"" onclick=""DeleteByIds('/Security/function/DeleteSoftByIds')"">
                            <i class=""fas fa-trash-alt"" aria-hidden=""true""></i>软删除
                        </button>
");
#nullable restore
#line 34 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanDelete)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <button id=""btn_delete"" type=""button"" class=""btn btn-danger"" onclick=""DeleteByIds('/Security/function/DeleteByIds')"">
                            <i class=""fas fa-trash-alt"" aria-hidden=""true""></i>删除
                        </button>
");
#nullable restore
#line 40 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Security\Views\Function\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
                <table id=""tbGrid""></table>
            </div>
            <!-- /.card-body -->
        </div>
        <!-- /.card -->
    </div>
</div>

<div class=""modal fade"" id=""addFormModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addFormModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <form class=""form-horizontal"" id=""frmSubmit"" method=""post"" novalidate=""novalidate"" enctype=""multipart/form-data"">
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
            WriteLiteral(@"                 <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""FullName"" class=""col-form-label col-2"">名称:</label>
                                    <input type=""text"" class=""form-control col-10"" name=""FullName"" id=""FullName"" placeholder=""请输入功能名称"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""EnCode"" class=""col-form-label col-2"">编码:</label>
                                    <input type=""text"" class=""form-control col-10"" name=""EnCode"" id=""EnCode"" placeholder=""请输入功能编码"">
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <di");
            WriteLiteral(@"v class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""SystemTypeId"" class=""col-form-label col-2"">系统:</label>
                                    <select class=""form-control select2  col-10"" name=""SystemTypeId"" id=""SystemTypeId"">
                                        <option");
            BeginWriteAttribute("value", " value=\"", 4722, "\"", 4730, 0);
            EndWriteAttribute();
            WriteLiteral(@">==请选择所属系统==</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""ParentId"" class=""col-form-label col-2"">上级:</label>
                                    <select class=""form-control select2  col-10"" name=""ParentId"" id=""ParentId"">
                                        <option");
            BeginWriteAttribute("value", " value=\"", 5319, "\"", 5327, 0);
            EndWriteAttribute();
            WriteLiteral(@">==请选择上级功能==</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""txtIcon"" class=""col-form-label col-2"">图标:</label>
                                    <div class=""input-group col-10"">
                                        <input type=""text"" class=""form-control "" name=""Icon"" id=""Icon"">
                                        <span class=""input-group-append"">
                                            <button type=""button"" onclick=""SelectIcon()"" class=""btn btn-primary btn-flat"">...</button>
                                        </span>
                                    </div>
                                </div>
         ");
            WriteLiteral(@"                   </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""SortCode"" class=""col-form-label col-2"">排序:</label>
                                    <input type=""text"" class=""form-control col-10"" name=""SortCode"" id=""SortCode"" placeholder=""请输入排序号"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-1""><label for=""recipient-name"" class=""col-form-label"">选项:</label></div>
                            <div class=""col-11"">
                                <label for=""IsPublic"">
                                    <input type=""checkbox"" class=""flat-red"" name=""IsPublic"" id=""IsPublic"">
                       ");
            WriteLiteral(@"             公共
                                </label>
                                <label for=""EnabledMark"">
                                    <input type=""checkbox"" class=""flat-red"" checked=""checked"" name=""EnabledMark"" id=""EnabledMark"">
                                    有效
                                </label>
");
            WriteLiteral(@"                                <label for=""AllowDelete"">
                                    <input type=""checkbox"" class=""flat-red"" name=""AllowDelete"" id=""AllowDelete"">
                                    允许删除
                                </label>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""Description"" class=""col-form-label"">描述:</label>
                        <textarea class=""form-control"" id=""Description"" name=""Description""></textarea>
                    </div>

                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-1""><label for=""recipient-name"" class=""col-form-label"">批量:</label></div>
                            <div class=""col-11"">
                                <label for=""IsPublic"">
                                    <input type=""checkbox"" class=""flat-red"" name=""AllowEdit"" i");
            WriteLiteral(@"d=""AllowEdit"">
                                    批量添加功能，含列表、添加、修改、禁用、启用、软删除和删除
                                </label>
                            </div>
                        </div>
                    </div>
                    <input type=""hidden"" id=""Id"" name=""Id""");
            BeginWriteAttribute("value", " value=\"", 9266, "\"", 9274, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-primary btnSave"" id=""btnSaveOK""><i class=""fa fa-save""></i>保存</button>
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal""><i class=""fa fa-close""></i>关闭</button>
                </div>
            </form>
        </div>
    </div>
</div>

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
        oTableInit.Init = functio");
            WriteLiteral(@"n () {
            $table.bootstrapTable({
                url: '/Security/Function/FindWithPager',         //请求后台的URL（*）
                method: 'get',                      //请求方式（*）
                toolbar: '#toolbar',                //工具按钮用哪个容器
                striped: true,                      //是否显示行间隔色
                cache: false,                       //是否使用缓存，默认为true，所以一般情况下需要设置一下这个属性（*）
                pagination: true,                   //是否显示分页（*）
                sortable: true,                     //是否启用排序
                sortOrder: ""asc"",                   //排序方式
                queryParams: oTableInit.queryParams,//传递参数（*）
                sidePagination: ""server"",           //分页方式：client客户端分页，server服务端分页（*）
                pageNumber: 1,                       //初始化加载第一页，默认第一页
                pageSize: 25,                       //每页的记录行数（*）
                pageList: [10, 25, 50, 100],        //可供选择的每页的行数（*）
                search: true,                       //是否显示表格搜索，此搜索是客户端搜索，");
            WriteLiteral(@"不会进服务端，所以，个人感觉意义不大
                strictSearch: true,
                showColumns: true,                  //是否显示所有的列
                showRefresh: true,                  //是否显示刷新按钮
                minimumCountColumns: 2,             //最少允许的列数
                clickToSelect: true,                //是否启用点击选中行
                //height: $(window).height(),                        //行高，如果没有设置height属性，表格自动根据记录条数觉得表格高度
                uniqueId: ""ID"",                     //每一行的唯一标识，一般为主键列
                showToggle: true,                    //是否显示详细视图和列表视图的切换按钮
                cardView: false,                    //是否显示详细视图
                detailView: false,                   //是否显示父子表
                searchOnEnterKey: true,
                searchText: keywords,
                columns: [
                    {
                        checkbox: true
                    }, {
                        field: 'FullName',
                        title: '功能名称',
                        sortable: true,
        ");
            WriteLiteral(@"                searchable: true,
                    }, {
                        field: 'EnCode',
                        title: '功能编码',
                        sortable: true,
                        searchable: true,
                    }, {
                        field: 'Icon',
                        title: '图标',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return '<i class=""' + value + '""></i>'
                        }
                    }, {
                        field: 'ParentName',
                        title: '上级功能',
                        sortable: true
                    }, {
                        field: 'SortCode',
                        title: '排序',
                        sortable: true,
                        align: ""center""
                    }, {
                        field: 'IsPublic',
                        title: '公共',");
            WriteLiteral(@"
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#28a745\""></i>' : ""<i class=\""fas fa-toggle-off\""></i>""
                        }
                    },  {
                        field: 'SystemTypeName',
                        title: '所属系统',
                        sortable: true
                    }, {
                        field: 'CreatorTime',
                        title: '创建时间',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return value.substring(0, 10);
                        }
                    },
                    {
                        field: 'EnabledMark',
                        title: '状态',
                        sortable: true,
                    ");
            WriteLiteral(@"    align: ""center"",
                        formatter: function (value, row, index) {
                            return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#28a745\"">启用</i>' : ""<i class=\""fas fa-toggle-off\"">禁用</i>""
                        }
                    },{
                        field: 'DeleteMark',
                        title: '删除',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#f00\"">是</i>' : ""<i class=\""fas fa-toggle-off\"">否</i>""
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
            var temp = {   //这里的键的名字和控制器的变量名必");
            WriteLiteral(@"须一直，这边改动，控制器也需要改成一样的
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
            url: ""/Security/function/FindTreeSelectJson"",
        });
        $(""#SystemTypeId"").bindSelect({
            url: ""/Security/SystemType/FindTreeSelectJson"",
        });
    }
    //选择图标
    function SelectIcon() {
        window.open(""https://fontawesome.com/icons?d=gallery&m=free"");
    }
    //新增、修改或查看明细信息（绑定显示数据）
    function ShowEditOrViewDialog(view) {
        if (view != null) {
            //首先取出来用户选择的数据的ID
            var rows = $table.bootstrapTable('getSelections');
            //首先取出来值判断用户只能选择一个
            if (rows.length == 0) {
    ");
            WriteLiteral(@"            toastr.warning(""请选择一条记录"");
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
        }
    }

    //绑定编辑详细信息的方法
    function BindEditInfo() {
        //首先用户发送一个异步请求去后台实现方法
        var ID = $table.bootstrapTable('getSelections')[0].Id;  //获取到了用用户选择的ID
        $.getJSON(""/Security/function/GetById?r="" + Math.random() + ""&id="" + ID, function (info) {
            //赋值有几种");
            WriteLiteral(@"方式：.datebox('setValue', info.Birthday);.combobox('setValue', info.Status);.val(info.Name);
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
                    }
                },
                messages: {
                    FullName: {
                        required: ""请输入功能名称"",
                        minlength: ""菜单名称至少2个字符""
                    },
                    EnCode: {
                        required: ""请输入功能编码"",
  ");
            WriteLiteral(@"                      minlength: ""功能编码至少2个字符""
                    },
                    SystemTypeId: {
                        required: ""请选择所属系统""
                    }
                },
                errorClass: 'help-block help-block-error',
                focusInvalid: true,
                //unhighlight: function (element, errorClass, validClass) { //验证通过
                //    $(element).tooltip('destroy').removeClass(errorClass);
                //},
                highlight: function (element) {//验证未通过
                    $(element).closest('.form-group').addClass('has-error');
                },
                success: function (label, element) {
                    $(element).closest('.form-group').removeClass('has-error');
                    //label.remove();
                    $(element).attr(""title"", """").tooltip(""hide"");
                    //alert(element);
                },
                errorPlacement: function (error, element) {
                    //element.pa");
            WriteLiteral(@"rent('div').append(error);
                    if ($(element).next(""div"").hasClass(""tooltip"")) {
                        $(element).attr(""data-original-title"", $(error).text()).tooltip(""show"");
                    } else {
                        $(element).attr(""title"", $(error).text()).tooltip(""show"");
                    }
                },
                submitHandler: function (form) {
                    //var postData = $(""#frmSubmit"").serializeArray();
                    //var postData = $(""#frmSubmit"").formSerialize();
                    var postData = {
                        ""Id"": $(""#Id"").val(),
                        ""FullName"": $(""#FullName"").val(),
                        ""EnCode"": $(""#EnCode"").val(),
                        ""ParentId"": $(""#ParentId"").val(),
                        ""SystemTypeId"": $(""#SystemTypeId"").val(),
                        ""SortCode"": $(""#SortCode"").val(),
                        ""Icon"": $(""#Icon"").val(),
                        ""IsPublic"": $(""#Is");
            WriteLiteral(@"Public"").is(':checked'),
                        ""EnabledMark"": $(""#EnabledMark"").is(':checked'),
                        ""AllowEdit"": $(""#AllowEdit"").is(':checked'),
                        ""AllowDelete"": $(""#AllowDelete"").is(':checked'),
                        ""Description"": $(""#Description"").val()
                    };
                    var keyValue = $(""#Id"").val();
                    var reqUrl = ""/Security/function/Insert"";
                    if (keyValue != """" && keyValue != null && keyValue != ""null"") {
                        reqUrl = ""/Security/function/Update?id="" + keyValue;
                    }
                    $.ajax({
                        url: reqUrl,
                        data: postData,
                        dataType: 'json',//服务器返回json格式数据
                        type: 'post',//HTTP请求类型
                        timeout: 100000,//超时时间设置为10秒；
                        success: function (data) {
                            //服务器返回响应，根据响应结果，分析是否登录成功；
            ");
            WriteLiteral(@"                if (data.Success) {
                                toastr.success(""操作成功"");
                                $(""#frmSubmit"")[0].reset();
                                $('#addFormModal').modal('hide');  //手动关闭
                                setTimeout(function () {
                                    $table.bootstrapTable('refresh');
                                }, 1500);
                            } else {
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
