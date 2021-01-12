CREATE OR ALTER PROCEDURE [dbo].[SP_TD_GET_NoteById]
(
	@NoteId BIGINT
)
AS
BEGIN
	SELECT
		NoteId,
		NoteTypeId,
		Title
	FROM
		Notes
	WHERE
		Notes.NoteId = @NoteId

END