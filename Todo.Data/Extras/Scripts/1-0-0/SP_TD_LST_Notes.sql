USE [todo]
GO

/****** Object:  StoredProcedure [dbo].[SP_TD_LST_NoteTypes]    Script Date: 12/12/2020 9:22:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [dbo].[SP_TD_LST_Notes]
AS
	BEGIN

		SELECT 
			[NoteId] ,[NoteTypeId] ,[Title]
		FROM 
			[todo].[dbo].[Notes]

	END
GO


