USE [master]
GO
/****** Object:  Database [SalePhoneMangement]    Script Date: 11/18/2022 3:16:31 AM ******/
CREATE DATABASE [SalePhoneMangement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SalePhoneMangement', FILENAME = N'D:\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\SalePhoneMangement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SalePhoneMangement_log', FILENAME = N'D:\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\SalePhoneMangement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SalePhoneMangement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SalePhoneMangement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SalePhoneMangement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET ARITHABORT OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SalePhoneMangement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SalePhoneMangement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SalePhoneMangement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SalePhoneMangement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET RECOVERY FULL 
GO
ALTER DATABASE [SalePhoneMangement] SET  MULTI_USER 
GO
ALTER DATABASE [SalePhoneMangement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SalePhoneMangement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SalePhoneMangement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SalePhoneMangement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SalePhoneMangement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SalePhoneMangement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SalePhoneMangement', N'ON'
GO
ALTER DATABASE [SalePhoneMangement] SET QUERY_STORE = OFF
GO
USE [SalePhoneMangement]
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 11/18/2022 3:16:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[customerID] [int] IDENTITY(1,1) NOT NULL,
	[customerName] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[customerPhoneNumber] [nchar](10) NOT NULL,
	[customerAddress] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblImport]    Script Date: 11/18/2022 3:16:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblImport](
	[importID] [int] IDENTITY(1,1) NOT NULL,
	[importDate] [date] NOT NULL,
	[supplierID] [int] NOT NULL,
 CONSTRAINT [PK_tblImport] PRIMARY KEY CLUSTERED 
(
	[importID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblImportInfo]    Script Date: 11/18/2022 3:16:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblImportInfo](
	[importID] [int] NOT NULL,
	[phoneID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[buyPricePerUnit] [int] NOT NULL,
 CONSTRAINT [PK_ImportInfo] PRIMARY KEY CLUSTERED 
(
	[importID] ASC,
	[phoneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblModel]    Script Date: 11/18/2022 3:16:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblModel](
	[modelID] [int] IDENTITY(1,1) NOT NULL,
	[modelName] [nvarchar](50) NOT NULL,
	[modelOrigin] [nvarchar](10) NOT NULL,
	[modelYearOfWarranty] [int] NOT NULL,
	[modelBrand] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblPhoneInfo] PRIMARY KEY CLUSTERED 
(
	[modelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhone]    Script Date: 11/18/2022 3:16:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhone](
	[phoneID] [int] IDENTITY(1,1) NOT NULL,
	[modelID] [int] NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[showPrice] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_Phone] PRIMARY KEY CLUSTERED 
(
	[phoneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblReceipt]    Script Date: 11/18/2022 3:16:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReceipt](
	[receiptID] [int] IDENTITY(1,1) NOT NULL,
	[receiptDate] [date] NOT NULL,
	[customerID] [int] NOT NULL,
 CONSTRAINT [PK_tblReceipt] PRIMARY KEY CLUSTERED 
(
	[receiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblReceiptInfo]    Script Date: 11/18/2022 3:16:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReceiptInfo](
	[receiptID] [int] NOT NULL,
	[phoneID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[sellPricePerUnit] [int] NOT NULL,
 CONSTRAINT [PK_tblReceiptInfo] PRIMARY KEY CLUSTERED 
(
	[receiptID] ASC,
	[phoneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSupplier]    Script Date: 11/18/2022 3:16:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSupplier](
	[supplierID] [int] IDENTITY(1,1) NOT NULL,
	[supplierName] [nvarchar](100) NOT NULL,
	[supplierPhoneNumber] [nvarchar](10) NOT NULL,
	[supplierAddress] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_tblSupplier] PRIMARY KEY CLUSTERED 
(
	[supplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblCustomer] ON 

INSERT [dbo].[tblCustomer] ([customerID], [customerName], [Gender], [customerPhoneNumber], [customerAddress]) VALUES (1, N'Bui Thanh TU', N'Male', N'0769649469', N'TPHCM')
INSERT [dbo].[tblCustomer] ([customerID], [customerName], [Gender], [customerPhoneNumber], [customerAddress]) VALUES (3, N'Haha', N'Female', N'0909090   ', N'test')
INSERT [dbo].[tblCustomer] ([customerID], [customerName], [Gender], [customerPhoneNumber], [customerAddress]) VALUES (4, N'Vi Van Chi', N'Male', N'234234    ', N'Q9')
INSERT [dbo].[tblCustomer] ([customerID], [customerName], [Gender], [customerPhoneNumber], [customerAddress]) VALUES (5, N'Ve Sy 2', N'Male', N'234234    ', N'Q9')
SET IDENTITY_INSERT [dbo].[tblCustomer] OFF
GO
SET IDENTITY_INSERT [dbo].[tblImport] ON 

INSERT [dbo].[tblImport] ([importID], [importDate], [supplierID]) VALUES (3, CAST(N'2022-02-01' AS Date), 1)
INSERT [dbo].[tblImport] ([importID], [importDate], [supplierID]) VALUES (4, CAST(N'2022-11-17' AS Date), 1)
INSERT [dbo].[tblImport] ([importID], [importDate], [supplierID]) VALUES (5, CAST(N'2022-11-18' AS Date), 1)
INSERT [dbo].[tblImport] ([importID], [importDate], [supplierID]) VALUES (6, CAST(N'2022-11-18' AS Date), 1)
SET IDENTITY_INSERT [dbo].[tblImport] OFF
GO
INSERT [dbo].[tblImportInfo] ([importID], [phoneID], [Quantity], [buyPricePerUnit]) VALUES (4, 1, 100, 13)
INSERT [dbo].[tblImportInfo] ([importID], [phoneID], [Quantity], [buyPricePerUnit]) VALUES (4, 2, 10, 10)
INSERT [dbo].[tblImportInfo] ([importID], [phoneID], [Quantity], [buyPricePerUnit]) VALUES (5, 1, 4, 10)
INSERT [dbo].[tblImportInfo] ([importID], [phoneID], [Quantity], [buyPricePerUnit]) VALUES (6, 6, 100, 9)
GO
SET IDENTITY_INSERT [dbo].[tblModel] ON 

INSERT [dbo].[tblModel] ([modelID], [modelName], [modelOrigin], [modelYearOfWarranty], [modelBrand]) VALUES (1, N'Xiaomi Redmit Note 7', N'China', 2, N'Xiaomi')
INSERT [dbo].[tblModel] ([modelID], [modelName], [modelOrigin], [modelYearOfWarranty], [modelBrand]) VALUES (2, N'Xioami redmi 2', N'CHina', 2, N'Xiaomi 2 ')
INSERT [dbo].[tblModel] ([modelID], [modelName], [modelOrigin], [modelYearOfWarranty], [modelBrand]) VALUES (3, N'Xioami redmi 2', N'CHina', 2, N'Xiaomi 2 ')
INSERT [dbo].[tblModel] ([modelID], [modelName], [modelOrigin], [modelYearOfWarranty], [modelBrand]) VALUES (4, N'Xioami redmi 2', N'CHina', 2, N'Xiaomi 2 ')
INSERT [dbo].[tblModel] ([modelID], [modelName], [modelOrigin], [modelYearOfWarranty], [modelBrand]) VALUES (5, N'Xioami redmi 2', N'CHina', 2, N'Xiaomi 2 ')
INSERT [dbo].[tblModel] ([modelID], [modelName], [modelOrigin], [modelYearOfWarranty], [modelBrand]) VALUES (6, N'IPhone 14 ', N'USA', 1, N'IPhone')
SET IDENTITY_INSERT [dbo].[tblModel] OFF
GO
SET IDENTITY_INSERT [dbo].[tblPhone] ON 

INSERT [dbo].[tblPhone] ([phoneID], [modelID], [type], [showPrice], [quantity]) VALUES (1, 1, N'Xiaomi', 3000, 10)
INSERT [dbo].[tblPhone] ([phoneID], [modelID], [type], [showPrice], [quantity]) VALUES (2, 1, N'Xiaomi', 3000, 10)
INSERT [dbo].[tblPhone] ([phoneID], [modelID], [type], [showPrice], [quantity]) VALUES (3, 2, N'Iphone', 3400, 10)
INSERT [dbo].[tblPhone] ([phoneID], [modelID], [type], [showPrice], [quantity]) VALUES (4, 3, N'LG', 200, 10)
INSERT [dbo].[tblPhone] ([phoneID], [modelID], [type], [showPrice], [quantity]) VALUES (5, 1, N'Xin', 10, 0)
INSERT [dbo].[tblPhone] ([phoneID], [modelID], [type], [showPrice], [quantity]) VALUES (6, 6, N'Pro Max 512GB 64GB ram ', 10, 96)
SET IDENTITY_INSERT [dbo].[tblPhone] OFF
GO
SET IDENTITY_INSERT [dbo].[tblReceipt] ON 

INSERT [dbo].[tblReceipt] ([receiptID], [receiptDate], [customerID]) VALUES (1, CAST(N'2022-01-01' AS Date), 1)
INSERT [dbo].[tblReceipt] ([receiptID], [receiptDate], [customerID]) VALUES (3, CAST(N'2021-02-02' AS Date), 1)
INSERT [dbo].[tblReceipt] ([receiptID], [receiptDate], [customerID]) VALUES (7, CAST(N'2022-11-18' AS Date), 3)
INSERT [dbo].[tblReceipt] ([receiptID], [receiptDate], [customerID]) VALUES (8, CAST(N'2022-11-18' AS Date), 3)
INSERT [dbo].[tblReceipt] ([receiptID], [receiptDate], [customerID]) VALUES (9, CAST(N'2022-11-18' AS Date), 1)
INSERT [dbo].[tblReceipt] ([receiptID], [receiptDate], [customerID]) VALUES (11, CAST(N'2022-11-18' AS Date), 1)
INSERT [dbo].[tblReceipt] ([receiptID], [receiptDate], [customerID]) VALUES (12, CAST(N'2022-11-18' AS Date), 1)
SET IDENTITY_INSERT [dbo].[tblReceipt] OFF
GO
INSERT [dbo].[tblReceiptInfo] ([receiptID], [phoneID], [Quantity], [sellPricePerUnit]) VALUES (1, 3, 100, 99)
INSERT [dbo].[tblReceiptInfo] ([receiptID], [phoneID], [Quantity], [sellPricePerUnit]) VALUES (3, 1, 45, 14)
INSERT [dbo].[tblReceiptInfo] ([receiptID], [phoneID], [Quantity], [sellPricePerUnit]) VALUES (7, 3, 1, 3400)
INSERT [dbo].[tblReceiptInfo] ([receiptID], [phoneID], [Quantity], [sellPricePerUnit]) VALUES (8, 1, 4, 3000)
INSERT [dbo].[tblReceiptInfo] ([receiptID], [phoneID], [Quantity], [sellPricePerUnit]) VALUES (8, 2, 1, 3000)
INSERT [dbo].[tblReceiptInfo] ([receiptID], [phoneID], [Quantity], [sellPricePerUnit]) VALUES (11, 1, 14, 3000)
INSERT [dbo].[tblReceiptInfo] ([receiptID], [phoneID], [Quantity], [sellPricePerUnit]) VALUES (12, 6, 4, 10)
GO
SET IDENTITY_INSERT [dbo].[tblSupplier] ON 

INSERT [dbo].[tblSupplier] ([supplierID], [supplierName], [supplierPhoneNumber], [supplierAddress]) VALUES (1, N'Tu', N'0234', N'test')
INSERT [dbo].[tblSupplier] ([supplierID], [supplierName], [supplierPhoneNumber], [supplierAddress]) VALUES (2, N'test', N'123', N'123')
INSERT [dbo].[tblSupplier] ([supplierID], [supplierName], [supplierPhoneNumber], [supplierAddress]) VALUES (3, N'Vi Van Chi', N'232323', N'Q9')
SET IDENTITY_INSERT [dbo].[tblSupplier] OFF
GO
ALTER TABLE [dbo].[tblImport]  WITH CHECK ADD  CONSTRAINT [FK_tblImport_tblSupplier] FOREIGN KEY([supplierID])
REFERENCES [dbo].[tblSupplier] ([supplierID])
GO
ALTER TABLE [dbo].[tblImport] CHECK CONSTRAINT [FK_tblImport_tblSupplier]
GO
ALTER TABLE [dbo].[tblImportInfo]  WITH CHECK ADD  CONSTRAINT [FK_tblImportInfo_tblImport] FOREIGN KEY([importID])
REFERENCES [dbo].[tblImport] ([importID])
GO
ALTER TABLE [dbo].[tblImportInfo] CHECK CONSTRAINT [FK_tblImportInfo_tblImport]
GO
ALTER TABLE [dbo].[tblImportInfo]  WITH CHECK ADD  CONSTRAINT [FK_tblImportInfo_tblPhone] FOREIGN KEY([phoneID])
REFERENCES [dbo].[tblPhone] ([phoneID])
GO
ALTER TABLE [dbo].[tblImportInfo] CHECK CONSTRAINT [FK_tblImportInfo_tblPhone]
GO
ALTER TABLE [dbo].[tblPhone]  WITH CHECK ADD  CONSTRAINT [FK_tblPhone_tblModel] FOREIGN KEY([modelID])
REFERENCES [dbo].[tblModel] ([modelID])
GO
ALTER TABLE [dbo].[tblPhone] CHECK CONSTRAINT [FK_tblPhone_tblModel]
GO
ALTER TABLE [dbo].[tblReceipt]  WITH CHECK ADD  CONSTRAINT [FK_tblReceipt_tblCustomer] FOREIGN KEY([customerID])
REFERENCES [dbo].[tblCustomer] ([customerID])
GO
ALTER TABLE [dbo].[tblReceipt] CHECK CONSTRAINT [FK_tblReceipt_tblCustomer]
GO
ALTER TABLE [dbo].[tblReceiptInfo]  WITH CHECK ADD  CONSTRAINT [FK_tblReceiptInfo_tblPhone] FOREIGN KEY([phoneID])
REFERENCES [dbo].[tblPhone] ([phoneID])
GO
ALTER TABLE [dbo].[tblReceiptInfo] CHECK CONSTRAINT [FK_tblReceiptInfo_tblPhone]
GO
ALTER TABLE [dbo].[tblReceiptInfo]  WITH CHECK ADD  CONSTRAINT [FK_tblReceiptInfo_tblReceipt] FOREIGN KEY([receiptID])
REFERENCES [dbo].[tblReceipt] ([receiptID])
GO
ALTER TABLE [dbo].[tblReceiptInfo] CHECK CONSTRAINT [FK_tblReceiptInfo_tblReceipt]
GO
USE [master]
GO
ALTER DATABASE [SalePhoneMangement] SET  READ_WRITE 
GO
