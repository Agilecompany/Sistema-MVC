UPDATE Provider 
SET Name =  @Name, CNPJ = @CNPJ, Address = @Address, Email = @Email, Excluded = @Excluded
WHERE ID = @ID;