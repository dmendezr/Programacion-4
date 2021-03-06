USE [master]
GO
/****** Object:  Database [Promerica]    Script Date: 06/03/2017 06:28:47 p.m. ******/
CREATE DATABASE [Promerica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Promerica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Promerica.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Promerica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Promerica_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Promerica] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Promerica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Promerica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Promerica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Promerica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Promerica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Promerica] SET ARITHABORT OFF 
GO
ALTER DATABASE [Promerica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Promerica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Promerica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Promerica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Promerica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Promerica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Promerica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Promerica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Promerica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Promerica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Promerica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Promerica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Promerica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Promerica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Promerica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Promerica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Promerica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Promerica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Promerica] SET  MULTI_USER 
GO
ALTER DATABASE [Promerica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Promerica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Promerica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Promerica] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Promerica] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Promerica]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 06/03/2017 06:28:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [varchar](50) NOT NULL,
	[NombreCliente] [varchar](50) NULL,
	[Apellido1Cliente] [varchar](50) NULL,
	[Apellido2Cliente] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Creditos]    Script Date: 06/03/2017 06:28:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Creditos](
	[IdCliente] [varchar](50) NULL,
	[IdOperacion] [varchar](50) NOT NULL,
	[MontoAprobado] [float] NULL,
	[Tasa] [float] NULL,
	[FechaFormalizacion] [datetime] NULL,
	[Plazo] [int] NULL,
	[FechaVencimiento]  AS (dateadd(month,[Plazo],[FechaFormalizacion])),
	[Saldo] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102420404', N'AMALIA', N'SOLANO', N'SALAZARRzz')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102440158', N'ELVIRA', N'DELGADO', N'MADRIGAL')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102530686', N'MANUEL', N'SOLANO', N'JIMENEZ')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102650390', N'BLANCA ROSA', N'MORA', N'CASCANTE')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102720754', N'JOSE FRANCISCO', N'SANCHEZ', N'ARAYA')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102740189', N'MILDRED', N'FERNANDEZ', N'SANCHEZ')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102750991', N'JUAN BENITO', N'RODRIGUEZ', N'VENEGAS')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102770580', N'NIEVES', N'ARIAS', N'MELENDEZ')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102820463', N'ESTRELLA', N'MORA', N'SABORIO')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102840793', N'LIGIA MARIA', N'RODRIGUEZ', N'SEQUEIRA')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102860655', N'JUAN RAFAEL', N'MORA', N'VARGAS')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102890374', N'JAVIER', N'MADRIGAL', N'LEON')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102910928', N'WALTER', N'ROJAS', N'CALDERON')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102950564', N'LUIS ROBERTO', N'BONILLA', N'SANCHEZ')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102970983', N'MARIA EUGENIA', N'QUIROS', N'VALVERDE')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102980843', N'MARIA CECILIA', N'FLORES', N'RIBA')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'102990429', N'NORMA', N'ASTORGA', N'SANCHEZ')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'103040598', N'CARLOS FERNANDO', N'MONGE', N'CHAVES')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'103040947', N'LIDIA MARTA', N'BEJARANO', N'SANDOVAL')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'103060452', N'ELIZABETH', N'FALLAS', N'SEAS')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'103090019', N'FLOR MARIA', N'CORRALES', N'MORA')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'103090247', N'MARIA CECILIA', N'VALVERDE', N'MARTINEZ')
GO
INSERT [dbo].[Clientes] ([IdCliente], [NombreCliente], [Apellido1Cliente], [Apellido2Cliente]) VALUES (N'103120967', N'RODOLFO DE JESUS', N'CORRALES', N'CORRALES')
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102420404', N'CRED193093', 2644681.32, 18.5, CAST(N'2015-09-17 11:19:00.000' AS DateTime), 48, 2284568.13)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102420404', N'CRED199681', 1527502.65, 15.75, CAST(N'2016-01-22 12:35:55.000' AS DateTime), 48, 1409207.49)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102420404', N'CRED201436', 419790.2, 11.5, CAST(N'2016-02-22 15:04:57.000' AS DateTime), 48, 391673.6)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102420404', N'CRED203071', 264890.13, 17.25, CAST(N'2016-03-17 15:23:53.000' AS DateTime), 24, 236523.84)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102440158', N'CRED200873', 2653873.56, 18.25, CAST(N'2016-02-12 10:30:53.000' AS DateTime), 48, 2538302.63)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102440158', N'CRED206627', 209814.36, 11.25, CAST(N'2016-05-23 12:51:06.000' AS DateTime), 24, 209814.36)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102440158', N'CRED209339', 314171.56, 11.25, CAST(N'2016-07-04 10:26:45.000' AS DateTime), 24, 314171.56)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102440158', N'CRED165598', 225603.6, 20.25, CAST(N'2014-06-26 12:48:52.000' AS DateTime), 24, 11318.78)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102530686', N'CRED167048', 1298041.86, 16, CAST(N'2014-07-15 17:51:20.000' AS DateTime), 24, 124614.99)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102650390', N'CRED136608', 827384.14, 21, CAST(N'2013-03-06 14:46:54.000' AS DateTime), 60, 395587.59)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102650390', N'CRED181151', 157681.23, 17, CAST(N'2015-03-17 14:00:19.000' AS DateTime), 18, 38568.58)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102650390', N'CRED199110', 152411.41, 17, CAST(N'2016-01-08 17:07:29.000' AS DateTime), 24, 130444.53)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102720754', N'CRED187335', 534887.12, 12.25, CAST(N'2015-06-24 15:53:57.000' AS DateTime), 24, 305840.49)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102720754', N'CRED181321', 1235411.39, 15.5, CAST(N'2015-03-19 14:58:05.000' AS DateTime), 36, 821359.95)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102720754', N'CRED151862', 1071210.57, 13, CAST(N'2013-10-25 09:47:37.000' AS DateTime), 36, 144480.18)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102740189', N'CRED180403', 118346.13, 17, CAST(N'2015-03-05 10:51:17.000' AS DateTime), 24, 54200.79)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102740189', N'CRED209672', 318920.43, 15.5, CAST(N'2016-07-07 11:00:11.000' AS DateTime), 60, 318920.43)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102740189', N'CRED207969', 317981.47, 15.5, CAST(N'2016-06-13 11:02:19.000' AS DateTime), 60, 317981.47)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102740189', N'CRED200445', 790607.98, 11.25, CAST(N'2016-02-05 10:34:11.000' AS DateTime), 24, 701189.7)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102740189', N'CRED186774', 482692.59, 12.25, CAST(N'2015-06-16 14:49:06.000' AS DateTime), 24, 275996.71)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102740189', N'CRED204580', 629960.32, 11.25, CAST(N'2016-04-19 09:37:12.000' AS DateTime), 48, 619507.95)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102750991', N'CRED198827', 261809.65, 11.25, CAST(N'2016-01-04 13:54:08.000' AS DateTime), 48, 239678.64)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102750991', N'CRED194820', 3882529.99, 18.25, CAST(N'2015-10-16 10:13:46.000' AS DateTime), 24, 2891441.04)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102750991', N'CRED170839', 1245280.43, 12.5, CAST(N'2014-09-03 12:46:27.000' AS DateTime), 24, 229632.82)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102750991', N'CRED200460', 267163.17, 17, CAST(N'2016-02-05 12:02:06.000' AS DateTime), 24, 238487.73)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102750991', N'CRED178307', 576782.06, 15.5, CAST(N'2015-01-27 11:44:18.000' AS DateTime), 24, 212302.57)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102770580', N'CRED149190', 2706246.34, 19.5, CAST(N'2013-09-17 15:04:46.000' AS DateTime), 36, 297783.16)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102770580', N'CRED175206', 432714.19, 12.5, CAST(N'2014-11-17 15:02:14.000' AS DateTime), 24, 118466.73)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102770580', N'CRED157515', 2728088.9, 21, CAST(N'2014-02-13 12:05:02.000' AS DateTime), 36, 846842.55)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102770580', N'CRED182574', 107273.65, 12.5, CAST(N'2015-04-09 14:52:05.000' AS DateTime), 24, 52485.77)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102770580', N'CRED173021', 542927.56, 12.5, CAST(N'2014-10-06 13:36:19.000' AS DateTime), 24, 124504.4)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102820463', N'CRED185611', 1796909.08, 16.25, CAST(N'2015-05-28 13:35:00.000' AS DateTime), 24, 970807.17)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102820463', N'CRED203177', 3347602.22, 19, CAST(N'2016-03-18 16:45:24.000' AS DateTime), 48, 3252676.63)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102840793', N'CRED206184', 792635.61, 15.5, CAST(N'2016-05-16 10:01:10.000' AS DateTime), 48, 792635.61)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102840793', N'CRED196809', 1429078.99, 12.25, CAST(N'2015-11-20 11:01:08.000' AS DateTime), 48, 1286152.9)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102860655', N'CRED196216', 1144169.64, 15.5, CAST(N'2015-11-10 10:05:30.000' AS DateTime), 24, 890271.85)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102890374', N'CRED207507', 107357.77, 16.25, CAST(N'2016-06-06 11:49:15.000' AS DateTime), 12, 107357.77)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102890374', N'CRED201273', 311933.22, 12, CAST(N'2016-02-18 16:08:47.000' AS DateTime), 12, 237406.19)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102910928', N'CRED208835', 2079895.17, 17, CAST(N'2016-06-27 10:00:07.000' AS DateTime), 48, 2079895.17)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102910928', N'CRED166177', 1286563.2, 15.25, CAST(N'2014-07-03 15:47:45.000' AS DateTime), 36, 533207.92)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102950564', N'CRED204833', 1560043.98, 19, CAST(N'2016-04-22 14:09:23.000' AS DateTime), 48, 1515806.92)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102970983', N'CRED203350', 1065333.47, 15.75, CAST(N'2016-03-22 11:55:35.000' AS DateTime), 48, 1032976.31)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102970983', N'CRED205398', 396187.52, 11.5, CAST(N'2016-05-03 08:45:22.000' AS DateTime), 48, 389648.17)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102970983', N'CRED200149', 2342615.01, 19, CAST(N'2016-02-01 16:16:26.000' AS DateTime), 48, 2207639.11)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102980843', N'CRED164750', 1039337.65, 16, CAST(N'2014-06-12 11:25:27.000' AS DateTime), 36, 433489.48)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102990429', N'CRED137061', 3744073.64, 18, CAST(N'2013-03-13 19:06:14.000' AS DateTime), 72, 2249404.42)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102990429', N'CRED202474', 7767057.57, 18.25, CAST(N'2016-03-09 11:37:54.000' AS DateTime), 48, 7543270.3)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'102990429', N'CRED200217', 1525642.36, 18.25, CAST(N'2016-02-02 13:44:17.000' AS DateTime), 48, 1436380.4)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103040598', N'CRED153271', 1037667.11, 17, CAST(N'2013-11-18 14:47:03.000' AS DateTime), 60, 616397.85)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103040947', N'CRED197575', 3896123.71, 18.25, CAST(N'2015-12-07 11:26:17.000' AS DateTime), 48, 3608998.61)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103040947', N'CRED192902', 795677.51, 15.5, CAST(N'2015-09-14 10:57:44.000' AS DateTime), 60, 721499.82)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103040947', N'CRED170424', 986705.02, 15.5, CAST(N'2014-08-29 11:31:49.000' AS DateTime), 60, 723554.68)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103040947', N'CRED183875', 2265610.55, 18.25, CAST(N'2015-04-29 14:45:48.000' AS DateTime), 84, 2073244.69)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103040947', N'CRED200312', 314074.21, 11.25, CAST(N'2016-02-03 15:16:23.000' AS DateTime), 48, 292934.63)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103040947', N'CRED207496', 1189565.75, 11.25, CAST(N'2016-06-06 10:55:14.000' AS DateTime), 60, 1189565.75)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103060452', N'CRED207219', 1591924.86, 16.25, CAST(N'2016-06-01 14:27:59.000' AS DateTime), 48, 1591924.86)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103060452', N'CRED203799', 3182491.52, 18, CAST(N'2016-04-04 13:38:20.000' AS DateTime), 48, 3090308.64)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103090019', N'CRED204190', 453594.2, 21.25, CAST(N'2016-04-12 10:07:37.000' AS DateTime), 60, 449291.5)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103090019', N'CRED200707', 1925981.94, 19, CAST(N'2016-02-10 08:44:17.000' AS DateTime), 84, 1892085.05)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103090019', N'CRED207832', 289946.51, 12, CAST(N'2016-06-10 10:57:42.000' AS DateTime), 60, 289946.51)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103090019', N'CRED210419', 268833.35, 17.75, CAST(N'2016-07-18 11:31:03.000' AS DateTime), 24, 268833.35)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103090019', N'CRED194809', 1075809.99, 19, CAST(N'2015-10-16 08:48:26.000' AS DateTime), 84, 1030201.88)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103090019', N'CRED191296', 1871609.29, 16.25, CAST(N'2015-08-21 08:51:17.000' AS DateTime), 60, 1677570.7)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103090247', N'CRED129023', 642234.88, 19.75, CAST(N'2012-09-26 15:49:11.000' AS DateTime), 60, 226375.5)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103120967', N'CRED095903', 2143373.22, 18.35, CAST(N'2011-01-13 14:54:03.000' AS DateTime), 72, 333055.18)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103120967', N'CRED107168', 1127607.89, 18.5, CAST(N'2011-08-10 15:15:30.000' AS DateTime), 72, 331970.31)
GO
INSERT [dbo].[Creditos] ([IdCliente], [IdOperacion], [MontoAprobado], [Tasa], [FechaFormalizacion], [Plazo], [Saldo]) VALUES (N'103120967', N'CRED155086', 8376671.94, 21.75, CAST(N'2013-12-19 12:09:23.000' AS DateTime), 96, 7101469.5)
GO
ALTER TABLE [dbo].[Creditos]  WITH CHECK ADD FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
USE [master]
GO
ALTER DATABASE [Promerica] SET  READ_WRITE 
GO
