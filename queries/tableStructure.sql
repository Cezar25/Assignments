USE CryptoAvenueAssignmentDB;

CREATE TABLE Coins(
   ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   CoinName NVARCHAR (20) NOT NULL UNIQUE,
   Abreviation NVARCHAR(5) NOT NULL UNIQUE,
   ValueInEUR FLOAT NOT NULL,
   ValueInUSD FLOAT NOT NULL,
   ValueInBTC FLOAT NOT NULL
);

CREATE TABLE Users(
   ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   Email VARCHAR(30) NOT NULL UNIQUE,
   Password VARCHAR(30) NOT NULL,
   Age INT NOT NULL CHECK (Age >= 18),
   SecurityQuestion VARCHAR(50) NOT NULL,
   SecurityAnswer VARCHAR(50) NOT NULL,
   HasPrivateProfile INT NOT NULL
);

CREATE TABLE Wallets(
   ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
   CoinID INT NOT NULL FOREIGN KEY REFERENCES Coins(ID),
   UserID INT NOT NULL FOREIGN KEY REFERENCES Users(ID),
   CoinAmount FLOAT NOT NULL
);
