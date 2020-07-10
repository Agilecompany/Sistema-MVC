-- Insert
INSERT INTO `User`
(Name, Email, Login, Password, Profile) 
VALUES 
(@Name, @Email, @Login, @Password, @Profile);
select LAST_INSERT_ID();