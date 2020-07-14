INSERT INTO SaleProduct
(SaleID, ProductID, UnitPrice, Quantity, ProductName, ExternalCode) 
VALUES 
(@SaleID, @ProductID, @UnitPricet, @Quantity, @ProductName, @ExternalCode);
select LAST_INSERT_ID();

