USE [master]
GO
/****** Object:  Database [TP4_IglesiasMarcos]    Script Date: 26/11/2021 15:53:07 ******/
CREATE DATABASE [TP4_IglesiasMarcos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP4_IglesiasMarcos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4_IglesiasMarcos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP4_IglesiasMarcos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4_IglesiasMarcos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4_IglesiasMarcos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET  MULTI_USER 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET QUERY_STORE = OFF
GO
USE [TP4_IglesiasMarcos]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 26/11/2021 15:53:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Nombre] [nvarchar](50) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Precio] [float] NOT NULL,
	[Stock] [int] NULL,
	[Stock_SI_NO] [bit] NULL,
	[ProductoCongelado] [bit] NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoSeleccionado]    Script Date: 26/11/2021 15:53:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoSeleccionado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodigoProducto1] [int] NOT NULL,
	[Cantidad1] [int] NOT NULL,
	[CodigoProducto2] [int] NULL,
	[Cantidad2] [int] NULL,
	[CodigoProducto3] [int] NULL,
	[Cantidad3] [int] NULL,
	[CodigoProducto4] [int] NULL,
	[Cantidad4] [int] NULL,
	[CodigoProducto5] [int] NULL,
	[Cantidad5] [int] NULL,
	[CodigoProducto6] [int] NULL,
	[Cantidad6] [int] NULL,
	[CodigoProducto7] [int] NULL,
	[Cantidad7] [int] NULL,
	[CodigoProducto8] [int] NULL,
	[Cantidad8] [int] NULL,
	[CodigoProducto9] [int] NULL,
	[Cantidad9] [int] NULL,
	[CodigoProducto10] [int] NULL,
	[Cantidad10] [int] NULL,
	[CodigoProducto11] [int] NULL,
	[Cantidad11] [int] NULL,
	[CodigoProducto12] [int] NULL,
	[Cantidad12] [int] NULL,
	[CodigoProducto13] [int] NULL,
	[Cantidad13] [int] NULL,
	[CodigoProducto14] [int] NULL,
	[Cantidad14] [int] NULL,
	[CodigoProducto15] [int] NULL,
	[Cantidad15] [int] NULL,
 CONSTRAINT [PK_ProductoSeleccionado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 26/11/2021 15:53:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[NumeroTicket] [int] IDENTITY(1,1) NOT NULL,
	[IdProductoSeleccionado] [int] NOT NULL,
	[Tipo] [char](10) NOT NULL,
	[Fecha] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[NumeroTicket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Dulce_de_leche', 10010, 70, 100, 1, 1, N'Lacteo')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Leber_wurst', 10011, 50, 100, 1, 1, N'Lacteo')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Leche', 10012, 75, 100, 1, 1, N'Lacteo')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Manteca', 10013, 110, 100, 1, 1, N'Lacteo')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Queso_cremoso', 10014, 150, 0, 1, 1, N'Lacteo')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Banana', 30010, 120, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Ciruela', 30011, 110, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Ciruela_amarilla', 30012, 100, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Durazno', 30013, 90, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Frutilla', 30014, 95, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Higo', 30015, 110, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Kaki', 30016, 80, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Limon', 30017, 95, 0, 0, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Mandarina', 30018, 46, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Mango', 30019, 45, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Manzana', 30020, 55, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Manzana_verde', 30021, 50, 0, 0, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Melon', 30022, 100, 0, 0, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Naranja', 30023, 70, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Papa_blanca', 30024, 80, 9, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Papa_negra', 30025, 70, 10, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Pelon', 30026, 75, 100, 1, 0, N'Fruta')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Acondicionador', 40001, 200, 100, 1, 0, N'Higiene')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Cepillo_dental', 40002, 150, 100, 1, 0, N'Higiene')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Dentrifico', 40003, 110, 100, 1, 0, N'Higiene')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Hilo_dental', 40004, 50, 100, 1, 0, N'Higiene')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Acaroina', 50010, 170, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Cera', 50011, 110, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Cloro', 50012, 160, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Desengrasante_multiuso', 50013, 150, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Detergente_magistral', 50014, 150, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Escobillon', 50015, 100, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Escobillon_economico', 50016, 200, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Escobillon_esquinero', 50017, 200, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Esponja', 50018, 70, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Franela', 50020, 60, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Jabon_liquido_Ariel', 50021, 190, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Jabon_liquido_Skip', 50022, 180, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Javon_blanco', 50023, 70, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Javon_en_polvo_ala', 50024, 85, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Javon_en_polvo_querivin', 50025, 90, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Lavandina_ropa_blanca', 50026, 250, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Paño_amarillo', 50027, 75, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Perfuminas', 50028, 55, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Esponja_viruta', 50029, 75, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Secador', 50030, 200, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Suavizante_vivere', 50031, 180, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Repasador', 50039, 50, 100, 1, 0, N'Limpieza')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Bombon', 60011, 100, 100, 1, 0, N'Golocina')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Caramelo', 60012, 15, 100, 1, 0, N'Golocina')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Chicle', 60013, 10, 100, 1, 0, N'Golocina')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Chocolate', 60014, 100, 100, 1, 0, N'Golocina')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Asado_de_ternera', 70001, 120, 100, 1, 1, N'Carne')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Bife_ancho', 70002, 150, 100, 1, 1, N'Carne')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Bife_angosto', 70003, 160, 100, 1, 1, N'Carne')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Cuadril', 70004, 170, 100, 1, 1, N'Carne')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Falda', 70005, 185, 100, 1, 1, N'Carne')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Lomo', 70006, 200, 100, 1, 1, N'Carne')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Nalga', 70007, 90, 100, 1, 1, N'Carne')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Paleta', 70008, 100, 100, 1, 1, N'Carne')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Picada_comun', 70009, 110, 100, 1, 1, N'Carne')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Achicoria', 200210, 30, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Acelga', 200211, 50, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Apio', 200212, 60, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Batata', 200213, 90, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Berenjena', 200214, 90, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Brocoli', 200215, 120, 10, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Calabaza', 200216, 140, 9, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Cebolla', 200217, 80, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Chaucha_chata', 200218, 85, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Chaucha_rolito', 200219, 50, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Choclo', 200220, 50, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Coliflor', 200321, 90, 4, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Espinaca', 200322, 80, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Lechuga_Crespa', 200324, 70, 15, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Lechuga_Mantecosa', 200325, 70, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Lechuga_Morada', 200326, 70, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Lechuga_Repollada', 200327, 70, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Pepino', 200328, 40, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Perejil', 200329, 50, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Pimiento_rojo', 200420, 65, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Pimiento_verde', 200421, 65, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Puerro', 200422, 55, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Rabanito', 200423, 46, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Remolacha', 200424, 75, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Repollo_blanco', 200425, 80, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Repollo_morado', 200426, 164, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Rucula', 200427, 110, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'tomate_perita', 200428, 90, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Tomate_redondo', 200439, 16, 100, 1, 0, N'Verdura')
INSERT [dbo].[Producto] ([Nombre], [Codigo], [Precio], [Stock], [Stock_SI_NO], [ProductoCongelado], [Tipo]) VALUES (N'Verdeo', 200540, 20, 100, 1, 0, N'Verdura')
GO
SET IDENTITY_INSERT [dbo].[ProductoSeleccionado] ON 

INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (1, 70002, 2, 70003, 5, 70004, 10, 70007, 6, 700010, 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (2, 10010, 3, 10011, 4, 200210, 8, 200215, 2, 70002, 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (3, 200322, 2, 200323, 5, 200328, 6, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (4, 30014, 10, 200323, 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (5, 40001, 5, 50010, 5, 50015, 15, 70003, 9, 70009, 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (7, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (8, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (9, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (10, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (11, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (12, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (13, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (14, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (15, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (16, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (17, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (18, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (19, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (20, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (21, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (22, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (23, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (24, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (25, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (26, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (27, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (28, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (29, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (30, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (31, 30016, 13, 30017, 3, 30018, 1, 30012, 1, 30021, 2, 40001, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (32, 10010, 3, 10013, 3, 30010, 11, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (33, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (34, 30016, 13, 30017, 3, 30018, 1, 30012, 1, 30021, 2, 40001, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (35, 10010, 3, 10013, 3, 30010, 11, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (36, 70004, 1, 10010, 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (37, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (38, 30016, 13, 30017, 3, 30018, 1, 30012, 1, 30021, 2, 40001, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (39, 10010, 3, 10013, 3, 30010, 11, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (40, 70007, 1, 70005, 1, 70009, 1, 10010, 29, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (41, 70006, 1, 70008, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (42, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (43, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (44, 10010, 3, 10013, 3, 30010, 10, 30012, 1, 30013, 2, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (45, 30016, 13, 30017, 3, 30018, 1, 30012, 1, 30021, 2, 40001, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ProductoSeleccionado] ([Id], [CodigoProducto1], [Cantidad1], [CodigoProducto2], [Cantidad2], [CodigoProducto3], [Cantidad3], [CodigoProducto4], [Cantidad4], [CodigoProducto5], [Cantidad5], [CodigoProducto6], [Cantidad6], [CodigoProducto7], [Cantidad7], [CodigoProducto8], [Cantidad8], [CodigoProducto9], [Cantidad9], [CodigoProducto10], [Cantidad10], [CodigoProducto11], [Cantidad11], [CodigoProducto12], [Cantidad12], [CodigoProducto13], [Cantidad13], [CodigoProducto14], [Cantidad14], [CodigoProducto15], [Cantidad15]) VALUES (46, 10010, 3, 10013, 3, 30010, 11, 30015, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[ProductoSeleccionado] OFF
GO
SET IDENTITY_INSERT [dbo].[Ticket] ON 

INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (3, 26, N'B         ', N'26/11/2021 12:29:52')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (4, 27, N'B         ', N'26/11/2021 12:31:00')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (5, 28, N'B         ', N'26/11/2021 12:31:00')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (6, 29, N'B         ', N'26/11/2021 12:31:00')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (7, 30, N'B         ', N'26/11/2021 12:32:32')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (8, 31, N'B         ', N'26/11/2021 12:32:43')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (9, 32, N'B         ', N'26/11/2021 12:32:50')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (10, 33, N'B         ', N'26/11/2021 14:18:22')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (11, 34, N'B         ', N'26/11/2021 14:18:24')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (12, 35, N'B         ', N'26/11/2021 14:18:25')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (13, 36, N'B         ', N'26/11/2021 14:18:27')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (14, 37, N'B         ', N'26/11/2021 15:38:59')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (15, 38, N'B         ', N'26/11/2021 15:39:10')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (16, 39, N'B         ', N'26/11/2021 15:39:20')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (17, 40, N'B         ', N'26/11/2021 15:39:30')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (18, 41, N'B         ', N'26/11/2021 15:41:43')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (19, 42, N'B         ', N'26/11/2021 15:44:25')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (20, 43, N'B         ', N'26/11/2021 15:45:21')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (21, 44, N'B         ', N'26/11/2021 15:47:50')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (22, 45, N'B         ', N'26/11/2021 15:48:08')
INSERT [dbo].[Ticket] ([NumeroTicket], [IdProductoSeleccionado], [Tipo], [Fecha]) VALUES (23, 46, N'B         ', N'26/11/2021 15:48:34')
SET IDENTITY_INSERT [dbo].[Ticket] OFF
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Ticket] FOREIGN KEY([IdProductoSeleccionado])
REFERENCES [dbo].[ProductoSeleccionado] ([Id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Ticket]
GO
USE [master]
GO
ALTER DATABASE [TP4_IglesiasMarcos] SET  READ_WRITE 
GO
