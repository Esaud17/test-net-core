USE [AFILIACION_GV]
GO
/****** Object:  User [uranus]    Script Date: 19/1/2021 02:36:11 ******/
CREATE USER [uranus] FOR LOGIN [uranus] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [uranus]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AFFILIATE_CONTRACT_SERVICES]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AFFILIATE_CONTRACT_SERVICES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[affiliate_contract_id] [int] NOT NULL,
	[service_id] [int] NOT NULL,
	[observation] [nvarchar](150) NULL,
 CONSTRAINT [PK_AFFILIATE_CONTRACT_SERVICES_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AFFILIATE_CONTRACTS]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AFFILIATE_CONTRACTS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[affiliate_id] [int] NOT NULL,
	[contract_statu_id] [int] NOT NULL,
	[application_date] [date] NOT NULL,
 CONSTRAINT [PK_AFFILIATE_CONTRACTS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AFFILIATES]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AFFILIATES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firts_name] [nvarchar](60) NOT NULL,
	[last_name] [nvarchar](60) NOT NULL,
	[national_id] [nvarchar](160) NOT NULL,
	[birthday] [date] NOT NULL,
	[gender] [nvarchar](1) NULL,
 CONSTRAINT [PK_AFFILIATES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONTRACT_STATUS]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTRACT_STATUS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[enable] [bit] NOT NULL,
 CONSTRAINT [PK_CONTRACT_STATUS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERVICES]    Script Date: 19/1/2021 02:36:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [nvarchar](60) NOT NULL,
	[service_name] [nvarchar](40) NOT NULL,
	[description] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_SERVICES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'3.1.8')
SET IDENTITY_INSERT [dbo].[AFFILIATE_CONTRACT_SERVICES] ON 

INSERT [dbo].[AFFILIATE_CONTRACT_SERVICES] ([id], [affiliate_contract_id], [service_id], [observation]) VALUES (2, 6, 2, N'valor ')
INSERT [dbo].[AFFILIATE_CONTRACT_SERVICES] ([id], [affiliate_contract_id], [service_id], [observation]) VALUES (5, 6, 1, N'valor')
INSERT [dbo].[AFFILIATE_CONTRACT_SERVICES] ([id], [affiliate_contract_id], [service_id], [observation]) VALUES (6, 7, 1, N'valor')
INSERT [dbo].[AFFILIATE_CONTRACT_SERVICES] ([id], [affiliate_contract_id], [service_id], [observation]) VALUES (7, 5, 1, NULL)
INSERT [dbo].[AFFILIATE_CONTRACT_SERVICES] ([id], [affiliate_contract_id], [service_id], [observation]) VALUES (8, 5, 2, N'otro valor')
SET IDENTITY_INSERT [dbo].[AFFILIATE_CONTRACT_SERVICES] OFF
SET IDENTITY_INSERT [dbo].[AFFILIATE_CONTRACTS] ON 

INSERT [dbo].[AFFILIATE_CONTRACTS] ([id], [affiliate_id], [contract_statu_id], [application_date]) VALUES (5, 2, 5, CAST(N'2021-01-19' AS Date))
INSERT [dbo].[AFFILIATE_CONTRACTS] ([id], [affiliate_id], [contract_statu_id], [application_date]) VALUES (6, 3, 5, CAST(N'2021-01-19' AS Date))
INSERT [dbo].[AFFILIATE_CONTRACTS] ([id], [affiliate_id], [contract_statu_id], [application_date]) VALUES (7, 4, 7, CAST(N'2021-01-19' AS Date))
INSERT [dbo].[AFFILIATE_CONTRACTS] ([id], [affiliate_id], [contract_statu_id], [application_date]) VALUES (8, 2, 4, CAST(N'2021-01-19' AS Date))
SET IDENTITY_INSERT [dbo].[AFFILIATE_CONTRACTS] OFF
SET IDENTITY_INSERT [dbo].[AFFILIATES] ON 

INSERT [dbo].[AFFILIATES] ([id], [firts_name], [last_name], [national_id], [birthday], [gender]) VALUES (2, N'Pedro', N'Perez', N'123-AAB', CAST(N'2021-01-04' AS Date), N'M')
INSERT [dbo].[AFFILIATES] ([id], [firts_name], [last_name], [national_id], [birthday], [gender]) VALUES (3, N'Carlos', N'Slim', N'123-AAA', CAST(N'2021-01-19' AS Date), N'M')
INSERT [dbo].[AFFILIATES] ([id], [firts_name], [last_name], [national_id], [birthday], [gender]) VALUES (4, N'Mario', N'gomez', N'123-ACB', CAST(N'2021-01-19' AS Date), N'M')
SET IDENTITY_INSERT [dbo].[AFFILIATES] OFF
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ADM', N'Administrador', N'Admin', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'AUD', N'Auditor', N'Audit', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'REG', N'Registro', N'Regiter', NULL)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'729e6b0d-6ec4-4f29-abab-7ba6560e8fd1', N'ADM')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'253c77d3-ff5c-4e5f-a81a-7b86c3735ae2', N'AUD')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1940d1f0-9773-45ad-b651-8a18eed7a4e8', N'REG')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1940d1f0-9773-45ad-b651-8a18eed7a4e8', N'regis@dominio.com', N'REGIS@DOMINIO.COM', N'regis@dominio.com', N'REGIS@DOMINIO.COM', 1, N'AQAAAAEAACcQAAAAEK1QaIX+vPHmGnzDmoxwA1XLfPzKCKAUFks1CFpL2PQrm+2kBzsn9GLWn/9vTWSqsw==', N'4OI5BJYQMQ3IUA54QCHV6AKNQEMJH6ZR', N'27b85876-d1d8-4464-acc6-9444d944f4fb', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'253c77d3-ff5c-4e5f-a81a-7b86c3735ae2', N'audit@dominio.com', N'AUDIT@DOMINIO.COM', N'audit@dominio.com', N'AUDIT@DOMINIO.COM', 1, N'AQAAAAEAACcQAAAAEIdQInNcu5OvfRLDyjJb/AuX9RKbwVuuow/Ra34pryxVqkcmX+6FQrVha/9DNYPB8g==', N'KCAXPSGGFG4TWNVEVNQJCUV2C47IITRI', N'c2956585-40f7-43ab-8c33-4f272d98351d', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'729e6b0d-6ec4-4f29-abab-7ba6560e8fd1', N'admin@dominio.com', N'ADMIN@DOMINIO.COM', N'admin@dominio.com', N'ADMIN@DOMINIO.COM', 1, N'AQAAAAEAACcQAAAAEG3doPrH1VhR8T/uHwFSFzrfNGFB+m9apvl8RyZ9ojN/Nrb5OqjqQG6Johkju6XKxQ==', N'Z6QXNEHLZ5QX7PTETAZDUVTJ6LXZPDLR', N'0e204c80-52ba-46a1-9802-57ebf89508d7', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[CONTRACT_STATUS] ON 

INSERT [dbo].[CONTRACT_STATUS] ([id], [status], [enable]) VALUES (4, N'Solicitud', 1)
INSERT [dbo].[CONTRACT_STATUS] ([id], [status], [enable]) VALUES (5, N'Aprobado', 1)
INSERT [dbo].[CONTRACT_STATUS] ([id], [status], [enable]) VALUES (6, N'Rechazado', 1)
INSERT [dbo].[CONTRACT_STATUS] ([id], [status], [enable]) VALUES (7, N'Anulado', 1)
SET IDENTITY_INSERT [dbo].[CONTRACT_STATUS] OFF
SET IDENTITY_INSERT [dbo].[SERVICES] ON 

INSERT [dbo].[SERVICES] ([id], [code], [service_name], [description]) VALUES (1, N'CD1', N'Ventas MNY', N'Por Mayor')
INSERT [dbo].[SERVICES] ([id], [code], [service_name], [description]) VALUES (2, N'CD2', N'Ventas MNR', N'Por Menor')
SET IDENTITY_INSERT [dbo].[SERVICES] OFF
ALTER TABLE [dbo].[AFFILIATE_CONTRACT_SERVICES]  WITH CHECK ADD  CONSTRAINT [FK_AFFILIATE_CONTRACT_SERVICES_AFFILIATE_CONTRACTS] FOREIGN KEY([affiliate_contract_id])
REFERENCES [dbo].[AFFILIATE_CONTRACTS] ([id])
GO
ALTER TABLE [dbo].[AFFILIATE_CONTRACT_SERVICES] CHECK CONSTRAINT [FK_AFFILIATE_CONTRACT_SERVICES_AFFILIATE_CONTRACTS]
GO
ALTER TABLE [dbo].[AFFILIATE_CONTRACT_SERVICES]  WITH CHECK ADD  CONSTRAINT [FK_AFFILIATE_CONTRACT_SERVICES_SERVICES] FOREIGN KEY([service_id])
REFERENCES [dbo].[SERVICES] ([id])
GO
ALTER TABLE [dbo].[AFFILIATE_CONTRACT_SERVICES] CHECK CONSTRAINT [FK_AFFILIATE_CONTRACT_SERVICES_SERVICES]
GO
ALTER TABLE [dbo].[AFFILIATE_CONTRACTS]  WITH CHECK ADD  CONSTRAINT [FK_AFFILIATE_CONTRACTS_AFFILIATES] FOREIGN KEY([affiliate_id])
REFERENCES [dbo].[AFFILIATES] ([id])
GO
ALTER TABLE [dbo].[AFFILIATE_CONTRACTS] CHECK CONSTRAINT [FK_AFFILIATE_CONTRACTS_AFFILIATES]
GO
ALTER TABLE [dbo].[AFFILIATE_CONTRACTS]  WITH CHECK ADD  CONSTRAINT [FK_AFFILIATE_CONTRACTS_CONTRACT_STATUS] FOREIGN KEY([contract_statu_id])
REFERENCES [dbo].[CONTRACT_STATUS] ([id])
GO
ALTER TABLE [dbo].[AFFILIATE_CONTRACTS] CHECK CONSTRAINT [FK_AFFILIATE_CONTRACTS_CONTRACT_STATUS]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
