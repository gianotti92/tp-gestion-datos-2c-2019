CREATE PROCEDURE SP_UPDATE_ROL
(@id INT,
 @nombre VARCHAR(50),
 @estado INT
)

AS

UPDATE GESTION_BDD_2C_2019.ROL 
SET
nombre = @nombre,
estado = @estado
WHERE id = @id;