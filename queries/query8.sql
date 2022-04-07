/***** Query 8-  ****/

USE CryptoAvenueAssignmentDB;
SELECT COUNT(*) AS 'Number of wallets'
FROM dbo.Users AS u, dbo.Wallets AS w
WHERE u.ID = w.UserID
ORDER BY COUNT(*) ASC