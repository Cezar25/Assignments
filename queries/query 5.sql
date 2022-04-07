/***** Query 5- count all users that are older than 20 and group them by the count in ascending order and display them with their age(if they have a a public profile) ****/

USE CryptoAvenueAssignmentDB;
SELECT COUNT(ID) AS 'Number of Users', Age
FROM dbo.Users
WHERE HasPrivateProfile = 0
GROUP BY Age
HAVING Age > 20
ORDER BY COUNT(ID) ASC