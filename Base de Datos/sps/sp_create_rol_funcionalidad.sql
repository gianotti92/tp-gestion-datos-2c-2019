CREATE PROCEDURE SP_CREATE_ROL_FUNCIONALIDAD
(
	@rol_id INT,
	@funcionalidad_id INT
)

AS

INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD(rol_id, funcionalidad_id)
VALUES (@rol_id, @funcionalidad_id);
