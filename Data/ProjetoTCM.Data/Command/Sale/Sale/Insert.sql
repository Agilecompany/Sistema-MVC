INSERT INTO Sale
VALUES 
(default,@SalesmanID, @Payment, @Date, @Excluded, @ClientID, @UserID, @ClientName, @ClientCPF, @SalesmanName);
select LAST_INSERT_ID();