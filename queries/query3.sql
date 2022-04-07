/***** Query 3- display the average value in BTC of every coin EXCEPT bitcoin ****/

SELECT AVG(ValueInBTC)
FROM [CryptoAvenueAssignmentDB].[dbo].[Coins]
Where Abreviation != 'BTC'