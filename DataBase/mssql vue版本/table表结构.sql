USE [YBNF]
GO
/****** Object:  Table [dbo].[CMS_Articlecategory]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CMS_Articlecategory](
	[Id] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](4000) NOT NULL,
	[ParentId] [nvarchar](50) NULL,
	[ClassPath] [nvarchar](1000) NULL,
	[ClassLayer] [int] NOT NULL,
	[SortCode] [int] NOT NULL,
	[LinkUrl] [nvarchar](255) NOT NULL,
	[ImgUrl] [nvarchar](255) NULL,
	[SeoTitle] [nvarchar](255) NULL,
	[SeoKeywords] [nvarchar](255) NULL,
	[SeoDescription] [nvarchar](255) NULL,
	[IsHot] [bit] NULL,
	[Description] [nvarchar](4000) NULL,
	[EnabledMark] [bit] NULL,
	[DeleteMark] [bit] NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [nvarchar](50) NULL,
	[CompanyId] [nvarchar](50) NULL,
	[DeptId] [nvarchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [nvarchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sys_Articlecategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CMS_Articlenews]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CMS_Articlenews](
	[Id] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](4000) NOT NULL,
	[CategoryId] [nvarchar](50) NULL,
	[CategoryName] [nvarchar](1000) NULL,
	[SubTitle] [nvarchar](4000) NOT NULL,
	[LinkUrl] [nvarchar](255) NOT NULL,
	[ImgUrl] [nvarchar](255) NULL,
	[SeoTitle] [nvarchar](255) NULL,
	[SeoKeywords] [nvarchar](255) NULL,
	[SeoDescription] [nvarchar](255) NULL,
	[Tags] [nvarchar](255) NULL,
	[Zhaiyao] [nvarchar](255) NULL,
	[SortCode] [int] NOT NULL,
	[IsMsg] [bit] NULL,
	[IsTop] [bit] NULL,
	[IsRed] [bit] NULL,
	[IsHot] [bit] NULL,
	[IsSys] [bit] NULL,
	[IsNew] [bit] NULL,
	[IsSlide] [bit] NULL,
	[Click] [int] NULL,
	[LikeCount] [int] NULL,
	[TotalBrowse] [int] NULL,
	[Source] [nvarchar](255) NULL,
	[Author] [nvarchar](255) NULL,
	[Description] [nvarchar](4000) NULL,
	[EnabledMark] [bit] NULL,
	[DeleteMark] [bit] NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [nvarchar](50) NULL,
	[CompanyId] [nvarchar](50) NULL,
	[DeptId] [nvarchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [nvarchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [nvarchar](50) NULL,
 CONSTRAINT [PK_CMS_Articlenews] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_APP]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_APP](
	[Id] [nvarchar](50) NOT NULL,
	[AppId] [nvarchar](50) NULL,
	[AppSecret] [nvarchar](50) NULL,
	[EncodingAESKey] [nvarchar](256) NULL,
	[RequestUrl] [nvarchar](600) NULL,
	[Token] [nvarchar](256) NULL,
	[IsOpenAEKey] [bit] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[Description] [varchar](500) NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[CompanyId] [nvarchar](50) NULL,
	[DeptId] [nvarchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](50) NULL,
 CONSTRAINT [PK_Sys_APP] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Area]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Area](
	[Id] [nvarchar](50) NOT NULL,
	[ParentId] [nvarchar](50) NULL,
	[Layers] [int] NULL,
	[EnCode] [nvarchar](50) NULL,
	[FullName] [nvarchar](400) NULL,
	[SimpleSpelling] [nvarchar](4000) NULL,
	[FullIdPath] [nvarchar](600) NULL,
	[IsLast] [bit] NULL,
	[SortCode] [int] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[Description] [varchar](500) NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_DbBackup]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_DbBackup](
	[Id] [varchar](50) NOT NULL,
	[BackupType] [varchar](50) NULL,
	[DbName] [varchar](50) NULL,
	[FileName] [varchar](50) NULL,
	[FileSize] [varchar](50) NULL,
	[FilePath] [varchar](500) NULL,
	[BackupTime] [datetime] NULL,
	[SortCode] [int] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[Description] [varchar](500) NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_FilterIP]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_FilterIP](
	[Id] [varchar](50) NOT NULL,
	[FilterType] [bit] NULL,
	[StartIP] [varchar](50) NULL,
	[EndIP] [varchar](50) NULL,
	[SortCode] [int] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[Description] [varchar](500) NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Items]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Items](
	[Id] [varchar](50) NOT NULL,
	[ParentId] [varchar](50) NULL,
	[EnCode] [varchar](50) NULL,
	[FullName] [varchar](50) NULL,
	[IsTree] [bit] NULL,
	[Layers] [int] NULL,
	[SortCode] [int] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[Description] [varchar](500) NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_ItemsDetail]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_ItemsDetail](
	[Id] [varchar](50) NOT NULL,
	[ItemId] [varchar](50) NULL,
	[ParentId] [varchar](50) NULL,
	[ItemCode] [varchar](50) NULL,
	[ItemName] [varchar](50) NULL,
	[SimpleSpelling] [varchar](500) NULL,
	[IsDefault] [bit] NULL,
	[Layers] [int] NULL,
	[SortCode] [int] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[Description] [varchar](500) NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Log]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Log](
	[Id] [varchar](50) NOT NULL,
	[Date] [datetime] NULL,
	[Account] [varchar](50) NULL,
	[NickName] [varchar](50) NULL,
	[OrganizeId] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
	[IPAddress] [varchar](50) NULL,
	[IPAddressName] [varchar](50) NULL,
	[ModuleId] [varchar](50) NULL,
	[ModuleName] [varchar](50) NULL,
	[Result] [bit] NULL,
	[Description] [text] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Menu]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Menu](
	[Id] [nvarchar](50) NOT NULL,
	[SystemTypeId] [nvarchar](50) NULL,
	[ParentId] [nvarchar](50) NULL,
	[Layers] [int] NULL,
	[EnCode] [varchar](50) NULL,
	[FullName] [varchar](50) NULL,
	[Icon] [varchar](50) NULL,
	[UrlAddress] [varchar](500) NULL,
	[Component] [varchar](255) NULL,
	[Target] [varchar](50) NULL,
	[MenuType] [char](1) NULL,
	[ActiveMenu] [varchar](255) NULL,
	[IsExpand] [bit] NULL,
	[IsFrame] [bit] NOT NULL,
	[IsShow] [bit] NOT NULL,
	[IsCache] [bit] NOT NULL,
	[IsPublic] [bit] NULL,
	[AllowEdit] [bit] NULL,
	[AllowDelete] [bit] NULL,
	[SortCode] [int] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[Description] [varchar](500) NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](50) NULL,
 CONSTRAINT [PK__Sys_Menu__3214EC07F62609AA] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_OpenIdSettings]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_OpenIdSettings](
	[OpenIdType] [nvarchar](4000) NOT NULL,
	[Name] [nvarchar](64) NOT NULL,
	[Description] [ntext] NULL,
	[Settings] [ntext] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Organize]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Organize](
	[Id] [varchar](50) NOT NULL,
	[ParentId] [varchar](50) NULL,
	[Layers] [int] NULL,
	[EnCode] [varchar](50) NULL,
	[FullName] [varchar](50) NULL,
	[ShortName] [varchar](50) NULL,
	[CategoryId] [varchar](50) NULL,
	[ManagerId] [varchar](50) NULL,
	[TelePhone] [varchar](20) NULL,
	[MobilePhone] [varchar](20) NULL,
	[WeChat] [varchar](50) NULL,
	[Fax] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[AreaId] [varchar](50) NULL,
	[Address] [varchar](500) NULL,
	[AllowEdit] [bit] NULL,
	[AllowDelete] [bit] NULL,
	[SortCode] [int] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[Description] [varchar](500) NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Role]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Role](
	[Id] [varchar](50) NOT NULL,
	[OrganizeId] [varchar](50) NULL,
	[Category] [int] NULL,
	[EnCode] [varchar](50) NULL,
	[FullName] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
	[AllowEdit] [bit] NULL,
	[AllowDelete] [bit] NULL,
	[SortCode] [int] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[Description] [varchar](500) NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_RoleAuthorize]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_RoleAuthorize](
	[Id] [varchar](50) NOT NULL,
	[ItemType] [int] NULL,
	[ItemId] [varchar](50) NULL,
	[ObjectType] [int] NULL,
	[ObjectId] [varchar](50) NULL,
	[SortCode] [int] NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_RoleData]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_RoleData](
	[Id] [nvarchar](50) NOT NULL,
	[RoleId] [nvarchar](50) NOT NULL,
	[AuthorizeData] [nvarchar](50) NULL,
	[DType] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Sequence]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Sequence](
	[Id] [nvarchar](50) NOT NULL,
	[SequenceName] [nvarchar](50) NOT NULL,
	[SequenceDelimiter] [nvarchar](50) NULL,
	[SequenceReset] [nvarchar](50) NULL,
	[Step] [int] NOT NULL,
	[CurrentNo] [int] NOT NULL,
	[CurrentCode] [nvarchar](4000) NULL,
	[CurrentReset] [nvarchar](50) NULL,
	[Description] [nvarchar](4000) NULL,
	[EnabledMark] [bit] NULL,
	[DeleteMark] [bit] NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [nvarchar](50) NULL,
	[CompanyId] [nvarchar](50) NULL,
	[DeptId] [nvarchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](50) NULL,
 CONSTRAINT [PK_AD_DocNoGenerator] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_SequenceRule]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_SequenceRule](
	[Id] [nvarchar](50) NOT NULL,
	[SequenceName] [nvarchar](4000) NULL,
	[RuleOrder] [int] NOT NULL,
	[RuleType] [nvarchar](4000) NOT NULL,
	[RuleValue] [nvarchar](4000) NULL,
	[PaddingSide] [nvarchar](4000) NULL,
	[PaddingWidth] [int] NOT NULL,
	[PaddingChar] [nvarchar](4000) NULL,
	[Description] [nvarchar](4000) NULL,
	[EnabledMark] [bit] NOT NULL,
	[DeleteMark] [bit] NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [nvarchar](50) NULL,
	[CompanyId] [nvarchar](50) NULL,
	[DeptId] [nvarchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [nvarchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [nvarchar](50) NULL,
 CONSTRAINT [PK_AD_Sequence] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_SystemType]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_SystemType](
	[Id] [varchar](50) NOT NULL,
	[EnCode] [varchar](50) NULL,
	[FullName] [varchar](50) NULL,
	[Url] [varchar](250) NULL,
	[AllowEdit] [bit] NULL,
	[AllowDelete] [bit] NULL,
	[SortCode] [int] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[Description] [varchar](500) NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_TaskJobsLog]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_TaskJobsLog](
	[Id] [nvarchar](50) NOT NULL,
	[TaskId] [nvarchar](50) NOT NULL,
	[TaskName] [nvarchar](50) NULL,
	[JobAction] [nvarchar](50) NULL,
	[Status] [bit] NOT NULL,
	[Description] [text] NULL,
	[CreatorTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Sys_TaskJobsLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_TaskManager]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_TaskManager](
	[Id] [nvarchar](50) NOT NULL,
	[TaskName] [nvarchar](300) NOT NULL,
	[GroupName] [nvarchar](300) NOT NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[Cron] [nvarchar](300) NOT NULL,
	[IsLocal] [bit] NOT NULL,
	[JobCallAddress] [nvarchar](300) NOT NULL,
	[JobCallParams] [nvarchar](300) NULL,
	[LastRunTime] [datetime] NULL,
	[LastErrorTime] [datetime] NULL,
	[NextRunTime] [datetime] NULL,
	[RunCount] [int] NOT NULL,
	[ErrorCount] [int] NOT NULL,
	[Description] [nvarchar](4000) NULL,
	[SendMail] [int] NULL,
	[EmailAddress] [nvarchar](4000) NULL,
	[Status] [int] NOT NULL,
	[EnabledMark] [bit] NULL,
	[DeleteMark] [bit] NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [nvarchar](50) NULL,
	[CompanyId] [nvarchar](50) NULL,
	[DeptId] [nvarchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](50) NULL,
 CONSTRAINT [PK_Sys_TaskManager] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Tenant]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Tenant](
	[Id] [nvarchar](50) NULL,
	[TenantName] [nvarchar](50) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[HostDomain] [nvarchar](4000) NOT NULL,
	[LinkMan] [nvarchar](50) NULL,
	[Telphone] [nvarchar](50) NULL,
	[DataSource] [nvarchar](4000) NULL,
	[Description] [nvarchar](4000) NULL,
	[EnabledMark] [bit] NULL,
	[DeleteMark] [bit] NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [nvarchar](50) NULL,
	[CompanyId] [nvarchar](50) NULL,
	[DeptId] [nvarchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_UploadFile]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_UploadFile](
	[Id] [nvarchar](50) NOT NULL,
	[FileName] [nvarchar](4000) NOT NULL,
	[FilePath] [nvarchar](500) NOT NULL,
	[Description] [nvarchar](4000) NULL,
	[FileType] [nvarchar](50) NULL,
	[FileSize] [int] NULL,
	[Extension] [nvarchar](50) NULL,
	[EnabledMark] [bit] NOT NULL,
	[SortCode] [int] NOT NULL,
	[DeleteMark] [bit] NOT NULL,
	[CreatorUserId] [nvarchar](50) NULL,
	[CreateUserName] [nvarchar](50) NULL,
	[CreatorTime] [datetime] NOT NULL,
	[Thumbnail] [nvarchar](500) NULL,
	[BelongApp] [varchar](4000) NULL,
	[BelongAppId] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_User]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_User](
	[Id] [nvarchar](50) NOT NULL,
	[Account] [varchar](50) NOT NULL,
	[RealName] [varchar](50) NULL,
	[NickName] [varchar](50) NULL,
	[HeadIcon] [varchar](250) NULL,
	[Gender] [int] NULL,
	[Birthday] [datetime] NULL,
	[MobilePhone] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[WeChat] [varchar](50) NULL,
	[ManagerId] [varchar](50) NULL,
	[SecurityLevel] [int] NULL,
	[Signature] [varchar](500) NULL,
	[Country] [nvarchar](4000) NULL,
	[Province] [nvarchar](4000) NULL,
	[City] [nvarchar](4000) NULL,
	[District] [nvarchar](4000) NULL,
	[OrganizeId] [varchar](50) NULL,
	[DepartmentId] [varchar](500) NULL,
	[RoleId] [varchar](500) NULL,
	[DutyId] [varchar](500) NULL,
	[IsAdministrator] [bit] NULL,
	[IsMember] [bit] NULL,
	[MemberGradeId] [varchar](50) NULL,
	[ReferralUserId] [varchar](50) NULL,
	[UnionId] [nvarchar](4000) NULL,
	[SortCode] [int] NULL,
	[DeleteMark] [bit] NULL,
	[EnabledMark] [bit] NULL,
	[Description] [varchar](500) NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_UserExtend]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_UserExtend](
	[Id] [nvarchar](50) NOT NULL,
	[UserId] [nvarchar](50) NOT NULL,
	[CardContent] [text] NULL,
	[Telphone] [nvarchar](50) NULL,
	[Address] [nvarchar](250) NULL,
	[CompanyName] [nvarchar](250) NULL,
	[PositionTitle] [nvarchar](250) NULL,
	[WechatQrCode] [nvarchar](250) NULL,
	[IndustryId] [nvarchar](500) NULL,
	[OpenType] [int] NULL,
	[IsOtherShare] [bit] NULL,
	[ShareTitle] [nvarchar](250) NULL,
	[WebUrl] [nvarchar](250) NULL,
	[CompanyDesc] [text] NULL,
	[CardTheme] [nvarchar](250) NULL,
	[VipGrade] [nvarchar](50) NULL,
	[IsAuthentication] [bit] NULL,
	[AuthenticationType] [int] NULL,
	[EnabledMark] [bit] NOT NULL,
	[DeleteMark] [bit] NULL,
	[CreatorTime] [datetime] NULL,
	[CreatorUserId] [varchar](50) NULL,
	[CompanyId] [nvarchar](50) NULL,
	[DeptId] [nvarchar](50) NULL,
	[LastModifyTime] [datetime] NULL,
	[LastModifyUserId] [varchar](50) NULL,
	[DeleteTime] [datetime] NULL,
	[DeleteUserId] [varchar](50) NULL,
 CONSTRAINT [PK_CMS_NameCard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_UserLogOn]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_UserLogOn](
	[Id] [varchar](50) NOT NULL,
	[UserId] [varchar](50) NOT NULL,
	[UserPassword] [varchar](50) NOT NULL,
	[UserSecretkey] [varchar](50) NOT NULL,
	[AllowStartTime] [datetime] NULL,
	[AllowEndTime] [datetime] NULL,
	[LockStartDate] [datetime] NULL,
	[LockEndDate] [datetime] NULL,
	[FirstVisitTime] [datetime] NULL,
	[PreviousVisitTime] [datetime] NULL,
	[LastVisitTime] [datetime] NULL,
	[ChangePasswordDate] [datetime] NULL,
	[MultiUserLogin] [bit] NULL,
	[LogOnCount] [int] NULL,
	[UserOnLine] [bit] NULL,
	[Question] [varchar](50) NULL,
	[AnswerQuestion] [varchar](500) NULL,
	[CheckIPAddress] [bit] NULL,
	[Language] [varchar](50) NULL,
	[Theme] [nvarchar](3000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_UserOpenIds]    Script Date: 2021/1/25 16:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_UserOpenIds](
	[UserId] [nvarchar](50) NOT NULL,
	[OpenIdType] [nvarchar](256) NOT NULL,
	[OpenId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_Sys_UserOpenIds] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[OpenIdType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CMS_Articlecategory] ADD  CONSTRAINT [DF_Sys_Articlecategory_SortCode]  DEFAULT ((99)) FOR [SortCode]
GO
ALTER TABLE [dbo].[CMS_Articlecategory] ADD  CONSTRAINT [DF_Sys_Articlecategory_EnabledMark]  DEFAULT ((1)) FOR [EnabledMark]
GO
ALTER TABLE [dbo].[CMS_Articlecategory] ADD  CONSTRAINT [DF_Sys_Articlecategory_DeleteMark]  DEFAULT ((0)) FOR [DeleteMark]
GO
ALTER TABLE [dbo].[CMS_Articlenews] ADD  CONSTRAINT [DF_CMS_Articlenews_SortCode]  DEFAULT ((99)) FOR [SortCode]
GO
ALTER TABLE [dbo].[CMS_Articlenews] ADD  CONSTRAINT [DF_CMS_Articlenews_Click]  DEFAULT ((0)) FOR [Click]
GO
ALTER TABLE [dbo].[CMS_Articlenews] ADD  CONSTRAINT [DF_CMS_Articlenews_Click3]  DEFAULT ((0)) FOR [LikeCount]
GO
ALTER TABLE [dbo].[CMS_Articlenews] ADD  CONSTRAINT [DF_CMS_Articlenews_Click2]  DEFAULT ((0)) FOR [TotalBrowse]
GO
ALTER TABLE [dbo].[CMS_Articlenews] ADD  CONSTRAINT [DF_CMS_Articlenews_EnabledMark]  DEFAULT ((1)) FOR [EnabledMark]
GO
ALTER TABLE [dbo].[CMS_Articlenews] ADD  CONSTRAINT [DF_CMS_Articlenews_DeleteMark]  DEFAULT ((0)) FOR [DeleteMark]
GO
ALTER TABLE [dbo].[Sys_Menu] ADD  CONSTRAINT [DF_Sys_Menu_IsFrame]  DEFAULT ((0)) FOR [IsFrame]
GO
ALTER TABLE [dbo].[Sys_Menu] ADD  CONSTRAINT [DF_Sys_Menu_IsShow]  DEFAULT ((1)) FOR [IsShow]
GO
ALTER TABLE [dbo].[Sys_Menu] ADD  CONSTRAINT [DF_Sys_Menu_IsCache]  DEFAULT ((0)) FOR [IsCache]
GO
ALTER TABLE [dbo].[Sys_Sequence] ADD  CONSTRAINT [DF_Sys_SequenceData_Step]  DEFAULT ((1)) FOR [Step]
GO
ALTER TABLE [dbo].[Sys_Sequence] ADD  CONSTRAINT [DF_Sys_Sequence_CurrentNo]  DEFAULT ((0)) FOR [CurrentNo]
GO
ALTER TABLE [dbo].[Sys_Sequence] ADD  CONSTRAINT [DF_Sys_Sequence_EnabledMark]  DEFAULT ((1)) FOR [EnabledMark]
GO
ALTER TABLE [dbo].[Sys_Sequence] ADD  CONSTRAINT [DF_Sys_Sequence_DeleteMark]  DEFAULT ((0)) FOR [DeleteMark]
GO
ALTER TABLE [dbo].[Sys_SequenceRule] ADD  CONSTRAINT [DF_Sys_SequenceRule_RuleOrder]  DEFAULT ((1)) FOR [RuleOrder]
GO
ALTER TABLE [dbo].[Sys_SequenceRule] ADD  CONSTRAINT [DF_Sys_SequenceRule_PaddingSide]  DEFAULT (N'left') FOR [PaddingSide]
GO
ALTER TABLE [dbo].[Sys_SequenceRule] ADD  CONSTRAINT [DF_AD_Sequence_CycleType]  DEFAULT ((2)) FOR [PaddingWidth]
GO
ALTER TABLE [dbo].[Sys_TaskManager] ADD  CONSTRAINT [DF_Sys_TaskManager_IsLocal]  DEFAULT ((1)) FOR [IsLocal]
GO
ALTER TABLE [dbo].[Sys_TaskManager] ADD  CONSTRAINT [DF_Sys_Task_ExeNumber]  DEFAULT ((0)) FOR [RunCount]
GO
ALTER TABLE [dbo].[Sys_TaskManager] ADD  CONSTRAINT [DF_Sys_TaskManager_ErrorCount]  DEFAULT ((0)) FOR [ErrorCount]
GO
ALTER TABLE [dbo].[Sys_TaskManager] ADD  CONSTRAINT [DF_Sys_TaskManager_IsSendMail]  DEFAULT ((0)) FOR [SendMail]
GO
ALTER TABLE [dbo].[Sys_TaskManager] ADD  CONSTRAINT [DF_Sys_Task_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Sys_TaskManager] ADD  CONSTRAINT [DF_Sys_Task_EnabledMark]  DEFAULT ((1)) FOR [EnabledMark]
GO
ALTER TABLE [dbo].[Sys_TaskManager] ADD  CONSTRAINT [DF_Sys_Task_DeleteMark]  DEFAULT ((0)) FOR [DeleteMark]
GO
ALTER TABLE [dbo].[Sys_Tenant] ADD  CONSTRAINT [DF_Sys_MultiTenant_EnabledMark]  DEFAULT ((1)) FOR [EnabledMark]
GO
ALTER TABLE [dbo].[Sys_Tenant] ADD  CONSTRAINT [DF_Sys_MultiTenant_DeleteMark]  DEFAULT ((0)) FOR [DeleteMark]
GO
ALTER TABLE [dbo].[Sys_UploadFile] ADD  CONSTRAINT [DF__Sys_Uploa__Enabl__4BAC3F29]  DEFAULT ((1)) FOR [EnabledMark]
GO
ALTER TABLE [dbo].[Sys_UploadFile] ADD  CONSTRAINT [DF__Sys_Uploa__SortC__4CA06362]  DEFAULT ((0)) FOR [SortCode]
GO
ALTER TABLE [dbo].[Sys_UploadFile] ADD  CONSTRAINT [DF__Sys_Uploa__Delet__4D94879B]  DEFAULT ((0)) FOR [DeleteMark]
GO
ALTER TABLE [dbo].[Sys_UploadFile] ADD  CONSTRAINT [DF__Sys_Uploa__Creat__4E88ABD4]  DEFAULT (getdate()) FOR [CreatorTime]
GO
ALTER TABLE [dbo].[Sys_UserExtend] ADD  CONSTRAINT [DF_CMS_NameCard_IsOtherShare]  DEFAULT ((1)) FOR [IsOtherShare]
GO
ALTER TABLE [dbo].[Sys_UserExtend] ADD  CONSTRAINT [DF_CMS_NameCard_EnabledMark]  DEFAULT ((1)) FOR [EnabledMark]
GO
ALTER TABLE [dbo].[Sys_UserExtend] ADD  CONSTRAINT [DF_CMS_NameCard_DeleteMark]  DEFAULT ((0)) FOR [DeleteMark]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'ClassPath'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'ClassLayer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'SortCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'LinkUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'ImgUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SEO??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'SeoTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SEO?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'SeoKeywords'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SEO??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'SeoDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'IsHot'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'EnabledMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'DeleteMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'CreatorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'CreatorUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'CompanyId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'DeptId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'LastModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'LastModifyUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'DeleteTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory', @level2type=N'COLUMN',@level2name=N'DeleteUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlecategory'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'CategoryId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'CategoryName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'SubTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'LinkUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'ImgUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SEO??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'SeoTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SEO?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'SeoKeywords'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SEO??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'SeoDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'Tags'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'Zhaiyao'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'SortCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'IsMsg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'IsTop'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'IsRed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'IsHot'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'IsSys'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'IsNew'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'IsSlide'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'Click'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'LikeCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'TotalBrowse'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'Source'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'Author'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'EnabledMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'DeleteMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'CreatorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'CreatorUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'CompanyId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'DeptId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'LastModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'LastModifyUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'DeleteTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews', @level2type=N'COLUMN',@level2name=N'DeleteUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CMS_Articlenews'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_APP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Area'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_DbBackup'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IP????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_FilterIP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Items'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_ItemsDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Log'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'SystemTypeId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'Layers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'EnCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'FullName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'Icon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'UrlAddress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'Component'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'IsFrame'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_OpenIdSettings'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Organize'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Role'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????0-????????????1-?????????2-??????/?????????3-??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleAuthorize', @level2type=N'COLUMN',@level2name=N'ItemType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleAuthorize', @level2type=N'COLUMN',@level2name=N'ItemId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????/??????1-?????????2-?????????3-??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleAuthorize', @level2type=N'COLUMN',@level2name=N'ObjectType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????????????????????/??????????????????????????????ID?????????????????????ID?????????????????????ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleAuthorize', @level2type=N'COLUMN',@level2name=N'ObjectId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleAuthorize'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????????????????ID?????????ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleData', @level2type=N'COLUMN',@level2name=N'AuthorizeData'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????company-?????????dept-?????????person-??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleData', @level2type=N'COLUMN',@level2name=N'DType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleData'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'SequenceName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'SequenceDelimiter'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'SequenceReset'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'Step'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'CurrentNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'CurrentCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'CurrentReset'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'EnabledMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'DeleteMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'CreatorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'CreatorUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'CompanyId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'DeptId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'LastModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'LastModifyUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'DeleteTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence', @level2type=N'COLUMN',@level2name=N'DeleteUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Sequence'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'SequenceName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'RuleOrder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????????const???number???date???timestamp' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'RuleType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????YYMMDD' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'RuleValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????????Left???Right???None' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'PaddingSide'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'PaddingWidth'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'PaddingChar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'EnabledMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'DeleteMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'CreatorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'CreatorUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'CompanyId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'DeptId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'LastModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'LastModifyUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'DeleteTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule', @level2type=N'COLUMN',@level2name=N'DeleteUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SequenceRule'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_SystemType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskJobsLog', @level2type=N'COLUMN',@level2name=N'TaskId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskJobsLog', @level2type=N'COLUMN',@level2name=N'TaskName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskJobsLog', @level2type=N'COLUMN',@level2name=N'JobAction'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????? ???????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskJobsLog', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskJobsLog', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskJobsLog', @level2type=N'COLUMN',@level2name=N'CreatorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskJobsLog'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'TaskName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'GroupName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'StartTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'EndTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CRON?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'Cron'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????????????????1??????????????????0?????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'IsLocal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????url' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'JobCallAddress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????????JSON??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'JobCallParams'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'LastRunTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'LastErrorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'NextRunTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'RunCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'ErrorCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'SendMail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'EnabledMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'DeleteMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'CreatorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'CreatorUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'CompanyId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'DeptId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'LastModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'LastModifyUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'DeleteTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager', @level2type=N'COLUMN',@level2name=N'DeleteUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_TaskManager'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'TenantName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'CompanyName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'HostDomain'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'LinkMan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'Telphone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'DataSource'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'Description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'EnabledMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'DeleteMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'CreatorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'CreatorUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'???????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'CompanyId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'DeptId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'LastModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'LastModifyUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'DeleteTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant', @level2type=N'COLUMN',@level2name=N'DeleteUserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Tenant'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UploadFile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_User'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'CardContent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'Telphone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'CompanyName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'PositionTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'WechatQrCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'IndustryId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'?????????0-????????????1-?????????2-????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'OpenType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'IsOtherShare'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'ShareTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'WebUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'CompanyDesc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'CardTheme'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Vip??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'VipGrade'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'IsAuthentication'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'????????????1-?????????2-??????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend', @level2type=N'COLUMN',@level2name=N'AuthenticationType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserExtend'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserLogOn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'??????????????????????????????????????????' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserOpenIds'
GO
