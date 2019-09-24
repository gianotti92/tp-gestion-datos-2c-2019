CREATE PROCEDURE SP_SAVE_USER
(@username VARCHAR(40),
 @pass VARCHAR(40),
 @estado INT,
 @tipo INT,
 @intentos INT
)
AS
insert into GESTION_BDD_2C_2019.USUARIO (username, pass, estado, tipo, intentos) 
values (@username, @pass, @estado, @tipo, @intentos);