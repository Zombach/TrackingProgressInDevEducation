﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllPaymentsByStudent]
	@Student int
AS
	SELECT id
	,PaymentOn
	,PaymentTo
	,Amount
	,[Status]
	FROM [Payments]
	WHERE StudentId = @Student