USE [master]
GO
/****** Object:  Database [HastaneProje]    Script Date: 19.01.2025 16:35:19 ******/
CREATE DATABASE [HastaneProje]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HastaneProje', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\HastaneProje.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HastaneProje_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\HastaneProje_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HastaneProje] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HastaneProje].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HastaneProje] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HastaneProje] SET ARITHABORT OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [HastaneProje] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HastaneProje] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HastaneProje] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HastaneProje] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HastaneProje] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HastaneProje] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HastaneProje] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HastaneProje] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HastaneProje] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HastaneProje] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HastaneProje] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HastaneProje] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HastaneProje] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HastaneProje] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HastaneProje] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HastaneProje] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HastaneProje] SET  MULTI_USER 
GO
ALTER DATABASE [HastaneProje] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HastaneProje] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HastaneProje] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HastaneProje] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [HastaneProje]
GO
/****** Object:  Table [dbo].[Tbl_Branslar]    Script Date: 19.01.2025 16:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Branslar](
	[Bransid] [tinyint] IDENTITY(1,1) NOT NULL,
	[BransAd] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Doktorlar]    Script Date: 19.01.2025 16:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Doktorlar](
	[Doktorid] [tinyint] IDENTITY(1,1) NOT NULL,
	[DoktorAd] [varchar](10) NULL,
	[DoktorSoyad] [varchar](10) NULL,
	[DoktorBrans] [varchar](30) NULL,
	[DoktorEposta] [varchar](40) NULL,
	[DoktorSifre] [varchar](15) NULL,
 CONSTRAINT [PK_Tbl_Doktorlar] PRIMARY KEY CLUSTERED 
(
	[Doktorid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Hastalar]    Script Date: 19.01.2025 16:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Hastalar](
	[Hastaid] [smallint] IDENTITY(1,1) NOT NULL,
	[HastaAd] [varchar](10) NULL,
	[HastaSoyad] [varchar](10) NULL,
	[HastaEposta] [varchar](40) NULL,
	[HastaSifre] [varchar](15) NULL,
 CONSTRAINT [PK_Tbl_Hastalar] PRIMARY KEY CLUSTERED 
(
	[Hastaid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Randevular]    Script Date: 19.01.2025 16:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Randevular](
	[Randevuid] [int] IDENTITY(1,1) NOT NULL,
	[RandevuTarih] [varchar](10) NULL,
	[RandevuSaat] [varchar](5) NULL,
	[RandevuBrans] [varchar](30) NULL,
	[RandevuDoktor] [varchar](20) NULL,
	[RandevuDurum] [bit] NULL CONSTRAINT [DF_Tbl_Randevular_RandevuDurum]  DEFAULT ((0)),
	[HastaEposta] [varchar](40) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Yonetici]    Script Date: 19.01.2025 16:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Yonetici](
	[Yoneticiid] [tinyint] IDENTITY(1,1) NOT NULL,
	[YoneticiAdSoyad] [varchar](20) NULL,
	[YoneticiEposta] [varchar](40) NULL,
	[YoneticiSifre] [varchar](15) NULL,
 CONSTRAINT [PK_Tbl_Yonetici] PRIMARY KEY CLUSTERED 
(
	[Yoneticiid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Branslar] ON 

INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (1, N'Dahiliye')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (2, N'KBB')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (3, N'Kardiyoloji')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (4, N'Beyin Cerrahisi')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (5, N'Nöroloji')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (6, N'Hematoloji')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (8, N'Psikiyatri')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (9, N'Üroloji')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (10, N'Göğüs Hastalıkları')
SET IDENTITY_INSERT [dbo].[Tbl_Branslar] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Doktorlar] ON 

INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorEposta], [DoktorSifre]) VALUES (1, N'Osman', N'Yılmaz', N'Dahiliye', N'osman_yilmaz@gmail.com', N'12345')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorEposta], [DoktorSifre]) VALUES (2, N'Mehmet', N'Çağdaş', N'KBB', N'Mehmet@gmail', N'000')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorEposta], [DoktorSifre]) VALUES (4, N'Kerem', N'Gürpınar', N'Beyin Cerrahisi', N'Keremg@mail.com', N'kerem123')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorEposta], [DoktorSifre]) VALUES (6, N'Esra', N'Arslan', N'Kardiyoloji', N'Esra.arslan@hotmail.com', N'0')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorEposta], [DoktorSifre]) VALUES (7, N'Fatma', N'Koç', N'Nöroloji', N'Fatmakoc@outlook.com', N'123')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorEposta], [DoktorSifre]) VALUES (8, N'Kemal', N'Aslan', N'KBB', N'Kemal12@mail.com', N'100')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorEposta], [DoktorSifre]) VALUES (9, N'Ali', N'Kaya', N'Psikiyatri', N'Ali1980@gmail.com', N'1980')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorEposta], [DoktorSifre]) VALUES (10, N'Mert', N'Çelik', N'Kardiyoloji', N'Mert@gmail.com', N'0000')
SET IDENTITY_INSERT [dbo].[Tbl_Doktorlar] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Hastalar] ON 

INSERT [dbo].[Tbl_Hastalar] ([Hastaid], [HastaAd], [HastaSoyad], [HastaEposta], [HastaSifre]) VALUES (1, N'Ece', N'Özdemir', N'Ece@gmail.com', N'1234')
INSERT [dbo].[Tbl_Hastalar] ([Hastaid], [HastaAd], [HastaSoyad], [HastaEposta], [HastaSifre]) VALUES (2, N'Mehmet', N'Aydin', N'mehmetaydin@gmail.com', N'1980')
INSERT [dbo].[Tbl_Hastalar] ([Hastaid], [HastaAd], [HastaSoyad], [HastaEposta], [HastaSifre]) VALUES (3, N'Hasan', N'Çavdar', N'hasancavdar@gmail', N'0807')
INSERT [dbo].[Tbl_Hastalar] ([Hastaid], [HastaAd], [HastaSoyad], [HastaEposta], [HastaSifre]) VALUES (4, N'Enes', N'Yılmaz', N'Enes123@gmail.com', N'0123')
INSERT [dbo].[Tbl_Hastalar] ([Hastaid], [HastaAd], [HastaSoyad], [HastaEposta], [HastaSifre]) VALUES (5, N'Ali', N'Okur', N'Ali123@mail.com', N'0101')
INSERT [dbo].[Tbl_Hastalar] ([Hastaid], [HastaAd], [HastaSoyad], [HastaEposta], [HastaSifre]) VALUES (6, N'Zeki', N'Yıldırım', N'zeki@mail.com', N'123')
SET IDENTITY_INSERT [dbo].[Tbl_Hastalar] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Randevular] ON 

INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (16, N'25.01.2025', N'09.30', N'Psikiyatri', N'Ali Kaya', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (2, N'23.01.2025', N'17.30', N'KBB', N'Mehmet Çağdaş', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (3, N'27.01.2025', N'18.00', N'KBB', N'Mehmet Çağdaş', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (4, N'24.01.2025', N'09.30', N'KBB', N'Mehmet Çağdaş', 1, N'zeki@mail.com')
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (5, N'29.01.2025', N'18.30', N'KBB', N'Mehmet Çağdaş', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (9, N'26.01.2025', N'09.15', N'KBB', N'Kemal Aslan', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (7, N'26.01.2025', N'12.15', N'KBB', N'Mehmet Çağdaş', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (8, N'23.01.2025', N'13.15', N'Dahiliye', N'Osman Yılmaz', 1, N'Ece@gmail.com')
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (10, N'23.01.2025', N'11.30', N'KBB', N'Kemal Aslan', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (11, N'24.01.2025', N'13.45', N'KBB', N'Kemal Aslan', 1, N'zeki@mail.com')
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (12, N'22.01.2025', N'15.50', N'Nöroloji', N'Fatma Koç', 1, N'Enes123@gmail.com')
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (13, N'23.01.2025', N'16.30', N'Kardiyoloji', N'Esra Arslan', 1, N'hasancavdar@gmail')
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (15, N'07.01.2025', N'12:45', N'KBB', N'Mehmet Çağdaş', 1, N'mehmetaydin@gmail.com')
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (17, N'25.01.2025', N'09.45', N'Psikiyatri', N'Ali Kaya', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (18, N'25.01.2025', N'10.00', N'Psikiyatri', N'Ali Kaya', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (19, N'25.01.2025', N'10.20', N'Psikiyatri', N'Ali Kaya', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (20, N'25.01.2025', N'10.45', N'Psikiyatri', N'Ali Kaya', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (21, N'25.01.2025', N'11.00', N'Psikiyatri', N'Ali Kaya', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (22, N'25.01.2025', N'11.20', N'Psikiyatri', N'Ali Kaya', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (23, N'25.01.2025', N'12.00', N'Psikiyatri', N'Ali Kaya', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (24, N'25.01.2025', N'14.30', N'Psikiyatri', N'Ali Kaya', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (25, N'25.01.2025', N'10.20', N'Kardiyoloji', N'Esra Arslan', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (26, N'25.01.2025', N'10.20', N'Kardiyoloji', N'Mert Çelik', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (27, N'25.01.2025', N'10.45', N'Kardiyoloji', N'Esra Arslan', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (28, N'25.01.2025', N'11.00', N'Kardiyoloji', N'Esra Arslan', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (29, N'25.01.2025', N'13.45', N'Kardiyoloji', N'Esra Arslan', 0, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaEposta]) VALUES (30, N'25.01.2025', N'15.30', N'Kardiyoloji', N'Mert Çelik', 0, NULL)
SET IDENTITY_INSERT [dbo].[Tbl_Randevular] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Yonetici] ON 

INSERT [dbo].[Tbl_Yonetici] ([Yoneticiid], [YoneticiAdSoyad], [YoneticiEposta], [YoneticiSifre]) VALUES (1, N'Ahmet', N'Ahmet@mail.com', N'Ahmet123')
INSERT [dbo].[Tbl_Yonetici] ([Yoneticiid], [YoneticiAdSoyad], [YoneticiEposta], [YoneticiSifre]) VALUES (2, N'Ali Güneş', N'ali', N'12345')
INSERT [dbo].[Tbl_Yonetici] ([Yoneticiid], [YoneticiAdSoyad], [YoneticiEposta], [YoneticiSifre]) VALUES (3, N'İrem Demir', N'İremdmr@hotmail.com', N'irem')
SET IDENTITY_INSERT [dbo].[Tbl_Yonetici] OFF
USE [master]
GO
ALTER DATABASE [HastaneProje] SET  READ_WRITE 
GO
