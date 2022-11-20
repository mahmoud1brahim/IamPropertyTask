

Create DATABASE Test

USE [Test]
GO

/****** Object:  StoredProcedure [dbo].[IsPalindrom]    Script Date: 11/20/2022 7:37:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Mahmoud Hefny>
-- Description:	<A stored procedure that detects if a text is palindrom or not>
-- =============================================
CREATE PROCEDURE [dbo].[IsPalindrom] 
	@Word varchar(200)
AS
BEGIN	
	SET NOCOUNT ON;

	DECLARE @result BIT
	SET @result = 0
	IF  @Word is null
	begin
		Select 'isPalindrom' = @result
		return
	end
	SET @Word = Replace(@Word,' ','')

	IF @Word = REVERSE(@Word)
	Begin
		Set @result = 1
	End
	Select 'isPalindrom' = @result
END
GO

