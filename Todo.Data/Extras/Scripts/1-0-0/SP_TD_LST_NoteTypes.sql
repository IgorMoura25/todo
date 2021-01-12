USE [todo]
GO

/****** Object:  StoredProcedure [dbo].[SP_TD_GET_NoteById]    Script Date: 12/12/2020 9:19:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[SP_TD_LST_NoteTypes]
AS
	BEGIN

		SELECT 
			[NoteTypeId], [Name]
		FROM 
			[todo].[dbo].[NoteTypes]

	END
GO


