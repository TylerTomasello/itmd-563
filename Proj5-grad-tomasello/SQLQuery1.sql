USE [Mortgages]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Mortgages] (
    [Principle]            INT           IDENTITY (1, 1) NOT NULL,
    [Interest Rate]        DECIMAL (3, 2) NOT NULL,
	[Duration Years]       INT NOT NULL,
	[Monthly Payment]      DECIMAL (15, 2) NOT NULL
);


