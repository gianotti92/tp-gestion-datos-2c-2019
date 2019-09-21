CREATE PROCEDURE SP_UPDATE_USER
(@username VARCHAR(40),
 @pass VARCHAR(40),
 @estado INT,
 @tipo INT,
 @intentos INT
)
AS
UPDATE GESTION_BDD_2C_2019.USUARIO 
SET
username = @username,
pass = @pass,
estado = @estado,
tipo = @tipo,
intentos = @intentos

where username like @username;