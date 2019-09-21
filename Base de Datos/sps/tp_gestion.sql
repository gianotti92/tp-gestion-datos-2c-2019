/* TABLA FUNCIONALIDAD */
CREATE TABLE GESTION_BDD_2C_2019.FUNCIONALIDAD
( 
	id INT NOT NULL PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL
);

/* TABLA ROL*/
CREATE TABLE GESTION_BDD_2C_2019.ROL
( 
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	nombre VARCHAR(50) NOT NULL,
	estado BIT DEFAULT(1)
);

/* TABLA ROL_FUNCION */
CREATE TABLE GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD
(
	rol_id INT NOT NULL FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.ROL(id),
	funcionalidad_id INT NOT NULL FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.FUNCIONALIDAD(id)
);

/* TABLA USUARIO*/
CREATE TABLE GESTION_BDD_2C_2019.USUARIO
(	
	username VARCHAR(40) NOT NULL PRIMARY KEY,
	tipo INT,
	pass VARCHAR(40) NOT NULL,
	estado BIT DEFAULT(1),
	intentos INT DEFAULT(0)
);

/* CREATE TABLA ROL_USUARIO*/
CREATE TABLE GESTION_BDD_2C_2019.ROL_USUARIO
( 
	rol_id INT NOT NULL FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.ROL(id),
	username VARCHAR(40) NOT NULL FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.USUARIO(username)
); 

/* DATOS FUNCIONALIDAD */
INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD (id, nombre) 
VALUES	(1, 'Login y seguridad'),
		(2, 'ABM de Rol'),
		(3, 'Registro de Usuario'),
		(4, 'ABM de Cliente'),
		(5, 'ABM de Proveedor'),
		(6, 'Cargar Crédito'),
		(7, 'Comprar Oferta'),
		(8, 'Confección y publicación de Ofertas'),
		(9, 'Facturación a Proveedor'),
		(10, 'Listado Estadístico');

/* DATOS ROL */
INSERT INTO GESTION_BDD_2C_2019.ROL(nombre) 
VALUES	('Proveedor'),
		('Administrativo'),
		('Cliente');

/* DATOS ROL_FUNCION le doy todo el poder al administrativo */
INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD(rol_id, funcionalidad_id) 
VALUES	(2, 1),
		(2, 2),
		(2, 3),
		(2, 4),
		(2, 5),
		(2, 6),
		(2, 7),
		(2, 8),
		(2, 9),
		(2, 10); 

/* DATOS USUARIO */
INSERT INTO GESTION_BDD_2C_2019.USUARIO(username, tipo, pass) 
VALUES ('test', 1, 'asd123');

/* DATOS EJEMPLO ROL_USUARIO*/
INSERT INTO GESTION_BDD_2C_2019.ROL_USUARIO(rol_id, username) 
VALUES	(1, 'test'),
		(2, 'test'),
		(3, 'test');