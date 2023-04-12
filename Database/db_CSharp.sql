/****** Object:  Database [db_CSharp]    Script Date: 2019/2/26 19:44:03 ******/
CREATE DATABASE [db_CSharp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_CSharp', FILENAME = N'D:\db_CSharp.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_CSharp_log', FILENAME = N'D:\db_CSharp_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

USE [db_CSharp]
GO

CREATE TABLE [dbo].[tb_01](
	[yearID] [int] NULL,
	[month1] [bigint] NULL,
	[month2] [bigint] NULL,
	[month3] [bigint] NULL,
	[month4] [bigint] NULL,
	[month5] [bigint] NULL,
	[month6] [bigint] NULL,
	[month7] [bigint] NULL,
	[month8] [bigint] NULL,
	[month9] [bigint] NULL,
	[month10] [bigint] NULL,
	[month11] [bigint] NULL,
	[month12] [bigint] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_02](
	[boyNum] [int] NULL,
	[girlNum] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_03](
	[yearID] [int] NULL,
	[month1] [bigint] NULL,
	[month2] [bigint] NULL,
	[month3] [bigint] NULL,
	[month4] [bigint] NULL,
	[month5] [bigint] NULL,
	[month6] [bigint] NULL,
	[month7] [bigint] NULL,
	[month8] [bigint] NULL,
	[month9] [bigint] NULL,
	[month10] [bigint] NULL,
	[month11] [bigint] NULL,
	[month12] [bigint] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_age](
	[编号] [int] NOT NULL,
	[年龄段] [varchar](50) NULL,
	[人数] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_command](
	[编号] [int] NOT NULL,
	[姓名] [varchar](50) NULL,
	[性别] [varchar](50) NULL,
	[年龄] [varchar](50) NULL,
	[奖金] [decimal](18, 0) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_emp](
	[编号] [int] IDENTITY(1,1) NOT NULL,
	[姓名] [char](10) NULL,
	[职称] [char](10) NULL,
	[部门] [char](10) NULL,
	[性别] [char](10) NULL,
 CONSTRAINT [PK_tb_emp] PRIMARY KEY CLUSTERED 
(
	[编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_Employee](
	[ID] [varchar](20) NOT NULL,
	[Name] [varchar](30) NULL,
	[Sex] [char](4) NULL,
	[Age] [int] NULL,
	[Tel] [varchar](20) NULL,
	[Address] [varchar](100) NULL,
	[QQ] [bigint] NULL,
	[Email] [varchar](50) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_Login](
	[Name] [nchar](10) NULL,
	[Pwd] [nchar](10) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_man](
	[编号] [int] NOT NULL,
	[职工姓名] [char](10) NULL,
	[职工性别] [char](10) NULL,
	[职工年龄] [int] NULL,
	[职工原籍] [char](10) NULL,
	[职工工资] [decimal](18, 0) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_people](
	[tb_PID] [varchar](50) NULL,
	[tb_pname] [varchar](50) NULL,
	[tb_psex] [char](10) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_Salary](
	[ID] [varchar](20) NOT NULL,
	[Name] [varchar](50) NULL,
	[Salary] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_teacher](
	[编号] [int] NOT NULL,
	[教师名称] [char](10) NULL,
	[教师性别] [char](10) NULL,
	[负责科目] [char](10) NULL,
	[教师工龄] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_test](
	[编号] [int] NOT NULL,
	[商品名称] [char](10) NULL,
	[商品价格] [char](10) NULL,
	[商品类型] [char](10) NULL,
	[商品产地] [char](10) NULL,
	[新旧程度] [char](10) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_vote](
	[编号] [int] NOT NULL,
	[选项] [varchar](50) NULL,
	[票数] [int] NULL
) ON [PRIMARY]
GO

INSERT [dbo].[tb_01] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2001, 2006, 122, 133, 333, 323, 1234, 1221, 213, 543, 5454, 6564, 5454)
INSERT [dbo].[tb_01] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2002, 654, 767, 432, 656, 234, 543, 432, 432, 234, 324, 324, 432)
INSERT [dbo].[tb_01] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2003, 2004, 466, 123, 1234, 2759, 13, 432, 169, 0, 3478, 2568, 234)
INSERT [dbo].[tb_01] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2004, 2002, 6454, 158, 8520, 510, 1110, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tb_01] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2005, 2001, 3232, 632, 152, 128, 666, 0, 0, 0, 0, 0, 700)
INSERT [dbo].[tb_01] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2006, 2003, 3213, 4444, 852, 632, 685, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tb_01] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2007, 3000, 3500, 3700, 3800, 123, 145, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tb_02] ([boyNum], [girlNum]) VALUES (70, 30)
INSERT [dbo].[tb_03] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2001, 200, 300, 133, 333, 323, 123, 122, 213, 543, 545, 656, 233)
INSERT [dbo].[tb_03] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2002, 654, 767, 432, 656, 234, 543, 432, 432, 234, 324, 324, 432)
INSERT [dbo].[tb_03] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2003, 200, 466, 123, 123, 275, 888, 432, 169, 889, 347, 256, 234)
INSERT [dbo].[tb_03] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2004, 200, 645, 999, 999, 999, 999, 543, 234, 556, 888, 864, 954)
INSERT [dbo].[tb_03] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2005, 200, 323, 999, 999, 999, 666, 435, 564, 998, 585, 564, 700)
INSERT [dbo].[tb_03] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2006, 200, 321, 444, 999, 999, 999, 999, 321, 889, 456, 987, 564)
INSERT [dbo].[tb_03] ([yearID], [month1], [month2], [month3], [month4], [month5], [month6], [month7], [month8], [month9], [month10], [month11], [month12]) VALUES (2007, 300, 350, 370, 380, 999, 999, 667, 645, 897, 867, 898, 999)
INSERT [dbo].[tb_age] ([编号], [年龄段], [人数]) VALUES (1, N'20-25', 22)
INSERT [dbo].[tb_age] ([编号], [年龄段], [人数]) VALUES (2, N'26-30', 22)
INSERT [dbo].[tb_age] ([编号], [年龄段], [人数]) VALUES (3, N'31-40', 4)
INSERT [dbo].[tb_command] ([编号], [姓名], [性别], [年龄], [奖金]) VALUES (1, N'小吕', N'男', N'28', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([编号], [姓名], [性别], [年龄], [奖金]) VALUES (2, N'小王', N'男', N'24', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([编号], [姓名], [性别], [年龄], [奖金]) VALUES (3, N'小张', N'男', N'26', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([编号], [姓名], [性别], [年龄], [奖金]) VALUES (4, N'小郭', N'女', N'24', CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([编号], [姓名], [性别], [年龄], [奖金]) VALUES (5, N'小贯', N'女', N'24', CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([编号], [姓名], [性别], [年龄], [奖金]) VALUES (6, N'小陈', N'女', N'24', CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([编号], [姓名], [性别], [年龄], [奖金]) VALUES (7, N'小梁', N'男', N'28', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([编号], [姓名], [性别], [年龄], [奖金]) VALUES (8, N'小苏', N'男', N'26', CAST(0 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[tb_emp] ON 

INSERT [dbo].[tb_emp] ([编号], [姓名], [职称], [部门], [性别]) VALUES (1, N'小吕      ', N'工程师    ', N'C#        ', N'男        ')
INSERT [dbo].[tb_emp] ([编号], [姓名], [职称], [部门], [性别]) VALUES (2, N'陈        ', N'高级工程师', N'C#        ', N'女        ')
INSERT [dbo].[tb_emp] ([编号], [姓名], [职称], [部门], [性别]) VALUES (3, N'郭        ', N'高级工程师', N'C#        ', N'女        ')
INSERT [dbo].[tb_emp] ([编号], [姓名], [职称], [部门], [性别]) VALUES (4, N'贯        ', N'高级工程师', N'ASP.NET   ', N'女        ')
INSERT [dbo].[tb_emp] ([编号], [姓名], [职称], [部门], [性别]) VALUES (5, N'苏        ', N'高级工程师', N'ASP.NET   ', N'男        ')
INSERT [dbo].[tb_emp] ([编号], [姓名], [职称], [部门], [性别]) VALUES (6, N'小王      ', N'高级工程师', N'C#        ', N'男        ')
INSERT [dbo].[tb_emp] ([编号], [姓名], [职称], [部门], [性别]) VALUES (7, N'小刘      ', N'工程师    ', N'C#        ', N'男        ')
INSERT [dbo].[tb_emp] ([编号], [姓名], [职称], [部门], [性别]) VALUES (8, N'小张      ', N'工程师    ', N'ASP.NET   ', N'男        ')
SET IDENTITY_INSERT [dbo].[tb_emp] OFF
INSERT [dbo].[tb_Employee] ([ID], [Name], [Sex], [Age], [Tel], [Address], [QQ], [Email]) VALUES (N'YGBH0001', N'小王', N'男  ', 24, N'13100000000', N'吉林省长春市', 3800000, N'wangxiaoke68@126.com')
INSERT [dbo].[tb_Employee] ([ID], [Name], [Sex], [Age], [Tel], [Address], [QQ], [Email]) VALUES (N'YGBH0002', N'小李', N'男  ', 28, N'13000000000', N'吉林省长春市', 4000000, N'lovelvshuang@163.com')
INSERT [dbo].[tb_Employee] ([ID], [Name], [Sex], [Age], [Tel], [Address], [QQ], [Email]) VALUES (N'YGBH0003', N'小刘', N'男  ', 24, N'13800000000', N'吉林省长春市', 10000000, N'xiaoliu@163.com')
INSERT [dbo].[tb_Employee] ([ID], [Name], [Sex], [Age], [Tel], [Address], [QQ], [Email]) VALUES (N'YGBH0004', N'小科', N'男  ', 24, N'13100000000', N'山西省长治市', 10000000, N'xiaoke@163.com')
INSERT [dbo].[tb_Employee] ([ID], [Name], [Sex], [Age], [Tel], [Address], [QQ], [Email]) VALUES (N'YGBH0005', N'小亮', N'男  ', 24, N'13100000000', N'吉林省长春市', 3800000, N'wangxiaoke68@126.com')
INSERT [dbo].[tb_Login] ([Name], [Pwd]) VALUES (N'mr        ', N'mrsoft    ')
INSERT [dbo].[tb_man] ([编号], [职工姓名], [职工性别], [职工年龄], [职工原籍], [职工工资]) VALUES (1, N'小王      ', NULL, 24, N'吉林省    ', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[tb_man] ([编号], [职工姓名], [职工性别], [职工年龄], [职工原籍], [职工工资]) VALUES (2, N'小郭      ', NULL, 24, N'吉林省    ', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[tb_man] ([编号], [职工姓名], [职工性别], [职工年龄], [职工原籍], [职工工资]) VALUES (3, N'小陈      ', NULL, 24, N'吉林省    ', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[tb_man] ([编号], [职工姓名], [职工性别], [职工年龄], [职工原籍], [职工工资]) VALUES (4, N'小张      ', NULL, 27, N'吉林省    ', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[tb_man] ([编号], [职工姓名], [职工性别], [职工年龄], [职工原籍], [职工工资]) VALUES (5, N'小吕      ', NULL, 28, N'吉林省    ', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[tb_people] ([tb_PID], [tb_pname], [tb_psex]) VALUES (N'1', N'222', N'222       ')
INSERT [dbo].[tb_people] ([tb_PID], [tb_pname], [tb_psex]) VALUES (N'1', N'222', N'222       ')
INSERT [dbo].[tb_people] ([tb_PID], [tb_pname], [tb_psex]) VALUES (N'1', N'222', N'222       ')
INSERT [dbo].[tb_people] ([tb_PID], [tb_pname], [tb_psex]) VALUES (N'3', N'', N'          ')
INSERT [dbo].[tb_people] ([tb_PID], [tb_pname], [tb_psex]) VALUES (N'0002', N'vt', N'v         ')
INSERT [dbo].[tb_Salary] ([ID], [Name], [Salary]) VALUES (N'YGBH0001', N'小王', 1500)
INSERT [dbo].[tb_Salary] ([ID], [Name], [Salary]) VALUES (N'YGBH0002', N'小李', 1600)
INSERT [dbo].[tb_Salary] ([ID], [Name], [Salary]) VALUES (N'YGBH0003', N'小刘', 1500)
INSERT [dbo].[tb_Salary] ([ID], [Name], [Salary]) VALUES (N'YGBH0004', N'小科', 1500)
INSERT [dbo].[tb_Salary] ([ID], [Name], [Salary]) VALUES (N'YGBH0005', N'小亮', 1500)
INSERT [dbo].[tb_teacher] ([编号], [教师名称], [教师性别], [负责科目], [教师工龄]) VALUES (1, N'吕老师    ', N'男        ', N'C#        ', 20)
INSERT [dbo].[tb_teacher] ([编号], [教师名称], [教师性别], [负责科目], [教师工龄]) VALUES (2, N'张老师    ', N'男        ', N'ASP.NET   ', 25)
INSERT [dbo].[tb_teacher] ([编号], [教师名称], [教师性别], [负责科目], [教师工龄]) VALUES (3, N'王老师    ', N'男        ', N'C#        ', 21)
INSERT [dbo].[tb_teacher] ([编号], [教师名称], [教师性别], [负责科目], [教师工龄]) VALUES (4, N'陈老师    ', N'女        ', N'JAVA      ', 19)
INSERT [dbo].[tb_teacher] ([编号], [教师名称], [教师性别], [负责科目], [教师工龄]) VALUES (5, N'房老师    ', N'男        ', N'ASP.NET   ', 20)
INSERT [dbo].[tb_teacher] ([编号], [教师名称], [教师性别], [负责科目], [教师工龄]) VALUES (6, N'贯老师    ', N'女        ', N'ASP.NET   ', 15)
INSERT [dbo].[tb_teacher] ([编号], [教师名称], [教师性别], [负责科目], [教师工龄]) VALUES (7, N'郭老师    ', N'女        ', N'Photoshop ', 18)
INSERT [dbo].[tb_teacher] ([编号], [教师名称], [教师性别], [负责科目], [教师工龄]) VALUES (8, N'梁老师    ', N'男        ', N'C#        ', 20)
INSERT [dbo].[tb_test] ([编号], [商品名称], [商品价格], [商品类型], [商品产地], [新旧程度]) VALUES (1, N'电动自行车', N'300       ', N'交通工具  ', N'国产      ', N'全新      ')
INSERT [dbo].[tb_test] ([编号], [商品名称], [商品价格], [商品类型], [商品产地], [新旧程度]) VALUES (2, N'手机      ', N'1300      ', N'家电      ', N'国产      ', N'二手      ')
INSERT [dbo].[tb_test] ([编号], [商品名称], [商品价格], [商品类型], [商品产地], [新旧程度]) VALUES (3, N'电脑      ', N'9000      ', N'家电      ', N'国产      ', N'二手      ')
INSERT [dbo].[tb_test] ([编号], [商品名称], [商品价格], [商品类型], [商品产地], [新旧程度]) VALUES (4, N'背包      ', N'350       ', N'服饰      ', N'国产      ', N'全新      ')
INSERT [dbo].[tb_test] ([编号], [商品名称], [商品价格], [商品类型], [商品产地], [新旧程度]) VALUES (5, N'MP4       ', N'299       ', N'家电      ', N'国产      ', N'全新      ')
INSERT [dbo].[tb_test] ([编号], [商品名称], [商品价格], [商品类型], [商品产地], [新旧程度]) VALUES (6, N'电视机    ', N'1350      ', N'家电      ', N'国产      ', N'全新      ')
INSERT [dbo].[tb_vote] ([编号], [选项], [票数]) VALUES (1, N'支付宝', 16)
INSERT [dbo].[tb_vote] ([编号], [选项], [票数]) VALUES (2, N'微信支付', 2)
INSERT [dbo].[tb_vote] ([编号], [选项], [票数]) VALUES (3, N'京东白条', 4)
INSERT [dbo].[tb_vote] ([编号], [选项], [票数]) VALUES (4, N'小度钱包', 3)
