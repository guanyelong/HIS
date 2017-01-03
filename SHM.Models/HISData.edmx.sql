
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/03/2017 13:59:04
-- Generated from EDMX file: D:\project\SchoolHospitalManager\SHM.Models\HISData.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HISManager];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[SYS_USERINFO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SYS_USERINFO];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SYS_USERINFO'
CREATE TABLE [dbo].[SYS_USERINFO] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [GUID] uniqueidentifier  NULL,
    [LoginName] nvarchar(50)  NULL,
    [PASSWORD] nvarchar(50)  NULL,
    [NAME] nvarchar(50)  NULL,
    [AGE] int  NULL,
    [SEX] bigint  NULL,
    [PHONE] nvarchar(50)  NULL,
    [DepartmentID] int  NULL,
    [CreateTime] datetime  NULL,
    [Email] nvarchar(50)  NULL,
    [QQ] nvarchar(50)  NULL,
    [Tel] nvarchar(50)  NULL,
    [Position] nvarchar(50)  NULL,
    [HeadImg] nvarchar(300)  NULL
);
GO

-- Creating table 'SYS_ITEMMENU'
CREATE TABLE [dbo].[SYS_ITEMMENU] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [MenuNum] varchar(50)  NULL,
    [ParentID] int  NULL,
    [TEXT] nvarchar(50)  NULL,
    [URL] nvarchar(50)  NULL,
    [ICON] nvarchar(200)  NULL,
    [CREATETIME] datetime  NULL,
    [STATE] nvarchar(10)  NULL,
    [CHECKED] bit  NULL,
    [SEQ] int  NULL,
    [ActionNum] nvarchar(50)  NULL,
    [ORDERINDEX] int  NULL
);
GO

-- Creating table 'SYS_ROLE'
CREATE TABLE [dbo].[SYS_ROLE] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ROLENAME] nvarchar(50)  NULL,
    [STATE] tinyint  NULL,
    [ROLENUM] nvarchar(50)  NULL,
    [CREATETIME] datetime  NULL,
    [FLAG] int  NULL
);
GO

-- Creating table 'SYS_Action'
CREATE TABLE [dbo].[SYS_Action] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ActionName] nvarchar(50)  NULL,
    [ActionNum] nvarchar(50)  NULL,
    [ParentID] int  NULL,
    [DESC] nvarchar(50)  NULL,
    [ActionMenu] int  NULL,
    [CREATETIME] datetime  NULL,
    [Flag] int  NULL,
    [Type] int  NULL
);
GO

-- Creating table 'SYS_USERROLEMAPPING'
CREATE TABLE [dbo].[SYS_USERROLEMAPPING] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ROLEID] int  NULL,
    [USERID] int  NULL,
    [CREATEDATE] datetime  NULL
);
GO

-- Creating table 'SYS_ROLEACTIONMAPPING'
CREATE TABLE [dbo].[SYS_ROLEACTIONMAPPING] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ROLEID] int  NULL,
    [ACTIONID] int  NULL,
    [CREATETIME] datetime  NULL
);
GO

-- Creating table 'SYS_Department'
CREATE TABLE [dbo].[SYS_Department] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Department] nvarchar(50)  NULL,
    [DepartmentNum] nvarchar(50)  NULL,
    [Flag] int  NULL,
    [CreateTime] datetime  NULL,
    [ParentID] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'SYS_USERINFO'
ALTER TABLE [dbo].[SYS_USERINFO]
ADD CONSTRAINT [PK_SYS_USERINFO]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SYS_ITEMMENU'
ALTER TABLE [dbo].[SYS_ITEMMENU]
ADD CONSTRAINT [PK_SYS_ITEMMENU]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SYS_ROLE'
ALTER TABLE [dbo].[SYS_ROLE]
ADD CONSTRAINT [PK_SYS_ROLE]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SYS_Action'
ALTER TABLE [dbo].[SYS_Action]
ADD CONSTRAINT [PK_SYS_Action]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SYS_USERROLEMAPPING'
ALTER TABLE [dbo].[SYS_USERROLEMAPPING]
ADD CONSTRAINT [PK_SYS_USERROLEMAPPING]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SYS_ROLEACTIONMAPPING'
ALTER TABLE [dbo].[SYS_ROLEACTIONMAPPING]
ADD CONSTRAINT [PK_SYS_ROLEACTIONMAPPING]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SYS_Department'
ALTER TABLE [dbo].[SYS_Department]
ADD CONSTRAINT [PK_SYS_Department]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------