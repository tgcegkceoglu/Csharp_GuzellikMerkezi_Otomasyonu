USE [master]
GO
/****** Object:  Database [guzellikmerkezi]    Script Date: 1.9.2021 16:31:11 ******/
CREATE DATABASE [guzellikmerkezi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'musteri', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\musteri.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'musteri_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\musteri_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [guzellikmerkezi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [guzellikmerkezi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [guzellikmerkezi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET ARITHABORT OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [guzellikmerkezi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [guzellikmerkezi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [guzellikmerkezi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [guzellikmerkezi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [guzellikmerkezi] SET  MULTI_USER 
GO
ALTER DATABASE [guzellikmerkezi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [guzellikmerkezi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [guzellikmerkezi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [guzellikmerkezi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [guzellikmerkezi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [guzellikmerkezi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [guzellikmerkezi] SET QUERY_STORE = OFF
GO
USE [guzellikmerkezi]
GO
/****** Object:  Table [dbo].[ayarlar]    Script Date: 1.9.2021 16:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ayarlar](
	[sirketno] [nvarchar](50) NULL,
	[sirketadi] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NULL,
	[mail] [nvarchar](50) NULL,
	[mailsifre] [nvarchar](50) NULL,
	[resim] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bugün]    Script Date: 1.9.2021 16:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bugün](
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[tarih1] [nvarchar](50) NULL,
	[tarih2] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteri]    Script Date: 1.9.2021 16:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteri](
	[musterino] [varchar](50) NULL,
	[adivesoyadi] [varchar](50) NULL,
	[telefon] [varchar](50) NULL,
	[tarih] [varchar](50) NULL,
	[saat] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[seansekleme1]    Script Date: 1.9.2021 16:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seansekleme1](
	[sirano] [nvarchar](50) NULL,
	[adivesoyadi] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NULL,
	[yapilanis] [varchar](50) NULL,
	[seans] [nvarchar](50) NULL,
	[tarih] [nvarchar](50) NULL,
	[saat] [nvarchar](50) NULL,
	[durum] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tahsilat]    Script Date: 1.9.2021 16:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tahsilat](
	[musteriadi] [nvarchar](50) NULL,
	[toplamtutar] [nvarchar](50) NULL,
	[yatirilantutar] [nvarchar](50) NULL,
	[kalantutar] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tahsilat1]    Script Date: 1.9.2021 16:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tahsilat1](
	[sirano] [nvarchar](50) NULL,
	[adivesoyadi] [varchar](50) NULL,
	[telefon] [nvarchar](50) NULL,
	[odenecektutar] [nvarchar](50) NULL,
	[yatirilantutar] [nvarchar](50) NULL,
	[kalantutar] [nvarchar](50) NULL,
	[odemeturu] [varchar](50) NULL,
	[durum] [varchar](50) NULL,
	[tarih] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tarih2]    Script Date: 1.9.2021 16:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tarih2](
	[musteriadi] [nvarchar](50) NULL,
	[tarih] [nvarchar](50) NULL,
	[saat] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ayarlar] ([sirketno], [sirketadi], [telefon], [mail], [mailsifre], [resim]) VALUES (N'1', N'Best My', N'000', N'b@hotmail.com', N'00000', N'C:\Users\user\Desktop\bestmy\gg.png')
GO
INSERT [dbo].[musteri] ([musterino], [adivesoyadi], [telefon], [tarih], [saat]) VALUES (N'1', N'busra', N'123456', N'1.9.2021', N'16:05:49')
INSERT [dbo].[musteri] ([musterino], [adivesoyadi], [telefon], [tarih], [saat]) VALUES (N'2', N'tugce', N'456', N'1.9.2021', N'16:05:56')
GO
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'1', N'busra', N'123456', N'ilkkk', N'4', N'01.09.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'2', N'busra', N'123456', N'ilk', N'4', N'16.09.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'3', N'busra', N'123456', N'ilk', N'4', N'01.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'4', N'busra', N'123456', N'ilk', N'4', N'16.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'5', N'busra', N'123456', N'ikinci', N'5', N'02.09.2021', N'16:08:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'6', N'busra', N'123456', N'ikinci', N'5', N'12.09.2021', N'16:08:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'7', N'busra', N'123456', N'ikinci', N'5', N'22.09.2021', N'16:08:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'8', N'busra', N'123456', N'ikinci', N'5', N'02.10.2021', N'16:08:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'9', N'busra', N'123456', N'ikinci', N'5', N'12.10.2021', N'16:08:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'10', N'busra', N'123456', N'ikinci', N'5', N'02.9.2021', N'16:08:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'11', N'busra', N'123456', N'ikinci', N'5', N'12.09.2021', N'16:08:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'12', N'busra', N'123456', N'ikinci', N'5', N'22.09.2021', N'16:08:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'13', N'busra', N'123456', N'ikinci', N'5', N'02.10.2021', N'16:08:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'14', N'busra', N'123456', N'ikinci', N'5', N'12.10.2021', N'16:08:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'20', N'busra', N'123456', N'son', N'5', N'01.9.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'21', N'busra', N'123456', N'son', N'5', N'16.09.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'22', N'busra', N'123456', N'son', N'5', N'01.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'23', N'busra', N'123456', N'son', N'5', N'16.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'24', N'busra', N'123456', N'son', N'5', N'31.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'25', N'busra', N'123456', N'son', N'5', N'01.09.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'26', N'busra', N'123456', N'son', N'5', N'16.09.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'27', N'busra', N'123456', N'son', N'5', N'01.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'28', N'busra', N'123456', N'son', N'5', N'16.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'29', N'busra', N'123456', N'son', N'5', N'31.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'30', N'busra', N'123456', N'son', N'5', N'01.09.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'31', N'busra', N'123456', N'son', N'5', N'16.09.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'32', N'busra', N'123456', N'son', N'5', N'01.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'33', N'busra', N'123456', N'son', N'5', N'16.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'34', N'busra', N'123456', N'son', N'5', N'31.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'35', N'tugce', N'456', N'eee', N'5', N'02.09.2021', N'16:11:10', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'36', N'tugce', N'456', N'eee', N'5', N'06.09.2021', N'16:11:10', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'37', N'tugce', N'456', N'eee', N'5', N'10.09.2021', N'16:11:10', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'38', N'tugce', N'456', N'eee', N'5', N'14.09.2021', N'16:11:10', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'39', N'tugce', N'456', N'eee', N'5', N'18.09.2021', N'16:11:10', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'40', N'busra', N'123456', N'hhh', N'1', N'02.09.2021', N'16:13:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'15', N'busra', N'123456', N'ggg', N'5', N'01.9.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'16', N'busra', N'123456', N'ggg', N'5', N'16.09.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'17', N'busra', N'123456', N'ggg', N'5', N'01.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'18', N'busra', N'123456', N'ggg', N'5', N'16.10.2021', N'14:15:00', NULL)
INSERT [dbo].[seansekleme1] ([sirano], [adivesoyadi], [telefon], [yapilanis], [seans], [tarih], [saat], [durum]) VALUES (N'19', N'busra', N'123456', N'ggg', N'5', N'31.10.2021', N'14:15:00', NULL)
GO
INSERT [dbo].[tahsilat] ([musteriadi], [toplamtutar], [yatirilantutar], [kalantutar]) VALUES (N'busra', N'1500', N'1500', N'0')
GO
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'1', N'busra', N'123456', N'1500', N'1500', N'0', N'Nakit Ödeme', N'Ödendi', N'Jan  9 2021 12:00AM')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'2', N'busra', N'123456', N'1500', N'0', N'1500', N'Nakit Ödeme', N'Bekleniyor', N'Feb  9 2021 12:00AM')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'3', N'busra', N'123456', N'500', N'0', N'500', N'Elden Taksit', N'Bekleniyor', N'Feb  9 2021 12:00AM')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'4', N'busra', N'123456', N'500', N'0', N'500', N'Elden Taksit', N'Bekleniyor', N'Dec  9 2021 12:00AM')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'5', N'busra', N'123456', N'500', N'0', N'500', N'Elden Taksit', N'Bekleniyor', N'Jan  9 2021 12:00AM')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'6', N'busra', N'123456', N'500', N'0', N'500', N'Elden Taksit', N'Bekleniyor', N'01.09.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'7', N'busra', N'123456', N'500', N'0', N'500', N'Elden Taksit', N'Bekleniyor', N'16.09.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'8', N'busra', N'123456', N'500', N'0', N'500', N'Elden Taksit', N'Bekleniyor', N'01.10.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'9', N'busra', N'123456', N'250', N'0', N'250', N'Elden Taksit', N'Bekleniyor', N'01.09.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'10', N'busra', N'123456', N'250', N'0', N'250', N'Elden Taksit', N'Bekleniyor', N'16.09.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'11', N'busra', N'123456', N'250', N'0', N'250', N'Elden Taksit', N'Bekleniyor', N'01.10.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'12', N'busra', N'123456', N'250', N'0', N'250', N'Elden Taksit', N'Bekleniyor', N'16.10.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'13', N'busra', N'123456', N'250', N'0', N'250', N'Elden Taksit', N'Bekleniyor', N'31.10.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'14', N'busra', N'123456', N'250', N'0', N'250', N'Elden Taksit', N'Bekleniyor', N'15.11.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'15', N'busra', N'123456', N'166,67', N'0', N'166,67', N'Elden Taksit', N'Bekleniyor', N'01.09.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'16', N'busra', N'123456', N'166,67', N'0', N'166,67', N'Elden Taksit', N'Bekleniyor', N'16.09.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'17', N'busra', N'123456', N'166,67', N'0', N'166,67', N'Elden Taksit', N'Bekleniyor', N'01.10.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'18', N'busra', N'123456', N'166,67', N'0', N'166,67', N'Elden Taksit', N'Bekleniyor', N'16.10.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'19', N'busra', N'123456', N'166,67', N'0', N'166,67', N'Elden Taksit', N'Bekleniyor', N'31.10.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'20', N'busra', N'123456', N'166,67', N'0', N'166,67', N'Elden Taksit', N'Bekleniyor', N'15.11.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'21', N'busra', N'123456', N'166,67', N'0', N'166,67', N'Elden Taksit', N'Bekleniyor', N'30.11.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'22', N'busra', N'123456', N'166,67', N'0', N'166,67', N'Elden Taksit', N'Bekleniyor', N'15.12.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'23', N'busra', N'123456', N'166,67', N'0', N'166,67', N'Elden Taksit', N'Bekleniyor', N'30.12.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'24', N'tugce', N'456', N'1500', N'0', N'1500', N'Nakit Ödeme', N'Bekleniyor', N'02.09.2021')
INSERT [dbo].[tahsilat1] ([sirano], [adivesoyadi], [telefon], [odenecektutar], [yatirilantutar], [kalantutar], [odemeturu], [durum], [tarih]) VALUES (N'25', N'busra', N'123456', N'1500', N'0', N'1500', N'Nakit Ödeme', N'Bekleniyor', N'02.09.2021')
GO
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Aug 31 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Sep 10 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Sep 20 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Sep 30 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Oct 10 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Sep  1 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Sep 11 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Sep 21 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Oct  1 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Oct 11 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Oct 21 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Oct 31 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Sep 15 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'eee', N'Oct 15 2021 12:00AM', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'busra', N'31.8.2021 00:00:00', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'busra', N'15.09.2021', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'busra', N'30.09.2021', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'busra', N'15.10.2021', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'busra', N'1.9.2021 00:00:00', N'16:08:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'busra', N'11.09.2021', N'16:08:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'busra', N'21.09.2021', N'16:08:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'busra', N'01.10.2021', N'16:08:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'busra', N'11.10.2021', N'16:08:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'busra', N'30.10.2021', N'14:15:00')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'tugce', N'1.9.2021 00:00:00', N'16:11:10')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'tugce', N'05.09.2021', N'16:11:10')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'tugce', N'09.09.2021', N'16:11:10')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'tugce', N'13.09.2021', N'16:11:10')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'tugce', N'17.09.2021', N'16:11:10')
INSERT [dbo].[tarih2] ([musteriadi], [tarih], [saat]) VALUES (N'busra', N'1.9.2021 00:00:00', N'16:13:00')
GO
USE [master]
GO
ALTER DATABASE [guzellikmerkezi] SET  READ_WRITE 
GO
