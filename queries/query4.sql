/***** Query 4- count all users that are older than 20 years old and have a PUBLIC profile ****/

SELECT COUNT(*)
FROM [CryptoAvenueAssignmentDB].[dbo].[Users]
WHERE (Age > 20) and (HasPrivateProfile = 0)