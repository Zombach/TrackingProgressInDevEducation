﻿CREATE TABLE [dbo].[Homeworks] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_HOMEWORKS] PRIMARY KEY CLUSTERED ([id] ASC)
);

