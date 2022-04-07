/***** Query 6- join users and coins based on their ID
NOTE: This doesn't really make sense for my project, as I don't have a many to many structure. I'm implementing these joins just for practice
****/

USE CryptoAvenueAssignmentDB;

SELECT u.Email, u.Age, u.ID, c.Abreviation
FROM dbo.Users as u
   INNER JOIN dbo.Wallets as w
      ON u.ID = w.UserID
	INNER JOIN dbo.Coins as c
	   ON c.ID = w.CoinID
ORDER BY c.Abreviation