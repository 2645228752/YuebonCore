#pragma checksum "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Opp\Views\Category\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b83b3585b04bc2f38dcc0af2038d3019d1691902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Opp_Views_Category_Edit), @"mvc.1.0.view", @"/Areas/Opp/Views/Category/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b83b3585b04bc2f38dcc0af2038d3019d1691902", @"/Areas/Opp/Views/Category/Edit.cshtml")]
    public class Areas_Opp_Views_Category_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("charset", new global::Microsoft.AspNetCore.Html.HtmlString("utf-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ueditor/ueditor.config.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ueditor/ueditor.all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ueditor/lang/zh-cn/zh-cn.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Opp\Views\Category\Edit.cshtml"
  
    ViewData["Title"] = "商机管理-商机类型-编辑类型";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.CurrentMenuP = "Opp";
    ViewBag.CurrentMenu = "Category/List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""edit-page-wrapper"">
    <div class=""row"">
        <div class=""col-12"">
            <form class=""form-horizontal"" id=""frmSubmit"" method=""post"" enctype=""multipart/form-data"">
                <div class=""card"">
                    <div class=""card-header d-flex p-0"">
                        <ul class=""nav nav-pills p-2"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" href=""#basicInfo"" data-toggle=""tab"">基本信息</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#seoInfo"" data-toggle=""tab"">SEO选项</a>
                            </li>
                        </ul>
                    </div><!-- /.card-header -->
                    <div class=""card-body"">
                        <div class=""tab-content p-0"">
                            <!-- Morris chart - Sales -->
                            <div class=""chart tab-pane active"" id=""basi");
            WriteLiteral(@"cInfo"" style=""position: relative;"">
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <label for=""Title"" class=""col-form-label col-md-1"">分类名称:</label>
                                        <input type=""text"" class=""form-control col-md-5"" name=""Title"" id=""Title"" placeholder=""请输入分类名称"">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <label for=""ParentId"" class=""col-form-label col-1"">所属上级:</label>
                                        <select class=""form-control select2  col-5"" name=""ParentId"" id=""ParentId"">
                                            <option");
            BeginWriteAttribute("value", " value=\"", 2065, "\"", 2073, 0);
            EndWriteAttribute();
            WriteLiteral(@">==请选择上级分类==</option>
                                        </select>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <label for=""ImgUrl"" class=""col-form-label col-1"">图片:</label>
                                        <div class=""input-group col-5"">
                                            <input type=""text"" class=""form-control upload-path"" name=""ImgUrl"" id=""ImgUrl"">
                                            <button type=""button"" id=""j_upload_img_btn"">选择图片</button>
                                            <ul id=""upload_img_wrap""></ul>
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""row"">
                              ");
            WriteLiteral("          <label for=\"ImgUrlPic\" class=\"col-form-label col-1\"></label>\r\n                                        <div class=\"input-group col-5\">\r\n                                            <img src=\"...\"");
            BeginWriteAttribute("alt", " alt=\"", 3301, "\"", 3307, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""ImgUrlPic"" class=""img-rounded"" width=""100"" height=""100"" />
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <label for=""LinkUrl"" class=""col-form-label col-1"">URL链接:</label>
                                        <input type=""text"" class=""form-control col-5"" name=""LinkUrl"" id=""LinkUrl"" placeholder=""填写后直接跳转到该网址"">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <label for=""SortCode"" class=""col-form-label col-1"">排序:</label>
                                        <input type=""number"" class=""form-control col-5"" name=""SortCode"" id=""SortCode"" placeholder=""请输入排序号"">
                        ");
            WriteLiteral(@"            </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <div class=""col-1""><label for=""recipient-name"" class=""col-form-label"">选项:</label></div>
                                        <div class=""col-5"">
                                            <label for=""EnabledMark"">
                                                <input type=""checkbox"" class=""flat-red"" checked=""checked"" name=""EnabledMark"" id=""EnabledMark"">
                                                有效
                                            </label>
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <div class=""col-1""><label for=""recipient-name"" class=""c");
            WriteLiteral(@"ol-form-label"">描述:</label></div>
                                        <div class=""col-10""> <textarea id=""Description"" name=""Description""></textarea></div>
                                    </div>
                                </div>
                            </div>
                            <div class=""chart tab-pane"" id=""seoInfo"" style=""position: relative; "">

                                <div class=""form-group"">
                                    <div class=""row"">
                                        <label for=""SeoTitle"" class=""col-form-label col-1"">SEO标题:</label>
                                        <input type=""text"" class=""form-control col-5"" name=""SeoTitle"" id=""SeoTitle"" placeholder=""请输入SEO标题"">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <label for=""SeoKeywords"" class=""col-form-lab");
            WriteLiteral(@"el col-1"">SEO关键词:</label>
                                        <input type=""text"" class=""form-control col-5"" name=""SeoKeywords"" id=""SeoKeywords"" placeholder=""请输入SEO关键词"">
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <div class=""row"">
                                        <label for=""SeoDescription"" class=""col-form-label col-1"">SEO描述:</label>
                                        <input type=""text"" class=""form-control col-5"" name=""SeoDescription"" id=""SeoDescription"" placeholder=""请输入SEO描述"">
                                    </div>
                                </div>
                            </div>


                            <input type=""hidden"" id=""Id"" name=""Id""");
            BeginWriteAttribute("value", " value=\"", 7208, "\"", 7232, 2);
#nullable restore
#line 112 "D:\netcorespace\YueGroup\src\Yuebon.Manager\Yuebon.WebApp\Areas\Opp\Views\Category\Edit.cshtml"
WriteAttributeValue("", 7216, ViewData["Id"], 7216, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 7231, "", 7232, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <div class=""modal-footer"">
                                <button type=""submit"" class=""btn btn-primary btnSave"" id=""btnSaveOK""><i class=""fa fa-save""></i>保存</button>
                                <button type=""button"" class=""btn btn-danger"" onclick=""javascript:history.go(-1)""><i class=""fa fa-close""></i>返回</button>
                            </div>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>
<textarea id=""uploadEditor"" style=""display: none;""></textarea>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b83b3585b04bc2f38dcc0af2038d3019d169190213603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b83b3585b04bc2f38dcc0af2038d3019d169190214809", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b83b3585b04bc2f38dcc0af2038d3019d169190216015", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script type=""text/javascript"">
    // 实例化编辑器，这里注意配置项隐藏编辑器并禁用默认的基础功能。
    var uploadEditor = UE.getEditor(""uploadEditor"", {
        isShow: false,
        focus: false,
        enableAutoSave: false,
        autoSyncData: false,
        autoFloatEnabled: false,
        wordCount: false,
        sourceEditor: null,
        scaleEnabled: true,
        toolbars: [[""insertimage"", ""attachment""]]
    });
    
        var ue = UE.getEditor('Description', {
            initialFrameHeight: 200
        });
    // 监听多图上传和上传附件组件的插入动作
    uploadEditor.ready(function () {
        uploadEditor.addListener(""beforeInsertImage"", _beforeInsertImage);
    });
    // 自定义按钮绑定触发多图上传和上传附件对话框事件
    document.getElementById('j_upload_img_btn').onclick = function () {
        var dialog = uploadEditor.getDialog(""insertimage"");
        dialog.title = '多图上传';
        dialog.render();
        dialog.open();
    };
    // 多图上传动作
    function _beforeInsertImage(t, result) {
        var imageHtml = '';
     ");
            WriteLiteral(@"   $(""#ImgUrl"").val(result[0].src);
        $(""#ImgUrlPic"").attr(""src"", result[0].src);
    }
</script>
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
        setTimeout(function(){BindEditInfo(); }, 1200);
        BindSaveEvent();
    });
    //初始化数据字典
    function InitDictItem() {
        $(""#ParentId"").bindSelect({
            url: ""/Opp/Category/FindTreeSelectJson"",
        });
    }
    //绑定编辑详细信息的方法
    function BindEditInfo() {
        var ID = $(""#Id"").val();
        if (ID.trim() != """") {
            //首先用户发送一个异步请求去后台实现方法
            $.getJSON(""/Opp/Category/GetById?r="" + Math.random() + ""&id="" + ID, function (info) {
            ");
            WriteLiteral(@"    //赋值有几种方式：.datebox('setValue', info.Birthday);.combobox('setValue', info.Status);.val(info.Name);
                $(""#Id"").val(info.ResData.Id);
                $(""#frmSubmit"").formSerialize(info.ResData);
                $(""#ImgUrlPic"").attr(""src"", info.ResData.ImgUrl);
                ue.ready(function() { 
                    ue.setContent(info.ResData.Description);
                });
            });
        }
    }
    //绑定保存按钮的事件
    function BindSaveEvent() {
        $(""#btnSaveOK"").click(function () {
            $(""#frmSubmit"").validate({
                rules: {
                    Title: {
                        required: true,
                        minlength: 2
                    },
                },
                messages: {
                    Title: {
                        required: ""请输入分类名称"",
                        minlength: ""分类名称至少2个字符""
                    },
                },
                errorClass: 'help-block help-block-error',
               ");
            WriteLiteral(@" focusInvalid: true,
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
                        $(element).attr(""data-original-title"", $(error).text()).tooltip(""show"");
                    } else {
                        $(element).attr(""tit");
            WriteLiteral(@"le"", $(error).text()).tooltip(""show"");
                    }
                },
                submitHandler: function (form) {
                    var postData = {
                        ""Id"": $(""#Id"").val(),
                        ""Title"": $(""#Title"").val(),
                        ""ParentId"": $(""#ParentId"").val(),
                        ""ImgUrl"": $(""#ImgUrl"").val(),
                        ""LinkUrl"": $(""#LinkUrl"").val(),
                        ""SeoTitle"": $(""#SeoTitle"").val(),
                        ""SeoKeywords"": $(""#SeoKeywords"").val(),
                        ""SeoDescription"": $(""#SeoDescription"").val(),
                        ""SortCode"": $(""#SortCode"").val(),
                        ""EnabledMark"": $(""#EnabledMark"").is(':checked'),
                        ""Description"": UE.getEditor('Description').getContent()
                    };
                    var keyValue = $(""#Id"").val().trim();
                    var reqUrl = ""/Opp/Category/Insert"";
                    if (keyValue");
            WriteLiteral(@" != """" && keyValue != null && keyValue != ""null"") {
                        reqUrl = ""/Opp/Category/Update?id="" + keyValue;
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
                                $(""#frmSubmit"")[0].reset();
                                toastr.success(""操作成功"");
                                setTimeout(function () {
                                    window.location.href = ""/Opp/Category/Index""
                                }, 1500);
                            } else {
                                toastr.warning(""操作失败："" + data.ErrMsg);
                            }
     ");
            WriteLiteral(@"                   },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            toastr.warning(""操作失败："" + errorThrown);
                        }
                    });
                }
            });
        });
    }

</script>
");
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
