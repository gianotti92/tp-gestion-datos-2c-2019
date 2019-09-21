CREATE PROCEDURE SP_GET_FUNCTIONALITY_BY_USER
(@username VARCHAR(40))
AS
select f.id, f.nombre from GESTION_BDD_2C_2019.ROL_USUARIO ru 
join GESTION_BDD_2C_2019.ROL r ON ru.id = r.id
join GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD rf ON rf.rol_id = r.id
join GESTION_BDD_2C_2019.FUNCIONALIDAD f ON f.id = rf.funcionalidad_id
where ru.username like @username;











select * from GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD;
select * from GESTION_BDD_2C_2019.ROL_USUARIO;
select * from GESTION_BDD_2C_2019.ROL;