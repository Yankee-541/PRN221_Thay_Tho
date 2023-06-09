USE [master]
GO
/****** Object:  Database [PRN221]    Script Date: 4/14/2023 12:37:51 AM ******/
CREATE DATABASE [PRN221]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PRN221', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PRN221.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PRN221_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PRN221_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PRN221] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PRN221].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PRN221] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PRN221] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PRN221] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PRN221] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PRN221] SET ARITHABORT OFF 
GO
ALTER DATABASE [PRN221] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PRN221] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PRN221] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PRN221] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PRN221] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PRN221] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PRN221] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PRN221] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PRN221] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PRN221] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PRN221] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PRN221] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PRN221] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PRN221] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PRN221] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PRN221] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PRN221] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PRN221] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PRN221] SET  MULTI_USER 
GO
ALTER DATABASE [PRN221] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PRN221] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PRN221] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PRN221] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PRN221] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PRN221] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PRN221] SET QUERY_STORE = OFF
GO
USE [PRN221]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 4/14/2023 12:37:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 4/14/2023 12:37:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Dob] [datetime] NULL,
	[Gender] [nchar](10) NULL,
	[Active] [bit] NULL,
	[Country] [int] NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [Name]) VALUES (1, N'Viet Nam                                          ')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (2, N'USA                                               ')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (3, N'Canada                                            ')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (4, N'Italia                                            ')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (5, N'Ha noi                                            ')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (6, N'Phap                                              ')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (7, N'Malaisya                                          ')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (8, N'Campuchia                                         ')
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (1, N'DANG', CAST(N'2022-03-26T00:00:00.000' AS DateTime), N'Male      ', 1, 7)
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (2, N'Mai', CAST(N'2022-08-08T00:00:00.000' AS DateTime), N'Female    ', 1, 1)
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (3, N'Mem2', CAST(N'2022-03-26T00:00:00.000' AS DateTime), N'Male      ', 0, 2)
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (4, N'Mem3', CAST(N'2022-08-08T00:00:00.000' AS DateTime), N'Male      ', 0, 2)
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (5, N'Admin', CAST(N'2022-03-26T00:00:00.000' AS DateTime), N'Female    ', 0, 3)
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (6, N'dangfghj', CAST(N'2022-08-08T00:00:00.000' AS DateTime), N'Female    ', 1, 4)
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (8, N'Admin', CAST(N'2022-08-08T00:00:00.000' AS DateTime), N'Female    ', 1, 6)
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (9, N'Admin', CAST(N'2022-03-26T00:00:00.000' AS DateTime), N'Male      ', 1, 3)
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (13, N'dang', CAST(N'2023-04-03T00:00:00.000' AS DateTime), N'Female    ', 1, NULL)
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (14, N'aaaaa', CAST(N'2023-04-12T00:00:00.000' AS DateTime), N'Female    ', 0, NULL)
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (234, N'adf', CAST(N'2023-03-29T00:00:00.000' AS DateTime), N'Male      ', 0, 3)
INSERT [dbo].[Person] ([Id], [Name], [Dob], [Gender], [Active], [Country]) VALUES (2343, N'asdf', CAST(N'2023-04-05T00:00:00.000' AS DateTime), N'Male      ', 1, 3)
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Countries] FOREIGN KEY([Country])
REFERENCES [dbo].[Countries] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Countries]
GO
USE [master]
GO
ALTER DATABASE [PRN221] SET  READ_WRITE 
GO
