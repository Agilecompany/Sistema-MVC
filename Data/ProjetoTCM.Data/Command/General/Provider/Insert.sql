INSERT INTO Provider 
VALUES 
(default,@Name, @CNPJ, @Address, @Email, 0);
select LAST_INSERT_ID();