CREATE PROCEDURE SP_DELETE_ROL_FUNCIONALIDAD
(@rol_id INT)

AS

DELETE FROM GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD 
WHERE rol_id = @rol_id;