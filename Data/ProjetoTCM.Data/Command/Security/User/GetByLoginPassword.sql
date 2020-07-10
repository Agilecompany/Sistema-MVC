SELECT ID, Name, Email, Login, Password, Profile FROM `User`
WHERE Login = @Login AND Password = @Password AND Excluded = 0;