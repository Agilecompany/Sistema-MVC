UPDATE Product
SET  ExternalCode = @ExternalCode, Name=@Name, Description=@Description, Brand=@Brand, Model=@Model, UnitPrice=@UnitPrice, Excluded=@Excluded
WHERE id = @ID;

