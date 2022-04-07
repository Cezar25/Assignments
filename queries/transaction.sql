/*** Transaction update 3 records then delete 2 records***/
BEGIN TRY
   BEGIN TRANSACTION
      UPDATE dbo.Coins
	  SET Abreviation = 'EU' ,ValueInBTC = 2
	  WHERE Abreviation = 'EUR'

	  UPDATE dbo.Users
	  SET Email = 'cezar.buna@rocketmail.com' ,Age = 21
	  WHERE Email = 'cezar.buna25@gmail.com'

	  UPDATE dbo.Wallets
	  SET CoinAMount = 999
	  WHERE UserID = 1

   COMMIT TRANSACTION
END TRY

BEGIN CATCH
   ROLLBACK TRANSACTION
END CATCH