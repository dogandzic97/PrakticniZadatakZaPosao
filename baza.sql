USE [master]
GO
/****** Object:  Database [Proizvodi]    Script Date: 1/23/2020 6:31:30 PM ******/
CREATE DATABASE [Proizvodi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proizvodi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.LUKADOGANDZIC\MSSQL\DATA\Proizvodi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proizvodi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.LUKADOGANDZIC\MSSQL\DATA\Proizvodi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Proizvodi] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proizvodi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proizvodi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proizvodi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proizvodi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proizvodi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proizvodi] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proizvodi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proizvodi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proizvodi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proizvodi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proizvodi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proizvodi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proizvodi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proizvodi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proizvodi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proizvodi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Proizvodi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proizvodi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proizvodi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proizvodi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proizvodi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proizvodi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proizvodi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proizvodi] SET RECOVERY FULL 
GO
ALTER DATABASE [Proizvodi] SET  MULTI_USER 
GO
ALTER DATABASE [Proizvodi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proizvodi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proizvodi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proizvodi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proizvodi] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Proizvodi', N'ON'
GO
ALTER DATABASE [Proizvodi] SET QUERY_STORE = OFF
GO
USE [Proizvodi]
GO
/****** Object:  Table [dbo].[Proizvod]    Script Date: 1/23/2020 6:31:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvod](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NULL,
	[Opis] [nvarchar](250) NULL,
	[Kategorija] [nvarchar](100) NULL,
	[Proizvodjac] [nvarchar](50) NULL,
	[Dobavljac] [nvarchar](50) NULL,
	[Cena] [float] NOT NULL,
 CONSTRAINT [PK_Proizvod] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Proizvodi] SET  READ_WRITE 
GO
