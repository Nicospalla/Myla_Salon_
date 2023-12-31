USE [master]
GO
/****** Object:  Database [MYLA_DB]    Script Date: 18/9/2023 19:25:28 ******/
CREATE DATABASE [MYLA_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MYLA_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MYLA_DB.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MYLA_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MYLA_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MYLA_DB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MYLA_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MYLA_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MYLA_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MYLA_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MYLA_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MYLA_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MYLA_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MYLA_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MYLA_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MYLA_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MYLA_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MYLA_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MYLA_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MYLA_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MYLA_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MYLA_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MYLA_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MYLA_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MYLA_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MYLA_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MYLA_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MYLA_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MYLA_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MYLA_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MYLA_DB] SET  MULTI_USER 
GO
ALTER DATABASE [MYLA_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MYLA_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MYLA_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MYLA_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MYLA_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MYLA_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MYLA_DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [MYLA_DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MYLA_DB]
GO
/****** Object:  Table [dbo].[CAJA]    Script Date: 18/9/2023 19:25:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAJA](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Inicio] [int] NULL,
	[Retiro] [int] NULL,
	[RetiroMotivo] [varchar](100) NULL,
	[PagoProv] [int] NULL,
	[NombreProv] [varchar](100) NULL,
	[Ingreso] [int] NULL,
	[PagoTarjeta] [int] NULL,
	[PagoEfectivo] [int] NULL,
	[IdCliente] [int] NULL,
	[IdEspe] [int] NULL,
	[Estado] [bit] NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_CAJA] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 18/9/2023 19:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DATOSCLIENTES]    Script Date: 18/9/2023 19:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATOSCLIENTES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[Telefono] [varchar](50) NULL,
	[Cumple] [date] NULL,
	[UltimaVisita] [date] NULL,
	[UltimoContacto] [date] NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_DATOSCLIENTES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESPECIALISTAS]    Script Date: 18/9/2023 19:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESPECIALISTAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NULL,
	[Email] [varchar](200) NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Cumple] [date] NULL,
	[Sueldo] [money] NULL,
	[Porcentaje] [float] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_ESPECIALISTAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESPECIALISTAS_CATEGORIAS]    Script Date: 18/9/2023 19:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESPECIALISTAS_CATEGORIAS](
	[idCat] [int] NOT NULL,
	[idEsp] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HISTORIAL_VENTAS]    Script Date: 18/9/2023 19:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORIAL_VENTAS](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdEspecialista] [int] NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[IdSubcategoria] [int] NULL,
	[ServicioAdicional] [varchar](200) NULL,
	[CodigoTinte] [varchar](100) NULL,
	[Fecha] [date] NOT NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_HISTORIAL_VENTAS] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOGIN]    Script Date: 18/9/2023 19:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOGIN](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Admin] [bit] NOT NULL,
 CONSTRAINT [PK_LOGIN] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUBCATEGORIA]    Script Date: 18/9/2023 19:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUBCATEGORIA](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Duracion] [time](7) NOT NULL,
 CONSTRAINT [PK_SUBCATEGORIA] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TURNOS]    Script Date: 18/9/2023 19:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TURNOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTurno] [int] NULL,
	[IdCliente] [int] NOT NULL,
	[IdSubCategoria] [int] NOT NULL,
	[IdEspecialista] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[HoraInicio] [time](7) NOT NULL,
	[HoraFin] [time](7) NOT NULL,
	[Estado] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TURNOS_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CAJA] ON 

INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (22, N'nicolas', 1000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, CAST(N'2023-09-12' AS Date))
INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (23, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3989, 2, 6, NULL, CAST(N'2023-09-10' AS Date))
INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (25, NULL, 2000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-09-13' AS Date))
INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (26, N'Nicolas', 2000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-09-12' AS Date))
INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (27, N'Nicolas', NULL, NULL, NULL, NULL, NULL, 3000, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-09-13' AS Date))
INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (28, N'Nicolas', NULL, 2000, N'Compra papel', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-09-13' AS Date))
INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (29, N'Nicolas', NULL, NULL, NULL, 3500, N'Pantenne', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-09-13' AS Date))
INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 4, 5, NULL, CAST(N'2023-09-13' AS Date))
INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (31, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 10000, 4, 5, NULL, CAST(N'2023-09-13' AS Date))
INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (32, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 12000, NULL, 1, 4, NULL, CAST(N'2023-09-13' AS Date))
INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (33, N'florencia', 15000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, CAST(N'2023-09-14' AS Date))
INSERT [dbo].[CAJA] ([Id], [Usuario], [Inicio], [Retiro], [RetiroMotivo], [PagoProv], [NombreProv], [Ingreso], [PagoTarjeta], [PagoEfectivo], [IdCliente], [IdEspe], [Estado], [Fecha]) VALUES (34, N'admin', 25000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, CAST(N'2023-09-18' AS Date))
SET IDENTITY_INSERT [dbo].[CAJA] OFF
GO
SET IDENTITY_INSERT [dbo].[CATEGORIAS] ON 

INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (1, N'Peluqueria')
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (2, N'Manicura')
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (3, N'Masajes')
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (4, N'Pedicura')
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (5, N'Cejas')
INSERT [dbo].[CATEGORIAS] ([Id], [Descripcion]) VALUES (6, N'Pestanas')
SET IDENTITY_INSERT [dbo].[CATEGORIAS] OFF
GO
SET IDENTITY_INSERT [dbo].[DATOSCLIENTES] ON 

INSERT [dbo].[DATOSCLIENTES] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [UltimaVisita], [UltimoContacto], [Estado]) VALUES (1, N'Nicolas', N'Spalla', N'Nico@Spalla.com', N'876543', CAST(N'1990-10-12' AS Date), CAST(N'2023-08-27' AS Date), CAST(N'2023-08-27' AS Date), 1)
INSERT [dbo].[DATOSCLIENTES] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [UltimaVisita], [UltimoContacto], [Estado]) VALUES (2, N'Catalina', N'Spalla', N'cata@spalla.com', N'34234254', CAST(N'2023-06-16' AS Date), CAST(N'2023-08-27' AS Date), CAST(N'2023-08-27' AS Date), 1)
INSERT [dbo].[DATOSCLIENTES] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [UltimaVisita], [UltimoContacto], [Estado]) VALUES (3, N'Florencia', N'maza', N'flo.maza@gmail.com', N'34234254', CAST(N'1993-02-15' AS Date), CAST(N'2023-08-27' AS Date), CAST(N'2023-08-27' AS Date), 1)
INSERT [dbo].[DATOSCLIENTES] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [UltimaVisita], [UltimoContacto], [Estado]) VALUES (4, N'Armando', N'Cajones', N'armando@micajon.com', N'34234254', CAST(N'1990-01-01' AS Date), CAST(N'2023-08-27' AS Date), CAST(N'2023-08-27' AS Date), 1)
INSERT [dbo].[DATOSCLIENTES] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [UltimaVisita], [UltimoContacto], [Estado]) VALUES (15, N'Milagros', N'Maza', N'mili.maza@gmail.com', N'987654321', CAST(N'2001-02-16' AS Date), NULL, NULL, 0)
INSERT [dbo].[DATOSCLIENTES] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [UltimaVisita], [UltimoContacto], [Estado]) VALUES (16, N'Cesar', N'Salvatierra', N'cs@gmail.com', N'12341234', CAST(N'2001-07-15' AS Date), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[DATOSCLIENTES] OFF
GO
SET IDENTITY_INSERT [dbo].[ESPECIALISTAS] ON 

INSERT [dbo].[ESPECIALISTAS] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [Sueldo], [Porcentaje], [Estado]) VALUES (1, N'Juancho', N'Martinez', N'123@gmial.com', N'12345', CAST(N'1994-08-10' AS Date), 150000.0000, 20, 1)
INSERT [dbo].[ESPECIALISTAS] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [Sueldo], [Porcentaje], [Estado]) VALUES (2, N'prueba2', N'prueba2', N'prueba2', N'123', NULL, NULL, NULL, 0)
INSERT [dbo].[ESPECIALISTAS] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [Sueldo], [Porcentaje], [Estado]) VALUES (3, N'prueba3', N'prueba3', N'prueba3', N'123', NULL, NULL, NULL, 0)
INSERT [dbo].[ESPECIALISTAS] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [Sueldo], [Porcentaje], [Estado]) VALUES (4, N'Esteban', N'Quito', N'as@hotmail.com', N'15643782', CAST(N'2003-07-16' AS Date), NULL, NULL, 1)
INSERT [dbo].[ESPECIALISTAS] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [Sueldo], [Porcentaje], [Estado]) VALUES (5, N'Maravilla', N'Martinez', N'mara@gmail.com', N'34631616456', CAST(N'2074-02-14' AS Date), 15000.0000, 10, 1)
INSERT [dbo].[ESPECIALISTAS] ([Id], [Nombre], [Apellido], [Email], [Telefono], [Cumple], [Sueldo], [Porcentaje], [Estado]) VALUES (6, N'Iron Mike', N'Tyson', N'tyson@ko.com', N'101292332', CAST(N'1971-03-04' AS Date), 30000.0000, 12, 1)
SET IDENTITY_INSERT [dbo].[ESPECIALISTAS] OFF
GO
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (2, 2)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (3, 2)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (4, 2)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (1, 3)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (2, 3)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (3, 4)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (4, 5)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (3, 5)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (5, 5)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (6, 5)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (1, 6)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (2, 6)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (3, 6)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (4, 6)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (5, 6)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (1, 4)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (2, 4)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (2, 1)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (3, 1)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (4, 1)
INSERT [dbo].[ESPECIALISTAS_CATEGORIAS] ([idCat], [idEsp]) VALUES (1, 1)
GO
SET IDENTITY_INSERT [dbo].[HISTORIAL_VENTAS] ON 

INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (6, 9, 3, 1, 0, N'', N'', CAST(N'2023-08-29' AS Date), 0.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (10, 12, 13, 1, 0, N'', N'', CAST(N'2023-08-29' AS Date), 0.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (11, 9, 6, 3, 9, N'', N'', CAST(N'2023-08-29' AS Date), 0.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (12, 9, 6, 5, 11, N'', N'', CAST(N'2023-08-29' AS Date), 15000.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (13, 1, 5, 4, 0, N'no', N'fd4', CAST(N'2023-08-29' AS Date), 15000.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (15, 1, 6, 4, 5, N'Corte', N'A90DS', CAST(N'2023-09-02' AS Date), 12000.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (20, 1, 4, 2, 7, N'', N'', CAST(N'2023-09-09' AS Date), 4500.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (28, 2, 6, 3, 9, N'', N'', CAST(N'2023-09-12' AS Date), 20000.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (29, 2, 6, 2, 7, N'', N'', CAST(N'2023-09-12' AS Date), 30000.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (37, 3, 5, 4, 5, N'', N'', CAST(N'2023-09-12' AS Date), 1320.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (38, 2, 5, 4, 4, N'', N'', CAST(N'2023-09-12' AS Date), 25000.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (39, 2, 13, 1, 3, N'', N'', CAST(N'2023-09-12' AS Date), 5000.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (40, 3, 5, 4, 4, N'', N'', CAST(N'2023-09-12' AS Date), 4000.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (42, 3, 5, 4, 4, N'', N'', CAST(N'2023-09-12' AS Date), 11040.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (44, 2, 7, 4, 4, N'', N'', CAST(N'2023-09-12' AS Date), 545.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (46, 4, 5, 3, 10, N'', N'', CAST(N'2023-09-13' AS Date), 10000.0000)
INSERT [dbo].[HISTORIAL_VENTAS] ([IdVenta], [IdCliente], [IdEspecialista], [IdCategoria], [IdSubcategoria], [ServicioAdicional], [CodigoTinte], [Fecha], [Precio]) VALUES (47, 1, 4, 2, 7, N'', N'', CAST(N'2023-09-13' AS Date), 12000.0000)
SET IDENTITY_INSERT [dbo].[HISTORIAL_VENTAS] OFF
GO
SET IDENTITY_INSERT [dbo].[LOGIN] ON 

INSERT [dbo].[LOGIN] ([Id], [Usuario], [Password], [Admin]) VALUES (1, N'nicolas', N'123', 1)
INSERT [dbo].[LOGIN] ([Id], [Usuario], [Password], [Admin]) VALUES (7, N'admin', N'admin', 1)
INSERT [dbo].[LOGIN] ([Id], [Usuario], [Password], [Admin]) VALUES (8, N'user', N'user', 0)
SET IDENTITY_INSERT [dbo].[LOGIN] OFF
GO
SET IDENTITY_INSERT [dbo].[SUBCATEGORIA] ON 

INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (1, 1, N'Corte', CAST(N'00:30:00' AS Time))
INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (2, 1, N'Color', CAST(N'02:15:00' AS Time))
INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (3, 1, N'Brushing', CAST(N'01:00:00' AS Time))
INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (4, 4, N'Esmaltado', CAST(N'00:30:00' AS Time))
INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (5, 4, N'Esmaltado Semi Permanente', CAST(N'00:45:00' AS Time))
INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (6, 3, N'Masaje Linfatico', CAST(N'01:00:00' AS Time))
INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (7, 2, N'Esmaltado', CAST(N'00:30:00' AS Time))
INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (8, 2, N'Esmaltado Semi Permanente', CAST(N'00:30:00' AS Time))
INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (9, 3, N'Cuerpo entero', CAST(N'02:00:00' AS Time))
INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (10, 3, N'Tren inferior', CAST(N'01:15:00' AS Time))
INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (11, 5, N'Corte', CAST(N'00:30:00' AS Time))
INSERT [dbo].[SUBCATEGORIA] ([Id], [IdCategoria], [Descripcion], [Duracion]) VALUES (12, 5, N'Tintura', CAST(N'00:45:00' AS Time))
SET IDENTITY_INSERT [dbo].[SUBCATEGORIA] OFF
GO
SET IDENTITY_INSERT [dbo].[TURNOS] ON 

INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (10, 10, 2, 11, 5, CAST(N'2023-09-04' AS Date), CAST(N'18:00:00' AS Time), CAST(N'18:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (11, 10, 2, 11, 5, CAST(N'2023-09-04' AS Date), CAST(N'18:15:00' AS Time), CAST(N'18:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (12, 10, 2, 11, 5, CAST(N'2023-09-04' AS Date), CAST(N'18:30:00' AS Time), CAST(N'18:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (21, 21, 3, 9, 6, CAST(N'2023-09-06' AS Date), CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (24, 24, 3, 9, 6, CAST(N'2023-09-07' AS Date), CAST(N'12:00:00' AS Time), CAST(N'14:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (26, 26, 4, 3, 6, CAST(N'2023-09-07' AS Date), CAST(N'11:00:00' AS Time), CAST(N'11:15:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (35, 35, 3, 9, 4, CAST(N'2023-09-07' AS Date), CAST(N'15:30:00' AS Time), CAST(N'17:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (219, 35, 3, 9, 4, CAST(N'2023-09-07' AS Date), CAST(N'15:45:00' AS Time), CAST(N'17:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (220, 35, 3, 9, 4, CAST(N'2023-09-07' AS Date), CAST(N'16:00:00' AS Time), CAST(N'17:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (221, 35, 3, 9, 4, CAST(N'2023-09-07' AS Date), CAST(N'16:15:00' AS Time), CAST(N'17:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (222, 35, 3, 9, 4, CAST(N'2023-09-07' AS Date), CAST(N'16:30:00' AS Time), CAST(N'17:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (223, 35, 3, 9, 4, CAST(N'2023-09-07' AS Date), CAST(N'16:45:00' AS Time), CAST(N'17:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (224, 35, 3, 9, 4, CAST(N'2023-09-07' AS Date), CAST(N'17:00:00' AS Time), CAST(N'17:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (225, 35, 3, 9, 4, CAST(N'2023-09-07' AS Date), CAST(N'17:15:00' AS Time), CAST(N'17:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (226, 35, 3, 9, 4, CAST(N'2023-09-07' AS Date), CAST(N'17:30:00' AS Time), CAST(N'17:30:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (251, 21, 3, 9, 6, CAST(N'2023-09-06' AS Date), CAST(N'10:15:00' AS Time), CAST(N'12:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (252, 21, 3, 9, 6, CAST(N'2023-09-06' AS Date), CAST(N'10:30:00' AS Time), CAST(N'12:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (253, 21, 3, 9, 6, CAST(N'2023-09-06' AS Date), CAST(N'10:45:00' AS Time), CAST(N'12:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (254, 21, 3, 9, 6, CAST(N'2023-09-06' AS Date), CAST(N'11:00:00' AS Time), CAST(N'12:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (255, 21, 3, 9, 6, CAST(N'2023-09-06' AS Date), CAST(N'11:15:00' AS Time), CAST(N'12:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (256, 21, 3, 9, 6, CAST(N'2023-09-06' AS Date), CAST(N'11:30:00' AS Time), CAST(N'12:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (257, 21, 3, 9, 6, CAST(N'2023-09-06' AS Date), CAST(N'11:45:00' AS Time), CAST(N'12:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (258, 21, 3, 9, 6, CAST(N'2023-09-06' AS Date), CAST(N'12:00:00' AS Time), CAST(N'12:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (260, 24, 3, 9, 6, CAST(N'2023-09-07' AS Date), CAST(N'12:15:00' AS Time), CAST(N'14:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (261, 24, 3, 9, 6, CAST(N'2023-09-07' AS Date), CAST(N'12:30:00' AS Time), CAST(N'14:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (262, 24, 3, 9, 6, CAST(N'2023-09-07' AS Date), CAST(N'12:45:00' AS Time), CAST(N'14:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (263, 24, 3, 9, 6, CAST(N'2023-09-07' AS Date), CAST(N'13:00:00' AS Time), CAST(N'14:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (264, 24, 3, 9, 6, CAST(N'2023-09-07' AS Date), CAST(N'13:15:00' AS Time), CAST(N'14:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (265, 24, 3, 9, 6, CAST(N'2023-09-07' AS Date), CAST(N'13:30:00' AS Time), CAST(N'14:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (266, 24, 3, 9, 6, CAST(N'2023-09-07' AS Date), CAST(N'13:45:00' AS Time), CAST(N'14:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (267, 24, 3, 9, 6, CAST(N'2023-09-07' AS Date), CAST(N'14:00:00' AS Time), CAST(N'14:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (268, 26, 4, 3, 6, CAST(N'2023-09-07' AS Date), CAST(N'11:15:00' AS Time), CAST(N'11:15:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (269, 269, 3, 2, 1, CAST(N'2023-09-08' AS Date), CAST(N'16:45:00' AS Time), CAST(N'19:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (288, 269, 3, 2, 1, CAST(N'2023-09-08' AS Date), CAST(N'17:00:00' AS Time), CAST(N'19:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (289, 269, 3, 2, 1, CAST(N'2023-09-08' AS Date), CAST(N'17:15:00' AS Time), CAST(N'19:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (290, 269, 3, 2, 1, CAST(N'2023-09-08' AS Date), CAST(N'17:30:00' AS Time), CAST(N'19:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (291, 269, 3, 2, 1, CAST(N'2023-09-08' AS Date), CAST(N'17:45:00' AS Time), CAST(N'19:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (292, 269, 3, 2, 1, CAST(N'2023-09-08' AS Date), CAST(N'18:00:00' AS Time), CAST(N'19:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (293, 269, 3, 2, 1, CAST(N'2023-09-08' AS Date), CAST(N'18:15:00' AS Time), CAST(N'19:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (294, 269, 3, 2, 1, CAST(N'2023-09-08' AS Date), CAST(N'18:30:00' AS Time), CAST(N'19:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (295, 269, 3, 2, 1, CAST(N'2023-09-08' AS Date), CAST(N'18:45:00' AS Time), CAST(N'19:00:00' AS Time), N'Reservado')
INSERT [dbo].[TURNOS] ([Id], [IdTurno], [IdCliente], [IdSubCategoria], [IdEspecialista], [Fecha], [HoraInicio], [HoraFin], [Estado]) VALUES (296, 269, 3, 2, 1, CAST(N'2023-09-08' AS Date), CAST(N'19:00:00' AS Time), CAST(N'19:00:00' AS Time), N'Reservado')
SET IDENTITY_INSERT [dbo].[TURNOS] OFF
GO
ALTER TABLE [dbo].[CAJA]  WITH CHECK ADD  CONSTRAINT [FK_CAJA_DATOSCLIENTES] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[DATOSCLIENTES] ([Id])
GO
ALTER TABLE [dbo].[CAJA] CHECK CONSTRAINT [FK_CAJA_DATOSCLIENTES]
GO
ALTER TABLE [dbo].[CAJA]  WITH CHECK ADD  CONSTRAINT [FK_CAJA_ESPECIALISTAS] FOREIGN KEY([IdEspe])
REFERENCES [dbo].[ESPECIALISTAS] ([Id])
GO
ALTER TABLE [dbo].[CAJA] CHECK CONSTRAINT [FK_CAJA_ESPECIALISTAS]
GO
ALTER TABLE [dbo].[ESPECIALISTAS_CATEGORIAS]  WITH CHECK ADD  CONSTRAINT [FK_ESPECIALISTAS_CATEGORIAS_CATEGORIAS] FOREIGN KEY([idCat])
REFERENCES [dbo].[CATEGORIAS] ([Id])
GO
ALTER TABLE [dbo].[ESPECIALISTAS_CATEGORIAS] CHECK CONSTRAINT [FK_ESPECIALISTAS_CATEGORIAS_CATEGORIAS]
GO
ALTER TABLE [dbo].[ESPECIALISTAS_CATEGORIAS]  WITH CHECK ADD  CONSTRAINT [FK_ESPECIALISTAS_CATEGORIAS_ESPECIALISTAS] FOREIGN KEY([idEsp])
REFERENCES [dbo].[ESPECIALISTAS] ([Id])
GO
ALTER TABLE [dbo].[ESPECIALISTAS_CATEGORIAS] CHECK CONSTRAINT [FK_ESPECIALISTAS_CATEGORIAS_ESPECIALISTAS]
GO
ALTER TABLE [dbo].[TURNOS]  WITH CHECK ADD  CONSTRAINT [FK_TURNOS_DATOSCLIENTES] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[DATOSCLIENTES] ([Id])
GO
ALTER TABLE [dbo].[TURNOS] CHECK CONSTRAINT [FK_TURNOS_DATOSCLIENTES]
GO
ALTER TABLE [dbo].[TURNOS]  WITH CHECK ADD  CONSTRAINT [FK_TURNOS_ESPECIALISTAS] FOREIGN KEY([IdEspecialista])
REFERENCES [dbo].[ESPECIALISTAS] ([Id])
GO
ALTER TABLE [dbo].[TURNOS] CHECK CONSTRAINT [FK_TURNOS_ESPECIALISTAS]
GO
ALTER TABLE [dbo].[TURNOS]  WITH CHECK ADD  CONSTRAINT [FK_TURNOS_SUBCATEGORIA] FOREIGN KEY([IdSubCategoria])
REFERENCES [dbo].[SUBCATEGORIA] ([Id])
GO
ALTER TABLE [dbo].[TURNOS] CHECK CONSTRAINT [FK_TURNOS_SUBCATEGORIA]
GO
/****** Object:  StoredProcedure [dbo].[listarTurnosIdEsp]    Script Date: 18/9/2023 19:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listarTurnosIdEsp]
    @Fecha DATE,
	@IdEsp INT
AS
BEGIN
    WITH CTE AS (
        SELECT 
            IdTurno, 
            IdCliente, 
            C.Nombre as NombreCliente, 
            IdSubCategoria, 
            s.Descripcion as Subcategoria, 
            IdEspecialista, 
            e.Nombre as Especialista,
            Fecha,
            HoraInicio, 
            HoraFin,
            t.Estado as esta2,
            ROW_NUMBER() OVER (PARTITION BY IdTurno ORDER BY Fecha, HoraInicio) AS RowNum
        FROM 
            TURNOS T
        JOIN 
            SUBCATEGORIA S ON T.IdSubCategoria = S.Id
        JOIN 
            DATOSCLIENTES C ON T.IdCliente = C.Id
        JOIN 
            ESPECIALISTAS E ON T.IdEspecialista = E.Id
        WHERE 
			IdEspecialista = @IdEsp
            AND t.Fecha = @Fecha
            
    )
    SELECT 
        IdTurno, 
        IdCliente, 
        NombreCliente, 
        IdSubCategoria, 
        Subcategoria, 
        IdEspecialista, 
        Especialista,
        Fecha,
        HoraInicio, 
        HoraFin,
        esta2
    FROM 
        CTE
    WHERE 
        RowNum = 1;
END;
GO
/****** Object:  StoredProcedure [dbo].[listarTurnosTodos]    Script Date: 18/9/2023 19:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listarTurnosTodos]
    @Fecha DATE
AS
BEGIN
    WITH CTE AS (
        SELECT 
            IdTurno, 
            IdCliente, 
            C.Nombre as NombreCliente, 
            IdSubCategoria, 
            s.Descripcion as Subcategoria, 
            IdEspecialista, 
            e.Nombre as Especialista,
            Fecha,
            HoraInicio, 
            HoraFin,
            t.Estado as esta2,
            ROW_NUMBER() OVER (PARTITION BY IdTurno ORDER BY Fecha, HoraInicio) AS RowNum
        FROM 
            TURNOS T
        JOIN 
            SUBCATEGORIA S ON T.IdSubCategoria = S.Id
        JOIN 
            DATOSCLIENTES C ON T.IdCliente = C.Id
        JOIN 
            ESPECIALISTAS E ON T.IdEspecialista = E.Id
        WHERE 
            t.Fecha = @Fecha
            
    )
    SELECT 
        IdTurno, 
        IdCliente, 
        NombreCliente, 
        IdSubCategoria, 
        Subcategoria, 
        IdEspecialista, 
        Especialista,
        Fecha,
        HoraInicio, 
        HoraFin,
        esta2
    FROM 
        CTE
    WHERE 
        RowNum = 1;
END;
GO
/****** Object:  StoredProcedure [dbo].[ObtenerVentasConIdSubCategoria]    Script Date: 18/9/2023 19:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerVentasConIdSubCategoria]
    @IdCliente INT
AS
BEGIN
    SELECT 
		IdVenta,
        IdCliente, 
        IdEspecialista, 
        E.Nombre as NombreEsp,
        HV.IdCategoria,
        IdSubcategoria, 
        S.Descripcion, 
        S.Id as IdSub,
        S.Descripcion as Subcategoria, 
        C.Descripcion as Categoria,
        DC.Nombre as Nombre, 
        ServicioAdicional,
        CodigoTinte,
        Fecha,
        Precio 
    FROM 
        HISTORIAL_VENTAS as HV
        INNER JOIN CATEGORIAS as C ON HV.IdCategoria = C.Id
        LEFT JOIN SUBCATEGORIA as S ON HV.IdSubcategoria = S.Id
        INNER JOIN DATOSCLIENTES as DC ON DC.Id = HV.IdCliente
        INNER JOIN ESPECIALISTAS as E ON E.Id = HV.IdEspecialista
    WHERE 
        IdCliente = @IdCliente
        AND (IdSubcategoria IS NULL OR IdSubcategoria = S.Id or s.Id IS NULL);
END;
GO
USE [master]
GO
ALTER DATABASE [MYLA_DB] SET  READ_WRITE 
GO
