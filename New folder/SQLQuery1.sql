create proc Login_Select
		@user nvarchar(50),
		@pass nvarchar(50)
as

SELECT [username]
      ,[password]
      ,[permision]
  FROM [dbo].[Login]
  Where @user=[username]
	and	@pass=[password]

