﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetByIdStudent](@id int)
AS
select [Name], [Surname], [Rate] from [Students]
where [id] = @id