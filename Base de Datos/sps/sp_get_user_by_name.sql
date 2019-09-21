CREATE PROCEDURE SP_GET_USER
(@username VARCHAR(40))
AS
select * from GESTION_BDD_2C_2019.USUARIO where username like @username;