create proc TuDien_Them
           @ID nvarchar(50)
           ,@English nvarchar(50)
           ,@ShortVN nvarchar(50)
           ,@VN nvarchar(max)
as

INSERT INTO [dbo].[TuDienAv]
           ([ID]
           ,[English]
           ,[ShortVN]
           ,[VN])
     VALUES
           (@ID
           ,@English
           ,@ShortVN
           ,@VN)



