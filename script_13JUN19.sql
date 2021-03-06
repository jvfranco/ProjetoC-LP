USE [master]
GO
/****** Object:  Database [OFICINA]    Script Date: 13/06/2019 20:12:28 ******/
CREATE DATABASE [OFICINA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OFICINA', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OFICINA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OFICINA_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OFICINA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OFICINA] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OFICINA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OFICINA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OFICINA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OFICINA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OFICINA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OFICINA] SET ARITHABORT OFF 
GO
ALTER DATABASE [OFICINA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OFICINA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OFICINA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OFICINA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OFICINA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OFICINA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OFICINA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OFICINA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OFICINA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OFICINA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OFICINA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OFICINA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OFICINA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OFICINA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OFICINA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OFICINA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OFICINA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OFICINA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OFICINA] SET  MULTI_USER 
GO
ALTER DATABASE [OFICINA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OFICINA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OFICINA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OFICINA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OFICINA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OFICINA] SET QUERY_STORE = OFF
GO
USE [OFICINA]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 13/06/2019 20:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](70) NULL,
	[endereco] [varchar](50) NULL,
	[numero] [int] NULL,
	[bairro] [varchar](30) NULL,
	[cep] [varchar](10) NULL,
	[cidade] [varchar](50) NULL,
	[estado] [varchar](30) NULL,
	[telefone] [varchar](20) NULL,
	[email] [varchar](50) NULL,
	[data_cadastro] [date] NULL,
	[cpf_cnpj] [varchar](20) NULL,
	[rg] [varchar](20) NULL,
	[tipo_pessoa] [varchar](15) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estoque]    Script Date: 13/06/2019 20:12:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estoque](
	[id_produto] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](50) NULL,
	[quantidade] [float] NULL,
	[valor] [float] NULL,
 CONSTRAINT [PK_Estoque] PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 13/06/2019 20:12:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[id_funcionario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NULL,
	[cpf] [varchar](15) NULL,
	[cargo] [varchar](20) NULL,
 CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[id_funcionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Revisao]    Script Date: 13/06/2019 20:12:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Revisao](
	[id_revisao] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NULL,
	[id_funcionario] [int] NULL,
	[id_servico] [int] NULL,
	[km_atual] [int] NULL,
	[data_revisao] [date] NULL,
	[observacao] [varchar](300) NULL,
	[valor_total] [float] NULL,
	[id_veiculo] [int] NULL,
	[forma_pagto] [varchar](50) NULL,
	[desconto] [float] NULL,
	[valor_final] [float] NULL,
 CONSTRAINT [PK_revisao] PRIMARY KEY CLUSTERED 
(
	[id_revisao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Revisao_Estoque]    Script Date: 13/06/2019 20:12:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Revisao_Estoque](
	[id_revisao] [int] NOT NULL,
	[id_produto] [int] NOT NULL,
	[quantidade] [float] NULL,
 CONSTRAINT [PK_Revisao_Estoque] PRIMARY KEY CLUSTERED 
(
	[id_revisao] ASC,
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicos]    Script Date: 13/06/2019 20:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicos](
	[id_servico] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](70) NULL,
	[val_mao_obra] [float] NULL,
 CONSTRAINT [PK_Servicos] PRIMARY KEY CLUSTERED 
(
	[id_servico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/06/2019 20:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_funcionario] [int] NOT NULL,
	[login] [varchar](50) NOT NULL,
	[senha] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Veiculos]    Script Date: 13/06/2019 20:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veiculos](
	[id_veiculo] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[modelo] [varchar](50) NULL,
	[marca] [varchar](50) NULL,
	[placa] [varchar](10) NULL,
 CONSTRAINT [PK_Veiculos] PRIMARY KEY CLUSTERED 
(
	[id_veiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Revisao]  WITH CHECK ADD  CONSTRAINT [FK_Revisao_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id])
GO
ALTER TABLE [dbo].[Revisao] CHECK CONSTRAINT [FK_Revisao_Clientes]
GO
ALTER TABLE [dbo].[Revisao]  WITH CHECK ADD  CONSTRAINT [FK_Revisao_Funcionario] FOREIGN KEY([id_funcionario])
REFERENCES [dbo].[Funcionario] ([id_funcionario])
GO
ALTER TABLE [dbo].[Revisao] CHECK CONSTRAINT [FK_Revisao_Funcionario]
GO
ALTER TABLE [dbo].[Revisao]  WITH CHECK ADD  CONSTRAINT [FK_Revisao_Servicos] FOREIGN KEY([id_servico])
REFERENCES [dbo].[Servicos] ([id_servico])
GO
ALTER TABLE [dbo].[Revisao] CHECK CONSTRAINT [FK_Revisao_Servicos]
GO
ALTER TABLE [dbo].[Revisao]  WITH CHECK ADD  CONSTRAINT [FK_Revisao_Veiculos] FOREIGN KEY([id_veiculo])
REFERENCES [dbo].[Veiculos] ([id_veiculo])
GO
ALTER TABLE [dbo].[Revisao] CHECK CONSTRAINT [FK_Revisao_Veiculos]
GO
ALTER TABLE [dbo].[Revisao_Estoque]  WITH CHECK ADD  CONSTRAINT [FK_Revisao_Estoque_Revisao] FOREIGN KEY([id_produto])
REFERENCES [dbo].[Estoque] ([id_produto])
GO
ALTER TABLE [dbo].[Revisao_Estoque] CHECK CONSTRAINT [FK_Revisao_Estoque_Revisao]
GO
ALTER TABLE [dbo].[Revisao_Estoque]  WITH CHECK ADD  CONSTRAINT [FK_Revisao_Estoque_Revisao1] FOREIGN KEY([id_revisao])
REFERENCES [dbo].[Revisao] ([id_revisao])
GO
ALTER TABLE [dbo].[Revisao_Estoque] CHECK CONSTRAINT [FK_Revisao_Estoque_Revisao1]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Funcionario] FOREIGN KEY([id_funcionario])
REFERENCES [dbo].[Funcionario] ([id_funcionario])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Funcionario]
GO
USE [master]
GO
ALTER DATABASE [OFICINA] SET  READ_WRITE 
GO
