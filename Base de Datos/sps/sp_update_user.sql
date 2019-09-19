CREATE PROCEDURE SP_UPDATE_USER
(@id_usuario INT,
 @nombre VARCHAR(40),
 @contrasena VARCHAR(40),
 @estado_usuario INT,
 @tipo_usuario INT,
 @intentos INT
)
AS
UPDATE GESTION_BDD_2C_2019.USUARIO 
SET 
id_usuario = @id_usuario,
nombre = @nombre,
contrasena = @contrasena,
estado_usuario = @estado_usuario,
tipo_usuario = @tipo_usuario,
intentos = @intentos;