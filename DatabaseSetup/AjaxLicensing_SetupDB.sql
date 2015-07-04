USE [master]
GO

/****** Object:  Database [AjaxLicensing]    Script Date: 4/07/2015 9:12:25 p.m. ******/
CREATE DATABASE [AjaxLicensing]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AjaxLicensing', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AjaxLicensing.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AjaxLicensing_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AjaxLicensing_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [AjaxLicensing] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AjaxLicensing].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [AjaxLicensing] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [AjaxLicensing] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [AjaxLicensing] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [AjaxLicensing] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [AjaxLicensing] SET ARITHABORT OFF 
GO

ALTER DATABASE [AjaxLicensing] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [AjaxLicensing] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [AjaxLicensing] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [AjaxLicensing] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [AjaxLicensing] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [AjaxLicensing] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [AjaxLicensing] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [AjaxLicensing] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [AjaxLicensing] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [AjaxLicensing] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [AjaxLicensing] SET  DISABLE_BROKER 
GO

ALTER DATABASE [AjaxLicensing] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [AjaxLicensing] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [AjaxLicensing] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [AjaxLicensing] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [AjaxLicensing] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [AjaxLicensing] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [AjaxLicensing] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [AjaxLicensing] SET RECOVERY FULL 
GO

ALTER DATABASE [AjaxLicensing] SET  MULTI_USER 
GO

ALTER DATABASE [AjaxLicensing] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [AjaxLicensing] SET DB_CHAINING OFF 
GO

ALTER DATABASE [AjaxLicensing] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [AjaxLicensing] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [AjaxLicensing] SET  READ_WRITE 
GO

