CREATE PROCEDURE SP_SAVE_USER
(@id_usuario INT,
 @nombre VARCHAR(40),
 @contrasena VARCHAR(40),
 @estado_usuario INT,
 @tipo_usuario INT,
 @intentos INT
)
AS
insert into GESTION_BDD_2C_2019.USUARIO (id_usuario, nombre, contrasena, estado_usuario, tipo_usuario, intentos) 
values (@id_usuario, @nombre, @contrasena, @estado_usuario, @tipo_usuario, @intentos);