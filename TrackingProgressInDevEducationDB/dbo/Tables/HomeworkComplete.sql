﻿CREATE TABLE [dbo].[HomeworkComplete] (
    [id]         INT IDENTITY (1, 1) NOT NULL,
    [HomeworkId] INT NOT NULL,
    [StudentId]  INT NOT NULL,
    [Status]     BIT NOT NULL,
    CONSTRAINT [PK_HOMEWORKCOMPLETE] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [HomeworkComplete_fk0] FOREIGN KEY ([HomeworkId]) REFERENCES [dbo].[Homeworks] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [HomeworkComplete_fk1] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Students] ([id]) ON UPDATE CASCADE
);

