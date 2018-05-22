
CREATE PROCEDURE dbo.GetAnimalsForUser
	@userId int
AS
BEGIN
	SET NOCOUNT ON;

	select * From animals a
	where a.userId = @userId
END