/***** Query 2- display all users whose emails begin with 'a' and display all the fields ****/

SELECT TOP(1000) *
FROM [CryptoAvenueAssignmentDB].[dbo].[Users]
WHERE Email LIKE 'a%'