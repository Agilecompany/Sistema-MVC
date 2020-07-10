INSERT INTO Salesman
(Name, CPF, Address, Sex, Email, Phone, Excluded) 
VALUES
(@Name, @CPF, @Address, @Sex, @Email, @Phone,  @Excluded);
select LAST_INSERT_ID();