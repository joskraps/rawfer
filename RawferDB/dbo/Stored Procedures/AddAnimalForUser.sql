
CREATE PROCEDURE dbo.AddAnimalForUser
	@userId int,
	@name varchar(200),
	@breed varchar(200) = null,
	@weight decimal = null,
	@targetWeight decimal = null
AS
BEGIN
	SET NOCOUNT ON;

INSERT INTO [dbo].[Animals]
           ([userId]
           ,[name]
           ,[breed]
           ,[weight]
           ,[targetWeight])
     VALUES
           (@userId
           ,@name
           ,@breed
           ,@weight
           ,@targetWeight)
END