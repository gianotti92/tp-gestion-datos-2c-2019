USE GD2C2019
GO

-- Verifico si existe el schema, si no existe lo creo

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'GESTION_BDD_2C_2019')
	BEGIN
		EXEC sys.sp_executesql N'CREATE SCHEMA [GESTION_BDD_2C_2019] AUTHORIZATION [gdCupon2019]'
		--PRINT 'Schema correctamente creado'
	END
GO

IF(OBJECT_ID('SP_crear_tablas') IS NOT NULL)
	DROP PROCEDURE SP_crear_tablas
IF(OBJECT_ID('SP_CREATE_ROL') IS NOT NULL)
	DROP PROCEDURE SP_CREATE_ROL
IF(OBJECT_ID('SP_CREATE_ROL_FUNCIONALIDAD') IS NOT NULL)
	DROP PROCEDURE SP_CREATE_ROL_FUNCIONALIDAD
IF(OBJECT_ID('SP_GET_USER') IS NOT NULL)
	DROP PROCEDURE SP_GET_USER
IF(OBJECT_ID('SP_GET_VENDOR') IS NOT NULL)
	DROP PROCEDURE SP_GET_VENDOR
IF(OBJECT_ID('SP_VALIDATE_USER') IS NOT NULL)
	DROP PROCEDURE SP_VALIDATE_USER
IF(OBJECT_ID('SP_SAVE_USER') IS NOT NULL)
	DROP PROCEDURE SP_SAVE_USER
IF(OBJECT_ID('SP_UPDATE_USER') IS NOT NULL)
	DROP PROCEDURE SP_UPDATE_USER
IF(OBJECT_ID('SP_GET_FUNCTIONALITY_BY_USER') IS NOT NULL)
	DROP PROCEDURE SP_GET_FUNCTIONALITY_BY_USER
IF(OBJECT_ID('SP_DELETE_ROL_FUNCIONALIDAD') IS NOT NULL)
	DROP PROCEDURE SP_DELETE_ROL_FUNCIONALIDAD
IF(OBJECT_ID('SP_UPDATE_ROL') IS NOT NULL)
	DROP PROCEDURE SP_UPDATE_ROL
IF(OBJECT_ID('SP_DELETE_ROL') IS NOT NULL)
	DROP PROCEDURE SP_DELETE_ROL
IF(OBJECT_ID('SP_GET_FUNCIONALIDAD_BY_ROL_ID') IS NOT NULL)
	DROP PROCEDURE SP_GET_FUNCIONALIDAD_BY_ROL_ID
IF(OBJECT_ID('SP_SAVE_ROL_USUARIO') IS NOT NULL)
	DROP PROCEDURE SP_SAVE_ROL_USUARIO
IF(OBJECT_ID('SP_DELETE_USER') IS NOT NULL)
	DROP PROCEDURE SP_DELETE_USER
IF(OBJECT_ID('SP_DELETE_ROL_USUARIO') IS NOT NULL)
	DROP PROCEDURE SP_DELETE_ROL_USUARIO
IF(OBJECT_ID('SP_SAVE_OFERTA') IS NOT NULL)
	DROP PROCEDURE SP_SAVE_OFERTA
IF(OBJECT_ID('SP_SAVE_POSTAL_CODE') IS NOT NULL)
	DROP PROCEDURE SP_SAVE_POSTAL_CODE
IF (OBJECT_ID('SP_SAVE_DIRECCION') IS NOT NULL)
	DROP PROCEDURE SP_SAVE_DIRECCION
IF(OBJECT_ID('SP_SAVE_CLIENT') IS NOT NULL)
	DROP PROCEDURE SP_SAVE_CLIENT
IF(OBJECT_ID('SP_CREAR_TABLAS') IS NOT NULL)
	DROP PROCEDURE SP_CREAR_TABLAS
IF(OBJECT_ID('SP_MIGRACION') IS NOT NULL)
	DROP PROCEDURE SP_MIGRACION
IF(OBJECT_ID('SP_SAVE_PROVIDER') IS NOT NULL)
	DROP PROCEDURE SP_SAVE_PROVIDER
GO

CREATE PROCEDURE SP_CREAR_TABLAS
AS

	BEGIN
		
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.Rol_Funcionalidad'))
		DROP TABLE GESTION_BDD_2C_2019.Rol_Funcionalidad
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.Funcionalidad'))
		DROP TABLE GESTION_BDD_2C_2019.Funcionalidad
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.ROL_USUARIO'))
		DROP TABLE GESTION_BDD_2C_2019.ROL_USUARIO
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.COMPRAS'))
		DROP TABLE GESTION_BDD_2C_2019.COMPRAS
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.OFERTA'))
		DROP TABLE GESTION_BDD_2C_2019.OFERTA
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.FACTURA'))
		DROP TABLE GESTION_BDD_2C_2019.FACTURA
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.PROVEEDOR'))
		DROP TABLE GESTION_BDD_2C_2019.PROVEEDOR
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.RUBRO'))
		DROP TABLE GESTION_BDD_2C_2019.RUBRO
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.CARGA_SALDO'))
		DROP TABLE GESTION_BDD_2C_2019.CARGA_SALDO
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.Rol'))
		DROP TABLE GESTION_BDD_2C_2019.Rol
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.DIRECCION'))
		DROP TABLE GESTION_BDD_2C_2019.DIRECCION

	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.CIUDAD'))
		DROP TABLE GESTION_BDD_2C_2019.CIUDAD
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.CODIGO_POSTAL'))
		DROP TABLE GESTION_BDD_2C_2019.CODIGO_POSTAL

	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.CLIENTE'))
		DROP TABLE GESTION_BDD_2C_2019.CLIENTE
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'GESTION_BDD_2C_2019.USUARIO'))
		DROP TABLE GESTION_BDD_2C_2019.USUARIO


	CREATE TABLE GESTION_BDD_2C_2019.ROL (
		id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		nombre VARCHAR(50) NOT NULL,
		estado BIT DEFAULT(1)
		);

	CREATE TABLE GESTION_BDD_2C_2019.FUNCIONALIDAD (
			id INT NOT NULL PRIMARY KEY,
			nombre VARCHAR(50) NOT NULL
		);

	CREATE TABLE GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD (
		rol_id INT NOT NULL FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.ROL(id),
		funcionalidad_id INT NOT NULL FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.FUNCIONALIDAD(id)
		);

	CREATE TABLE GESTION_BDD_2C_2019.USUARIO (
			username VARCHAR(40) NOT NULL PRIMARY KEY,
			tipo INT,
			pass VARCHAR(40) NOT NULL,
			habilitado BIT DEFAULT(1),
			intentos INT DEFAULT(0)
		);

	CREATE TABLE GESTION_BDD_2C_2019.CIUDAD(
		ID INT IDENTITY NOT NULL PRIMARY KEY,
		CIUDAD_NOMBRE NVARCHAR(255)
		)
	CREATE TABLE GESTION_BDD_2C_2019.CODIGO_POSTAL(
		ID INT IDENTITY NOT NULL PRIMARY KEY, 
		DESCRIPCION NVARCHAR (255),
		)

	CREATE TABLE GESTION_BDD_2C_2019.DIRECCION (
		id INT IDENTITY NOT NULL PRIMARY KEY,
		CALLE NVARCHAR(255),
		NUMERO varchar (10),
		DPTO varchar (10),
		LOCALIDAD NVARCHAR(255),
		PISO NVARCHAR(255),
		CIUDAD INT FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.CIUDAD(ID), --FK CIUDAD
		CODIGO_POSTAL INT,
		CODIGO_POSTAL_TEST INT FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.CODIGO_POSTAL(ID), --FK CODIGO_POSTAL
		)
	


	CREATE TABLE GESTION_BDD_2C_2019.ROL_USUARIO (
		rol_id INT NOT NULL FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.ROL(id),
		username VARCHAR(40) NOT NULL FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.USUARIO(username)
		);

		CREATE TABLE GESTION_BDD_2C_2019.CLIENTE (
		ID NUMERIC(18,0) IDENTITY  NOT NULL PRIMARY KEY,
		DNI NUMERIC(18) NOT NULL,
		NOMBRE NVARCHAR(255),
		APELLIDO NVARCHAR(255),
		MAIL NVARCHAR(255),
		TELEFONO NUMERIC(18),
		DIRECCION INT, --FK DIRECCION
		FNANCIAMIENTO DATETIME, 
		USUARIO VARCHAR(40) NOT NULL FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.USUARIO(username), --FK USUARIO
		SALDO DECIMAL(18,2)
		)
		

		CREATE TABLE GESTION_BDD_2C_2019.RUBRO(
		ID INT NOT NULL IDENTITY PRIMARY KEY,
		DESCRIPCION NVARCHAR(255), 
		)


	CREATE TABLE GESTION_BDD_2C_2019.PROVEEDOR (
		ID NUMERIC(18,0) IDENTITY NOT NULL PRIMARY KEY, 
		CUIT NVARCHAR(20) UNIQUE NOT NULL,
		RAZON_SOCIAL NVARCHAR(255) UNIQUE,
		MAIL NVARCHAR(255),
		TELEFONO NUMERIC(18),
		DIRECCION INT FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.DIRECCION(ID),  --FK DIRECCION
		RUBRO INT FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.RUBRO(ID), --FK RUBRO
		CONTACTO NVARCHAR(255),
		USUARIO VARCHAR(40) NOT NULL FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.USUARIO(username),--FK USUARIO

		)
	CREATE TABLE GESTION_BDD_2C_2019.CARGA_SALDO(
		ID INT IDENTITY NOT NULL PRIMARY KEY,
		CLIENTE_ID NUMERIC(18) FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.CLIENTE(ID),
		FECHA DATETIME,
		MONTO DECIMAL (18,2),
		TIPO VARCHAR(15)
			 CHECK( TIPO IN('DEBITO','CREDITO') ), --Enum de tipos
		TARJETA_NRO INT,
		TARJETA_NOMBRE NVARCHAR (255),
		TARJETA_VENC DATETIME,
		TARJETA_COD_SEG INT
		)
	CREATE TABLE GESTION_BDD_2C_2019.OFERTA(
		ID NVARCHAR(50) NOT NULL PRIMARY KEY,
		PROV_ID  NUMERIC(18,0) FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.PROVEEDOR(ID),
		PRECIO DECIMAL(18,2),
		PRECIO_LISTO DECIMAL(18,2),
		STOCK_DISPONIBLE NUMERIC(18,0),
		DESCRIPCION NVARCHAR(255),
		FECHA_PUBLIC DATETIME,
		FECHA_VENC DATETIME,
		MAX_X_COMPRA NUMERIC(18,0),
		)

	CREATE TABLE GESTION_BDD_2C_2019.FACTURA (
		ID INT NOT NULL PRIMARY KEY,
		FECHA DATETIME,
		PROV_ID NUMERIC (18,0) FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.PROVEEDOR(ID),
		PERIODO_INICIO DATETIME,
		PERIODO_FIN DATETIME,
		)
		
	CREATE TABLE GESTION_BDD_2C_2019.COMPRAS(
		ID INT IDENTITY NOT NULL PRIMARY KEY,
		OFERTA_ID NVARCHAR(50)FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.OFERTA(ID),
		CLIENTE_ID NUMERIC(18,0) FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.CLIENTE(ID),
		FECHA DATETIME,
		CUPON DECIMAL(18,2),
		FECHA_CONSUMO DATETIME,
		FACTURA_ID INT FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.FACTURA(ID),

		) 

		END
GO

IF(OBJECT_ID('udf_GetNumeric') IS NOT NULL)
	DROP function udf_GetNumeric
GO
CREATE FUNCTION dbo.udf_GetNumeric
(@strAlphaNumeric VARCHAR(256))
RETURNS VARCHAR(256)
AS
BEGIN
	DECLARE @intAlpha INT
	SET @intAlpha = PATINDEX('%[^0-9]%', @strAlphaNumeric)
	BEGIN
		WHILE @intAlpha > 0
			BEGIN
			SET @strAlphaNumeric = STUFF(@strAlphaNumeric, @intAlpha, 1, '' )
			SET @intAlpha = PATINDEX('%[^0-9]%', @strAlphaNumeric )
			END
	END
	RETURN ISNULL(@strAlphaNumeric,0)
END
GO
	CREATE PROCEDURE SP_MIGRACION  
	AS
	BEGIN



	
		/**Cracion de datos***/

		/* DATOS FUNCIONALIDAD */
		INSERT INTO GESTION_BDD_2C_2019.FUNCIONALIDAD (id, nombre) 
		VALUES	(1, 'Login y seguridad'),
				(2, 'ABM de Rol'),
				(3, 'Registro de Usuario'),
				(4, 'ABM de Cliente'),
				(5, 'ABM de Proveedor'),
				(6, 'Cargar Credito'),
				(7, 'Comprar Oferta'),
				(8, 'Confeccion y publicacion de Ofertas'),
				(9, 'Facturacion a Proveedor'),
				(10, 'Listado Estadistico');

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
				(2, 10),
				(1,8);

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.USUARIO
	(username,tipo,pass,habilitado,intentos)
	SELECT DISTINCT M.Cli_Dni,0,HASHBYTES('SHA2_256',CAST(M.Cli_Dni AS nvarchar) ),1,0
	FROM GD2C2019.gd_esquema.Maestra M
	WHERE M.Cli_Dni IS NOT NULL
	ORDER BY 1

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.ROL_USUARIO
	(rol_id,username)
	SELECT 3,username
	FROM GD2C2019.GESTION_BDD_2C_2019.USUARIO
	WHERE tipo = 0

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.USUARIO
	(username,tipo,pass,habilitado,intentos)
	SELECT DISTINCT M.Provee_CUIT,1,HASHBYTES('SHA2_256',CAST(M.Provee_CUIT AS nvarchar) ),1,0
	FROM GD2C2019.gd_esquema.Maestra M
	WHERE M.Provee_CUIT IS NOT NULL
	ORDER BY 1

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.ROL_USUARIO
	(rol_id,username)
	SELECT 1,username
	FROM GD2C2019.GESTION_BDD_2C_2019.USUARIO
	WHERE tipo = 1

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.CIUDAD
	(CIUDAD_NOMBRE)
	SELECT DISTINCT Cli_Ciudad
	FROM GD2C2019.gd_esquema.Maestra
	where Cli_Ciudad is not null
	UNION 
	SELECT DISTINCT Provee_Ciudad
	FROM GD2C2019.gd_esquema.Maestra
	where Provee_Ciudad is not null
	ORDER BY 1

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.CODIGO_POSTAL
	(DESCRIPCION)
	values ('No Informado')
		
	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.DIRECCION
	(CALLE,NUMERO,DPTO,LOCALIDAD,CIUDAD,CODIGO_POSTAL)
	select distinct left(m.Cli_Direccion, len(m.Cli_Direccion )-4), dbo.udf_GetNumeric(RIGHT(m.Cli_Direccion,5)),NULL,NULL,
	(select c.id from GD2C2019.GESTION_BDD_2C_2019.CIUDAD  c where m.Cli_Ciudad = c.CIUDAD_NOMBRE),1
	from GD2C2019.gd_esquema.Maestra M 
	WHERE M.Cli_Direccion IS NOT NULL

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.DIRECCION
	(CALLE,NUMERO,DPTO,LOCALIDAD,CIUDAD,CODIGO_POSTAL)
	select distinct left(m.Provee_Dom, len(m.Provee_Dom )-4), dbo.udf_GetNumeric(RIGHT(m.Provee_Dom,5)),NULL,NULL,
	(select c.id from GD2C2019.GESTION_BDD_2C_2019.CIUDAD  c where m.Provee_Ciudad = c.CIUDAD_NOMBRE),1
	from GD2C2019.gd_esquema.Maestra M
	where m.Provee_CUIT is not null 


	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.CLIENTE
	(DNI,NOMBRE,APELLIDO,MAIL,TELEFONO,DIRECCION,FNANCIAMIENTO,USUARIO,SALDO)
	SELECT DISTINCT M.Cli_Dni,M.Cli_Nombre,M.Cli_Apellido,M.Cli_Mail,M.Cli_Telefono,
	( Select d.id from GD2C2019.GESTION_BDD_2C_2019.DIRECCION D 
	where d.CALLE = left(m.Cli_Direccion, len(m.Cli_Direccion )-4)
	and d.NUMERO = dbo.udf_GetNumeric(RIGHT(m.Cli_Direccion,5)) ),
	M.Cli_Fecha_Nac,U.username,0
	FROM GD2C2019.gd_esquema.Maestra M
	JOIN GD2C2019.GESTION_BDD_2C_2019.USUARIO U ON U.username = CAST(M.Cli_DnI AS VARCHAR)
	ORDER BY 1


	insert into GD2C2019.GESTION_BDD_2C_2019.RUBRO
	(DESCRIPCION)
	SELECT DISTINCT M.Provee_Rubro
	FROM GD2C2019.gd_esquema.Maestra M
	WHERE M.Provee_Rubro IS NOT NULL


	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.PROVEEDOR
	(CUIT,RAZON_SOCIAL,MAIL,TELEFONO,DIRECCION,RUBRO,CONTACTO,USUARIO)
	SELECT DISTINCT M.Provee_CUIT, Provee_RS, NULL, Provee_Telefono,
	( Select d.id from GD2C2019.GESTION_BDD_2C_2019.DIRECCION D 
	where d.CALLE = left(m.Provee_Dom, len(m.Provee_Dom )-4)
	and d.NUMERO = dbo.udf_GetNumeric(RIGHT(m.Provee_Dom,5)) ) ,
	(SELECT R.ID FROM GD2C2019.GESTION_BDD_2C_2019.RUBRO R WHERE R.DESCRIPCION = M.Provee_Rubro) , NULL,
	M.Provee_CUIT
	FROM GD2C2019.gd_esquema.Maestra M
	Where m.Provee_CUIT is not null


	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.OFERTA
	(ID,PROV_ID,PRECIO,PRECIO_LISTO,STOCK_DISPONIBLE,DESCRIPCION,FECHA_PUBLIC,FECHA_VENC,MAX_X_COMPRA)
	SELECT DISTINCT M.Oferta_Codigo, (SELECT P.ID FROM GD2C2019.GESTION_BDD_2C_2019.PROVEEDOR P WHERE P.CUIT = M.Provee_CUIT)
	,M.Oferta_Precio,Oferta_Precio_Ficticio,Oferta_Cantidad,Oferta_Descripcion,
	Oferta_Fecha,Oferta_Fecha_Venc,0
	FROM GD2C2019.gd_esquema.Maestra M
	WHERE Oferta_Codigo IS NOT NULL
	ORDER BY Oferta_Codigo
	
	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.FACTURA
	(ID,FECHA,PROV_ID,PERIODO_INICIO,PERIODO_FIN)
	SELECT DISTINCT M.Factura_Nro, M.Factura_Fecha, 
	(SELECT P.ID FROM GD2C2019.GESTION_BDD_2C_2019.PROVEEDOR P WHERE P.CUIT = M.Provee_CUIT),
	Factura_Fecha,Factura_Fecha
	FROM GD2C2019.gd_esquema.Maestra M
	WHERE M.Factura_Nro IS NOT NULL
	ORDER BY 1


	

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.Usuario
	(username,tipo,pass,habilitado,intentos)
     VALUES ('admin','2',HASHBYTES('SHA2_256','w23e'),1,0)
	 
	 INSERT INTO GD2C2019.GESTION_BDD_2C_2019.ROL_USUARIO
	(rol_id,username)
     VALUES (2, 'admin')


	END

GO
		EXEC DBO.SP_CREAR_TABLAS
		EXEC DBO.SP_MIGRACION


GO


		CREATE PROCEDURE SP_CREATE_ROL
		(@nombre VARCHAR(50))

		AS
		BEGIN
		INSERT INTO GESTION_BDD_2C_2019.ROL(nombre)
		OUTPUT inserted.id
		VALUES (@nombre);
		END
		GO
		CREATE PROCEDURE SP_CREATE_ROL_FUNCIONALIDAD
		(
			@rol_id INT,
			@funcionalidad_id INT
		)

		AS
		BEGIN
		INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD(rol_id, funcionalidad_id)
		VALUES (@rol_id, @funcionalidad_id);
		END


		GO
		
		
		CREATE PROCEDURE SP_GET_FUNCTIONALITY_BY_USER
		(@username VARCHAR(40))
		AS
		BEGIN
		select f.id, f.nombre from GESTION_BDD_2C_2019.ROL_USUARIO ru 
		join GESTION_BDD_2C_2019.ROL r ON ru.rol_id = r.id
		join GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD rf ON rf.rol_id = r.id
		join GESTION_BDD_2C_2019.FUNCIONALIDAD f ON f.id = rf.funcionalidad_id
		where ru.username like @username;


		select * from GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD;
		select * from GESTION_BDD_2C_2019.ROL_USUARIO;
		select * from GESTION_BDD_2C_2019.ROL;
		END
		
		
		GO
		
		
		CREATE PROCEDURE SP_GET_USER
		(@username VARCHAR(40))
		AS
		BEGIN
		select * from GESTION_BDD_2C_2019.USUARIO where username like @username;
		END

		
GO

		CREATE PROCEDURE SP_VALIDATE_USER
	(@username VARCHAR(40),@passWord varchar(255),@status bit=0 OUTPUT )
	AS

	BEGIN
		
		declare @hash as varchar(max) = cast( HASHBYTES('SHA2_256', @passWord ) as varchar)

		SET @status = ISNULL((SELECT
									CASE									
									WHEN (@hash = u.pass) THEN 1
									ELSE 0
									END
								FROM GESTION_BDD_2C_2019.USUARIO u
								WHERE  username like @username ),0)
	END

GO
		CREATE PROCEDURE SP_SAVE_PROVIDER
		(@razonSocial NVARCHAR(255),
		@tel NUMERIC(18),
		@direc INT, 
		@ciut NVARCHAR(20), 
		@rubro INT,
		@mail  NVARCHAR(255), 
		@contacto NVARCHAR(255),
		@usuario VARCHAR(40))
		AS
		BEGIN
		insert into GESTION_BDD_2C_2019.PROVEEDOR (RAZON_SOCIAL, CUIT, CONTACTO, DIRECCION, RUBRO, TELEFONO, MAIL, USUARIO)
		values (@razonSocial, @ciut, @contacto, @direc, @rubro, @tel, @mail, @usuario )
		END
		GO

		CREATE PROCEDURE SP_SAVE_USER
		(@username VARCHAR(40),
		 @pass VARCHAR(40),
		 @tipo INT,
		 @rol_id INT
		)
		AS
		BEGIN
		insert into GESTION_BDD_2C_2019.USUARIO (username, pass, tipo) 


		values (@username,HASHBYTES('SHA2_256',CAST(@pass AS nvarchar) ) , @tipo);
		END
		GO

		CREATE PROCEDURE SP_UPDATE_USER
		(@username VARCHAR(40),
		 @pass VARCHAR(40),
		 @habilitado BIT,
		 @tipo INT,
		 @intentos INT
		)
		AS
		BEGIN
		UPDATE GESTION_BDD_2C_2019.USUARIO 
		SET
		pass = HASHBYTES( 'SHA2_256',CAST(@pass AS nvarchar) ),
		habilitado = @habilitado,
		tipo = @tipo,
		intentos = @intentos

		where username like @username;
		END

		GO

		CREATE PROCEDURE SP_DELETE_ROL_FUNCIONALIDAD
		(@rol_id INT)

		AS
		BEGIN
		DELETE FROM GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD 
		WHERE rol_id = @rol_id; 
		END

		GO

		CREATE PROCEDURE SP_UPDATE_ROL
		(@id INT,
		 @nombre VARCHAR(50),
		 @estado INT
		)

		AS
		BEGIN
		UPDATE GESTION_BDD_2C_2019.ROL 
		SET
			nombre = @nombre,
			estado = @estado
		WHERE id = @id; 
		END
		GO

		CREATE PROCEDURE SP_SAVE_POSTAL_CODE
		(@descripcion varchar(40))
		AS
		BEGIN
		insert into GESTION_BDD_2C_2019.CODIGO_POSTAL (DESCRIPCION)
		values
		(@descripcion)
		END
		GO

		CREATE PROCEDURE SP_SAVE_DIRECCION
		(@calle VARCHAR(255),
		 @nro VARCHAR(10),
		 @piso NVARCHAR(255),
		 @depto VARCHAR(10),
		 @localidad NVARCHAR(255),
		 @id_cod_postal INT)
		 AS
		 BEGIN

		insert into GESTION_BDD_2C_2019.DIRECCION (NUMERO, CALLE, PISO, DPTO, LOCALIDAD, CODIGO_POSTAL)
		values (@nro, @calle, @piso, @depto, @localidad, @id_cod_postal);
		END
		GO

		CREATE PROCEDURE SP_SAVE_CLIENT
		(@nombre VARCHAR(40),
		 @apellido VARCHAR(40),
		 @dni INT,
		 @mail NVARCHAR(255),
		 @telefono NUMERIC(18),
		 @fechaNac datetime,
		 @direccion_id INT,
		 @usuario_id VARCHAR(40))
	
		AS
		BEGIN

		insert into GESTION_BDD_2C_2019.CLIENTE (APELLIDO, DNI, MAIL, TELEFONO, FNANCIAMIENTO, NOMBRE, DIRECCION, USUARIO) 
		values ( @apellido, @dni, @mail, @telefono, @fechaNac, @nombre, @direccion_id, @usuario_id);
		END
		GO

		/******SP delete rol ***********/
		CREATE PROCEDURE SP_DELETE_ROL	
		(@rol_id INT)
		AS
		BEGIN
			delete from GESTION_BDD_2C_2019.ROL_USUARIO where rol_id = @rol_id;
			delete from GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD where rol_id = @rol_id
			delete from GESTION_BDD_2C_2019.ROL where id = @rol_id
		END
		GO

		/****SP funcionalidad por rol id******/
		create procedure SP_GET_FUNCIONALIDAD_BY_ROL_ID
		(@rol_id INT)
		AS
		BEGIN
			select f.id, f.nombre from GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD rf
			join GESTION_BDD_2C_2019.FUNCIONALIDAD f ON f.id = rf.funcionalidad_id
			where rf.rol_id like @rol_id
		END
		GO

		/****SP save oferta y proovedor asociado ******/
		create procedure SP_SAVE_OFERTA
		(@Id INT,
		@proovedor_id INT,
		@precio decimal,
		@precioLista decimal,
		@stockDisponible numeric,
		@fechaPublicacion datetime,
		@fechaVencimiento datetime,
		@cantidadMaximaPorCompra numeric
		)
		AS
		BEGIN
			insert into GESTION_BDD_2C_2019.OFERTA 
			(ID,PRECIO,PROV_ID, PRECIO_LISTO, STOCK_DISPONIBLE, FECHA_PUBLIC, FECHA_VENC, MAX_X_COMPRA)
			values
			(@Id, @precio, @proovedor_id,@precioLista,@stockDisponible,@fechaPublicacion,@fechaVencimiento,@cantidadMaximaPorCompra)
		END
		GO

		/******SP save rol_usuario ***********/
		CREATE PROCEDURE SP_SAVE_ROL_USUARIO
		(
			@rol_id INT,
			@username VARCHAR(40)
		)
		AS
		BEGIN
		insert into GESTION_BDD_2C_2019.ROL_USUARIO(rol_id, username) 
		values (@rol_id, @username);
		END

		GO

		/******SP delete usuario ***********/
		CREATE PROCEDURE SP_DELETE_USER
		(@username VARCHAR(40))
		AS
		BEGIN
			UPDATE GESTION_BDD_2C_2019.USUARIO
			SET habilitado = 0
			WHERE username = @username
		END
		GO

		/******SP delete rol usuario ***********/
		CREATE PROCEDURE SP_DELETE_ROL_USUARIO
		(@username VARCHAR(40))
		AS
		BEGIN
			DELETE FROM GESTION_BDD_2C_2019.ROL_USUARIO
			WHERE username = @username
		END

		GO


		/* DATOS USUARIO */
		INSERT INTO GESTION_BDD_2C_2019.USUARIO(username, tipo, pass) 
		VALUES ('test', 1, 'asd123');

		/* DATOS EJEMPLO ROL_USUARIO*/
		INSERT INTO GESTION_BDD_2C_2019.ROL_USUARIO(rol_id, username) 
		VALUES	(1, 'test'),
				(2, 'test'),
				(3, 'test');





GO

CREATE PROCEDURE SP_GET_VENDOR
		(@idVendor numeric(18))
		AS
		BEGIN
		select * from GESTION_BDD_2C_2019.PROVEEDOR where ID = @idVendor
END