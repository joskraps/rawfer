
CREATE PROCEDURE [dbo].[GetFoodItemsForUser]
	@userId int
AS
BEGIN
	SET NOCOUNT ON;

	select * From FoodItems fi
	where fi.UserId in (0,@userId)
END