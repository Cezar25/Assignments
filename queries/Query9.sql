/***** Query 9- select all the users whose password length is greater than 7 and they have a public profile
****/

USE CryptoAvenueAssignmentDB;
SELECT Email, Password, HasPrivateProfile
FROM dbo.Users
WHERE (LEN(Password) > 7) AND (HasPrivateProfile = 0);
