CREATE PROCEDURE SP_GET_USER
(@id_usuario INT)
AS
select * from GESTION_BDD_2C_2019.USUARIO where id_usuario like @id_usuario;