USE [master]
GO
/****** Object:  Database [TallerDB]    Script Date: 5/13/2017 10:26:22 AM ******/
CREATE DATABASE [TallerDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TallerDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TallerDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TallerDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TallerDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TallerDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TallerDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TallerDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TallerDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TallerDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TallerDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TallerDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TallerDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TallerDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TallerDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TallerDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TallerDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TallerDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TallerDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TallerDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TallerDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TallerDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TallerDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TallerDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TallerDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TallerDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TallerDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TallerDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TallerDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TallerDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TallerDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TallerDB] SET  MULTI_USER 
GO
ALTER DATABASE [TallerDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TallerDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TallerDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TallerDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TallerDB]
GO
/****** Object:  StoredProcedure [dbo].[ConsultaClientes]    Script Date: 5/13/2017 10:26:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConsultaClientes]

AS
BEGIN
	SELECT * FROM CLiente
END

GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 5/13/2017 10:26:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATe PROCEDURE [dbo].[InsertarCliente]
 @Apellido VARCHAR(100),
 @Nombre VARCHAR(100),
 @Edad INT
AS

BEGIN
	INSERT INTO Cliente VALUES(@Apellido, @Nombre, @Edad)
END
GO
/****** Object:  UserDefinedFunction [dbo].[ObtenerMayor]    Script Date: 5/13/2017 10:26:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ObtenerMayor]() RETURNS INT

AS

BEGIN


	DECLARE @mayor int;

	SELECT @mayor = MAX(Edad) FROM Cliente
	return @mayor;
END
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 5/13/2017 10:26:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](70) NOT NULL,
	[Nombre] [varchar](70) NOT NULL,
	[Edad] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_1]    Script Date: 5/13/2017 10:26:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_1](
	[dfds] [nchar](10) NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [TallerDB] SET  READ_WRITE 
GO
