INSERT INTO product
VALUES (default, @ExternalCode, @Name, @Description, @Brand, @Model,@UnitPrice,@Excluded);
select LAST_INSERT_ID();
