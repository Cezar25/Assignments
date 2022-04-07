/***** Query 10 - display the average value in USD of every coin EXCEPT USD
****/

USE CryptoAvenueAssignmentDB;
SELECT AVG(ValueInUSD)
FROM dbo.Coins
WHERE Abreviation != 'USD'