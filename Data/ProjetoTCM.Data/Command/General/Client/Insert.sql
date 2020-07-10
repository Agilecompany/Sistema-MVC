INSERT INTO Client 
VALUES
(default, @Name, @CPF, @Sex, @Email, @Phone, @CellPhone, @Excluded);
select LAST_INSERT_ID();
