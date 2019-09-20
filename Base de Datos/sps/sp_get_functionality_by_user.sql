CREATE PROCEDURE SP_GET_FUNCTIONALITY_BY_USER
(@usuario INT)
AS
select f.id_funcionalidad, f.nombre from GESTION_BDD_2C_2019.ROL_USUARIO ru 
		join GESTION_BDD_2C_2019.ROL r 
		on ru.id_rol = r.id_rol
		join GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD rf
		on rf.id_rol = r.id_rol
		join GESTION_BDD_2C_2019.FUNCIONALIDAD f
		on f.id_funcionalidad = rf.id_funcion
		where ru.username like @usuario;