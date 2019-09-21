/* TABLA ROL*/
CREATE TABLE GESTION_BDD_2C_2019.ROL
( id INT NOT NULL PRIMARY KEY,
estado INT,   
  nombre VARCHAR(50) NOT NULL
);

/* TABLA ROL_FUNCION */
CREATE TABLE GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
( id INT NOT NULL PRIMARY KEY,
  rol_id INT NOT NULL,
  funcionalidad_id INT NOT NULL
);

/* TABLA FUNCIONALIDAD */
CREATE TABLE GESTION_BDD_2C_2019.FUNCIONALIDAD
( id INT NOT NULL PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL
);

/* TABLA USUARIO*/
CREATE TABLE GESTION_BDD_2C_2019.USUARIO
(	username VARCHAR(40) PRIMARY KEY,
	tipo INT,
	pass VARCHAR(40),
	estado INT,
	intentos INT
);

/* CREATE TABLA ROL_USUARIO*/
CREATE TABLE GESTION_BDD_2C_2019.ROL_USUARIO
( id INT NOT NULL PRIMARY KEY,
  username VARCHAR(40) NOT NULL
); 

/* DATOS FUNCIONALIDAD */
INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD 
(id, nombre) values (1, 'Login y seguridad'); 

INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD 
(id, nombre) values (2, ' ABM de Rol');

INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD 
(id, nombre) values (3, 'Registro de Usuario');

INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD 
(id, nombre) values (4, 'ABM de Cliente');

INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD 
(id, nombre) values (5, 'ABM de Proveedor');

INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD 
(id, nombre) values (6, 'Cargar Crédito');

INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD 
(id, nombre) values (7, 'Comprar Oferta');

INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD 
(id, nombre) values (8, 'Confección y publicación de Ofertas');

INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD 
(id, nombre) values (9, 'Facturación a Proveedor');

INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD 
(id, nombre) values (10, 'Listado Estadístico');

/* DATOS ROL */
INSERT INTO GESTION_BDD_2C_2019.ROL
(id, nombre, estado) values (1, 'Proveedor', 1);

INSERT INTO GESTION_BDD_2C_2019.ROL
(id, nombre, estado) values (2, 'Administrativo', 1);

INSERT INTO GESTION_BDD_2C_2019.ROL
(id, nombre, estado) values (3, 'Cliente', 1);

/* DATOS ROL_FUNCION le doy todo el poder al administrativo */
INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
(id, rol_id, funcionalidad_id) values (1, 2, 1);

INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
(id, rol_id, funcionalidad_id) values (2, 2, 2);

INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
(id, rol_id, funcionalidad_id) values (3, 2, 3);

INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
(id, rol_id, funcionalidad_id) values (4, 2, 4);

INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
(id, rol_id, funcionalidad_id) values (5, 2, 5);

INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
(id, rol_id, funcionalidad_id) values (6, 2, 6);

INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
(id, rol_id, funcionalidad_id) values (7, 2, 7);

INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
(id, rol_id, funcionalidad_id) values (8, 2, 8);

INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
(id, rol_id, funcionalidad_id) values (9, 2, 9);

INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
(id, rol_id, funcionalidad_id) values (10, 2, 10); 

/* DATOS USUARIO */
INSERT INTO GESTION_BDD_2C_2019.USUARIO
(username, tipo, pass, estado, intentos) values ('test', 1, 'asd123', 1, 0);

/* DATOS EJEMPLO ROL_USUARIO*/
insert INTO GESTION_BDD_2C_2019.ROL_USUARIO
(id, username) values (1, 'test');

insert INTO GESTION_BDD_2C_2019.ROL_USUARIO
(id, username) values (2, 'test'); 

insert INTO GESTION_BDD_2C_2019.ROL_USUARIO
(id, username) values (3, 'test');


