﻿CREATE TABLE [TrackingProgressInDevEducationDB].[CommentFor]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [Name] NCHAR(10) NOT NULL
	CONSTRAINT [PK_COMMENTFOR] PRIMARY KEY CLUSTERED ([id] ASC),
)