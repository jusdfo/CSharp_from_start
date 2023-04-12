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
	[���] [int] NOT NULL,
	[�����] [varchar](50) NULL,
	[����] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_command](
	[���] [int] NOT NULL,
	[����] [varchar](50) NULL,
	[�Ա�] [varchar](50) NULL,
	[����] [varchar](50) NULL,
	[����] [decimal](18, 0) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_emp](
	[���] [int] IDENTITY(1,1) NOT NULL,
	[����] [char](10) NULL,
	[ְ��] [char](10) NULL,
	[����] [char](10) NULL,
	[�Ա�] [char](10) NULL,
 CONSTRAINT [PK_tb_emp] PRIMARY KEY CLUSTERED 
(
	[���] ASC
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
	[���] [int] NOT NULL,
	[ְ������] [char](10) NULL,
	[ְ���Ա�] [char](10) NULL,
	[ְ������] [int] NULL,
	[ְ��ԭ��] [char](10) NULL,
	[ְ������] [decimal](18, 0) NULL
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
	[���] [int] NOT NULL,
	[��ʦ����] [char](10) NULL,
	[��ʦ�Ա�] [char](10) NULL,
	[�����Ŀ] [char](10) NULL,
	[��ʦ����] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_test](
	[���] [int] NOT NULL,
	[��Ʒ����] [char](10) NULL,
	[��Ʒ�۸�] [char](10) NULL,
	[��Ʒ����] [char](10) NULL,
	[��Ʒ����] [char](10) NULL,
	[�¾ɳ̶�] [char](10) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_vote](
	[���] [int] NOT NULL,
	[ѡ��] [varchar](50) NULL,
	[Ʊ��] [int] NULL
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
INSERT [dbo].[tb_age] ([���], [�����], [����]) VALUES (1, N'20-25', 22)
INSERT [dbo].[tb_age] ([���], [�����], [����]) VALUES (2, N'26-30', 22)
INSERT [dbo].[tb_age] ([���], [�����], [����]) VALUES (3, N'31-40', 4)
INSERT [dbo].[tb_command] ([���], [����], [�Ա�], [����], [����]) VALUES (1, N'С��', N'��', N'28', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([���], [����], [�Ա�], [����], [����]) VALUES (2, N'С��', N'��', N'24', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([���], [����], [�Ա�], [����], [����]) VALUES (3, N'С��', N'��', N'26', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([���], [����], [�Ա�], [����], [����]) VALUES (4, N'С��', N'Ů', N'24', CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([���], [����], [�Ա�], [����], [����]) VALUES (5, N'С��', N'Ů', N'24', CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([���], [����], [�Ա�], [����], [����]) VALUES (6, N'С��', N'Ů', N'24', CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([���], [����], [�Ա�], [����], [����]) VALUES (7, N'С��', N'��', N'28', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[tb_command] ([���], [����], [�Ա�], [����], [����]) VALUES (8, N'С��', N'��', N'26', CAST(0 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[tb_emp] ON 

INSERT [dbo].[tb_emp] ([���], [����], [ְ��], [����], [�Ա�]) VALUES (1, N'С��      ', N'����ʦ    ', N'C#        ', N'��        ')
INSERT [dbo].[tb_emp] ([���], [����], [ְ��], [����], [�Ա�]) VALUES (2, N'��        ', N'�߼�����ʦ', N'C#        ', N'Ů        ')
INSERT [dbo].[tb_emp] ([���], [����], [ְ��], [����], [�Ա�]) VALUES (3, N'��        ', N'�߼�����ʦ', N'C#        ', N'Ů        ')
INSERT [dbo].[tb_emp] ([���], [����], [ְ��], [����], [�Ա�]) VALUES (4, N'��        ', N'�߼�����ʦ', N'ASP.NET   ', N'Ů        ')
INSERT [dbo].[tb_emp] ([���], [����], [ְ��], [����], [�Ա�]) VALUES (5, N'��        ', N'�߼�����ʦ', N'ASP.NET   ', N'��        ')
INSERT [dbo].[tb_emp] ([���], [����], [ְ��], [����], [�Ա�]) VALUES (6, N'С��      ', N'�߼�����ʦ', N'C#        ', N'��        ')
INSERT [dbo].[tb_emp] ([���], [����], [ְ��], [����], [�Ա�]) VALUES (7, N'С��      ', N'����ʦ    ', N'C#        ', N'��        ')
INSERT [dbo].[tb_emp] ([���], [����], [ְ��], [����], [�Ա�]) VALUES (8, N'С��      ', N'����ʦ    ', N'ASP.NET   ', N'��        ')
SET IDENTITY_INSERT [dbo].[tb_emp] OFF
INSERT [dbo].[tb_Employee] ([ID], [Name], [Sex], [Age], [Tel], [Address], [QQ], [Email]) VALUES (N'YGBH0001', N'С��', N'��  ', 24, N'13100000000', N'����ʡ������', 3800000, N'wangxiaoke68@126.com')
INSERT [dbo].[tb_Employee] ([ID], [Name], [Sex], [Age], [Tel], [Address], [QQ], [Email]) VALUES (N'YGBH0002', N'С��', N'��  ', 28, N'13000000000', N'����ʡ������', 4000000, N'lovelvshuang@163.com')
INSERT [dbo].[tb_Employee] ([ID], [Name], [Sex], [Age], [Tel], [Address], [QQ], [Email]) VALUES (N'YGBH0003', N'С��', N'��  ', 24, N'13800000000', N'����ʡ������', 10000000, N'xiaoliu@163.com')
INSERT [dbo].[tb_Employee] ([ID], [Name], [Sex], [Age], [Tel], [Address], [QQ], [Email]) VALUES (N'YGBH0004', N'С��', N'��  ', 24, N'13100000000', N'ɽ��ʡ������', 10000000, N'xiaoke@163.com')
INSERT [dbo].[tb_Employee] ([ID], [Name], [Sex], [Age], [Tel], [Address], [QQ], [Email]) VALUES (N'YGBH0005', N'С��', N'��  ', 24, N'13100000000', N'����ʡ������', 3800000, N'wangxiaoke68@126.com')
INSERT [dbo].[tb_Login] ([Name], [Pwd]) VALUES (N'mr        ', N'mrsoft    ')
INSERT [dbo].[tb_man] ([���], [ְ������], [ְ���Ա�], [ְ������], [ְ��ԭ��], [ְ������]) VALUES (1, N'С��      ', NULL, 24, N'����ʡ    ', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[tb_man] ([���], [ְ������], [ְ���Ա�], [ְ������], [ְ��ԭ��], [ְ������]) VALUES (2, N'С��      ', NULL, 24, N'����ʡ    ', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[tb_man] ([���], [ְ������], [ְ���Ա�], [ְ������], [ְ��ԭ��], [ְ������]) VALUES (3, N'С��      ', NULL, 24, N'����ʡ    ', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[tb_man] ([���], [ְ������], [ְ���Ա�], [ְ������], [ְ��ԭ��], [ְ������]) VALUES (4, N'С��      ', NULL, 27, N'����ʡ    ', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[tb_man] ([���], [ְ������], [ְ���Ա�], [ְ������], [ְ��ԭ��], [ְ������]) VALUES (5, N'С��      ', NULL, 28, N'����ʡ    ', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[tb_people] ([tb_PID], [tb_pname], [tb_psex]) VALUES (N'1', N'222', N'222       ')
INSERT [dbo].[tb_people] ([tb_PID], [tb_pname], [tb_psex]) VALUES (N'1', N'222', N'222       ')
INSERT [dbo].[tb_people] ([tb_PID], [tb_pname], [tb_psex]) VALUES (N'1', N'222', N'222       ')
INSERT [dbo].[tb_people] ([tb_PID], [tb_pname], [tb_psex]) VALUES (N'3', N'', N'          ')
INSERT [dbo].[tb_people] ([tb_PID], [tb_pname], [tb_psex]) VALUES (N'0002', N'vt', N'v         ')
INSERT [dbo].[tb_Salary] ([ID], [Name], [Salary]) VALUES (N'YGBH0001', N'С��', 1500)
INSERT [dbo].[tb_Salary] ([ID], [Name], [Salary]) VALUES (N'YGBH0002', N'С��', 1600)
INSERT [dbo].[tb_Salary] ([ID], [Name], [Salary]) VALUES (N'YGBH0003', N'С��', 1500)
INSERT [dbo].[tb_Salary] ([ID], [Name], [Salary]) VALUES (N'YGBH0004', N'С��', 1500)
INSERT [dbo].[tb_Salary] ([ID], [Name], [Salary]) VALUES (N'YGBH0005', N'С��', 1500)
INSERT [dbo].[tb_teacher] ([���], [��ʦ����], [��ʦ�Ա�], [�����Ŀ], [��ʦ����]) VALUES (1, N'����ʦ    ', N'��        ', N'C#        ', 20)
INSERT [dbo].[tb_teacher] ([���], [��ʦ����], [��ʦ�Ա�], [�����Ŀ], [��ʦ����]) VALUES (2, N'����ʦ    ', N'��        ', N'ASP.NET   ', 25)
INSERT [dbo].[tb_teacher] ([���], [��ʦ����], [��ʦ�Ա�], [�����Ŀ], [��ʦ����]) VALUES (3, N'����ʦ    ', N'��        ', N'C#        ', 21)
INSERT [dbo].[tb_teacher] ([���], [��ʦ����], [��ʦ�Ա�], [�����Ŀ], [��ʦ����]) VALUES (4, N'����ʦ    ', N'Ů        ', N'JAVA      ', 19)
INSERT [dbo].[tb_teacher] ([���], [��ʦ����], [��ʦ�Ա�], [�����Ŀ], [��ʦ����]) VALUES (5, N'����ʦ    ', N'��        ', N'ASP.NET   ', 20)
INSERT [dbo].[tb_teacher] ([���], [��ʦ����], [��ʦ�Ա�], [�����Ŀ], [��ʦ����]) VALUES (6, N'����ʦ    ', N'Ů        ', N'ASP.NET   ', 15)
INSERT [dbo].[tb_teacher] ([���], [��ʦ����], [��ʦ�Ա�], [�����Ŀ], [��ʦ����]) VALUES (7, N'����ʦ    ', N'Ů        ', N'Photoshop ', 18)
INSERT [dbo].[tb_teacher] ([���], [��ʦ����], [��ʦ�Ա�], [�����Ŀ], [��ʦ����]) VALUES (8, N'����ʦ    ', N'��        ', N'C#        ', 20)
INSERT [dbo].[tb_test] ([���], [��Ʒ����], [��Ʒ�۸�], [��Ʒ����], [��Ʒ����], [�¾ɳ̶�]) VALUES (1, N'�綯���г�', N'300       ', N'��ͨ����  ', N'����      ', N'ȫ��      ')
INSERT [dbo].[tb_test] ([���], [��Ʒ����], [��Ʒ�۸�], [��Ʒ����], [��Ʒ����], [�¾ɳ̶�]) VALUES (2, N'�ֻ�      ', N'1300      ', N'�ҵ�      ', N'����      ', N'����      ')
INSERT [dbo].[tb_test] ([���], [��Ʒ����], [��Ʒ�۸�], [��Ʒ����], [��Ʒ����], [�¾ɳ̶�]) VALUES (3, N'����      ', N'9000      ', N'�ҵ�      ', N'����      ', N'����      ')
INSERT [dbo].[tb_test] ([���], [��Ʒ����], [��Ʒ�۸�], [��Ʒ����], [��Ʒ����], [�¾ɳ̶�]) VALUES (4, N'����      ', N'350       ', N'����      ', N'����      ', N'ȫ��      ')
INSERT [dbo].[tb_test] ([���], [��Ʒ����], [��Ʒ�۸�], [��Ʒ����], [��Ʒ����], [�¾ɳ̶�]) VALUES (5, N'MP4       ', N'299       ', N'�ҵ�      ', N'����      ', N'ȫ��      ')
INSERT [dbo].[tb_test] ([���], [��Ʒ����], [��Ʒ�۸�], [��Ʒ����], [��Ʒ����], [�¾ɳ̶�]) VALUES (6, N'���ӻ�    ', N'1350      ', N'�ҵ�      ', N'����      ', N'ȫ��      ')
INSERT [dbo].[tb_vote] ([���], [ѡ��], [Ʊ��]) VALUES (1, N'֧����', 16)
INSERT [dbo].[tb_vote] ([���], [ѡ��], [Ʊ��]) VALUES (2, N'΢��֧��', 2)
INSERT [dbo].[tb_vote] ([���], [ѡ��], [Ʊ��]) VALUES (3, N'��������', 4)
INSERT [dbo].[tb_vote] ([���], [ѡ��], [Ʊ��]) VALUES (4, N'С��Ǯ��', 3)
