INSERT INTO Product
(Name,Description,Brand,Model,UnitPrice,Excluded, ExternalCode)
VALUES 
(@Name,@Description,@Brand,@Model,@UnitPrice, @Excluded, @ExternalCode);
select LAST_INSERT_ID();
