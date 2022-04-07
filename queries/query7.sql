/***** Query 7 -  display all the coins that have a total sum of their 3 values greater than 5****/

USE CryptoAvenueAssignmentDB;

SELECT c.CoinName, c.Abreviation
FROM dbo.Coins as c
WHERE (c.ValueInEUR + c.ValueInUSD + c.ValueInBTC) > 5
ORDER BY c.Abreviation