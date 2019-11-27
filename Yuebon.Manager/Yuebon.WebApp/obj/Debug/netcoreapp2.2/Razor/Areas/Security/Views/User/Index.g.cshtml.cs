#pragma checksum "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d45bef76f96e44e6bbaa085834fdc5a04dcd1b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Security_Views_User_Index), @"mvc.1.0.view", @"/Areas/Security/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Security/Views/User/Index.cshtml", typeof(AspNetCore.Areas_Security_Views_User_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d45bef76f96e44e6bbaa085834fdc5a04dcd1b7", @"/Areas/Security/Views/User/Index.cshtml")]
    public class Areas_Security_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml"
  
    ViewData["Title"] = "用户管理-系统管理";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.CurrentMenuP = "Security";
    ViewBag.CurrentMenu = "User/List";

#line default
#line hidden
            BeginContext(172, 166, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <div id=\"toolbar\" class=\"btn-group\">\r\n");
            EndContext();
#line 13 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanInsert)
                    {

#line default
#line hidden
            BeginContext(420, 270, true);
            WriteLiteral(@"                        <button id=""btn_add"" type=""button"" class=""btn btn-primary"" data-toggle=""modal"" onclick=""ShowEditOrViewDialog()"" data-whatever=""新增"">
                            <i class=""fas fa-plus"" aria-hidden=""true""></i>新增
                        </button>
");
            EndContext();
#line 18 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(713, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 19 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanUpdate)
                    {

#line default
#line hidden
            BeginContext(795, 279, true);
            WriteLiteral(@"                        <button id=""btn_edit"" type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" onclick=""ShowEditOrViewDialog('edit')"" data-whatever=""修改"">
                            <i class=""fas fa-edit"" aria-hidden=""true""></i>修改
                        </button>
");
            EndContext();
#line 24 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1097, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 25 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanDelete)
                    {

#line default
#line hidden
            BeginContext(1179, 257, true);
            WriteLiteral(@"                        <button id=""btn_delete"" type=""button"" class=""btn btn-danger"" onclick=""DeleteByIds('/Security/User/DeleteByIds')"">
                            <i class=""fas fa-trash-alt"" aria-hidden=""true""></i>删除
                        </button>
");
            EndContext();
#line 30 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1459, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 31 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanUpdateEnable)
                    {

#line default
#line hidden
            BeginContext(1547, 322, true);
            WriteLiteral(@"                        <button type=""button"" class=""btn btn-warning"" onclick=""EnableByIds('0','/Security/User')""><i class="" fa fa-stop-circle""></i>禁用</button>
                        <button type=""button"" class=""btn btn-success"" onclick=""EnableByIds('1','/Security/User')""><i class="" fa fa-play-circle""></i>启用</button>
");
            EndContext();
#line 35 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1892, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 36 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml"
                     if (@ViewBag.AuthorizeKey.CanExtend)
                    {

#line default
#line hidden
            BeginContext(1974, 138, true);
            WriteLiteral("                        <button type=\"button\" class=\"btn btn-info\" onclick=\"ResetPassword()\"><i class=\"fas fa-retweet\"></i>重置密码</button>\r\n");
            EndContext();
#line 39 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Security\Views\User\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2135, 26220, true);
            WriteLiteral(@"                </div>
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
                            <div clas");
            WriteLiteral(@"s=""form-group"">
                                <div class=""row"">
                                    <label for=""Account"" class=""col-form-label col-2"">账号:</label>
                                    <input type=""text"" class=""form-control col-10"" name=""Account"" id=""Account"" placeholder=""请输入账号"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""RealName"" class=""col-form-label col-2"">姓名:</label>
                                    <input type=""text"" class=""form-control col-10"" name=""RealName"" id=""RealName"" placeholder=""请输入姓名"">
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class=""row"">
                        <div class=""col-6"">
       ");
            WriteLiteral(@"                     <div class=""form-group"">
                                <div class=""row"">
                                    <label class=""col-form-label col-2"">性别:</label>
                                    <div class=""input-group col-10"">
                                        <select class=""form-control select2"" style=""width: 80%;"" name=""Gender"" id=""Gender"">
                                            <option value="""">=请选择性别=</option>
                                            <option value=""true"">男</option>
                                            <option value=""false"">女</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""UserPasswor");
            WriteLiteral(@"d"" class=""col-form-label col-2"">密码:</label>
                                    <input type=""password"" class=""form-control col-10"" name=""UserPassword"" id=""UserPassword"" placeholder=""请输入密码"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""OrganizeId"" class=""col-form-label col-2"">公司:</label>
                                    <select class=""form-control select2"" style=""width: 80%;"" name=""OrganizeId"" id=""OrganizeId"">
                                        <option value="""">==请选择所属公司==</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class=""col-6""");
            WriteLiteral(@">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""DepartmentId"" class=""col-form-label col-2"">部门:</label>
                                    <select class=""form-control select2"" style=""width: 80%;"" name=""DepartmentId"" id=""DepartmentId"">
                                        <option value="""">==请选择部门==</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""MobilePhone"" class=""col-form-label col-2"">手机:</label>
                                    <input type=""text"" class=""form-control col-10"" name=""MobilePhone"" id=""MobilePhone"" placehol");
            WriteLiteral(@"der=""请输入手机"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""Birthday"" class=""col-form-label col-2"">生日:</label>
                                    <input type=""text"" class=""form-control col-10"" name=""Birthday"" id=""Birthday"" placeholder=""请输入生日"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""Email"" class=""col-form-label col-2"">Email:</label>
                                    <input type=""email"" class=""form-control col-10"" name=""Em");
            WriteLiteral(@"ail"" id=""Email"" placeholder=""请输入Email"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""WeChat"" class=""col-form-label col-2"">微信:</label>
                                    <input type=""text"" class=""form-control col-10"" name=""WeChat"" id=""WeChat"" placeholder=""请输入微信"">
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class=""row"">
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label for=""DutyId"" class=""col-form-label col-2"">岗位:</label>
                                    <select class=""form-control selec");
            WriteLiteral(@"t2"" style=""width: 80%;"" name=""DutyId"" id=""DutyId"">
                                        <option value="""">==请选择岗位==</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                        <div class=""col-6"">
                            <div class=""form-group"">
                                <div class=""row"">
                                    <label class=""col-form-label col-2"">选项:</label>
                                    <label for=""IsAdministrator"">
                                        <input type=""checkbox"" class=""flat-red"" name=""IsAdministrator"" id=""IsAdministrator"">
                                        系统管理员
                                    </label>
                                    <label for=""EnabledMark"">
                                        <input type=""checkbox"" class=""flat-red"" checked=""checked"" name=""EnabledMark"" id=""EnabledMark"">
                    ");
            WriteLiteral(@"                    有效
                                    </label>
                                    <label for=""DeleteMark"">
                                        <input type=""checkbox"" class=""flat-red"" name=""DeleteMark"" id=""DeleteMark"">
                                        删除
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-1""><label for=""RoleId"" class=""col-form-label"">角色:</label></div>
                            <div class=""col-11"">
                                <select class=""form-control select2"" multiple=""multiple"" style=""width: 100%;"" name=""RoleId"" id=""RoleId"">
                                    <option value="""">==请选择角色==</option>
                                </select>
                            </div>
            ");
            WriteLiteral(@"            </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""Description"" class=""col-form-label"">描述:</label>
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

<!-- page script -->
<script>
    $(function () {
        //iCheck for checkbox and radio inputs
        $('input[type=""checkbox""].flat-red').iCheck({
            checkboxClass: 'icheckbox_minimal-blue',
            radioClass: 'i");
            WriteLiteral(@"radio_minimal',
        })
        //1.初始化Table
        var oTable = new TableInit();
        oTable.Init();
        InitDictItem();
        BindSaveEvent();
    });
    var $table = $('#tbGrid');
    var TableInit = function () {
        var oTableInit = new Object();
        var keywords = """";
        //初始化Table
        oTableInit.Init = function () {
            $table.bootstrapTable({
                url: '/Security/User/FindWithPager',         //请求后台的URL（*）
                method: 'get',                      //请求方式（*）
                toolbar: '#toolbar',                //工具按钮用哪个容器
                striped: true,                      //是否显示行间隔色
                cache: false,                       //是否使用缓存，默认为true，所以一般情况下需要设置一下这个属性（*）
                pagination: true,                   //是否显示分页（*）
                sortable: true,                     //是否启用排序
                sortOrder: ""asc"",                   //排序方式
                queryParams: oTableInit.queryParams,//传递参数（*）
        ");
            WriteLiteral(@"        sidePagination: ""server"",           //分页方式：client客户端分页，server服务端分页（*）
                pageNumber: 1,                       //初始化加载第一页，默认第一页
                pageSize: 25,                       //每页的记录行数（*）
                pageList: [10, 25, 50, 100],        //可供选择的每页的行数（*）
                search: true,                       //是否显示表格搜索，此搜索是客户端搜索，不会进服务端，所以，个人感觉意义不大
                strictSearch: true,
                showColumns: true,                  //是否显示所有的列
                showRefresh: true,                  //是否显示刷新按钮
                minimumCountColumns: 2,             //最少允许的列数
                clickToSelect: true,                //是否启用点击选中行
                //height: $(window).height(),                        //行高，如果没有设置height属性，表格自动根据记录条数觉得表格高度
                uniqueId: ""ID"",                     //每一行的唯一标识，一般为主键列
                showToggle: true,                    //是否显示详细视图和列表视图的切换按钮
                cardView: false,                    //是否显示详细视图
                detailView: false,  ");
            WriteLiteral(@"                 //是否显示父子表
                searchOnEnterKey: true,
                searchText: keywords,
                columns: [
                    {
                        checkbox: true
                    }, {
                        field: 'Account',
                        title: '账户',
                        sortable: true,
                    }, {
                        field: 'RealName',
                        title: '姓名',
                        sortable: true,
                        //formatter: function (value, row, index) {
                        //    var gstr = '<i class=""fas fa-male""></i>';
                        //    if (!row.Gender) {
                        //        gstr = '<i class=""fas fa-female""></i>';
                        //    }
                        //    return value + '(<span style=""font-size:1.2rem;color:red;"">' + gstr + '<span>)';
                        //}
                    }, {
                        field: 'Gender',
                   ");
            WriteLiteral(@"     title: '性别',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return value ? '男' : ""女""
                        }
                    }, {
                        field: 'RoleName',
                        title: '角色',
                        sortable: true
                    }, {
                        field: 'Birthday',
                        title: '生日',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            if (value != null)
                                return value.substring(0, 10);
                        }
                    }, {
                        field: 'MobilePhone',
                        title: '手机',
                        sortable: true,
                    }, {
                        field: 'OrganizeName',
   ");
            WriteLiteral(@"                     title: '所属组织',
                        sortable: true,
                    }, {
                        field: 'DepartmentName',
                        title: '部门',
                        sortable: true,
                    }, {
                        field: 'DutyName',
                        title: '岗位',
                        sortable: true,
                    }, {
                        field: 'IsAdministrator',
                        title: '系统管理员',
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
        ");
            WriteLiteral(@"                formatter: function (value, row, index) {
                            return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#28a745\""></i>' : ""<i class=\""fas fa-toggle-off\""></i>""
                        }
                    }, {
                        field: 'DeleteMark',
                        title: '删除',
                        sortable: true,
                        align: ""center"",
                        formatter: function (value, row, index) {
                            return value ? '<i class=\""fas fa-toggle-on\"" style=\""color:#f00\""></i>' : ""<i class=\""fas fa-toggle-off\""></i>""
                        }
                    }
                ]
            });
        };

        //得到查询的参数
        oTableInit.queryParams = function (params) {
            var temp = {   //这里的键的名字和控制器的变量名必须一直，这边改动，控制器也需要改成一样的
                limit: params.limit,   //页面大小
                offset: params.offset,  //页码
                order: params.order,
                sort");
            WriteLiteral(@": params.sort,
                search: $(""input[ name='search_text']"").val(), //定义传输的搜索参数
            };
            return temp;
        };
        return oTableInit;
    };

    //初始化数据字典
    function InitDictItem() {
        BindSelect2(""OrganizeId"", ""/Security/Organize/FindTreeSelectJson"");
        BindSelect2(""DepartmentId"", ""/Security/Organize/FindTreeSelectJson"");
        BindSelect2(""RoleId"", ""/Security/Role/FindTreeSelectJson"");
        BindSelect2(""DutyId"", ""/Security/Duty/FindTreeSelectJson"");

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
                toastr.warning(""每次只能修改/查看一条记录，你已经选择了<font color='red'  size='6'>"" + rows.length + ""</f");
            WriteLiteral(@"ont>条"");
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
        $.getJSON(""/Security/User/GetById?r="" + Math.random() + ""&id="" + ID, function (info) {
            //赋值有几种方式：.datebox('setValue', info.Birthday);.combobox('setValue', info.Status);.val(info.Name);
            $(""#Id"").val(info.ResData.Id);
            $(""#frmSubmit"").formSerialize(info.ResData);
            $(""#RoleId"").select2(");
            WriteLiteral(@"""val"", info.ResData.RoleId.split(','));
        });
    }
    //绑定保存按钮的事件
    function BindSaveEvent() {
        $(""#btnSaveOK"").click(function () {
            $(""#frmSubmit"").validate({
                rules: {
                    Account: {
                        required: true,
                        minlength: 4
                    },
                    RealName: {
                        required: true,
                        minlength: 2
                    },
                    OrganizeId: {
                        required: true
                    },
                    DepartmentId: {
                        required: true
                    },
                    RoleId: {
                        required: true
                    }, DutyId: {
                        required: true
                    }
                },
                messages: {
                    Account: {
                        required: ""请输入账户"",
                        minlength: ""账户至");
            WriteLiteral(@"少4个字符""
                    },
                    RealName: {
                        required: ""请输入真实姓名"",
                        minlength: ""真实姓名至少2个字符""
                    },
                    OrganizeId: {
                        required: ""请选择归属公司""
                    },
                    DepartmentId: {
                        required: ""请选择所属部门""
                    },
                    RoleId: {
                        required: ""请选择所属角色""
                    },
                    DutyId: {
                        required: ""请选择岗位""
                    }
                },
                errorClass: 'help-block help-block-error',
                focusInvalid: true,
                //unhighlight: function (element, errorClass, validClass) { //验证通过
                //    $(element).tooltip('destroy').removeClass(errorClass);
                //},
                highlight: function (element) {//验证未通过
                    $(element).closest('.form-group').addClass('has-error');");
            WriteLiteral(@"
                },
                success: function (label, element) {
                    $(element).closest('.form-group').removeClass('has-error');
                    $(element).attr(""title"", """").tooltip(""hide"");
                },
                errorPlacement: function (error, element) {
                    if ($(element).next(""div"").hasClass(""tooltip"")) {
                        $(element).attr(""data-original-title"", $(error).text()).tooltip(""show"");
                    } else {
                        $(element).attr(""title"", $(error).text()).tooltip(""show"");
                    }
                },
                submitHandler: function (form) {
                    var roleobj = $(""#RoleId"").select2('data');
                    var roleIds = """";
                    $.each(roleobj, function (i, item) {
                        roleIds += item.id + "","";
                    });
                    roleIds = roleIds.substring(0, roleIds.length - 1);
                    var postData");
            WriteLiteral(@" = {
                        ""Id"": $(""#Id"").val(),
                        ""Account"": $(""#Account"").val(),
                        ""RealName"": $(""#RealName"").val(),
                        ""UserPassword"": $(""#UserPassword"").val(),
                        ""Gender"": $(""#Gender"").val(),
                        ""OrganizeId"": $(""#OrganizeId"").val(),
                        ""DepartmentId"": $(""#DepartmentId"").val(),
                        ""RoleId"": roleIds,
                        ""DutyId"": $(""#DutyId"").val(),
                        ""MobilePhone"": $(""#MobilePhone"").val(),
                        ""Birthday"": $(""#Birthday"").val(),
                        ""Email"": $(""#Email"").val(),
                        ""WeChat"": $(""#WeChat"").val(),
                        ""IsAdministrator"": $(""#IsAdministrator"").is(':checked'),
                        ""EnabledMark"": $(""#EnabledMark"").is(':checked'),
                        ""DeleteMark"": $(""#DeleteMark"").is(':checked'),
                        ""Description"": $(""#D");
            WriteLiteral(@"escription"").val()
                    };
                    var keyValue = $(""#Id"").val();
                    var reqUrl = ""/Security/User/Add"";
                    if (keyValue != """" && keyValue != null && keyValue != ""null"") {
                        reqUrl = ""/Security/User/Edit?id="" + keyValue;
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
                                toastr.success(""操作成功"");
                                setTimeout(function () {
                                    $table.bootstrapTable('refresh');
   ");
            WriteLiteral(@"                                 $(""#frmSubmit"")[0].reset();
                                }, 2500);
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

    function ResetPassword() {
        //得到用户选择的数据的ID
        var rows = $table.bootstrapTable('getSelections');
        if (rows.length >= 1) {
            //遍历出用户选择的数据的信息，这就是用户用户选择删除的用户ID的信息
            var ids = """";   //1,2,3,4,5
            for (var i = 0; i < rows.length; i++) {
                ids += rows[i].Id + "","";
            }
            //最后去掉最后的那一个,
            ids = ids.substring(0, ids.length - 1);
            var postData = { userId: ids };
            s");
            WriteLiteral(@"wal({
                title: ""操作提示"",
                text: ""您确定对选定用户重置密码吗？"",
                icon: ""warning"",
                closeOnClickOutside: false,
                buttons: {
                    cancel: {
                        text: ""取消"",
                        visible: true,
                        closeModal: true,
                    },
                    confirm: {
                        text: ""是的"",
                        value: ""ok"",
                        className: ""swal-button-confirm""
                    },
                }
            }).then(function (value) {
                if (value == ""ok"") {
                    $.ajax({
                        url: ""/Security/User/ResetPassword"",
                        data: postData,
                        dataType: 'json',//服务器返回json格式数据
                        type: 'post',//HTTP请求类型
                        timeout: 100000,//超时时间设置为10秒；
                        success: function (data) {
                            /");
            WriteLiteral(@"/服务器返回响应，根据响应结果，分析是否登录成功；
                            if (data.Success) {
                                swal(""重置密码成功！"", ""新密码："" + data.ErrMsg, ""success"")
                            } else {
                                toastr.warning(""操作失败："" + data.ErrMsg);
                            }
                        },
                        error: function (data) {
                            toastr.warning(""重置密码异常,请重新试试"");
                        }
                    });
                }
            });
        } else {
            toastr.warning(""请选择你要重置密码的用户"");
        }
    }
</script>

");
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
