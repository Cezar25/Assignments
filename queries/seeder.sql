USE CryptoAvenueAssignmentDB

INSERT INTO dbo.Coins (CoinName, Abreviation,ValueInEUR, ValueInUSD, ValueInBTC)
VALUES
('Euro','EUR', 1,1.15,0.000023),
('US dollar','USD',0.85,1,0.000021),
('Bitcoin','BTC',42000,47400,1),
('Ethereum','ETH',3074,3370,0.071),
('Cardano','ADA',1.13,1.24,0.000026),
('Solana','SOL',100,111,0.0037),
('Sandbox','SAND',3.13,3.61,0.00007),
('Dogecoin','DOGE',0.14,0.16,0.0000032),
('BinanceCoin', 'BNB', 393.7, 427.6, 0.1),
('Ripple', 'XRP', 0.7, 0.77, 0.000018)

INSERT INTO dbo.Users (Email, Password, Age, SecurityQuestion, SecurityAnswer, HasPrivateProfile )
VALUES
('cezar.buna25@gmail.com','cacamaca',20,'dog name?','snowy', 0),
('andi.popescu@gmail.com','alabala',22,'cat name?','freckles', 0),
('andrei.ionescu@gmail.com','flrtasd',19,'grandpa name?','grandpa', 1),
('paul.popescu@gmail.com','asdasdsd',30,'granma name?','granma', 0),
('raul.mihoc@gmail.com','aerwwer',25,'father name?','ion', 1),
('alin.georgescu@yahoo.com','truliluli',35,'car brand?','bmw', 0),
('razvan.popa@yahoo.com','qweqwe',21,'college name?','poli', 0),
('sorin.cartescu@yahoo.com','ghfghgfh',19,'home town?','timisoara', 0),
('mara.robescu@yahoo.com','sgfdgfg',21,'gender?','female', 1),
('alina.mihaescu@icloud.com','lsdpflsdf',21,'mother name?','ioana', 1)

INSERT INTO dbo.Wallets (CoinID, UserID, CoinAmount)
VALUES 
(1, 1, 450),
(2, 2, 1000),
(3, 3, 0.45),
(4, 4, 1.32),
(5, 1, 156),
(6, 1, 3.5),
(7, 5, 250),
(8, 6, 10000),
(9, 7, 3.5),
(10, 3, 700)
