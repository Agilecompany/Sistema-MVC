UPDATE Client
SET Name = @Name, CPF=@CPF, Sex=@Sex, Email=@Email, Phone=@Phone, CellPhone=@CellPhone, Excluded=@Excluded
WHERE id = @ID;