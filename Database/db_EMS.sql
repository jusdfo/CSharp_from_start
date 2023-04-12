/****** Object:  Database [db_EMS]    Script Date: 2019/2/26 17:19:37 ******/
CREATE DATABASE [db_EMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_EMS', FILENAME = N'D:\db_EMS.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_EMS_log', FILENAME = N'D:\db_EMS_log.ldf' , SIZE = 7616KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
USE [db_EMS]
GO
CREATE TABLE [dbo].[tb_employee](
	[employeecode] [varchar](5) NOT NULL,
	[fullname] [varchar](10) NOT NULL,
	[sex] [varchar](4) NULL,
	[dept] [varchar](20) NULL,
	[tel] [varchar](20) NULL,
	[memo] [varchar](40) NULL,
 CONSTRAINT [PK_tb_employee] PRIMARY KEY CLUSTERED 
(
	[fullname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_power](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[sysuser] [varchar](20) NOT NULL,
	[password] [varchar](20) NULL,
	[stock] [bit] NULL,
	[vendition] [bit] NULL,
	[storage] [bit] NULL,
	[system] [bit] NULL,
	[base] [bit] NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_product](
	[t_Name] [varchar](50) NULL,
	[t_Num] [int] NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_resell_detailed](
	[billcode] [varchar](20) NOT NULL,
	[tradecode] [varchar](20) NOT NULL,
	[fullname] [varchar](20) NOT NULL,
	[unit] [char](4) NULL,
	[qty] [float] NULL,
	[price] [float] NULL,
	[tsum] [float] NULL,
	[billdate] [datetime] NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_resell_main](
	[billdate] [datetime] NOT NULL,
	[billcode] [varchar](20) NOT NULL,
	[units] [varchar](30) NOT NULL,
	[handle] [varchar](10) NOT NULL,
	[summary] [varchar](100) NULL,
	[fullpayment] [float] NULL,
	[payment] [float] NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_rewarehouse_detailed](
	[billcode] [varchar](20) NOT NULL,
	[tradecode] [varchar](20) NOT NULL,
	[fullname] [varchar](20) NOT NULL,
	[type] [varchar](10) NULL,
	[standard] [varchar](10) NULL,
	[produce] [varchar](20) NULL,
	[unit] [char](4) NULL,
	[qty] [float] NULL,
	[price] [float] NULL,
	[tsum] [float] NULL,
	[billdate] [datetime] NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_rewarehouse_main](
	[billdate] [datetime] NOT NULL,
	[billcode] [varchar](20) NOT NULL,
	[units] [varchar](30) NOT NULL,
	[handle] [varchar](10) NOT NULL,
	[summary] [varchar](100) NULL,
	[fullgathering] [float] NULL,
	[gathering] [float] NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_sell_detailed](
	[billcode] [varchar](20) NOT NULL,
	[tradecode] [varchar](20) NOT NULL,
	[fullname] [varchar](20) NOT NULL,
	[unit] [varchar](4) NULL,
	[qty] [float] NULL,
	[price] [float] NULL,
	[tsum] [float] NULL,
	[billdate] [datetime] NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_sell_main](
	[billdate] [datetime] NOT NULL,
	[billcode] [varchar](20) NOT NULL,
	[units] [varchar](30) NOT NULL,
	[handle] [varchar](10) NOT NULL,
	[summary] [varchar](100) NULL,
	[fullgathering] [float] NULL,
	[gathering] [float] NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_Stat](
	[ShowYear] [nvarchar](10) NOT NULL,
	[Year_M1] [bigint] NULL,
	[Year_M2] [bigint] NULL,
	[Year_M3] [bigint] NULL,
	[Year_M4] [bigint] NULL,
	[Year_M5] [bigint] NULL,
	[Year_M6] [bigint] NULL,
	[Year_M7] [bigint] NULL,
	[Year_M8] [bigint] NULL,
	[Year_M9] [bigint] NULL,
	[Year_M10] [bigint] NULL,
	[Year_M11] [bigint] NULL,
	[Year_M12] [bigint] NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_stock](
	[tradecode] [varchar](5) NOT NULL,
	[fullname] [varchar](20) NOT NULL,
	[type] [varchar](10) NOT NULL,
	[standard] [varchar](10) NOT NULL,
	[unit] [varchar](10) NOT NULL,
	[produce] [varchar](20) NOT NULL,
	[qty] [float] NULL,
	[price] [float] NULL,
	[averageprice] [float] NULL,
	[saleprice] [float] NULL,
	[stockcheck] [float] NULL,
	[upperlimit] [int] NULL,
	[lowerlimit] [int] NULL,
 CONSTRAINT [PK_tb_stock] PRIMARY KEY CLUSTERED 
(
	[fullname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_unit](
	[fullname] [varchar](30) NOT NULL,
	[tax] [varchar](30) NULL,
	[tel] [varchar](20) NULL,
	[linkman] [varchar](10) NULL,
	[address] [varchar](60) NULL,
	[accounts] [varchar](80) NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_units](
	[unitcode] [varchar](5) NOT NULL,
	[fullname] [varchar](30) NOT NULL,
	[tax] [varchar](30) NULL,
	[tel] [varchar](20) NULL,
	[linkman] [varchar](10) NULL,
	[address] [varchar](60) NULL,
	[accounts] [varchar](80) NULL,
	[gathering] [float] NULL,
	[payment] [float] NULL,
 CONSTRAINT [PK_tb_units] PRIMARY KEY CLUSTERED 
(
	[fullname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_warehouse_detailed](
	[billcode] [varchar](20) NOT NULL,
	[tradecode] [varchar](20) NOT NULL,
	[fullname] [varchar](20) NOT NULL,
	[unit] [varchar](10) NULL,
	[qty] [float] NULL,
	[price] [float] NULL,
	[tsum] [float] NULL,
	[billdate] [datetime] NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[tb_warehouse_main](
	[billdate] [datetime] NOT NULL,
	[billcode] [varchar](20) NOT NULL,
	[units] [varchar](30) NOT NULL,
	[handle] [varchar](10) NOT NULL,
	[summary] [varchar](100) NULL,
	[fullpayment] [float] NULL,
	[payment] [float] NULL
) ON [PRIMARY]
GO

INSERT [dbo].[tb_employee] ([employeecode], [fullname], [sex], [dept], [tel], [memo]) VALUES (N'E1002', N'小刘', N'女', N'销售部门', N'1123456', N'')
INSERT [dbo].[tb_employee] ([employeecode], [fullname], [sex], [dept], [tel], [memo]) VALUES (N'E1001', N'小王', N'男性', N'销售部门', N'1123456', N'')
SET IDENTITY_INSERT [dbo].[tb_power] ON 

INSERT [dbo].[tb_power] ([ID], [sysuser], [password], [stock], [vendition], [storage], [system], [base]) VALUES (1, N'mr', N'mrsoft', 1, 1, 1, 1, 1)
INSERT [dbo].[tb_power] ([ID], [sysuser], [password], [stock], [vendition], [storage], [system], [base]) VALUES (2, N'wxk', N'wxk', 1, 1, 1, 1, 1)
INSERT [dbo].[tb_power] ([ID], [sysuser], [password], [stock], [vendition], [storage], [system], [base]) VALUES (3, N'user', N'user', 1, 1, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[tb_power] OFF
INSERT [dbo].[tb_product] ([t_Name], [t_Num]) VALUES (N'苹果', 200)
INSERT [dbo].[tb_product] ([t_Name], [t_Num]) VALUES (N'香蕉', 350)
INSERT [dbo].[tb_product] ([t_Name], [t_Num]) VALUES (N'西瓜', 130)
INSERT [dbo].[tb_product] ([t_Name], [t_Num]) VALUES (N'桔子', 150)
INSERT [dbo].[tb_product] ([t_Name], [t_Num]) VALUES (N'西瓜', 100)
INSERT [dbo].[tb_product] ([t_Name], [t_Num]) VALUES (N'葡萄', 500)
INSERT [dbo].[tb_Stat] ([ShowYear], [Year_M1], [Year_M2], [Year_M3], [Year_M4], [Year_M5], [Year_M6], [Year_M7], [Year_M8], [Year_M9], [Year_M10], [Year_M11], [Year_M12]) VALUES (N'2011', 2006, 122, 133, 333, 323, 1234, 1221, 213, 543, 5454, 6564, 5454)
INSERT [dbo].[tb_Stat] ([ShowYear], [Year_M1], [Year_M2], [Year_M3], [Year_M4], [Year_M5], [Year_M6], [Year_M7], [Year_M8], [Year_M9], [Year_M10], [Year_M11], [Year_M12]) VALUES (N'2012', 654, 767, 432, 656, 234, 543, 432, 432, 234, 324, 324, 432)
INSERT [dbo].[tb_Stat] ([ShowYear], [Year_M1], [Year_M2], [Year_M3], [Year_M4], [Year_M5], [Year_M6], [Year_M7], [Year_M8], [Year_M9], [Year_M10], [Year_M11], [Year_M12]) VALUES (N'2013', 2004, 466, 123, 1234, 2759, 13, 432, 169, 0, 3478, 2568, 234)
INSERT [dbo].[tb_Stat] ([ShowYear], [Year_M1], [Year_M2], [Year_M3], [Year_M4], [Year_M5], [Year_M6], [Year_M7], [Year_M8], [Year_M9], [Year_M10], [Year_M11], [Year_M12]) VALUES (N'2014', 2002, 6454, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tb_Stat] ([ShowYear], [Year_M1], [Year_M2], [Year_M3], [Year_M4], [Year_M5], [Year_M6], [Year_M7], [Year_M8], [Year_M9], [Year_M10], [Year_M11], [Year_M12]) VALUES (N'2015', 2001, 3232, 0, 0, 0, 666, 0, 0, 0, 0, 0, 700)
INSERT [dbo].[tb_Stat] ([ShowYear], [Year_M1], [Year_M2], [Year_M3], [Year_M4], [Year_M5], [Year_M6], [Year_M7], [Year_M8], [Year_M9], [Year_M10], [Year_M11], [Year_M12]) VALUES (N'2016', 2003, 3213, 4444, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tb_Stat] ([ShowYear], [Year_M1], [Year_M2], [Year_M3], [Year_M4], [Year_M5], [Year_M6], [Year_M7], [Year_M8], [Year_M9], [Year_M10], [Year_M11], [Year_M12]) VALUES (N'2017', 1000, 2000, 5000, 1000, 2832, 6854, 8030, 450, 0, 0, 0, 0)
INSERT [dbo].[tb_stock] ([tradecode], [fullname], [type], [standard], [unit], [produce], [qty], [price], [averageprice], [saleprice], [stockcheck], [upperlimit], [lowerlimit]) VALUES (N'T1011', N'C#200例', N'44', N'TUI', N'本', N'长春', 20, 89.9, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_stock] ([tradecode], [fullname], [type], [standard], [unit], [produce], [qty], [price], [averageprice], [saleprice], [stockcheck], [upperlimit], [lowerlimit]) VALUES (N'T1002', N'C#编程词典', N'1.1', N'1.1', N'个', N'吉林省', 5, 368, 368, 0, 50, 0, 0)
INSERT [dbo].[tb_stock] ([tradecode], [fullname], [type], [standard], [unit], [produce], [qty], [price], [averageprice], [saleprice], [stockcheck], [upperlimit], [lowerlimit]) VALUES (N'T1006', N'C#程序开发范例宝典', N'ISBN', N'ISBN', N'本', N'吉林省', 20, 95, 95, 0, 0, 0, 0)
INSERT [dbo].[tb_stock] ([tradecode], [fullname], [type], [standard], [unit], [produce], [qty], [price], [averageprice], [saleprice], [stockcheck], [upperlimit], [lowerlimit]) VALUES (N'T1007', N'C#从入门到精通', N'ISBN', N'ISBN', N'本', N'吉林省', 90, 79.8, 0, 0, 0, 0, 0)
INSERT [dbo].[tb_stock] ([tradecode], [fullname], [type], [standard], [unit], [produce], [qty], [price], [averageprice], [saleprice], [stockcheck], [upperlimit], [lowerlimit]) VALUES (N'T1003', N'电脑', N'5300', N'5300', N'台', N'中国', 10, 3000, 3000, 0, 0, 0, 0)
INSERT [dbo].[tb_stock] ([tradecode], [fullname], [type], [standard], [unit], [produce], [qty], [price], [averageprice], [saleprice], [stockcheck], [upperlimit], [lowerlimit]) VALUES (N'T1010', N'华为荣耀', N'4X', N'移动版', N'部', N'广东深圳', 100, 1099, 999, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_stock] ([tradecode], [fullname], [type], [standard], [unit], [produce], [qty], [price], [averageprice], [saleprice], [stockcheck], [upperlimit], [lowerlimit]) VALUES (N'T1100', N'零基础学C#', N'1.0', N'全彩版', N'本', N'吉林省长春市', 5000, 59.8, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_stock] ([tradecode], [fullname], [type], [standard], [unit], [produce], [qty], [price], [averageprice], [saleprice], [stockcheck], [upperlimit], [lowerlimit]) VALUES (N'T1004', N'明日软件', N'1.1', N'1.1', N'个', N'吉林省', 8, 500, 500, 0, 0, 0, 0)
INSERT [dbo].[tb_stock] ([tradecode], [fullname], [type], [standard], [unit], [produce], [qty], [price], [averageprice], [saleprice], [stockcheck], [upperlimit], [lowerlimit]) VALUES (N'T1001', N'三星手机', N'2350', N'1.021', N'韩国', N'韩国', 1003, 1200, 1200, 0, 0, 0, 0)
INSERT [dbo].[tb_unit] ([fullname], [tax], [tel], [linkman], [address], [accounts]) VALUES (N'www.vs66.com', N'220441235', N'13664339542', N'小王', N'北京大街22号', N'农业银行22054512313')
INSERT [dbo].[tb_units] ([unitcode], [fullname], [tax], [tel], [linkman], [address], [accounts], [gathering], [payment]) VALUES (N'U1001', N'三星专卖店', N'343743', N'13431346', N'13431346', N'别竟北京', N'34374', NULL, NULL)
INSERT [dbo].[tb_warehouse_detailed] ([billcode], [tradecode], [fullname], [unit], [qty], [price], [tsum], [billdate]) VALUES (N'20110507JH1000001', N'T1002', N'C#编程词典', N'个', 5, 368, 1840, CAST(N'2011-05-07T09:19:52.997' AS DateTime))
INSERT [dbo].[tb_warehouse_detailed] ([billcode], [tradecode], [fullname], [unit], [qty], [price], [tsum], [billdate]) VALUES (N'20110507JH1000001', N'T1003', N'电脑', N'台', 1, 3000, 3000, CAST(N'2011-05-07T09:19:52.997' AS DateTime))
ALTER TABLE [dbo].[tb_power] ADD  CONSTRAINT [DF_tb_power_stock]  DEFAULT ((0)) FOR [stock]
GO
ALTER TABLE [dbo].[tb_power] ADD  CONSTRAINT [DF_tb_power_vendition]  DEFAULT ((0)) FOR [vendition]
GO
ALTER TABLE [dbo].[tb_power] ADD  CONSTRAINT [DF_tb_power_storage]  DEFAULT ((0)) FOR [storage]
GO
ALTER TABLE [dbo].[tb_power] ADD  CONSTRAINT [DF_tb_power_system]  DEFAULT ((0)) FOR [system]
GO
ALTER TABLE [dbo].[tb_power] ADD  CONSTRAINT [DF_tb_power_base]  DEFAULT ((0)) FOR [base]
GO
ALTER TABLE [dbo].[tb_stock] ADD  CONSTRAINT [DF_tb_stock_qty]  DEFAULT ((0)) FOR [qty]
GO
ALTER TABLE [dbo].[tb_stock] ADD  CONSTRAINT [DF_tb_stock_price]  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[tb_stock] ADD  CONSTRAINT [DF_tb_stock_averageprice]  DEFAULT ((0)) FOR [averageprice]
GO
ALTER TABLE [dbo].[tb_stock] ADD  CONSTRAINT [DF_tb_stock_saleprice]  DEFAULT ((0)) FOR [saleprice]
GO
ALTER TABLE [dbo].[tb_stock] ADD  CONSTRAINT [DF_tb_stock_stockcheck]  DEFAULT ((0)) FOR [stockcheck]
GO
ALTER TABLE [dbo].[tb_stock] ADD  CONSTRAINT [DF_tb_stock_upperlimit]  DEFAULT ((0)) FOR [upperlimit]
GO
ALTER TABLE [dbo].[tb_stock] ADD  CONSTRAINT [DF_tb_stock_lowerlimit]  DEFAULT ((0)) FOR [lowerlimit]
GO
ALTER TABLE [dbo].[tb_resell_detailed]  WITH CHECK ADD  CONSTRAINT [FK_tb_resell_detailed_tb_stock] FOREIGN KEY([fullname])
REFERENCES [dbo].[tb_stock] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_resell_detailed] CHECK CONSTRAINT [FK_tb_resell_detailed_tb_stock]
GO
ALTER TABLE [dbo].[tb_resell_main]  WITH CHECK ADD  CONSTRAINT [FK_tb_resell_main_tb_employee] FOREIGN KEY([handle])
REFERENCES [dbo].[tb_employee] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_resell_main] CHECK CONSTRAINT [FK_tb_resell_main_tb_employee]
GO
ALTER TABLE [dbo].[tb_resell_main]  WITH CHECK ADD  CONSTRAINT [FK_tb_resell_main_tb_units] FOREIGN KEY([units])
REFERENCES [dbo].[tb_units] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_resell_main] CHECK CONSTRAINT [FK_tb_resell_main_tb_units]
GO
ALTER TABLE [dbo].[tb_rewarehouse_detailed]  WITH CHECK ADD  CONSTRAINT [FK_tb_rewarehouse_detailed_tb_stock] FOREIGN KEY([fullname])
REFERENCES [dbo].[tb_stock] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_rewarehouse_detailed] CHECK CONSTRAINT [FK_tb_rewarehouse_detailed_tb_stock]
GO
ALTER TABLE [dbo].[tb_rewarehouse_main]  WITH CHECK ADD  CONSTRAINT [FK_tb_rewarehouse_main_tb_employee] FOREIGN KEY([handle])
REFERENCES [dbo].[tb_employee] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_rewarehouse_main] CHECK CONSTRAINT [FK_tb_rewarehouse_main_tb_employee]
GO
ALTER TABLE [dbo].[tb_rewarehouse_main]  WITH CHECK ADD  CONSTRAINT [FK_tb_rewarehouse_main_tb_units] FOREIGN KEY([units])
REFERENCES [dbo].[tb_units] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_rewarehouse_main] CHECK CONSTRAINT [FK_tb_rewarehouse_main_tb_units]
GO
ALTER TABLE [dbo].[tb_sell_detailed]  WITH CHECK ADD  CONSTRAINT [FK_tb_sell_detailed_tb_stock] FOREIGN KEY([fullname])
REFERENCES [dbo].[tb_stock] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_sell_detailed] CHECK CONSTRAINT [FK_tb_sell_detailed_tb_stock]
GO
ALTER TABLE [dbo].[tb_sell_main]  WITH CHECK ADD  CONSTRAINT [FK_tb_sell_main_tb_employee] FOREIGN KEY([handle])
REFERENCES [dbo].[tb_employee] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_sell_main] CHECK CONSTRAINT [FK_tb_sell_main_tb_employee]
GO
ALTER TABLE [dbo].[tb_sell_main]  WITH CHECK ADD  CONSTRAINT [FK_tb_sell_main_tb_units] FOREIGN KEY([units])
REFERENCES [dbo].[tb_units] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_sell_main] CHECK CONSTRAINT [FK_tb_sell_main_tb_units]
GO
ALTER TABLE [dbo].[tb_warehouse_detailed]  WITH CHECK ADD  CONSTRAINT [FK_tb_warehouse_detailed_tb_stock1] FOREIGN KEY([fullname])
REFERENCES [dbo].[tb_stock] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_warehouse_detailed] CHECK CONSTRAINT [FK_tb_warehouse_detailed_tb_stock1]
GO
ALTER TABLE [dbo].[tb_warehouse_main]  WITH CHECK ADD  CONSTRAINT [FK_tb_warehouse_main_tb_employee] FOREIGN KEY([handle])
REFERENCES [dbo].[tb_employee] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_warehouse_main] CHECK CONSTRAINT [FK_tb_warehouse_main_tb_employee]
GO
ALTER TABLE [dbo].[tb_warehouse_main]  WITH CHECK ADD  CONSTRAINT [FK_tb_warehouse_main_tb_units] FOREIGN KEY([units])
REFERENCES [dbo].[tb_units] ([fullname])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tb_warehouse_main] CHECK CONSTRAINT [FK_tb_warehouse_main_tb_units]
GO
