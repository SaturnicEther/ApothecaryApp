USE [master]
GO
/****** Object:  Database [Аптека]    Script Date: 22.10.2023 13:08:10 ******/
CREATE DATABASE [Аптека]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Аптека', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Аптека.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Аптека_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Аптека_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Аптека] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Аптека].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Аптека] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Аптека] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Аптека] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Аптека] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Аптека] SET ARITHABORT OFF 
GO
ALTER DATABASE [Аптека] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Аптека] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Аптека] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Аптека] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Аптека] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Аптека] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Аптека] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Аптека] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Аптека] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Аптека] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Аптека] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Аптека] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Аптека] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Аптека] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Аптека] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Аптека] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Аптека] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Аптека] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Аптека] SET  MULTI_USER 
GO
ALTER DATABASE [Аптека] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Аптека] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Аптека] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Аптека] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Аптека] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Аптека] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Аптека] SET QUERY_STORE = OFF
GO
USE [Аптека]
GO
/****** Object:  Table [dbo].[Поставщики]    Script Date: 22.10.2023 13:08:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Поставщики](
	[Id_Поставщика] [int] IDENTITY(1,1) NOT NULL,
	[Название] [nvarchar](100) NOT NULL,
	[ФИО] [nvarchar](100) NOT NULL,
	[Телефон] [int] NOT NULL,
	[Город] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Поставщики] PRIMARY KEY CLUSTERED 
(
	[Id_Поставщика] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Прибыль]    Script Date: 22.10.2023 13:08:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Прибыль](
	[Id_Прибыли] [int] IDENTITY(1,1) NOT NULL,
	[Id_Товара] [int] NOT NULL,
	[Стоимость_Привезенных_Товаров] [money] NOT NULL,
	[Количество_Привезенных_Товаров] [int] NOT NULL,
	[Стоимость_Продажи_Товаров] [money] NOT NULL,
	[Количество_Продажи_Товаров] [int] NOT NULL,
	[Итого]  AS ([Стоимость_Привезенных_Товаров]*[Количество_Привезенных_Товаров]-[Стоимость_Продажи_Товаров]*[Количество_Продажи_Товаров]),
 CONSTRAINT [PK_Прибыль] PRIMARY KEY CLUSTERED 
(
	[Id_Прибыли] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Продажи]    Script Date: 22.10.2023 13:08:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Продажи](
	[Id_продаж] [int] IDENTITY(1,1) NOT NULL,
	[Дата_продажи] [date] NOT NULL,
	[Id_товара] [int] NOT NULL,
	[Стоимость] [money] NOT NULL,
	[Количество] [int] NOT NULL,
	[Сумма_Продаж]  AS ([Стоимость]*[Количество]),
 CONSTRAINT [PK_Продажи] PRIMARY KEY CLUSTERED 
(
	[Id_продаж] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Расчет_с_поставщиками]    Script Date: 22.10.2023 13:08:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Расчет_с_поставщиками](
	[Id_расчета] [int] IDENTITY(1,1) NOT NULL,
	[Дата_поставки] [date] NULL,
	[Сумма_прибыли] [money] NOT NULL,
	[Id_поставщика] [int] NOT NULL,
 CONSTRAINT [PK_Расчет_с_поставщиками] PRIMARY KEY CLUSTERED 
(
	[Id_расчета] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Списание]    Script Date: 22.10.2023 13:08:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Списание](
	[Id_списания] [int] IDENTITY(1,1) NOT NULL,
	[Дата_Списания] [date] NOT NULL,
	[Id_Товара] [int] NOT NULL,
	[Стоимость] [money] NOT NULL,
	[Количество] [int] NOT NULL,
	[Общая_сумма]  AS ([Стоимость]*[Количество]),
 CONSTRAINT [PK_Списание] PRIMARY KEY CLUSTERED 
(
	[Id_списания] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Список_Товаров]    Script Date: 22.10.2023 13:08:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Список_Товаров](
	[Id_Товара] [int] IDENTITY(1,1) NOT NULL,
	[Название_Товара] [nvarchar](100) NOT NULL,
	[Группа] [nvarchar](100) NOT NULL,
	[Дата_Изготовления] [date] NOT NULL,
	[Дата_Окончания_Срока_Годности] [date] NOT NULL,
	[Производитель] [nvarchar](100) NOT NULL,
	[Дозировка] [int] NOT NULL,
	[Id_поставщика] [int] NOT NULL,
 CONSTRAINT [PK_Список_Товаров] PRIMARY KEY CLUSTERED 
(
	[Id_Товара] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Поставщики] ON 

INSERT [dbo].[Поставщики] ([Id_Поставщика], [Название], [ФИО], [Телефон], [Город]) VALUES (5, N'Согер', N'Фунтусов В.А.', 89645765, N'Москва')
INSERT [dbo].[Поставщики] ([Id_Поставщика], [Название], [ФИО], [Телефон], [Город]) VALUES (7, N'Типи', N'Ядренников Е.Р.', 89249043, N'Москва')
INSERT [dbo].[Поставщики] ([Id_Поставщика], [Название], [ФИО], [Телефон], [Город]) VALUES (8, N'Гарант', N'Языкова Н.И.', 89245631, N'Москва')
INSERT [dbo].[Поставщики] ([Id_Поставщика], [Название], [ФИО], [Телефон], [Город]) VALUES (9, N'Айпара-СПБ', N'Труш Е.Р.', 89135423, N'Санкт-Петербург')
INSERT [dbo].[Поставщики] ([Id_Поставщика], [Название], [ФИО], [Телефон], [Город]) VALUES (10, N'Здоровье', N'Уваров А.П.', 89349031, N'Краснодар')
SET IDENTITY_INSERT [dbo].[Поставщики] OFF
GO
SET IDENTITY_INSERT [dbo].[Прибыль] ON 

INSERT [dbo].[Прибыль] ([Id_Прибыли], [Id_Товара], [Стоимость_Привезенных_Товаров], [Количество_Привезенных_Товаров], [Стоимость_Продажи_Товаров], [Количество_Продажи_Товаров]) VALUES (5, 1, 100.0000, 10, 80.0000, 3)
INSERT [dbo].[Прибыль] ([Id_Прибыли], [Id_Товара], [Стоимость_Привезенных_Товаров], [Количество_Привезенных_Товаров], [Стоимость_Продажи_Товаров], [Количество_Продажи_Товаров]) VALUES (6, 2, 150.0000, 15, 90.0000, 6)
INSERT [dbo].[Прибыль] ([Id_Прибыли], [Id_Товара], [Стоимость_Привезенных_Товаров], [Количество_Привезенных_Товаров], [Стоимость_Продажи_Товаров], [Количество_Продажи_Товаров]) VALUES (7, 3, 200.0000, 16, 150.0000, 5)
INSERT [dbo].[Прибыль] ([Id_Прибыли], [Id_Товара], [Стоимость_Привезенных_Товаров], [Количество_Привезенных_Товаров], [Стоимость_Продажи_Товаров], [Количество_Продажи_Товаров]) VALUES (8, 5, 300.0000, 20, 250.0000, 3)
INSERT [dbo].[Прибыль] ([Id_Прибыли], [Id_Товара], [Стоимость_Привезенных_Товаров], [Количество_Привезенных_Товаров], [Стоимость_Продажи_Товаров], [Количество_Продажи_Товаров]) VALUES (9, 6, 250.0000, 12, 200.0000, 10)
INSERT [dbo].[Прибыль] ([Id_Прибыли], [Id_Товара], [Стоимость_Привезенных_Товаров], [Количество_Привезенных_Товаров], [Стоимость_Продажи_Товаров], [Количество_Продажи_Товаров]) VALUES (10, 7, 500.0000, 10, 400.0000, 2)
SET IDENTITY_INSERT [dbo].[Прибыль] OFF
GO
SET IDENTITY_INSERT [dbo].[Продажи] ON 

INSERT [dbo].[Продажи] ([Id_продаж], [Дата_продажи], [Id_товара], [Стоимость], [Количество]) VALUES (1, CAST(N'2023-10-10' AS Date), 2, 90.0000, 2)
INSERT [dbo].[Продажи] ([Id_продаж], [Дата_продажи], [Id_товара], [Стоимость], [Количество]) VALUES (2, CAST(N'2023-10-11' AS Date), 2, 90.0000, 4)
INSERT [dbo].[Продажи] ([Id_продаж], [Дата_продажи], [Id_товара], [Стоимость], [Количество]) VALUES (3, CAST(N'2023-10-13' AS Date), 1, 80.0000, 3)
INSERT [dbo].[Продажи] ([Id_продаж], [Дата_продажи], [Id_товара], [Стоимость], [Количество]) VALUES (4, CAST(N'2023-10-13' AS Date), 3, 150.0000, 5)
INSERT [dbo].[Продажи] ([Id_продаж], [Дата_продажи], [Id_товара], [Стоимость], [Количество]) VALUES (6, CAST(N'2023-10-14' AS Date), 5, 250.0000, 3)
INSERT [dbo].[Продажи] ([Id_продаж], [Дата_продажи], [Id_товара], [Стоимость], [Количество]) VALUES (7, CAST(N'2023-10-14' AS Date), 6, 200.0000, 10)
INSERT [dbo].[Продажи] ([Id_продаж], [Дата_продажи], [Id_товара], [Стоимость], [Количество]) VALUES (8, CAST(N'2023-10-15' AS Date), 7, 400.0000, 2)
SET IDENTITY_INSERT [dbo].[Продажи] OFF
GO
SET IDENTITY_INSERT [dbo].[Расчет_с_поставщиками] ON 

INSERT [dbo].[Расчет_с_поставщиками] ([Id_расчета], [Дата_поставки], [Сумма_прибыли], [Id_поставщика]) VALUES (1, CAST(N'2023-10-01' AS Date), 55000.0000, 7)
INSERT [dbo].[Расчет_с_поставщиками] ([Id_расчета], [Дата_поставки], [Сумма_прибыли], [Id_поставщика]) VALUES (2, CAST(N'2023-08-15' AS Date), 65000.0000, 5)
INSERT [dbo].[Расчет_с_поставщиками] ([Id_расчета], [Дата_поставки], [Сумма_прибыли], [Id_поставщика]) VALUES (3, CAST(N'2023-09-24' AS Date), 67500.0000, 8)
INSERT [dbo].[Расчет_с_поставщиками] ([Id_расчета], [Дата_поставки], [Сумма_прибыли], [Id_поставщика]) VALUES (4, CAST(N'2023-09-28' AS Date), 59800.0000, 9)
INSERT [dbo].[Расчет_с_поставщиками] ([Id_расчета], [Дата_поставки], [Сумма_прибыли], [Id_поставщика]) VALUES (5, CAST(N'2023-10-03' AS Date), 60000.0000, 10)
SET IDENTITY_INSERT [dbo].[Расчет_с_поставщиками] OFF
GO
SET IDENTITY_INSERT [dbo].[Списание] ON 

INSERT [dbo].[Списание] ([Id_списания], [Дата_Списания], [Id_Товара], [Стоимость], [Количество]) VALUES (1, CAST(N'2023-10-16' AS Date), 1, 80.0000, 2)
INSERT [dbo].[Списание] ([Id_списания], [Дата_Списания], [Id_Товара], [Стоимость], [Количество]) VALUES (2, CAST(N'2023-10-17' AS Date), 2, 90.0000, 3)
INSERT [dbo].[Списание] ([Id_списания], [Дата_Списания], [Id_Товара], [Стоимость], [Количество]) VALUES (3, CAST(N'2023-10-17' AS Date), 3, 150.0000, 1)
INSERT [dbo].[Списание] ([Id_списания], [Дата_Списания], [Id_Товара], [Стоимость], [Количество]) VALUES (4, CAST(N'2023-10-18' AS Date), 5, 250.0000, 3)
INSERT [dbo].[Списание] ([Id_списания], [Дата_Списания], [Id_Товара], [Стоимость], [Количество]) VALUES (5, CAST(N'2023-10-18' AS Date), 6, 200.0000, 2)
SET IDENTITY_INSERT [dbo].[Списание] OFF
GO
SET IDENTITY_INSERT [dbo].[Список_Товаров] ON 

INSERT [dbo].[Список_Товаров] ([Id_Товара], [Название_Товара], [Группа], [Дата_Изготовления], [Дата_Окончания_Срока_Годности], [Производитель], [Дозировка], [Id_поставщика]) VALUES (1, N'Парацетамол', N'Жаропонижающее', CAST(N'2022-01-03' AS Date), CAST(N'2024-04-25' AS Date), N'Россия', 100, 7)
INSERT [dbo].[Список_Товаров] ([Id_Товара], [Название_Товара], [Группа], [Дата_Изготовления], [Дата_Окончания_Срока_Годности], [Производитель], [Дозировка], [Id_поставщика]) VALUES (2, N'Аспирин', N'Жаропонижающее', CAST(N'2022-02-09' AS Date), CAST(N'2024-05-03' AS Date), N'Россия', 10, 7)
INSERT [dbo].[Список_Товаров] ([Id_Товара], [Название_Товара], [Группа], [Дата_Изготовления], [Дата_Окончания_Срока_Годности], [Производитель], [Дозировка], [Id_поставщика]) VALUES (3, N'Нурофен', N'Жаропонижающее', CAST(N'2022-08-05' AS Date), CAST(N'2024-07-15' AS Date), N'Россия', 50, 5)
INSERT [dbo].[Список_Товаров] ([Id_Товара], [Название_Товара], [Группа], [Дата_Изготовления], [Дата_Окончания_Срока_Годности], [Производитель], [Дозировка], [Id_поставщика]) VALUES (5, N'Амигренин', N'Обезбаливающее', CAST(N'2022-07-10' AS Date), CAST(N'2024-03-11' AS Date), N'Россия', 17, 8)
INSERT [dbo].[Список_Товаров] ([Id_Товара], [Название_Товара], [Группа], [Дата_Изготовления], [Дата_Окончания_Срока_Годности], [Производитель], [Дозировка], [Id_поставщика]) VALUES (6, N'Апизартрон', N'Обезбаливающее', CAST(N'2022-04-19' AS Date), CAST(N'2025-05-20' AS Date), N'Россия', 200, 9)
INSERT [dbo].[Список_Товаров] ([Id_Товара], [Название_Товара], [Группа], [Дата_Изготовления], [Дата_Окончания_Срока_Годности], [Производитель], [Дозировка], [Id_поставщика]) VALUES (7, N'Утрожестан', N'Гормональные', CAST(N'2022-06-05' AS Date), CAST(N'2025-03-07' AS Date), N'Франция', 65, 10)
SET IDENTITY_INSERT [dbo].[Список_Товаров] OFF
GO
ALTER TABLE [dbo].[Продажи]  WITH CHECK ADD  CONSTRAINT [FK_Продажи_Список_Товаров] FOREIGN KEY([Id_товара])
REFERENCES [dbo].[Список_Товаров] ([Id_Товара])
GO
ALTER TABLE [dbo].[Продажи] CHECK CONSTRAINT [FK_Продажи_Список_Товаров]
GO
ALTER TABLE [dbo].[Расчет_с_поставщиками]  WITH CHECK ADD  CONSTRAINT [FK_Расчет_с_поставщиками_Поставщики] FOREIGN KEY([Id_поставщика])
REFERENCES [dbo].[Поставщики] ([Id_Поставщика])
GO
ALTER TABLE [dbo].[Расчет_с_поставщиками] CHECK CONSTRAINT [FK_Расчет_с_поставщиками_Поставщики]
GO
ALTER TABLE [dbo].[Списание]  WITH CHECK ADD  CONSTRAINT [FK_Списание_Список_Товаров] FOREIGN KEY([Id_Товара])
REFERENCES [dbo].[Список_Товаров] ([Id_Товара])
GO
ALTER TABLE [dbo].[Списание] CHECK CONSTRAINT [FK_Списание_Список_Товаров]
GO
ALTER TABLE [dbo].[Список_Товаров]  WITH CHECK ADD  CONSTRAINT [FK_Список_Товаров_Поставщики] FOREIGN KEY([Id_поставщика])
REFERENCES [dbo].[Поставщики] ([Id_Поставщика])
GO
ALTER TABLE [dbo].[Список_Товаров] CHECK CONSTRAINT [FK_Список_Товаров_Поставщики]
GO
USE [master]
GO
ALTER DATABASE [Аптека] SET  READ_WRITE 
GO
