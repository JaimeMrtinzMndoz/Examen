
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/11/2013 13:08:17
-- Generated from EDMX file: C:\Users\Luky\Trabajo\Curso Desarrollo web 2014\Módulo Frameworks de desarrollo Web\Proyectos\AplicacionPersonas3capas\DAOPersonas\DBPersonas.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBPersonas];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [IdPersona] int  NOT NULL,
    [NombrePersona] nvarchar(50)  NOT NULL,
    [Ciudad] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPersona] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------