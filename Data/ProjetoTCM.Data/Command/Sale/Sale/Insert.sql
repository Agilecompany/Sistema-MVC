INSERT INTO Sale
(ID, SalesmanID, Payment, Date, Excluded, ClientID, UserID, ClientName, ClientCPF, SalesmanName) 
VALUES 
(@ID, @SalesmanID, @Payment, @Date, @Excluded, @ClientID, @UserID, @ClientName, @ClientCPF, @SalesmanName);
select LAST_INSERT_ID();