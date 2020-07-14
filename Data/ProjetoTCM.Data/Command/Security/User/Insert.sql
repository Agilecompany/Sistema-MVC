-- Insert
INSERT INTO `User`
(Name, Login, Email,Password, Profile,Excluded) 
VALUES 
(@Name, @Login,@Email, @Password, @Profile, 0);
select LAST_INSERT_ID();