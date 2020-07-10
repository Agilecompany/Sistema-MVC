UPDATE `User` 
SET Name = @Name, Email = @Email, Login = @Login, Password = @Password, Profile = @Profile
WHERE id = @ID;