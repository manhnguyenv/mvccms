SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[ArticleID] [int] IDENTITY(1,1) NOT NULL,
	[ArticleName] [nvarchar](250) NOT NULL,
	[Alias] [varchar](250) NOT NULL,
	[DescriptShort] [nvarchar](max) NULL,
	[BlogID] [int] NOT NULL,
	[Images] [nvarchar](500) NULL,
	[Author] [nvarchar](max) NULL,
	[Content] [ntext] NULL,
	[MetaTitle] [nvarchar](250) NULL,
	[MetaKeyword] [nvarchar](250) NULL,
	[MetaDescription] [nvarchar](max) NULL,
	[News_hot] [bit] NOT NULL,
	[CreatedAt] [datetime] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Article] PRIMARY KEY CLUSTERED 
(
	[ArticleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Blog]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blog](
	[BlogID] [int] IDENTITY(1,1) NOT NULL,
	[BlogName] [nvarchar](250) NOT NULL,
	[Alias] [varchar](250) NOT NULL,
	[Content] [ntext] NULL,
	[Author] [nvarchar](max) NULL,
	[MetaTitle] [nvarchar](250) NULL,
	[MetaKeyword] [nvarchar](250) NULL,
	[MetaDescription] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Blog] PRIMARY KEY CLUSTERED 
(
	[BlogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](250) NOT NULL,
	[Alias] [varchar](250) NOT NULL,
	[Images] [nvarchar](500) NULL,
	[Content] [ntext] NULL,
	[MetaTitle] [nvarchar](250) NULL,
	[MetaKeyword] [nvarchar](250) NULL,
	[MetaDescription] [nvarchar](max) NULL,
	[Author] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Configure]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configure](
	[ConfigID] [int] IDENTITY(1,1) NOT NULL,
	[Logo] [nvarchar](256) NULL,
	[Favicon] [nvarchar](256) NULL,
	[NameCompany] [nvarchar](256) NULL,
	[Description] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Email] [nvarchar](50) NULL,
	[EmailReceive] [nvarchar](50) NULL,
	[Phone] [nvarchar](11) NULL,
	[Hotline] [nvarchar](150) NULL,
	[Map] [nvarchar](max) NULL,
	[FanpageFacebook] [nvarchar](max) NULL,
	[IconFacebook] [nvarchar](max) NULL,
	[IconTwiiter] [nvarchar](max) NULL,
	[IconInstagram] [nvarchar](max) NULL,
	[IconYoutube] [nvarchar](max) NULL,
	[IconGoogle] [nvarchar](max) NULL,
	[title_block_address] [nvarchar](max) NULL,
	[title_block_description_1] [nvarchar](max) NULL,
	[link_name_des_1] [nvarchar](max) NULL,
	[link_href_des_1] [nvarchar](max) NULL,
	[link_name_des_2] [nvarchar](max) NULL,
	[link_href_des_2] [nvarchar](max) NULL,
	[link_name_des_3] [nvarchar](max) NULL,
	[link_href_des_3] [nvarchar](max) NULL,
	[link_name_des_4] [nvarchar](max) NULL,
	[link_href_des_4] [nvarchar](max) NULL,
	[link_name_des_5] [nvarchar](max) NULL,
	[link_href_des_5] [nvarchar](max) NULL,
	[link_name_des_6] [nvarchar](max) NULL,
	[link_href_des_6] [nvarchar](max) NULL,
	[title_block_description2_1] [nvarchar](max) NULL,
	[link_name_des_2_1] [nvarchar](max) NULL,
	[link_href_des_2_1] [nvarchar](max) NULL,
	[link_name_des_2_2] [nvarchar](max) NULL,
	[link_href_des_2_2] [nvarchar](max) NULL,
	[link_name_des_2_3] [nvarchar](max) NULL,
	[link_href_des_2_3] [nvarchar](max) NULL,
	[link_name_des_2_4] [nvarchar](max) NULL,
	[link_href_des_2_4] [nvarchar](max) NULL,
	[link_name_des_2_5] [nvarchar](max) NULL,
	[link_href_des_2_5] [nvarchar](max) NULL,
	[link_name_des_2_6] [nvarchar](max) NULL,
	[link_href_des_2_6] [nvarchar](max) NULL,
	[title_dknt] [nvarchar](max) NULL,
	[content_dknt] [nvarchar](max) NULL,
	[title_map] [nvarchar](max) NULL,
	[MetaTitle] [nvarchar](250) NULL,
	[MetaKeyword] [nvarchar](250) NULL,
	[MetaDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Configure] PRIMARY KEY CLUSTERED 
(
	[ConfigID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contact]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](250) NOT NULL,
	[Email] [varchar](250) NOT NULL,
	[Phone] [varchar](11) NOT NULL,
	[Content] [ntext] NOT NULL,
	[ViewStatus] [bit] NOT NULL,
	[CreatedAt] [datetime] NULL,
 CONSTRAINT [PK_dbo.Contact] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[customerID] [int] IDENTITY(1,1) NOT NULL,
	[customerName] [nvarchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](250) NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[Phone] [varchar](11) NOT NULL,
	[CreatedAt] [datetime] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Customer] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Home]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Home](
	[HomeID] [int] IDENTITY(1,1) NOT NULL,
	[on_block_slogan] [bit] NOT NULL,
	[title_sologan] [nvarchar](max) NULL,
	[button_more_slogan] [nvarchar](max) NULL,
	[on_block_intro] [bit] NOT NULL,
	[title_intro] [nvarchar](max) NULL,
	[des_more_intro] [nvarchar](max) NULL,
	[images_intro_1] [nvarchar](max) NULL,
	[images_intro_2] [nvarchar](max) NULL,
	[content_intro] [nvarchar](max) NULL,
	[text_intro1] [nvarchar](max) NULL,
	[text_intro2] [nvarchar](max) NULL,
	[text_intro3] [nvarchar](max) NULL,
	[text_intro4] [nvarchar](max) NULL,
	[text_intro5] [nvarchar](max) NULL,
	[text_intro6] [nvarchar](max) NULL,
	[text_intro7] [nvarchar](max) NULL,
	[text_intro8] [nvarchar](max) NULL,
	[text_intro9] [nvarchar](max) NULL,
	[text_intro10] [nvarchar](max) NULL,
	[button_more_intro] [nvarchar](max) NULL,
	[on_product_home] [bit] NOT NULL,
	[title_product_home] [nvarchar](max) NULL,
	[link_title_product_home] [nvarchar](max) NULL,
	[collection_product_home] [int] NULL,
	[on_work_time] [bit] NOT NULL,
	[title_work] [nvarchar](max) NULL,
	[icon_work_1] [nvarchar](max) NULL,
	[titile_block_work1] [nvarchar](max) NULL,
	[content_block_work1] [nvarchar](max) NULL,
	[icon_work_2] [nvarchar](max) NULL,
	[titile_block_work2] [nvarchar](max) NULL,
	[content_block_work2] [nvarchar](max) NULL,
	[icon_work_3] [nvarchar](max) NULL,
	[titile_block_work3] [nvarchar](max) NULL,
	[content_block_work3] [nvarchar](max) NULL,
	[icon_work_4] [nvarchar](max) NULL,
	[titile_block_work4] [nvarchar](max) NULL,
	[content_block_work4] [nvarchar](max) NULL,
	[on_new_video] [bit] NOT NULL,
	[title_block_news] [nvarchar](max) NULL,
	[blog_news_chosse] [int] NULL,
	[title_block_video] [nvarchar](max) NULL,
	[video_iframe1] [nvarchar](max) NULL,
	[images_video_2] [nvarchar](max) NULL,
	[video_iframe2] [nvarchar](max) NULL,
	[images_video_3] [nvarchar](max) NULL,
	[video_iframe3] [nvarchar](max) NULL,
	[images_video_4] [nvarchar](max) NULL,
	[video_iframe4] [nvarchar](max) NULL,
	[on_say_customer] [bit] NOT NULL,
	[title_block_comment_customer] [nvarchar](max) NULL,
	[on_block_say_customer1] [bit] NOT NULL,
	[name_customer_say1] [nvarchar](max) NULL,
	[images_customer_1] [nvarchar](max) NULL,
	[company_customer_say1] [nvarchar](max) NULL,
	[content_customer_say1] [nvarchar](max) NULL,
	[on_block_say_customer2] [bit] NOT NULL,
	[name_customer_say2] [nvarchar](max) NULL,
	[images_customer_2] [nvarchar](max) NULL,
	[company_customer_say2] [nvarchar](max) NULL,
	[content_customer_say2] [nvarchar](max) NULL,
	[on_block_say_customer3] [bit] NOT NULL,
	[name_customer_say3] [nvarchar](max) NULL,
	[images_customer_3] [nvarchar](max) NULL,
	[company_customer_say3] [nvarchar](max) NULL,
	[content_customer_say3] [nvarchar](max) NULL,
	[on_block_say_customer4] [bit] NOT NULL,
	[name_customer_say4] [nvarchar](max) NULL,
	[images_customer_4] [nvarchar](max) NULL,
	[company_customer_say4] [nvarchar](max) NULL,
	[content_customer_say4] [nvarchar](max) NULL,
	[on_block_say_customer5] [bit] NOT NULL,
	[name_customer_say5] [nvarchar](max) NULL,
	[images_customer_5] [nvarchar](max) NULL,
	[company_customer_say5] [nvarchar](max) NULL,
	[content_customer_say5] [nvarchar](max) NULL,
	[on_block_say_customer6] [bit] NOT NULL,
	[name_customer_say6] [nvarchar](max) NULL,
	[images_customer_6] [nvarchar](max) NULL,
	[company_customer_say6] [nvarchar](max) NULL,
	[content_customer_say6] [nvarchar](max) NULL,
	[on_block_partner] [bit] NOT NULL,
	[title_partners] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Home] PRIMARY KEY CLUSTERED 
(
	[HomeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MenuNavigation]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuNavigation](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[Sequence] [int] NULL,
	[MenuName] [nvarchar](50) NOT NULL,
	[IconMenu] [nvarchar](max) NULL,
	[MenuParents] [int] NOT NULL,
	[PageStyle] [int] NOT NULL,
	[FormatPage] [int] NULL,
	[GroupLink] [int] NULL,
	[PageContent] [ntext] NULL,
	[PageLink] [nvarchar](250) NULL,
	[MetaTitle] [nvarchar](250) NULL,
	[MetaKeyword] [nvarchar](250) NULL,
	[MetaDescription] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.MenuNavigation] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](250) NOT NULL,
	[Alias] [varchar](250) NOT NULL,
	[Images] [nvarchar](max) NULL,
	[CategoryID] [int] NOT NULL,
	[DescriptShort] [nvarchar](max) NULL,
	[Content] [ntext] NULL,
	[Content2] [ntext] NULL,
	[Content3] [ntext] NULL,
	[MetaTitle] [nvarchar](250) NULL,
	[MetaKeyword] [nvarchar](250) NULL,
	[Author] [nvarchar](max) NULL,
	[MetaDescription] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RegisterUse]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegisterUse](
	[RegisterUseID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[FullName] [nvarchar](250) NOT NULL,
	[Email] [varchar](250) NOT NULL,
	[Phone] [varchar](11) NOT NULL,
	[ViewStatus] [bit] NOT NULL,
	[CreatedAt] [datetime] NULL,
 CONSTRAINT [PK_dbo.RegisterUse] PRIMARY KEY CLUSTERED 
(
	[RegisterUseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Slide]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slide](
	[SliderID] [int] IDENTITY(1,1) NOT NULL,
	[SortID] [int] NOT NULL,
	[SliderName] [nvarchar](250) NULL,
	[SliderName2] [nvarchar](250) NULL,
	[Description] [nvarchar](max) NULL,
	[Images] [nvarchar](max) NULL,
	[URL] [nvarchar](250) NULL,
	[OptionSelect] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Slide] PRIMARY KEY CLUSTERED 
(
	[SliderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](250) NOT NULL,
	[Fullname] [nvarchar](max) NOT NULL,
	[Image] [nvarchar](250) NULL,
	[Email] [varchar](50) NOT NULL,
	[Address] [nvarchar](150) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[CreatedAt] [datetime] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserBusiness]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserBusiness](
	[BusinessID] [varchar](50) NOT NULL,
	[BusinessName] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_dbo.UserBusiness] PRIMARY KEY CLUSTERED 
(
	[BusinessID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserGrantPermission]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGrantPermission](
	[PermissionID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_dbo.UserGrantPermission] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC,
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserPermission]    Script Date: 05/22/2018 10:41:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPermission](
	[PermissionID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionName] [varchar](100) NOT NULL,
	[PermissionDescription] [nvarchar](250) NOT NULL,
	[BusinessID] [varchar](50) NULL,
 CONSTRAINT [PK_dbo.UserPermission] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO