USE [EquipmentDB]
GO
/****** Object:  Table [dbo].[Corps]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corps](
	[Corps_ID] [int] IDENTITY(1,1) NOT NULL,
	[CorpsName] [varchar](100) NOT NULL,
	[Adress] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_CORPS] PRIMARY KEY CLUSTERED 
(
	[Corps_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Employee_ID] [int] IDENTITY(1,1) NOT NULL,
	[Post_ID] [int] NOT NULL,
	[Organization_ID] [int] NULL,
	[FName] [varchar](100) NOT NULL,
	[EmpName] [varchar](50) NOT NULL,
	[LName] [varchar](100) NOT NULL,
	[Phone] [varchar](20) NULL,
 CONSTRAINT [PK_EMPLOYEE] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeEquipment]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeEquipment](
	[EmployeeEquipment_ID] [int] IDENTITY(1,1) NOT NULL,
	[EquipmentLeasing_ID] [int] NOT NULL,
	[Equipment_ID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_EMPLOYEEEQUIPMENT] PRIMARY KEY CLUSTERED 
(
	[EmployeeEquipment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeRoom]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeRoom](
	[EmployeeRoom_ID] [int] IDENTITY(1,1) NOT NULL,
	[Room_ID] [int] NOT NULL,
	[Employee_ID] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_EMPLOYEEROOM] PRIMARY KEY CLUSTERED 
(
	[EmployeeRoom_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipment]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipment](
	[Equipment_ID] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer_ID] [int] NULL,
	[EquipmentType_ID] [int] NULL,
	[Serial] [varchar](50) NULL,
	[EquipmentName] [varchar](200) NULL,
	[Quantity] [int] NOT NULL,
	[InventoryNumber] [varchar](100) NULL,
	[Notice] [varchar](2500) NULL,
	[Model] [varchar](100) NULL,
 CONSTRAINT [PK_EQUIPMENT] PRIMARY KEY CLUSTERED 
(
	[Equipment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquipmentLeasing]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquipmentLeasing](
	[EquipmentLeasing_ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeOut_ID] [int] NOT NULL,
	[EmployeeIn_ID] [int] NOT NULL,
	[DateOfIssue] [datetime] NOT NULL,
	[DateReturn] [datetime] NOT NULL,
	[IsArchive] [bit] NOT NULL,
 CONSTRAINT [PK_EQUIPMENTLEASING] PRIMARY KEY CLUSTERED 
(
	[EquipmentLeasing_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquipmentType]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquipmentType](
	[EquipmentType_ID] [int] IDENTITY(1,1) NOT NULL,
	[EquipmentTypeName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_EQUIPMENTTYPE] PRIMARY KEY CLUSTERED 
(
	[EquipmentType_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[Manufacturer_ID] [int] IDENTITY(1,1) NOT NULL,
	[ManufacturerName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_MANUFACTURER] PRIMARY KEY CLUSTERED 
(
	[Manufacturer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organization]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organization](
	[Organization_ID] [int] IDENTITY(1,1) NOT NULL,
	[OrganizationName] [varchar](150) NOT NULL,
	[ContactPhone] [varchar](20) NULL,
 CONSTRAINT [PK_ORGANIZATION] PRIMARY KEY CLUSTERED 
(
	[Organization_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[Post_ID] [int] IDENTITY(1,1) NOT NULL,
	[PostName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_POST] PRIMARY KEY CLUSTERED 
(
	[Post_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[Room_ID] [int] IDENTITY(1,1) NOT NULL,
	[Corps_ID] [int] NOT NULL,
	[RoomName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ROOM] PRIMARY KEY CLUSTERED 
(
	[Room_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomEquipment]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomEquipment](
	[RoomEquipment_ID] [int] IDENTITY(1,1) NOT NULL,
	[Room_ID] [int] NOT NULL,
	[Equipment_ID] [int] NOT NULL,
	[DateOfIssue] [datetime] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_ROOMEQUIPMENT] PRIMARY KEY CLUSTERED 
(
	[RoomEquipment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[Employee_ID] [int] NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WriteOffEquipment]    Script Date: 16.05.2022 12:50:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WriteOffEquipment](
	[WriteOffEquipment_ID] [int] IDENTITY(1,1) NOT NULL,
	[Equipment_ID] [int] NOT NULL,
	[OrderNumber] [varchar](50) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_WRITEOFFEQUIPMENT] PRIMARY KEY CLUSTERED 
(
	[WriteOffEquipment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Corps] ON 

INSERT [dbo].[Corps] ([Corps_ID], [CorpsName], [Adress]) VALUES (1, N'Гимназия №17', N'Ворошиловский')
SET IDENTITY_INSERT [dbo].[Corps] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (1, 1, NULL, N'Греков', N'Анатольевич', N'Васильевич', NULL)
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (2, 2, 1, N'Ежова', N'Светлана', N'Сергеевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (3, 3, 1, N'Валуева', N'Марина', N'Валерьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (4, 4, 1, N'Козланюк', N'Ольга', N'Геннадьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (5, 5, 1, N'Курневича', N'Алёна', N'Олеговна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (6, 4, 1, N'Чуркина', N'Светлана', N'Дмитриевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (7, 6, 1, N'Чунца', N'Татьяна', N'Андреевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (8, 7, 1, N'Яблоновская', N'Татьяна', N'Евгеньевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (9, 4, 1, N'Колокольцова', N'Елена', N'Александровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (10, 8, 1, N'Рогозин', N'Владимир', N'Леонидович', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (11, 9, 1, N'Никольская', N'Марина', N'Викторовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (12, 4, 1, N'Яковиченко', N'Мария', N'Сергеевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (13, 10, 1, N'Зуева', N'Светлана', N'Рафаиловна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (14, 11, 1, N'Бунина', N'Надежда', N'Петровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (15, 12, 1, N'Уголева', N'Наталья', N'Львовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (16, 4, 1, N'Бандуркина', N'Людмила', N'Александровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (17, 2, 1, N'Крылаева', N'Наталья', N'Николаевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (18, 13, 1, N'Квасова', N'Елена', N'Сергеевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (19, 14, 1, N'Голубцова', N'Ирина', N'Валерьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (20, 15, 1, N'Шумякин', N'Василий', N'Юрьевич', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (21, 15, 1, N'Болокана', N'Людмила', N'Константиновна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (22, 12, 1, N'Кошляка', N'Райся', N'Равильевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (23, 9, 1, N'Есенина', N'Елена', N'Евгеньевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (24, 16, 1, N'Питосин', N'Владимир', N'Петрович', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (25, 15, 1, N'Измайлов', N'Сергей', N'Владимирович', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (26, 15, 1, N'Мальчикова', N'Олеся', N'Владимировна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (27, 10, 1, N'Бабинова', N'Севич', N'Алим кызы', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (28, 17, 1, N'Стародубова', N'Надежда', N'Алексеевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (29, 13, 1, N'Турфанова', N'Ольга', N'Юрьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (30, 4, 1, N'Зыкина', N'Дарья', N'Евгеньевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (31, 18, 1, N'Кобякова', N'Елена', N'Сергеевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (32, 19, 1, N'Ивашкина', N'Арина', N'Леонидовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (33, 20, 1, N'Бабурина', N'Нина', N'Михайловна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (34, 21, 1, N'Одинцова', N'Екатерина', N'Викторовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (35, 12, 1, N'Гадолина', N'Наталья', N'Николаевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (36, 22, 1, N'Кошляка', N'Оксана', N'Юрьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (37, 23, 1, N'Ядров', N'Анатолий', N'Иванович', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (38, 24, 1, N'Яикбаева', N'Лидия', N'Юрьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (39, 15, 1, N'Попкова', N'Елена', N'Владимировна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (40, 25, 1, N'Экономова', N'Мария', N'Сергеевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (41, 4, 1, N'Баева', N'Татьяна', N'Сергеевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (42, 26, 1, N'Кылымныка', N'Ольга', N'Николаевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (43, 4, 1, N'Блокова', N'Татьяна', N'Анатольевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (44, 27, 1, N'Скороходова', N'Ольга', N'Владимировна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (45, 28, 1, N'Янин', N'Ильфат', N'Рустамович', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (46, 8, 1, N'Ямзин', N'Рустам', N'Талгатович', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (47, 8, 1, N'Андронов', N'Константин', N'Юрьевич', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (48, 21, 1, N'Безруков', N'Александр', N'Дмитриевич', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (49, 4, 1, N'Овсова', N'Ирина', N'Анатольевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (50, 4, 1, N'Витковская', N'Лариса', N'Викторовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (51, 12, 1, N'Матвиенко', N'Людмила', N'Васильевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (52, 4, 1, N'Алиева', N'Светлана', N'Владимировна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (53, 29, 1, N'Карачёва', N'Анна', N'Ивановна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (54, 25, 1, N'Брынскиха', N'Анастасия', N'Евгеньевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (55, 9, 1, N'Ювелева', N'Марина', N'Николаевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (56, 21, 1, N'Сьянова', N'Лилия', N'Зевдятовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (57, 21, 1, N'Ярополова', N'Елена', N'Ильинична', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (58, 10, 1, N'Новожилова', N'Любовь', N'Геннадьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (59, 4, 1, N'Осенныха', N'Любовь', N'Павловна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (60, 13, 1, N'Подколодная', N'Нина', N'Владимировна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (61, 4, 1, N'Помельникова', N'Елена', N'Анатольевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (62, 21, 1, N'Ясюлевич', N'Ирина', N'Геннадьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (63, 30, 1, N'Ревякина', N'Надежда', N'Сергеевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (64, 9, 1, N'Путилина', N'Наталья', N'Валерьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (65, 31, 1, N'Кизатова', N'Анастасия', N'Валерьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (66, 12, 1, N'Ямских', N'Елена', N'Анатольевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (67, 6, 1, N'Терёшина', N'Лариса', N'Леонидовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (68, 4, 1, N'Алехина', N'Татьяна', N'Леонидовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (69, 21, 1, N'Котельникова', N'Анна', N'Юрьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (70, 6, 1, N'Кошкарова', N'Марина', N'Игоревна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (71, 13, 1, N'Кравчук', N'Алла', N'Юрьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (72, 12, 1, N'Крайнова', N'Марина', N'Васильевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (73, 22, 1, N'Кудимова', N'Наталья', N'Алексеевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (74, 25, 1, N'Кузнецова', N'Ирина', N'Александровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (75, 21, 1, N'Куличкова', N'Анна', N'Игоревна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (76, 32, 1, N'Лапшина', N'Марина', N'Равеловна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (77, 3, 1, N'Либерман', N'Милена', N'Григорьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (78, 12, 1, N'Лукина', N'Светлана', N'Васильевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (79, 27, 1, N'Лыскова', N'Надежда', N'Михайловна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (80, 22, 1, N'Малюточкина', N'Валентина', N'Михайловна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (81, 33, 1, N'Мануйлов', N'Денис', N'Юрьевич', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (82, 34, 1, N'Лыскова', N'Екатерина', N'Ивановна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (83, 4, 1, N'Бунина', N'Ольга', N'Анатольевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (84, 33, 1, N'Друганин', N'Андрей', N'Владимирович', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (85, 21, 1, N'Кошкова', N'Татьяна', N'Анатольевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (86, 19, 1, N'Бакшаева', N'Ирина', N'Владимировна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (87, 33, 1, N'Поздов', N'Марат', N'Мухаметшаевич', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (88, 18, 1, N'Глухова', N'Валентина', N'Дмитриевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (89, 13, 1, N'Поветникова', N'Юлия', N'Александровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (90, 25, 1, N'Шагидзянова', N'Алевтина', N'Ивановна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (91, 4, 1, N'Касьяненко', N'Елена', N'Викторовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (92, 12, 1, N'Косяк', N'Елена', N'Игоревна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (93, 9, 1, N'Крутова', N'Елена', N'Александровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (94, 4, 1, N'Басманова', N'Ульяна', N'Михайловна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (95, 12, 1, N'Корчагина', N'Надежда', N'Владимировна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (96, 35, 1, N'Левицкая', N'Евгения', N'Петровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (97, 4, 1, N'Лапухина', N'Галина', N'Викторовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (98, 36, 1, N'Вирановская', N'Ирина', N'Анатольевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (99, 12, 1, N'Винтухова', N'Лариса', N'Марсовна', N'')
GO
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (100, 22, 1, N'Яруллина', N'Ольга', N'Николаевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (101, 33, 1, N'Калитин', N'Александр', N'Николаевич', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (102, 13, 1, N'Степанкова', N'Мария', N'Владимировна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (103, 10, 1, N'Винокурова', N'Анна', N'Анатольевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (104, 4, 1, N'Буркова', N'Ирина', N'Петровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (105, 9, 1, N'Безрукова', N'Галина', N'Георгиевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (106, 4, 1, N'Жутова', N'Елена', N'Николаевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (107, 21, 1, N'Николенко', N'Людмила', N'Владимировна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (108, 22, 1, N'Клима', N'Валентина', N'Васильевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (109, 20, 1, N'Лукова', N'Ирина', N'Николаевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (110, 21, 1, N'Банина', N'Гулькай', N'Валиаровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (111, 37, 1, N'Язьков', N'Александр', N'Дмитриевич', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (112, 33, 1, N'Язвецова', N'Алексей', N'Федорович', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (113, 30, 1, N'Ястремск', N'Сергей', N'Николаевич', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (114, 38, 1, N'Кожевина', N'Ирина', N'Викторовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (115, 27, 1, N'Николаичева', N'Ольга', N'Васильевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (116, 4, 1, N'Устимович', N'Ольга', N'Алексеевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (117, 12, 1, N'Цыганкова', N'Татьяна', N'Аркадьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (118, 30, 1, N'Болотникова', N'Вероника', N'Викторовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (119, 7, 1, N'Ермолаева', N'Эльвира', N'Акремжанована', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (120, 39, 1, N'Коломникова', N'Наталья', N'Николаевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (121, 4, 1, N'Якухина', N'Анжелика', N'Александровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (122, 10, 1, N'Вирановская', N'Светлана', N'Владимировна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (123, 22, 1, N'Натарова', N'Галина', N'Николаевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (124, 21, 1, N'Николюк', N'Светлана', N'Юрьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (125, 40, 1, N'Фролов', N'Иван', N'Александрович', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (126, 12, 1, N'Хайбуллова', N'Фаимя', N'Николаевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (127, 21, 1, N'Хайруллова', N'Елена', N'Владимировна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (128, 22, 1, N'Хафиятуллова', N'Саимя', N'Джаватовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (129, 12, 1, N'Цветкова', N'Наталья', N'Геннадьевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (130, 33, 1, N'Чагаров', N'Олег', N'Александрович', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (131, 41, 1, N'Череватова', N'Анна', N'Александровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (132, 40, 1, N'Лунеев', N'Илья', N'Николаевич', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (133, 21, 1, N'Устимович', N'Константин', N'Николаевич', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (134, 12, 1, N'Цыганкова', N'Роза', N'Петровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (135, 8, 1, N'Болотников', N'Евгений', N'Алексеевич', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (136, 10, 1, N'Ермолаева', N'Татьяна', N'Викторовна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (137, 39, 1, N'Коломникова', N'Нина', N'Ивановна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (138, 15, 1, N'Якухина', N'Альфия', N'Зуфаровна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (139, 34, 1, N'Вирановская', N'Ольга', N'Андреевна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (140, 21, 1, N'Натарова', N'Ольга', N'Степановна', N'')
INSERT [dbo].[Employee] ([Employee_ID], [Post_ID], [Organization_ID], [FName], [EmpName], [LName], [Phone]) VALUES (141, 4, 1, N'Шишкина', N'Светлана', N'Анатольевна', N'')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[EmployeeEquipment] ON 

INSERT [dbo].[EmployeeEquipment] ([EmployeeEquipment_ID], [EquipmentLeasing_ID], [Equipment_ID], [Quantity]) VALUES (1, 1, 6, 1)
INSERT [dbo].[EmployeeEquipment] ([EmployeeEquipment_ID], [EquipmentLeasing_ID], [Equipment_ID], [Quantity]) VALUES (2, 3, 9, 1)
SET IDENTITY_INSERT [dbo].[EmployeeEquipment] OFF
GO
SET IDENTITY_INSERT [dbo].[EmployeeRoom] ON 

INSERT [dbo].[EmployeeRoom] ([EmployeeRoom_ID], [Room_ID], [Employee_ID], [Date]) VALUES (1, 1, 3, CAST(N'2022-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[EmployeeRoom] ([EmployeeRoom_ID], [Room_ID], [Employee_ID], [Date]) VALUES (2, 3, 13, CAST(N'2022-05-12T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[EmployeeRoom] OFF
GO
SET IDENTITY_INSERT [dbo].[Equipment] ON 

INSERT [dbo].[Equipment] ([Equipment_ID], [Manufacturer_ID], [EquipmentType_ID], [Serial], [EquipmentName], [Quantity], [InventoryNumber], [Notice], [Model]) VALUES (6, 1, 2, N'11', NULL, 6, N'1', N'', N'11')
INSERT [dbo].[Equipment] ([Equipment_ID], [Manufacturer_ID], [EquipmentType_ID], [Serial], [EquipmentName], [Quantity], [InventoryNumber], [Notice], [Model]) VALUES (7, 2, 6, N'210321-10', NULL, 17, N'105', N'', N'ASOS3-313')
INSERT [dbo].[Equipment] ([Equipment_ID], [Manufacturer_ID], [EquipmentType_ID], [Serial], [EquipmentName], [Quantity], [InventoryNumber], [Notice], [Model]) VALUES (8, 3, 4, N'2333', NULL, 5, N'32131', N'', N'AFOT-3000')
INSERT [dbo].[Equipment] ([Equipment_ID], [Manufacturer_ID], [EquipmentType_ID], [Serial], [EquipmentName], [Quantity], [InventoryNumber], [Notice], [Model]) VALUES (9, 4, 5, N'1023-10A', NULL, 32, N'21032', N'', N'FORZE012-20')
INSERT [dbo].[Equipment] ([Equipment_ID], [Manufacturer_ID], [EquipmentType_ID], [Serial], [EquipmentName], [Quantity], [InventoryNumber], [Notice], [Model]) VALUES (12, 2, 5, N'111', NULL, 1, N'111', N'', N'1111')
SET IDENTITY_INSERT [dbo].[Equipment] OFF
GO
SET IDENTITY_INSERT [dbo].[EquipmentLeasing] ON 

INSERT [dbo].[EquipmentLeasing] ([EquipmentLeasing_ID], [EmployeeOut_ID], [EmployeeIn_ID], [DateOfIssue], [DateReturn], [IsArchive]) VALUES (1, 1, 5, CAST(N'2022-05-10T00:00:00.000' AS DateTime), CAST(N'2022-05-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[EquipmentLeasing] ([EquipmentLeasing_ID], [EmployeeOut_ID], [EmployeeIn_ID], [DateOfIssue], [DateReturn], [IsArchive]) VALUES (2, 1, 4, CAST(N'2022-05-11T00:00:00.000' AS DateTime), CAST(N'2022-05-11T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[EquipmentLeasing] ([EquipmentLeasing_ID], [EmployeeOut_ID], [EmployeeIn_ID], [DateOfIssue], [DateReturn], [IsArchive]) VALUES (3, 1, 3, CAST(N'2022-05-11T00:00:00.000' AS DateTime), CAST(N'2022-05-11T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[EquipmentLeasing] OFF
GO
SET IDENTITY_INSERT [dbo].[EquipmentType] ON 

INSERT [dbo].[EquipmentType] ([EquipmentType_ID], [EquipmentTypeName]) VALUES (7, N'Клавиатура')
INSERT [dbo].[EquipmentType] ([EquipmentType_ID], [EquipmentTypeName]) VALUES (5, N'Компьютер')
INSERT [dbo].[EquipmentType] ([EquipmentType_ID], [EquipmentTypeName]) VALUES (6, N'Мышь')
INSERT [dbo].[EquipmentType] ([EquipmentType_ID], [EquipmentTypeName]) VALUES (2, N'ноутбук')
INSERT [dbo].[EquipmentType] ([EquipmentType_ID], [EquipmentTypeName]) VALUES (4, N'Принтер')
INSERT [dbo].[EquipmentType] ([EquipmentType_ID], [EquipmentTypeName]) VALUES (3, N'Электронная доска')
SET IDENTITY_INSERT [dbo].[EquipmentType] OFF
GO
SET IDENTITY_INSERT [dbo].[Manufacturer] ON 

INSERT [dbo].[Manufacturer] ([Manufacturer_ID], [ManufacturerName]) VALUES (1, N'Asus')
INSERT [dbo].[Manufacturer] ([Manufacturer_ID], [ManufacturerName]) VALUES (4, N'DNS')
INSERT [dbo].[Manufacturer] ([Manufacturer_ID], [ManufacturerName]) VALUES (2, N'Logitech')
INSERT [dbo].[Manufacturer] ([Manufacturer_ID], [ManufacturerName]) VALUES (3, N'Sony')
SET IDENTITY_INSERT [dbo].[Manufacturer] OFF
GO
SET IDENTITY_INSERT [dbo].[Organization] ON 

INSERT [dbo].[Organization] ([Organization_ID], [OrganizationName], [ContactPhone]) VALUES (1, N'МОУ СОШ ГИМНАЗИЯ №17', N'+9(999) 999-99-99')
SET IDENTITY_INSERT [dbo].[Organization] OFF
GO
SET IDENTITY_INSERT [dbo].[Post] ON 

INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (1, N'Админ')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (20, N'Библиотекарь')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (34, N'Бухгалтер')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (11, N'Вахтер')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (39, N'Гардеробщик')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (14, N'Главный бухгалтер')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (8, N'Дворник')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (17, N'Директор')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (38, N'Зав. библиотекой')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (32, N'Завхоз')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (37, N'Зам. директора по АХЧ')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (13, N'Зам. директора по УВР')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (23, N'Заместитель директора по безопасности')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (35, N'Заместитель директора по информационно-коммуникационным технологиям')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (40, N'Инженер-программист')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (5, N'Лаборант')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (16, N'Педагог-организатор')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (6, N'Психолог')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (28, N'Рабочий по зданию')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (31, N'Секретарь')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (41, N'Секретарь-машинистка')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (27, N'Социальный педагог')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (36, N'Старший вожатый')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (33, N'Сторож')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (12, N'Уборщик/уборщица')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (21, N'Учитель')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (10, N'Учитель англ.яз.')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (2, N'Учитель биологии')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (19, N'Учитель географии')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (24, N'Учитель информатики')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (25, N'Учитель истории')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (22, N'Учитель математики')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (3, N'Учитель музыки')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (4, N'Учитель начальных классов')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (9, N'Учитель рус.яз. и литературы')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (30, N'Учитель технологии')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (15, N'Учитель физич.культуры')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (18, N'Учитель химии')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (29, N'Учитель-логопед')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (7, N'Экономист')
INSERT [dbo].[Post] ([Post_ID], [PostName]) VALUES (26, N'Юристконсульт')
SET IDENTITY_INSERT [dbo].[Post] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([Room_ID], [Corps_ID], [RoomName]) VALUES (1, 1, N'101 кабинет')
INSERT [dbo].[Room] ([Room_ID], [Corps_ID], [RoomName]) VALUES (2, 1, N'102 кабинет')
INSERT [dbo].[Room] ([Room_ID], [Corps_ID], [RoomName]) VALUES (3, 1, N'103 кабинет')
INSERT [dbo].[Room] ([Room_ID], [Corps_ID], [RoomName]) VALUES (4, 1, N'104 кабинет')
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[RoomEquipment] ON 

INSERT [dbo].[RoomEquipment] ([RoomEquipment_ID], [Room_ID], [Equipment_ID], [DateOfIssue], [Quantity]) VALUES (2, 1, 7, CAST(N'2022-05-11T16:36:11.027' AS DateTime), 7)
INSERT [dbo].[RoomEquipment] ([RoomEquipment_ID], [Room_ID], [Equipment_ID], [DateOfIssue], [Quantity]) VALUES (3, 1, 8, CAST(N'2022-05-11T16:37:06.190' AS DateTime), 1)
INSERT [dbo].[RoomEquipment] ([RoomEquipment_ID], [Room_ID], [Equipment_ID], [DateOfIssue], [Quantity]) VALUES (4, 1, 9, CAST(N'2022-05-11T16:40:45.313' AS DateTime), 31)
INSERT [dbo].[RoomEquipment] ([RoomEquipment_ID], [Room_ID], [Equipment_ID], [DateOfIssue], [Quantity]) VALUES (5, 1, 6, CAST(N'2022-05-11T16:57:35.990' AS DateTime), 1)
INSERT [dbo].[RoomEquipment] ([RoomEquipment_ID], [Room_ID], [Equipment_ID], [DateOfIssue], [Quantity]) VALUES (6, 1, 6, CAST(N'2022-05-12T13:15:47.203' AS DateTime), 1)
INSERT [dbo].[RoomEquipment] ([RoomEquipment_ID], [Room_ID], [Equipment_ID], [DateOfIssue], [Quantity]) VALUES (7, 1, 7, CAST(N'2022-05-12T14:12:03.310' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[RoomEquipment] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([User_ID], [Employee_ID], [Login], [Password]) VALUES (1, 1, N'1', N'1')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [AK_KEY_EMPUNIQUE_EMPLOYEE]    Script Date: 16.05.2022 12:50:31 ******/
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [AK_KEY_EMPUNIQUE_EMPLOYEE] UNIQUE NONCLUSTERED 
(
	[FName] ASC,
	[EmpName] ASC,
	[LName] ASC,
	[Post_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [AK_KEY_2_EMPLOYEE]    Script Date: 16.05.2022 12:50:31 ******/
ALTER TABLE [dbo].[EmployeeEquipment] ADD  CONSTRAINT [AK_KEY_2_EMPLOYEE] UNIQUE NONCLUSTERED 
(
	[EquipmentLeasing_ID] ASC,
	[Equipment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [AK_KEY_2_EMPROOM]    Script Date: 16.05.2022 12:50:31 ******/
ALTER TABLE [dbo].[EmployeeRoom] ADD  CONSTRAINT [AK_KEY_2_EMPROOM] UNIQUE NONCLUSTERED 
(
	[Room_ID] ASC,
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEE_REFCE_ORGANIZATION] FOREIGN KEY([Organization_ID])
REFERENCES [dbo].[Organization] ([Organization_ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_EMPLOYEE_REFCE_ORGANIZATION]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEE_REFERENCE_POST] FOREIGN KEY([Post_ID])
REFERENCES [dbo].[Post] ([Post_ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_EMPLOYEE_REFERENCE_POST]
GO
ALTER TABLE [dbo].[EmployeeEquipment]  WITH CHECK ADD  CONSTRAINT [FK_EMP_REFERENCE_EQUIPMENT] FOREIGN KEY([EquipmentLeasing_ID])
REFERENCES [dbo].[EquipmentLeasing] ([EquipmentLeasing_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeeEquipment] CHECK CONSTRAINT [FK_EMP_REFERENCE_EQUIPMENT]
GO
ALTER TABLE [dbo].[EmployeeEquipment]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEE_REFERENCE_EQUIPMEN] FOREIGN KEY([Equipment_ID])
REFERENCES [dbo].[Equipment] ([Equipment_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[EmployeeEquipment] CHECK CONSTRAINT [FK_EMPLOYEE_REFERENCE_EQUIPMEN]
GO
ALTER TABLE [dbo].[EmployeeRoom]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEE_REFERENCE_EMPLOYEE] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employee] ([Employee_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeeRoom] CHECK CONSTRAINT [FK_EMPLOYEE_REFERENCE_EMPLOYEE]
GO
ALTER TABLE [dbo].[EmployeeRoom]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEE_REFERENCE_ROOM] FOREIGN KEY([Room_ID])
REFERENCES [dbo].[Room] ([Room_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeeRoom] CHECK CONSTRAINT [FK_EMPLOYEE_REFERENCE_ROOM]
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK_EQUIPMEN_REFERENCE_EQUIPMEN] FOREIGN KEY([EquipmentType_ID])
REFERENCES [dbo].[EquipmentType] ([EquipmentType_ID])
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [FK_EQUIPMEN_REFERENCE_EQUIPMEN]
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK_EQUIPMEN_REFERENCE_MANUFACT] FOREIGN KEY([Manufacturer_ID])
REFERENCES [dbo].[Manufacturer] ([Manufacturer_ID])
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [FK_EQUIPMEN_REFERENCE_MANUFACT]
GO
ALTER TABLE [dbo].[EquipmentLeasing]  WITH CHECK ADD  CONSTRAINT [FK_EQUIP_REF_EMPLOYEE] FOREIGN KEY([EmployeeOut_ID])
REFERENCES [dbo].[Employee] ([Employee_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EquipmentLeasing] CHECK CONSTRAINT [FK_EQUIP_REF_EMPLOYEE]
GO
ALTER TABLE [dbo].[EquipmentLeasing]  WITH CHECK ADD  CONSTRAINT [FK_EQUIPMEN_REFERENCE_EMPLOYEE] FOREIGN KEY([EmployeeIn_ID])
REFERENCES [dbo].[Employee] ([Employee_ID])
GO
ALTER TABLE [dbo].[EquipmentLeasing] CHECK CONSTRAINT [FK_EQUIPMEN_REFERENCE_EMPLOYEE]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_ROOM_REFERENCE_CORPS] FOREIGN KEY([Corps_ID])
REFERENCES [dbo].[Corps] ([Corps_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_ROOM_REFERENCE_CORPS]
GO
ALTER TABLE [dbo].[RoomEquipment]  WITH CHECK ADD  CONSTRAINT [FK_ROOMEQUI_REFERENCE_EQUIPMEN] FOREIGN KEY([Equipment_ID])
REFERENCES [dbo].[Equipment] ([Equipment_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[RoomEquipment] CHECK CONSTRAINT [FK_ROOMEQUI_REFERENCE_EQUIPMEN]
GO
ALTER TABLE [dbo].[RoomEquipment]  WITH CHECK ADD  CONSTRAINT [FK_ROOMEQUI_REFERENCE_ROOM] FOREIGN KEY([Room_ID])
REFERENCES [dbo].[Room] ([Room_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoomEquipment] CHECK CONSTRAINT [FK_ROOMEQUI_REFERENCE_ROOM]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_USER_REFERENCE_EMPLOYEE] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employee] ([Employee_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_USER_REFERENCE_EMPLOYEE]
GO
ALTER TABLE [dbo].[WriteOffEquipment]  WITH CHECK ADD  CONSTRAINT [FK_WRITEOFF_REFERENCE_EQUIPMEN] FOREIGN KEY([Equipment_ID])
REFERENCES [dbo].[Equipment] ([Equipment_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[WriteOffEquipment] CHECK CONSTRAINT [FK_WRITEOFF_REFERENCE_EQUIPMEN]
GO
ALTER TABLE [dbo].[EmployeeEquipment]  WITH CHECK ADD  CONSTRAINT [CKC_QUANTITY_EMPLOYEE] CHECK  (([Quantity]>=(1)))
GO
ALTER TABLE [dbo].[EmployeeEquipment] CHECK CONSTRAINT [CKC_QUANTITY_EMPLOYEE]
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [CKC_QUANTITY_EQUIPMEN] CHECK  (([Quantity]>=(0)))
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [CKC_QUANTITY_EQUIPMEN]
GO
ALTER TABLE [dbo].[RoomEquipment]  WITH CHECK ADD  CONSTRAINT [CKC_QUANTITY_ROOMEQUI] CHECK  (([Quantity]>=(1)))
GO
ALTER TABLE [dbo].[RoomEquipment] CHECK CONSTRAINT [CKC_QUANTITY_ROOMEQUI]
GO
ALTER TABLE [dbo].[WriteOffEquipment]  WITH CHECK ADD  CONSTRAINT [CKC_QUANTITY_WRITEOFF] CHECK  (([Quantity]>=(1)))
GO
ALTER TABLE [dbo].[WriteOffEquipment] CHECK CONSTRAINT [CKC_QUANTITY_WRITEOFF]
GO
