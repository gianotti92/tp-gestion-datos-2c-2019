
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
IF(OBJECT_ID('SP_MIGRACION') IS NOT NULL)
	DROP PROCEDURE SP_MIGRACION
IF(OBJECT_ID('SP_CREATE_ROL') IS NOT NULL)
	DROP PROCEDURE SP_CREATE_ROL
IF(OBJECT_ID('SP_CREATE_ROL_FUNCIONALIDAD') IS NOT NULL)
	DROP PROCEDURE SP_CREATE_ROL_FUNCIONALIDAD
IF(OBJECT_ID('SP_GET_USER') IS NOT NULL)
	DROP PROCEDURE SP_GET_USER
IF(OBJECT_ID('SP_GET_VENDOR') IS NOT NULL)
	DROP PROCEDURE SP_GET_VENDOR
IF(OBJECT_ID('SP_GET_VENDORWITHUSER') IS NOT NULL)
	DROP PROCEDURE SP_GET_VENDORWITHUSER
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
IF(OBJECT_ID('SP_UPDATE_CLIENT') IS NOT NULL)
	DROP PROCEDURE SP_UPDATE_CLIENT
IF(OBJECT_ID('SP_SAVE_CARGA_SALDO') IS NOT NULL)
	DROP PROCEDURE SP_SAVE_CARGA_SALDO
IF(OBJECT_ID('SP_UPDATE_CLIENTE') IS NOT NULL)
	DROP PROCEDURE SP_UPDATE_CLIENTE
IF(OBJECT_ID('SP_GET_OFERTAS_BY_PROVIDER') IS NOT NULL)
	DROP PROCEDURE SP_GET_OFERTAS_BY_PROVIDER
IF(OBJECT_ID('SP_SAVE_FACTURA') IS NOT NULL)
	DROP PROCEDURE SP_SAVE_FACTURA
IF(OBJECT_ID('SP_SAVE_COMPRA') IS NOT NULL)
	DROP PROCEDURE SP_SAVE_COMPRA
IF(OBJECT_ID('SP_TOP5PROVMAYORFACTURACION') IS NOT NULL)
	DROP PROCEDURE SP_TOP5PROVMAYORFACTURACION
IF(OBJECT_ID('SP_TOP5MAYORDESCUENTO') IS NOT NULL)
	DROP PROCEDURE SP_TOP5MAYORDESCUENTO
IF(OBJECT_ID('SP_GET_OFERTAS_ADQUIRIDAS_BY_PROVIDER') IS NOT NULL)
	DROP PROCEDURE SP_GET_OFERTAS_ADQUIRIDAS_BY_PROVIDER
IF(OBJECT_ID('SP_ELIMINAR_CLIENTE') IS NOT NULL)
	DROP PROCEDURE SP_ELIMINAR_CLIENTE
IF(OBJECT_ID('SP_ELIMINAR_PROVEEDOR') IS NOT NULL)
	DROP PROCEDURE SP_ELIMINAR_PROVEEDOR
IF(OBJECT_ID('SP_UPDATE_PROVIDER') IS NOT NULL)
	DROP PROCEDURE SP_UPDATE_PROVIDER
IF(OBJECT_ID('SP_UPDATE_DIRECCION') IS NOT NULL)
	DROP PROCEDURE SP_UPDATE_DIRECCION
IF(OBJECT_ID('SP_UPDATE_COMPRA') IS NOT NULL)
	DROP PROCEDURE SP_UPDATE_COMPRA
IF(OBJECT_ID('SP_UPDATE_FECHA_CONSUMO') IS NOT NULL)
	DROP PROCEDURE SP_UPDATE_FECHA_CONSUMO
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
		CODIGO_POSTAL INT FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.CODIGO_POSTAL(ID) --FK CODIGO_POSTAL,
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
		SALDO DECIMAL(18,2) DEFAULT(0)
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
		ID INT NOT NULL PRIMARY KEY IDENTITY,
		IDOLD NVARCHAR(50),
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
		ID INT PRIMARY KEY ,
		FECHA DATETIME,
		PROV_ID NUMERIC (18,0) FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.PROVEEDOR(ID),
		PERIODO_INICIO DATETIME,
		PERIODO_FIN DATETIME,
		)
		
	CREATE TABLE GESTION_BDD_2C_2019.COMPRAS(
		ID INT IDENTITY NOT NULL PRIMARY KEY,
		OFERTA_ID INT FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.OFERTA(ID),
		CLIENTE_ID NUMERIC(18,0) FOREIGN KEY REFERENCES GESTION_BDD_2C_2019.CLIENTE(ID),
		FECHA DATETIME,
		--CUPON DECIMAL(18,2) NULL,
		FECHA_CONSUMO DATETIME NULL,
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
		VALUES	(1, 'Entrega Oferta'),
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
		VALUES	('Cliente'),
				('Proveedor'),
				('Administrativo'),
				('Administrador General');
				

		/* DATOS ROL_FUNCION le doy todo el poder al administrativo y ademas funcionalidad x usuario 
		1 Cliente, 2 Provedor, 3 Admin*/
		INSERT INTO GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD(rol_id, funcionalidad_id) 
		VALUES	(3,10),(3, 2),(3, 4),(3, 5), (3, 9), (3, 8), (1, 6), (1, 7), (2, 8), (2, 1), (4, 1), (4,2),(4,3),(4,4),(4,5),(4,6), (4,7), (4,8),(4,9),(4,10)
					

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.USUARIO
	(username,tipo,pass,habilitado,intentos)
	SELECT DISTINCT M.Cli_Dni,1,HASHBYTES('SHA2_256',CAST(M.Cli_Dni AS varchar(40)) ),1,0
	FROM GD2C2019.gd_esquema.Maestra M
	WHERE M.Cli_Dni IS NOT NULL
	ORDER BY 1

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.ROL_USUARIO
	(rol_id,username)
	SELECT 1,username
	FROM GD2C2019.GESTION_BDD_2C_2019.USUARIO
	WHERE tipo = 1

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.USUARIO
	(username,tipo,pass,habilitado,intentos)
	SELECT DISTINCT M.Provee_CUIT,2,HASHBYTES('SHA2_256',CAST(M.Provee_CUIT AS varchar(40)) ),1,0
	FROM GD2C2019.gd_esquema.Maestra M
	WHERE M.Provee_CUIT IS NOT NULL
	ORDER BY 1

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.ROL_USUARIO
	(rol_id,username)
	SELECT 2,username
	FROM GD2C2019.GESTION_BDD_2C_2019.USUARIO
	WHERE tipo = 2

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
	(IDOLD,PROV_ID,PRECIO,PRECIO_LISTO,STOCK_DISPONIBLE,DESCRIPCION,FECHA_PUBLIC,FECHA_VENC,MAX_X_COMPRA)
SELECT DISTINCT 
       [Oferta_Codigo]	   
	  ,(SELECT P.ID FROM GD2C2019.GESTION_BDD_2C_2019.PROVEEDOR P WHERE P.CUIT = M.Provee_CUIT)     
      ,[Oferta_Precio]
      ,[Oferta_Precio_Ficticio]
      ,[Oferta_Cantidad] --Se corresponde al campo de stock disponible. No tendría relación. Revisar.
	  ,[Oferta_Descripcion]
      ,[Oferta_Fecha]
      ,[Oferta_Fecha_Venc]
	  ,(select Max(oferta_cantidad) FROM [GD2C2019].[gd_esquema].[Maestra] M2 where M2.oferta_codigo = M.oferta_codigo)
  FROM [GD2C2019].[gd_esquema].[Maestra] M
  where oferta_codigo is not null
  order by oferta_codigo
	
	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.FACTURA
	(ID,FECHA,PROV_ID,PERIODO_INICIO,PERIODO_FIN)
	SELECT DISTINCT 
	M.Factura_Nro, 
	M.Factura_Fecha, 
	(SELECT P.ID FROM GD2C2019.GESTION_BDD_2C_2019.PROVEEDOR P WHERE P.CUIT = M.Provee_CUIT),
	DATEADD(ss,-86399, DATEADD(dd,-(DAY(factura_fecha)-1),factura_fecha)) fechaDesde, --obtengo primer día del mes con hora y minutos 00:00
	Factura_Fecha 
	FROM GD2C2019.gd_esquema.Maestra M
	WHERE M.Factura_Nro IS NOT NULL
	ORDER BY 1

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.COMPRAS
	(OFERTA_ID, CLIENTE_ID, FECHA, --CUPON,
	--FECHA_CONSUMO, se actualiza en un update más adelante.
	FACTURA_ID)
	SELECT DISTINCT 
		(select ID from GD2C2019.GESTION_BDD_2C_2019.OFERTA where idold = M.OFERTA_CODIGO),
		(select ID from GD2C2019.GESTION_BDD_2C_2019.CLIENTE C where C.DNI = M.cli_dni),
		M.Oferta_Fecha_Compra,
		-- CUPON?? VER COMO DEBERIA SER EL CUPON. A PRIORI, PODRÍA NO HACER FALTA.
		-- FECHA_CONSUMO se carga más adaelante.
		M.Factura_Nro
	from GD2C2019.gd_esquema.Maestra M
	where factura_nro is not null

	UPDATE
		GD2C2019.GESTION_BDD_2C_2019.COMPRAS
	SET
		 COMPRAS.FECHA_CONSUMO = M.oferta_entregado_fecha
	FROM
		 GD2C2019.GESTION_BDD_2C_2019.COMPRAS AS C
		INNER JOIN GD2C2019.GESTION_BDD_2C_2019.CLIENTE AS CL
			ON C.CLIENTE_ID = CL.ID
		INNER JOIN Gd2c2019.gestion_bdd_2c_2019.OFERTA AS o
			ON C.OFERTA_ID = o.id
		INNER JOIN gd_esquema.Maestra AS M
			ON CL.DNI = M.Cli_DNI
			and CL.NOMBRE = M.CLI_NOMBRE
			and CL.APELLIDO = M.CLI_APELLIDO
			and o.idold = M.OFERTA_CODIGO
	WHERE
		M.OFERTA_CODIGO is not null
		AND M.oferta_entregado_fecha IS NOT NULL


	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.CARGA_SALDO
	(CLIENTE_ID, FECHA, MONTO, TIPO)
	SELECT (select ID from GD2C2019.GESTION_BDD_2C_2019.CLIENTE C where C.DNI = M.cli_dni) cliente
	  ,[Carga_Fecha]      
      ,[Carga_Credito]
      ,CASE WHEN [Tipo_Pago_Desc] = 'Crédito' THEN 'CREDITO'
	        WHEN [Tipo_Pago_Desc] = 'Efectivo' THEN 'DEBITO'
	   END
	FROM [GD2C2019].[gd_esquema].[Maestra] M
	where m.Carga_Credito is not null


	SELECT C.CLIENTE_ID id, sum(C.MONTO) total
	Into #t_cargas_total
	FROM GD2C2019.GESTION_BDD_2C_2019.CARGA_SALDO C
	GROUP BY C.Cliente_ID

	UPDATE
		GD2C2019.GESTION_BDD_2C_2019.CLIENTE
	SET
		GD2C2019.GESTION_BDD_2C_2019.CLIENTE.SALDO = t.total
	FROM
		GD2C2019.GESTION_BDD_2C_2019.CLIENTE AS C
		INNER JOIN #t_cargas_total AS t
		ON C.ID = t.ID

	INSERT INTO GD2C2019.GESTION_BDD_2C_2019.Usuario
	(username,tipo,pass,habilitado,intentos)
     VALUES ('admin','3',HASHBYTES('SHA2_256','w23e'),1,0)
	 
	 INSERT INTO GESTION_BDD_2C_2019.CLIENTE
	 (NOMBRE, APELLIDO, DNI, MAIL, SALDO, USUARIO, TELEFONO, DIRECCION, FNANCIAMIENTO)
	 values
	 ('', '', 0, '', 10000, 'admin', 0, 1, '1946-06-29 00:00:00.000') 

	 INSERT INTO GESTION_BDD_2C_2019.PROVEEDOR
	 (CONTACTO, USUARIO, RAZON_SOCIAL, MAIL, CUIT,TELEFONO, RUBRO, DIRECCION)
	 values
	 ('','admin','','', '', 0, 1, 1)

	 INSERT INTO GD2C2019.GESTION_BDD_2C_2019.ROL_USUARIO
	(rol_id,username)
     VALUES (4, 'admin')
	 
	 INSERT INTO GD2C2019.GESTION_BDD_2C_2019.Usuario
	(username,tipo,pass,habilitado,intentos)
     VALUES ('administrativo','3',HASHBYTES('SHA2_256','w23e'),1,0)
	 
	 INSERT INTO GD2C2019.GESTION_BDD_2C_2019.ROL_USUARIO
	(rol_id,username)
     VALUES (3, 'administrativo')

/*
	SELECT M.Oferta_Codigo,m.Cli_Dni
	,M.Oferta_Fecha_Compra,Oferta_Entregado_Fecha,Factura_Nro
	Into #t_ofer2
	FROM GD2C2019.gd_esquema.Maestra M
	where M.Oferta_Codigo is not null
	ORDER BY Oferta_Codigo

	SELECT M.Oferta_Codigo,(SELECT C.ID FROM GD2C2019.GESTION_BDD_2C_2019.CLIENTE C WHERE C.DNI = M.Cli_Dni ) AS CLIENTE
	,M.Oferta_Fecha_Compra,NULL as cupon,
	(select top 1 t.Oferta_Entregado_Fecha from #t_ofer2 t 
	where t.Cli_Dni = m.Cli_Dni and t.Oferta_Codigo = m.Oferta_Codigo and t.Oferta_Fecha_Compra =m.Oferta_Fecha_Compra 
	and t.Oferta_Entregado_Fecha is not null ) ,
	(select top 1 t2.Factura_Nro from #t_ofer2 t2 where t2.Cli_Dni = m.Cli_Dni and t2.Oferta_Codigo = m.Oferta_Codigo 
	and t2.Factura_Nro =m.Factura_Nro and t2.Factura_Nro is not null )
	FROM GD2C2019.gd_esquema.Maestra M
	where M.Oferta_Codigo is not null
	ORDER BY Oferta_Codigo

	select Oferta_Codigo,Cli_Dni,Oferta_Fecha_Compra, SUM(isnull(Oferta_Entregado_Fecha,0)), sum(isnull(Factura_Nro,0))
	from #t_ofer2
	where Oferta_Entregado_Fecha is not null
	and Factura_Nro is not null
	group by Oferta_Codigo, Cli_Dni, Oferta_Fecha_Compra
	order by 1,2

--	INSERT INTO ICE_CUBES.Usuario(USERID, USER_TIPO,USER_PASS,USER_ROL)
--	VALUES ('admin','A',HASHBYTES('SHA2_256','w23e'),1)
*/



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
	(@username VARCHAR(40),@passWord varchar(255),@status bit OUTPUT )
	AS

	BEGIN
		
		declare @hash as varchar(max) = HASHBYTES('SHA2_256', @passWord )

		SELECT @status = (CASE									
							WHEN (@hash = u.pass) THEN 1
							ELSE 0
							END)
		FROM GESTION_BDD_2C_2019.USUARIO u
		WHERE  username like @username 
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

		CREATE PROCEDURE SP_UPDATE_PROVIDER
			(
			@id_prov NUMERIC(18,0),
			@razonSocial NVARCHAR(255),
			@tel NUMERIC(18),
			@direc INT,
			@ciut NVARCHAR(20),
			@rubro INT,
			@mail NVARCHAR(255),
			@contacto NVARCHAR(255),
            
			@calle VARCHAR(255),
			@nro VARCHAR(10),
			@piso NVARCHAR(255),
			@dpto  VARCHAR(10),
			@localidad NVARCHAR(255),
			@cp INT,
			@ciudad INT)
			AS 
			BEGIN
				
				update GESTION_BDD_2C_2019.DIRECCION set CALLE = @calle, DPTO = @dpto, NUMERO = @nro,
				CODIGO_POSTAL = @cp, CIUDAD = @ciudad, PISO = @piso, LOCALIDAD = @localidad
				where id = @direc
				
				update GESTION_BDD_2C_2019.PROVEEDOR set RAZON_SOCIAL = @razonSocial, TELEFONO = @tel,
				CUIT = @ciut, RUBRO = @rubro, MAIL = @mail, CONTACTO = @contacto, DIRECCION = @direc
				where ID = @id_prov
				
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
		values (@username,HASHBYTES('SHA2_256',@pass) , @tipo);
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
			IF @pass != (SELECT pass FROM GESTION_BDD_2C_2019.USUARIO WHERE username like @username)
			BEGIN
				UPDATE GESTION_BDD_2C_2019.USUARIO 
				SET	pass = HASHBYTES('SHA2_256',@pass)
				WHERE username like @username
			END

			UPDATE GESTION_BDD_2C_2019.USUARIO 
			SET	habilitado = @habilitado,
				tipo = @tipo,
				intentos = @intentos
			WHERE username like @username
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

		if (@estado = 0)
		begin
			delete from GESTION_BDD_2C_2019.ROL_USUARIO where rol_id = @id;
		end


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
		 @id_cod_postal INT,
		 @id_ciudad INT)
		 AS
		 BEGIN
			IF @id_ciudad = -1
			BEGIN
				INSERT INTO GESTION_BDD_2C_2019.DIRECCION (NUMERO, CALLE, PISO, DPTO, LOCALIDAD, CODIGO_POSTAL)
				OUTPUT inserted.id
				VALUES (@nro, @calle, @piso, @depto, @localidad, @id_cod_postal)
			END
			ELSE
			BEGIN
				INSERT INTO GESTION_BDD_2C_2019.DIRECCION (NUMERO, CALLE, PISO, DPTO, LOCALIDAD, CODIGO_POSTAL, CIUDAD)
				OUTPUT inserted.id
				VALUES (@nro, @calle, @piso, @depto, @localidad, @id_cod_postal, @id_ciudad)
			END
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
		 @usuario_id VARCHAR(40),
		 @saldo DECIMAL(18,2))
	
		AS
		BEGIN

		insert into GESTION_BDD_2C_2019.CLIENTE (APELLIDO, DNI, MAIL, TELEFONO, FNANCIAMIENTO, NOMBRE, DIRECCION, USUARIO, SALDO) 
		values ( @apellido, @dni, @mail, @telefono, @fechaNac, @nombre, @direccion_id, @usuario_id, @saldo);
		END
		GO

		CREATE PROCEDURE SP_UPDATE_CLIENTE
		(@id INT,
	     @nombre VARCHAR(40),
		 @apellido VARCHAR(40),
		 @dni INT,
		 @mail NVARCHAR(255),
		 @telefono NUMERIC(18),
		 @fechaNac datetime,
		 @direccion_id INT,
		 @usuario_id VARCHAR(40),
		 @saldo DECIMAL(18,2))
	
		AS
		BEGIN

		UPDATE GESTION_BDD_2C_2019.CLIENTE  
		SET NOMBRE = @nombre, 
			APELLIDO = @apellido,
			DNI = @dni,
			MAIL = @mail,
			TELEFONO = @telefono,
			FNANCIAMIENTO = @fechaNac,
			DIRECCION = @direccion_id,
			USUARIO = @usuario_id,
			SALDO = @saldo
		WHERE ID = @id 
		END 

		GO

		CREATE PROCEDURE SP_UPDATE_DIRECCION
		(	@id INT,
			@calle VARCHAR(255),
			@nro VARCHAR(10),
			@piso NVARCHAR(255),
			@dpto  VARCHAR(10),
			@localidad NVARCHAR(255),
			@cp INT)
		AS
		BEGIN
			update GESTION_BDD_2C_2019.DIRECCION set CALLE = @calle,
				NUMERO = @nro, PISO = @piso, DPTO = @dpto, CODIGO_POSTAL = @cp,
				LOCALIDAD = @localidad where ID = @id
		END
		GO


		/******SP delete rol ***********/
		CREATE PROCEDURE SP_DELETE_ROL	
		(@rol_id INT)
		AS
		BEGIN
			delete from GESTION_BDD_2C_2019.ROL_USUARIO where rol_id = @rol_id;
		--delete from GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD where rol_id = @rol_id
		--	delete from GESTION_BDD_2C_2019.ROL where id = @rol_id
			
			UPDATE GESTION_BDD_2C_2019.ROL 
			SET
				estado = 0
				WHERE id = @rol_id; 

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
		(
		@proovedor_id INT,
		@precio decimal,
		@precioLista decimal,
		@stockDisponible numeric,
		@fechaPublicacion datetime,
		@fechaVencimiento datetime,
		@cantidadMaximaPorCompra numeric,
		@descripcion NVARCHAR(255) 
		)
		AS
		BEGIN
			insert into GESTION_BDD_2C_2019.OFERTA 
			(PRECIO,PROV_ID, PRECIO_LISTO, STOCK_DISPONIBLE, FECHA_PUBLIC, FECHA_VENC, MAX_X_COMPRA, DESCRIPCION)
			OUTPUT inserted.ID
			values
			( @precio, @proovedor_id,@precioLista,@stockDisponible,@fechaPublicacion,@fechaVencimiento,@cantidadMaximaPorCompra, @descripcion)
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
		/*******SP save carga saldo ***********/
		CREATE PROCEDURE SP_SAVE_CARGA_SALDO
		(
			@cliente_id INT,
            @fecha DATETIME,
            @monto DECIMAL (18,2),
            @tipo VARCHAR(15),
            @tarjeta_nro INT,
            @tarjeta_nombre NVARCHAR (255),
            @tarjeta_fecha_vencimiento DATETIME,
            @tarjeta_codigo_seguridad INT
		)
		AS
		BEGIN
			INSERT INTO GESTION_BDD_2C_2019.CARGA_SALDO 
				(CLIENTE_ID, FECHA, MONTO, TIPO, TARJETA_NRO, TARJETA_NOMBRE, TARJETA_VENC, TARJETA_COD_SEG)
			VALUES 
				(@cliente_id, @fecha, @monto, @tipo, @tarjeta_nro, @tarjeta_nombre, @tarjeta_fecha_vencimiento, @tarjeta_codigo_seguridad)
		END
		GO

		CREATE PROCEDURE SP_GET_VENDOR
		(@idVendor numeric(18))
		AS
		BEGIN
			select * from GESTION_BDD_2C_2019.PROVEEDOR where ID = @idVendor
		END
		GO

		CREATE PROCEDURE SP_GET_OFERTAS_BY_PROVIDER (@id_proveedor  NUMERIC(18,0))
		AS
		BEGIN
			select * from GESTION_BDD_2C_2019.OFERTA where PROV_ID = @id_proveedor
		END
		GO

		CREATE PROCEDURE SP_GET_OFERTAS_ADQUIRIDAS_BY_PROVIDER(
		@id_proveedor NUMERIC(18,0),
		@fecha_inicio DATETIME,
		@fecha_fin DATETIME)
		AS
		BEGIN
			SELECT DISTINCT o.* from GESTION_BDD_2C_2019.COMPRAS c
			JOIN GESTION_BDD_2C_2019.OFERTA o
			ON o.ID = c.OFERTA_ID
			WHERE o.PROV_ID = @id_proveedor AND @fecha_inicio <= c.FECHA AND c.FECHA <= @fecha_fin
				  AND C.FACTURA_ID IS NULL
		END
		GO

		CREATE PROCEDURE SP_SAVE_FACTURA(
		@fecha_inicio DATETIME,
		@fecha_fin DATETIME,
		@fecha DATETIME,
		@prov_id NUMERIC (18,0))
		AS
		BEGIN
			insert into GESTION_BDD_2C_2019.FACTURA (ID, PROV_ID, PERIODO_INICIO, PERIODO_FIN, FECHA)
			OUTPUT inserted.ID
			values ((SELECT TOP 1 ID + 1 FROM GESTION_BDD_2C_2019.FACTURA ORDER BY ID DESC), @prov_id, @fecha_inicio, @fecha_fin, @fecha)
		END
		GO

		/*******SP save compra ***********/
		CREATE PROCEDURE SP_SAVE_COMPRA
		(
			@idOferta INT,
			@idCliente NUMERIC(18,0),
			@fecha DATETIME
			--@cantidad int
		)
		AS
		BEGIN
			INSERT INTO GESTION_BDD_2C_2019.COMPRAS(OFERTA_ID,CLIENTE_ID,FECHA)
			OUTPUT inserted.ID
			VALUES 
				(@idOferta, @idCliente, @fecha)

			update GESTION_BDD_2C_2019.OFERTA
			set STOCK_DISPONIBLE = (
			select (STOCK_DISPONIBLE-1 )
			from GESTION_BDD_2C_2019.OFERTA o
			where o.ID = @idOferta)
			where OFERTA.ID = @idOferta

		END
		GO
		
		CREATE PROCEDURE SP_ELIMINAR_CLIENTE
		(@id INT)
		AS
		BEGIN
			declare @id_usuario varchar(40)

			set @id_usuario = (select USUARIO from GESTION_BDD_2C_2019.CLIENTE where ID = @id)
			
			update GESTION_BDD_2C_2019.USUARIO set habilitado = 0 where username = @id_usuario
		END
		GO

		CREATE PROCEDURE SP_ELIMINAR_PROVEEDOR
		(@id INT)
		AS
		BEGIN
			declare @id_usuario varchar(40)

			set @id_usuario = (select c.USUARIO from GESTION_BDD_2C_2019.PROVEEDOR c where ID = @id)
			
			update GESTION_BDD_2C_2019.USUARIO set habilitado = 0 where username = @id_usuario
		END
		GO

		CREATE PROCEDURE SP_TOP5PROVMAYORFACTURACION
		 @anio int, @semestre int
		AS
		BEGIN	
	
			DECLARE @mes_comienzo_semestre int
			DECLARE @mes_fin_semestre int
			DECLARE @fecha_comienzo_semestre datetime
			DECLARE @fecha_fin_semestre datetime
	
				IF @semestre = 1	
				BEGIN	
				SET @mes_comienzo_semestre = 1	
				SET @mes_fin_semestre = 6
				SET @fecha_comienzo_semestre = DATETIMEFROMPARTS(@anio, @mes_comienzo_semestre, 1, 0, 0, 0, 0)
				SET @fecha_fin_semestre = DATETIMEFROMPARTS(@anio, @mes_fin_semestre, 30, 0, 0, 0, 0)		
				END
	
				IF @semestre = 2	
				BEGIN	
				SET @mes_comienzo_semestre = 7	
				SET @mes_fin_semestre = 12	
				SET @fecha_comienzo_semestre = DATETIMEFROMPARTS(@anio, @mes_comienzo_semestre, 1, 0, 0, 0, 0)
				SET @fecha_fin_semestre = DATETIMEFROMPARTS(@anio, @mes_fin_semestre, 31, 0, 0, 0, 0)
				END

				SELECT TOP 5 o.PROV_ID,P.RAZON_SOCIAL ,SUM(O.PRECIO) as total_facturado
				FROM GD2C2019.GESTION_BDD_2C_2019.COMPRAS C
				JOIN GD2C2019.GESTION_BDD_2C_2019.OFERTA O ON C.OFERTA_ID = O.ID
				JOIN GD2C2019.GESTION_BDD_2C_2019.PROVEEDOR P ON O.PROV_ID = P.ID
				WHERE C.FECHA >= @fecha_comienzo_semestre
				AND C.FECHA <= @fecha_fin_semestre
				GROUP BY O.PROV_ID, P.RAZON_SOCIAL
				order by 3 desc
		END

		GO

		CREATE PROCEDURE SP_TOP5MAYORDESCUENTO
		 @anio int, @semestre int
		AS
		BEGIN	
	
			DECLARE @mes_comienzo_semestre int
			DECLARE @mes_fin_semestre int
			DECLARE @fecha_comienzo_semestre datetime
			DECLARE @fecha_fin_semestre datetime
	
				IF @semestre = 1	
				BEGIN	
				SET @mes_comienzo_semestre = 1	
				SET @mes_fin_semestre = 6
				SET @fecha_comienzo_semestre = DATETIMEFROMPARTS(@anio, @mes_comienzo_semestre, 1, 0, 0, 0, 0)
				SET @fecha_fin_semestre = DATETIMEFROMPARTS(@anio, @mes_fin_semestre, 30, 0, 0, 0, 0)		
				END
	
				IF @semestre = 2	
				BEGIN	
				SET @mes_comienzo_semestre = 7	
				SET @mes_fin_semestre = 12	
				SET @fecha_comienzo_semestre = DATETIMEFROMPARTS(@anio, @mes_comienzo_semestre, 1, 0, 0, 0, 0)
				SET @fecha_fin_semestre = DATETIMEFROMPARTS(@anio, @mes_fin_semestre, 31, 0, 0, 0, 0)
				END

				SELECT distinct TOP 5   p.ID, p.RAZON_SOCIAL, ( sum(o.PRECIO) / sum(o.PRECIO_LISTO)) * 100 as mayorPorcentaje
				from GD2C2019.GESTION_BDD_2C_2019.OFERTA o
				join GD2C2019.GESTION_BDD_2C_2019.PROVEEDOR p on p.ID = o.PROV_ID
				WHERE o.FECHA_PUBLIC >= @fecha_comienzo_semestre
				AND o.FECHA_PUBLIC <= @fecha_fin_semestre
				GROUP BY  p.ID, P.RAZON_SOCIAL
				order by 3 desc
		END

		GO

		create procedure SP_UPDATE_COMPRA
		(@id_compra INT,
		 @factura_id int)
		 as
		 begin
			update GESTION_BDD_2C_2019.COMPRAS set FACTURA_ID = @factura_id
			where ID = @id_compra
		 end
		
		go

		create procedure SP_UPDATE_FECHA_CONSUMO
		(@compra_id INT,
		@fecha_consumo datetime)
		as
		begin
			update GESTION_BDD_2C_2019.COMPRAS set FECHA_CONSUMO = @fecha_consumo
			where ID = @compra_id 
		end
		go

/*exec SP_TOP5PROVMAYORFACTURACION '2020', '1'
exec SP_TOP5MAYORDESCUENTO '2020', '1'

go
				SELECT distinct TOP 5   p.ID, p.RAZON_SOCIAL, ( sum(o.PRECIO) / sum(o.PRECIO_LISTO)) * 100 as mayorPorcentaje
				from GD2C2019.GESTION_BDD_2C_2019.OFERTA o
				join GD2C2019.GESTION_BDD_2C_2019.PROVEEDOR p on p.ID = o.PROV_ID
				GROUP BY  p.ID, P.RAZON_SOCIAL
				order by 3 desc
				*/