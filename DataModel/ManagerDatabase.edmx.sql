
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/08/2016 00:35:17
-- Generated from EDMX file: E:\Temp\#Project\GloryManager\DataModel\ManagerDatabase.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ManagerDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MemberShipUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MemberShips] DROP CONSTRAINT [FK_MemberShipUser];
GO
IF OBJECT_ID(N'[dbo].[FK_MemberShipGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MemberShips] DROP CONSTRAINT [FK_MemberShipGroup];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserCollection]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserCollection];
GO
IF OBJECT_ID(N'[dbo].[Groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Groups];
GO
IF OBJECT_ID(N'[dbo].[MemberShips]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MemberShips];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserCollection'
CREATE TABLE [dbo].[UserCollection] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(100)  NOT NULL,
    [GroupId] int  NOT NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [groupId] int IDENTITY(1,1) NOT NULL,
    [group_name] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'MemberShips'
CREATE TABLE [dbo].[MemberShips] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GroupId] int  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'UserCollection'
ALTER TABLE [dbo].[UserCollection]
ADD CONSTRAINT [PK_UserCollection]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [groupId] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [PK_Groups]
    PRIMARY KEY CLUSTERED ([groupId] ASC);
GO

-- Creating primary key on [Id] in table 'MemberShips'
ALTER TABLE [dbo].[MemberShips]
ADD CONSTRAINT [PK_MemberShips]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'MemberShips'
ALTER TABLE [dbo].[MemberShips]
ADD CONSTRAINT [FK_MemberShipUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[UserCollection]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MemberShipUser'
CREATE INDEX [IX_FK_MemberShipUser]
ON [dbo].[MemberShips]
    ([UserId]);
GO

-- Creating foreign key on [GroupId] in table 'MemberShips'
ALTER TABLE [dbo].[MemberShips]
ADD CONSTRAINT [FK_MemberShipGroup]
    FOREIGN KEY ([GroupId])
    REFERENCES [dbo].[Groups]
        ([groupId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MemberShipGroup'
CREATE INDEX [IX_FK_MemberShipGroup]
ON [dbo].[MemberShips]
    ([GroupId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------