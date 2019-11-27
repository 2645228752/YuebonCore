#pragma checksum "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Shop\Views\MemberGrades\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb0957cb6e36413e9aee6b730c0fe2a18f00f501"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Shop_Views_MemberGrades_Edit), @"mvc.1.0.view", @"/Areas/Shop/Views/MemberGrades/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Shop/Views/MemberGrades/Edit.cshtml", typeof(AspNetCore.Areas_Shop_Views_MemberGrades_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0957cb6e36413e9aee6b730c0fe2a18f00f501", @"/Areas/Shop/Views/MemberGrades/Edit.cshtml")]
    public class Areas_Shop_Views_MemberGrades_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Shop\Views\MemberGrades\Edit.cshtml"
  
    ViewData["Title"] = "会员管理-会员等级-编辑会员等级";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.CurrentMenuP = "Members";
    ViewBag.CurrentMenu = "MemberGrades/List";

#line default
#line hidden
            BeginContext(188, 3498, true);
            WriteLiteral(@"<div class=""edit-page-wrapper"">
    <div class=""row"">
        <div class=""col-12"">
            <form class=""form-horizontal"" id=""frmSubmit"" method=""post"" enctype=""multipart/form-data"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""tab-content p-0"">
                            <!-- Morris chart - Sales -->
                            <div class=""chart tab-pane active"" id=""basicInfo"" style=""position: relative;"">
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <label for=""Name"" class=""col-form-label col-md-1"">会员等级名称:</label>
                                        <input type=""text"" class=""form-control col-md-5"" name=""Name"" id=""Name"" placeholder=""请输入会员等级名称"">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                 ");
            WriteLiteral(@"   <div class=""row"">
                                        <label for=""Points"" class=""col-form-label col-md-1"">积分满足点数:</label>
                                        <input type=""text"" class=""form-control col-md-5"" name=""Points"" id=""Points"" placeholder=""请输入积分满足点数，大于0的整数"">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <label for=""Discount"" class=""col-form-label col-md-1"">会员等级折扣:</label>
                                        <input type=""text"" class=""form-control col-md-5"" name=""Discount"" id=""Discount"" placeholder=""等级折扣为不能为空，且必须为0-999的整数"">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <div class=""col-1""><label for=""recipient-n");
            WriteLiteral(@"ame"" class=""col-form-label"">选项:</label></div>
                                        <div class=""col-5"">
                                            <label for=""EnabledMark"">
                                                <input type=""checkbox"" class=""flat-red"" checked=""checked"" name=""EnabledMark"" id=""EnabledMark"">
                                                有效
                                            </label>
                                            <label for=""IsDefault"" title=""是否默认"">
                                                <input type=""checkbox"" class=""flat-red"" name=""IsDefault"" id=""IsDefault"">
                                                默认
                                            </label>
                                        </div>
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <div class=""row"">
                                      ");
            WriteLiteral(@"  <div class=""col-1""><label for=""recipient-name"" class=""col-form-label"">描述:</label></div>
                                        <div class=""col-10""> <textarea id=""Description"" name=""Description"" class=""form-control""></textarea></div>
                                    </div>
                                </div>
                            </div>

                            <input type=""hidden"" id=""Id"" name=""Id""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3686, "\"", 3710, 2);
#line 59 "D:\netcorespace\YuebonFramework.NetCore\src\Yuebon.WebApp\Areas\Shop\Views\MemberGrades\Edit.cshtml"
WriteAttributeValue("", 3694, ViewData["Id"], 3694, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 3709, "", 3710, 1, true);
            EndWriteAttribute();
            BeginContext(3711, 5256, true);
            WriteLiteral(@" />
                            <div class=""modal-footer"">
                                <button type=""submit"" class=""btn btn-primary btnSave"" id=""btnSaveOK""><i class=""fa fa-save""></i>保存</button>
                                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal""><i class=""fa fa-close""></i>关闭</button>
                            </div>
                        </div>
                    </div>
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
       // $(""#myEditorImage"").InitUploader({ sendurl: ""/api/UEditor"", swf: ""~/lib/webuploader/uploader.swf"" });

        InitDictItem();
        BindEditInfo();
        BindSaveEvent();
    });
    //初始化数据字典
    function InitDictItem() ");
            WriteLiteral(@"{
    }
    //绑定编辑详细信息的方法
    function BindEditInfo() {
        var ID = $(""#Id"").val();
        if (ID.trim() != """") {
            //首先用户发送一个异步请求去后台实现方法
            $.getJSON(""/Shop/MemberGrades/GetById?r="" + Math.random() + ""&id="" + ID, function (info) {
                //赋值有几种方式：.datebox('setValue', info.Birthday);.combobox('setValue', info.Status);.val(info.Name);
                $(""#Id"").val(info.ResData.Id);
                $(""#frmSubmit"").formSerialize(info.ResData);
            });
        }
    }
    //绑定保存按钮的事件
    function BindSaveEvent() {
        $(""#btnSaveOK"").click(function () {
            $(""#frmSubmit"").validate({
                rules: {
                    Name: {
                        required: true,
                        minlength: 2
                    },
                },
                messages: {
                    Name: {
                        required: ""请输入等级名称"",
                        minlength: ""等级名称至少2个字符""
                    },
          ");
            WriteLiteral(@"      },
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
                    //element.parent('div').append(error);
                    if ($(element).next(""div"").hasClass(""tooltip"")) {
                        $(element).attr(""data-original-title"", $(error).text()).tooltip");
            WriteLiteral(@"(""show"");
                    } else {
                        $(element).attr(""title"", $(error).text()).tooltip(""show"");
                    }
                },
                submitHandler: function (form) {
                    var postData = {
                        ""Id"": $(""#Id"").val(),
                        ""Name"": $(""#Name"").val(),
                        ""Points"": $(""#Points"").val(),
                        ""Discount"": $(""#Discount"").val(),
                        ""IsDefault"": $(""#IsDefault"").is(':checked'),
                        ""EnabledMark"": $(""#EnabledMark"").is(':checked'),
                        ""Description"":$(""#Description"").val()
                    };
                    var keyValue = $(""#Id"").val().trim();
                    var reqUrl = ""/Shop/MemberGrades/Insert"";
                    if (keyValue != """" && keyValue != null && keyValue != ""null"") {
                        reqUrl = ""/Shop/MemberGrades/Update?id="" + keyValue;
                    }
                 ");
            WriteLiteral(@"   $.ajax({
                        url: reqUrl,
                        data: postData,
                        dataType: 'json',//服务器返回json格式数据
                        type: 'post',//HTTP请求类型
                        timeout: 100000,//超时时间设置为10秒；
                        success: function (data) {
                            //服务器返回响应，根据响应结果，分析是否登录成功；
                            if (data.Success) {
                                $(""#frmSubmit"")[0].reset();
                                toastr.success(""操作成功"");
                                setTimeout(function () {
                                    window.location.href = ""/Shop/MemberGrades/Index""
                                }, 1500);
                            } else {
                                toastr.warning(""操作失败："" + data.ErrMsg);
                            }
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            toastr.warning(""操作失败："" + ");
            WriteLiteral("errorThrown);\r\n                        }\r\n                    });\r\n                }\r\n            });\r\n        });\r\n    }\r\n\r\n</script>\r\n");
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
