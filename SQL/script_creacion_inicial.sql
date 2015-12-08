USE [GD2C2015]
GO


----------- CREACION DEL SCHEMA --------------------
IF (NOT EXISTS ( SELECT  1 FROM sys.schemas WHERE name = 'AWANTA' )) 
	BEGIN 
    EXEC('CREATE SCHEMA [AWANTA] AUTHORIZATION [gd]')
	END
GO


/*---------------------------DROP DE LAS TABLAS---------------------------*/

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'HISTORICO_BAJAS')
	DROP TABLE AWANTA.HISTORICO_BAJAS
	

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'DEVOLUCIONXENCOMIENDA')
	DROP TABLE AWANTA.DEVOLUCIONXENCOMIENDA

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'DEVOLUCIONXPASAJE')
	DROP TABLE AWANTA.DEVOLUCIONXPASAJE

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'DEVOLUCION')
	DROP TABLE AWANTA.DEVOLUCION

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'PASAJE')
	DROP TABLE AWANTA.PASAJE

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'ENCOMIENDA')
	DROP TABLE AWANTA.ENCOMIENDA

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'COMPRA')
	DROP TABLE AWANTA.COMPRA


IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'TERMINAL')
	DROP TABLE AWANTA.TERMINAL

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'TARJETA')
	DROP TABLE AWANTA.TARJETA


IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'TIPODEPAGO')
	DROP TABLE AWANTA.TIPODEPAGO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'BUTACA')
	DROP TABLE AWANTA.BUTACA


IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'VIAJE')
	DROP TABLE AWANTA.VIAJE


IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'AERONAVE')
	DROP TABLE AWANTA.AERONAVE

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'MODELO')
	DROP TABLE AWANTA.MODELO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'FABRICANTE')
	DROP TABLE AWANTA.FABRICANTE

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'CANJE')
	DROP TABLE AWANTA.CANJE

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'PRODUCTO')
	DROP TABLE AWANTA.PRODUCTO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'CLIENTE')
	DROP TABLE AWANTA.CLIENTE

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'USUARIO')
	DROP TABLE AWANTA.USUARIO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'FUNC_X_ROL')
	DROP TABLE AWANTA.FUNC_X_ROL

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'FUNCIONALIDAD')
	DROP TABLE AWANTA.FUNCIONALIDAD

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'ROL')
	DROP TABLE AWANTA.ROL

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'SERVICIOXRUTA')
	DROP TABLE AWANTA.SERVICIOXRUTA


IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'RUTA_AEREA')
	DROP TABLE AWANTA.RUTA_AEREA

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'RUTAS_VIEJAS')
	DROP TABLE AWANTA.RUTAS_VIEJAS

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'SERVICIO')
	DROP TABLE AWANTA.SERVICIO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'CIUDAD')
	DROP TABLE AWANTA.CIUDAD
IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'CONFIG')
	DROP TABLE AWANTA.CONFIG
GO

------------------- DROP PROCEDURES ---------------------------
DECLARE @name VARCHAR(128)
DECLARE @SQL VARCHAR(254)

SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'P' AND category = 0 ORDER BY [name])

WHILE @name is not null
BEGIN
    SELECT @SQL = 'DROP PROCEDURE [AWANTA].[' + RTRIM(@name) +']'
    EXEC (@SQL)
    PRINT 'Dropped Procedure: ' + @name
    SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] = 'P' AND category = 0 AND [name] > @name ORDER BY [name])
END
GO
---------------- DROP FUNCIONES ---------------------------
DECLARE @name VARCHAR(128)
DECLARE @SQL VARCHAR(254)

SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] IN (N'FN', N'IF', N'TF', N'FS', N'FT') AND category = 0 ORDER BY [name])

WHILE @name IS NOT NULL
BEGIN
    SELECT @SQL = 'DROP FUNCTION [AWANTA].[' + RTRIM(@name) +']'
    EXEC (@SQL)
    PRINT 'Dropped Function: ' + @name
    SELECT @name = (SELECT TOP 1 [name] FROM sysobjects WHERE [type] IN (N'FN', N'IF', N'TF', N'FS', N'FT') AND category = 0 AND [name] > @name ORDER BY [name])
END
GO

--------------- GET DATE CON FECHA CONFIGURADA  -------------------------

CREATE TABLE AWANTA.CONFIG(
	date_today DATETIME
	)
GO

CREATE PROCEDURE AWANTA.set_date(@date DATETIME)
AS
BEGIN
DELETE FROM AWANTA.CONFIG
INSERT INTO AWANTA.CONFIG(date_today) VALUES(@date)
END
GO

DECLARE @date DATETIME
SET @date = DATETIMEFROMPARTS(2017, 05, 13, 13, 13, 13, 00)
EXEC AWANTA.set_date @date

GO
CREATE FUNCTION AWANTA.getDate() RETURNS DATETIME
AS BEGIN 
RETURN (SELECT TOP 1 date_today FROM AWANTA.CONFIG) 
END
GO


/*---------------------------CREACION DE TABLAS Y CONSTRAINTS---------------------------*/


CREATE TABLE AWANTA.CIUDAD
(
	ciu_id numeric(18) identity(1,1) primary key,
	ciu_nombre nvarchar(255) not null,
)

CREATE TABLE AWANTA.SERVICIO
(
	serv_id_servicio numeric(18) identity(1,1) primary key,
	serv_nombre nvarchar(255) not null,
	serv_porcentaje_adicional int not null,		
)

CREATE TABLE AWANTA.RUTA_AEREA
(
	rut_codigo numeric(18) identity(1,1) primary key,
	rut_codigo_original numeric(18),
	rut_origen numeric(18) not null foreign key
	references AWANTA.CIUDAD(ciu_id),
	rut_destino numeric(18) not null foreign key
	references AWANTA.CIUDAD(ciu_id),
	rut_precio_base numeric(18,2) not null,
	rut_precio_base_x_kg numeric(18,2) not null,
	rut_habilitada bit not null,
)

CREATE TABLE AWANTA.SERVICIOXRUTA (
	servxr_ruta numeric(18) NOT NULL foreign key references AWANTA.RUTA_AEREA(rut_codigo),
	servxr_servicio numeric(18) NOT NULL foreign key references AWANTA.SERVICIO(serv_id_servicio)
)

CREATE TABLE AWANTA.ROL
(
	rol_id numeric(18) identity(0,1) primary key,
	rol_nombre nvarchar(255) not null,
	rol_estado bit not null,
)

CREATE TABLE AWANTA.FUNCIONALIDAD
(
	fun_id numeric(18) identity(1,1) primary key,
	fun_descripcion nvarchar(255) not null,
)

CREATE TABLE AWANTA.FUNC_X_ROL
(
	f_x_r_funcionalidad numeric(18) not null foreign key
	references AWANTA.FUNCIONALIDAD(fun_id) ,
	f_x_r_rol numeric(18) not null foreign key 
	references AWANTA.ROL(rol_id),
)

CREATE TABLE AWANTA.USUARIO
(
	usu_id numeric(18) identity(1,1) primary key,
	usu_username nvarchar(255) unique not null,
	usu_password nvarchar(255) not null,
	usu_estado bit not null,
	usu_fecha_alta datetime not null,
	usu_intentos_login int not null,
	usu_rol numeric(18) foreign key
	references AWANTA.ROL(rol_id)
)


CREATE TABLE AWANTA.CLIENTE
(	
	cli_codigo numeric(18) identity(1,1) primary key,
	cli_tipo_doc nvarchar(255) not null,
	cli_nro_doc numeric(18) not null,
	cli_nombre nvarchar(255) not null,
	cli_apellido nvarchar(255) not null,
	cli_direccion nvarchar(255) not null,
	cli_telefono numeric(18) not null,
	cli_fecha_nac datetime not null,
	cli_mail nvarchar(255)

)

CREATE TABLE AWANTA.PRODUCTO
(
	prod_id numeric(18) identity(1,1) primary key,
	prod_nombre nvarchar(255) not null,
	prod_millas bigint not null,
	prod_stock numeric(18),
)

CREATE TABLE AWANTA.CANJE  --suponemos que un canje es por cada producto, no que puede tener varios. 
(
	can_codigo numeric(18) identity(1,1) primary key,
	can_canjeador numeric(18) not null foreign key
	references AWANTA.CLIENTE(cli_codigo),
	can_producto numeric(18) not null foreign key
	references AWANTA.PRODUCTO(prod_id),
	can_cantidad numeric(18) not null,
	can_fecha datetime not null,
)


CREATE TABLE AWANTA.FABRICANTE(
	fab_id numeric(18) identity(1,1) primary key,
	fab_nombre nvarchar(255)
	)

CREATE TABLE AWANTA.MODELO(
	mod_id numeric(18) identity(1,1) primary key,
	mod_nombre nvarchar(255), -- puede tener un nombre o no! 
	mod_fabricante numeric(18) not null foreign key references AWANTA.FABRICANTE(fab_id)
)

CREATE TABLE AWANTA.AERONAVE
(
	aero_numero numeric(18) identity(1,1) primary key,
	aero_matricula nvarchar(255) unique not null,
	aero_modelo numeric(18) not null foreign key references AWANTA.MODELO(mod_id),
	aero_id_servicio numeric(18) not null foreign key
	references AWANTA.SERVICIO (serv_id_servicio),
	aero_fecha_de_alta datetime not null,
	aero_kgs_disponibles_encomiendas int not null,

)

CREATE TABLE AWANTA.VIAJE
(
	via_codigo numeric(18) identity(1,1) primary key,
	via_fecha_salida datetime not null,
	via_fecha_llegada datetime,
	via_fecha_llegada_estimada datetime not null,
	via_avion numeric(18) foreign key
	references AWANTA.AERONAVE(aero_numero) NOT NULL,
	via_ruta_aerea numeric(18) foreign key
	references AWANTA.RUTA_AEREA(rut_codigo) NOT NULL,
	via_cancelado bit,
)

CREATE TABLE AWANTA.BUTACA
(
	but_id numeric(18) identity(1,1) primary key,
	but_numero int not null,
	but_piso int not null,
	but_tipo nvarchar(255) not null,
	but_aeronave numeric not null foreign key references AWANTA.AERONAVE(aero_numero)

)


	-- si tenemos que el tipo de pago es 0, descripcion es efectivo, cuotas 1 (lo persistimos al principio) el resto son tarjetas de diferentes tipos
CREATE TABLE AWANTA.TIPODEPAGO(
	tdp_codigo numeric(18) primary key identity(0,1),
	tdp_descripcion nvarchar(255) not null,
	tdp_cuotas_maximas nvarchar(255) not null
)
CREATE TABLE AWANTA.TARJETA(
-- el tipo de la tarjeta siempre va a ser distinto de cero (se controla a nivel app) 
	tarjeta_id numeric(18) primary key identity(1,1),
	tarjeta_tipo numeric(18) not null foreign key references AWANTA.TIPODEPAGO(tdp_codigo),
    tarjeta_cliente  numeric(18)  not null foreign key references AWANTA.CLIENTE(cli_codigo),
	tarjeta_nro numeric(18) not null,
	tarjeta_codigo_seguridad numeric(18) not null,
	tarjeta_fecha_vencimiento datetime not null
	)

CREATE TABLE AWANTA.COMPRA
(
-- el cliente puede tener varias tarjetas que hagan referencia a el
	compra_id numeric(18) identity(1,1) primary key,
	compra_cliente numeric(18) references AWANTA.CLIENTE(cli_codigo),
	compra_fecha DATETIME,
	compra_cuotas int,
	compra_tipo_de_pago numeric(18) references AWANTA.TIPODEPAGO(tdp_codigo)
)


CREATE TABLE AWANTA.PASAJE
(
	pas_codigo numeric(18) identity (1,1) primary key,
	pas_pasajero numeric(18) not null foreign key references AWANTA.CLIENTE(cli_codigo),
	pas_compra numeric(18) not null foreign key references AWANTA.COMPRA(compra_id),
	pas_precio numeric(18,2),
	pas_viaje numeric(18) not null foreign key references AWANTA.VIAJE(via_codigo),
	pas_butaca numeric(18) not null foreign key references AWANTA.BUTACA(but_id) ,
    pas_cancelado bit
	-- referencio a la butaca, cuando quiera consultar me fijo en el viaje tambien y en butacas por viaje salta si esta ocupada o no.
)

CREATE TABLE AWANTA.ENCOMIENDA
(
	enc_codigo numeric(18) identity(1,1) primary key,
	enc_kg int not null,
	enc_viaje numeric(18) not null foreign key references AWANTA.VIAJE(via_codigo),
	enc_encomendador numeric(18) not null foreign key references AWANTA.CLIENTE(cli_codigo),
	enc_compra numeric(18) not null foreign key references AWANTA.COMPRA(compra_id),
	enc_precio numeric(18,2),
	enc_cancelado bit
)


CREATE TABLE AWANTA.DEVOLUCION
(
	dev_codigo numeric(18) identity(1,1) primary key,
	dev_compra numeric(18) not null references AWANTA.COMPRA(compra_id), -- esta repetido pero bueno
	dev_fecha datetime not null,
)

CREATE TABLE AWANTA.DEVOLUCIONXPASAJE (
	devxp_devolucion numeric(18) not null references AWANTA.DEVOLUCION,
	devxp_pasaje numeric(18) not null references AWANTA.PASAJE(pas_codigo),
	devxp_motivo NVARCHAR(255)
)

CREATE TABLE AWANTA.DEVOLUCIONXENCOMIENDA (
	devxp_devolucion numeric(18) not null references AWANTA.DEVOLUCION,
	devxp_encomienda numeric(18) not null references AWANTA.ENCOMIENDA(enc_codigo),
	devxe_motivo NVARCHAR(255)
)


CREATE TABLE AWANTA.HISTORICO_BAJAS 
(
	baja_codigo NUMERIC(18) identity (1,1) PRIMARY KEY,
	baja_avion NUMERIC(18) not null foreign key references AWANTA.AERONAVE(aero_numero),
	baja_fecha DATETIME not null,
	baja_reinicio DATETIME,
	baja_motivo bit,  -- 0 si fue por fin de vida util, 1 si era por mantenimiento
	--baja_ciudad NUMERIC(18) -- le pongo la ciudad en la que estaba cuando fue dado de baja
)

GO
GO

/*------MIGRACION DE LA TABLA CIUDAD------*/
INSERT INTO AWANTA.CIUDAD(ciu_nombre)
	SELECT DISTINCT Ruta_Ciudad_Origen
	FROM gd_esquema.Maestra
	WHERE NOT EXISTS (SELECT 1 FROM AWANTA.CIUDAD where ciu_nombre = Ruta_Ciudad_Origen)
GO


/*------MIGRACION DE LA TABLA SERVICIO------*/

CREATE FUNCTION AWANTA.porcentajeDadoUnServicio(@tipoServicio NVARCHAR(255))
RETURNS INT
AS
	BEGIN
		DECLARE @porcentaje INT
		DECLARE @precioTotal NUMERIC
		DECLARE @precioBase NUMERIC
		DECLARE miCursor CURSOR FOR SELECT Pasaje_Precio,Ruta_Precio_BasePasaje FROM gd_esquema.Maestra 
									WHERE Tipo_Servicio=@tipoServicio AND Pasaje_Precio > 0
		OPEN miCursor

		FETCH FROM miCursor INTO @precioTotal,@precioBase

		WHILE @@FETCH_STATUS = 0
			BEGIN
				SET @porcentaje = (@precioTotal-@precioBase) * 100 / @precioTotal
				CLOSE miCursor
				DEALLOCATE miCursor
				RETURN @porcentaje
			END	
		RETURN @porcentaje
	END
GO

INSERT INTO AWANTA.SERVICIO(serv_nombre,serv_porcentaje_adicional) VALUES('Turista',AWANTA.porcentajeDadoUnServicio('Turista'));
INSERT INTO AWANTA.SERVICIO(serv_nombre,serv_porcentaje_adicional) VALUES('Primera Clase',AWANTA.porcentajeDadoUnServicio('Primera Clase'));
INSERT INTO AWANTA.SERVICIO(serv_nombre,serv_porcentaje_adicional) VALUES('Ejecutivo',AWANTA.porcentajeDadoUnServicio('Ejecutivo'));
GO
/*------MIGRACION DE LA TABLA RUTA_AEREA------*/

CREATE FUNCTION AWANTA.getIdServicio(@Tipo_Servicio NVARCHAR(255))
RETURNS NUMERIC(18)
AS
	BEGIN
		RETURN (SELECT TOP 1 serv_id_servicio FROM AWANTA.SERVICIO WHERE @Tipo_Servicio LIKE '%' + serv_nombre)
	END 
GO

CREATE FUNCTION AWANTA.getIdCiudad(@nombreCiudad NVARCHAR(255))
RETURNS NUMERIC(18)
AS
	BEGIN
		RETURN (SELECT TOP 1 ciu_id FROM AWANTA.CIUDAD WHERE '%' + ciu_nombre + '%' LIKE '%' + @nombreCiudad + '%')
	END
GO

----- MIGRACION DE RUTAS -------
/*no tenemos rutas repetidas en la maestra que  tengan misma ciudad, origen, destino y tipo servicio y distintos campos restantes. (lo comprobamos mediante queries)
Ejemplo: 
SELECT DISTINCT Ruta_Codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, Tipo_Servicio, Ruta_Precio_BaseKG FROM gd_esquema.Maestra
WHERE Ruta_Precio_BaseKG != 0 
SELECT DISTINCT Ruta_Codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, Tipo_Servicio FROM gd_esquema.Maestra
WHERE Ruta_Precio_BaseKG != 0 
SELECT DISTINCT  Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, Tipo_Servicio FROM gd_esquema.Maestra
WHERE Ruta_Precio_BaseKG != 0 
todas estas queries devuelven 68 filas. 
notamos que tienen el mismo codigo cuando son ida y vuelta (a veces no coincide igual) pero como significan algo distinto, es decir, no es el mismo origen y el mismo destino,
las migramos con codigos diferentes.
no tuvimos en cuenta el codigo de las rutas para ver si eran distintas porque podiamos hacerlo viendo el resto de los campos. 

 */

CREATE FUNCTION AWANTA.getIdRuta(@origen NUMERIC, @destino NUMERIC) RETURNS NUMERIC
AS
BEGIN
RETURN (SELECT TOP 1 rut_codigo FROM AWANTA.RUTA_AEREA WHERE rut_origen = @origen AND rut_destino = @destino)
END
GO

CREATE FUNCTION AWANTA.compararCiudades(@origen NVARCHAR(255), @destino NVARCHAR(255)) RETURNS bit 
AS
BEGIN
IF (('%' + @origen + '%') LIKE ('%' + @destino + '%')) BEGIN RETURN 1 END RETURN 0
END
GO

DECLARE curs_rutas CURSOR FOR SELECT DISTINCT Ruta_Codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, Tipo_Servicio, Ruta_Precio_BaseKG FROM gd_esquema.Maestra
WHERE Ruta_Precio_BaseKG != 0
DECLARE @codigo numeric(18), @origen nvarchar(255), @destino nvarchar(255), @servicio nvarchar(255), @basekg numeric(18,2), @basepasaje numeric(18,2), @origenCodigo numeric(18), @destinoCodigo numeric(18), @servicioCodigo numeric(18)
OPEN curs_rutas
FETCH FROM curs_rutas INTO @codigo, @origen, @destino, @servicio, @basekg 
WHILE (@@FETCH_STATUS = 0)
BEGIN
SELECT @origenCodigo = AWANTA.getIdCiudad(@origen)
SELECT @destinoCodigo = AWANTA.getIdCiudad(@destino)
SET @servicioCodigo = (SELECT TOP 1 serv_id_servicio FROM AWANTA.SERVICIO WHERE serv_nombre = @servicio)
IF NOT EXISTS(SELECT 1 FROM AWANTA.RUTA_AEREA WHERE rut_origen = @origenCodigo AND rut_destino = @destinoCodigo)
BEGIN
INSERT INTO AWANTA.RUTA_AEREA(rut_origen, rut_destino, rut_precio_base_x_kg, rut_precio_base, rut_habilitada) VALUES (@origenCodigo, @destinoCodigo, @basekg, 0, 1)
INSERT INTO AWANTA.SERVICIOXRUTA(servxr_ruta,servxr_servicio) VALUES (SCOPE_IDENTITY(), @servicioCodigo)
UPDATE AWANTA.RUTA_AEREA SET rut_precio_base = (SELECT TOP 1 Ruta_Precio_BasePasaje FROM gd_esquema.Maestra WHERE  AWANTA.compararCiudades(Ruta_Ciudad_Destino, @destino) = 1 AND AWANTA.compararCiudades(Ruta_Ciudad_Origen, @origen) = 1 AND Ruta_Precio_BasePasaje != 0)
WHERE rut_origen = @origenCodigo AND rut_destino = @destinoCodigo
END
ELSE
IF NOT EXISTS (SELECT 1 FROM AWANTA.SERVICIOXRUTA WHERE servxr_ruta = SCOPE_IDENTITY() AND servxr_servicio = servxr_servicio)
INSERT INTO AWANTA.SERVICIOXRUTA(servxr_ruta,servxr_servicio) VALUES (AWANTA.getIdRuta(@origenCodigo, @destinoCodigo), @servicioCodigo)
FETCH FROM curs_rutas INTO @codigo, @origen, @destino, @servicio, @basekg
END
CLOSE curs_rutas
DEALLOCATE curs_rutas
GO

-------- marcar las rutas con un numero junto a su par --------------
DECLARE curs_tuplas CURSOR FOR SELECT rut_origen, rut_destino FROM AWANTA.RUTA_AEREA 
DECLARE @origen numeric(18), @destino numeric(18), @cod int = 0
OPEN curs_tuplas
FETCH FROM curs_tuplas INTO @origen, @destino 
WHILE @@FETCH_STATUS = 0
BEGIN
UPDATE AWANTA.RUTA_AEREA SET rut_codigo_original = @cod WHERE rut_codigo_original is null AND ((rut_origen = @origen AND rut_destino = @destino) OR (rut_origen = @destino AND rut_destino = @origen))
SET @cod = @cod + 1
FETCH FROM curs_tuplas INTO @origen, @destino
END
CLOSE curs_tuplas
DEALLOCATE curs_tuplas
GO

/*------MIGRACION DE LA TABLA ROL------*/
INSERT INTO AWANTA.ROL(rol_nombre,rol_estado)
	VALUES('Administrativo',1)

INSERT INTO AWANTA.ROL(rol_nombre,rol_estado)
	VALUES('Cliente',1)
GO



/*------MIGRACION DE LA TABLA FUNCIONALIDAD------*/
INSERT INTO AWANTA.FUNCIONALIDAD(fun_descripcion)
	SELECT 'ABM de Rol'
	UNION ALL
	SELECT 'Registro de Usuario'
	UNION ALL
	SELECT 'ABM de Ciudades'
	UNION ALL
	SELECT 'ABM de Ruta Aerea'
	UNION ALL
	SELECT 'ABM de Aeronaves'
	UNION ALL
	SELECT 'Generar Viaje'
	UNION ALL
	SELECT 'Registro de Llegada a Destino'
	UNION ALL
	SELECT 'Compra de Pasaje/Encomienda'
	UNION ALL
	SELECT 'Devolucion de Pasaje o Encomienda'
	UNION ALL
	SELECT 'Consultar Millas De Pasajero Frecuente'
	UNION ALL
	SELECT 'Canje de Millas de Pasajero Frecuente'
	UNION ALL
	SELECT 'Listado Estadistico'

GO


/*------MIGRACION DE LA TABLA FUNCIONALIDAD_X_ROL------*/	
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (1,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (2,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (3,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (4,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (5,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (6,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (7,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (8,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (9,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (10,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (11,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (12,0)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (8,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (10,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (12,1)
GO

CREATE PROCEDURE [AWANTA].set_funcionalidades_x_rol(@id_rol numeric(18),@id_funcionalidad numeric(18))
AS
	INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES(@id_funcionalidad,@id_rol);
GO


/*------MIGRACION DE LA TABLA CLIENTE------*/
INSERT INTO AWANTA.CLIENTE(cli_tipo_doc,cli_nro_doc,cli_nombre,cli_apellido,cli_direccion,cli_telefono,cli_fecha_nac,cli_mail)
SELECT DISTINCT 'DNI',Cli_Dni,Cli_Nombre,Cli_Apellido,Cli_Dir,Cli_Telefono,Cli_Fecha_Nac,Cli_Mail
FROM gd_esquema.Maestra
GO
--- la cliente que presentaba la inconsistencia como nacio en 1921 no era dni ---- 
DECLARE @cliente NUMERIC(18) 
SELECT @cliente = c1.cli_codigo FROM AWANTA.CLIENTE c1 JOIN AWANTA.CLIENTE c2 ON c1.cli_nro_doc = c2.cli_nro_doc AND c1.cli_codigo <> c2.cli_codigo WHERE c1.cli_fecha_nac < c2.cli_fecha_nac
UPDATE AWANTA.CLIENTE SET cli_tipo_doc = 'LC' WHERE cli_codigo = @cliente 
GO

/*------MIGRACION DE LA TABLA PRODUCTO------*/
GO
CREATE PROCEDURE [AWANTA].insertar_nuevo_producto(@nombreProducto NVARCHAR(255),@puntosNecesarios BIGINT,@stockProducto NUMERIC(18))
AS	
	IF NOT EXISTS(SELECT prod_nombre FROM AWANTA.PRODUCTO WHERE prod_nombre=@nombreProducto)
	BEGIN
		INSERT INTO AWANTA.PRODUCTO(prod_nombre,prod_millas,prod_stock)
		VALUES(@nombreProducto,@puntosNecesarios,@stockProducto);
	END
GO
	/*------INSERTO PRODUCTOS INICIALES------*/
EXEC AWANTA.insertar_nuevo_producto 'Televisor LCD',5000,100
EXEC AWANTA.insertar_nuevo_producto 'Notebook',6000,50
EXEC AWANTA.insertar_nuevo_producto 'Home Theatre',4500,60
EXEC AWANTA.insertar_nuevo_producto 'Playstation 4 ',3000,1000
EXEC AWANTA.insertar_nuevo_producto 'Heladera',2500,1000
EXEC AWANTA.insertar_nuevo_producto 'Smartphone',3500,2000
EXEC AWANTA.insertar_nuevo_producto 'Tablet',3000,1500

GO

--------- MIGRACION DE LOS FABRICANTES ------------

INSERT INTO AWANTA.FABRICANTE SELECT DISTINCT Aeronave_Fabricante from gd_esquema.Maestra
GO


CREATE FUNCTION AWANTA.getIdFabricante(@fabricante NVARCHAR(255)) RETURNS NUMERIC
AS BEGIN
RETURN (SELECT fab_id FROM AWANTA.FABRICANTE WHERE fab_nombre = @fabricante)
END
GO




----------- MIGRACION DE LOS MODELOS -------------
-- interpretamos que como el modelo forma parte de la aeronave, es un modelo distinto por aeronave. cada fabricante tiene 
-- el modelo 

INSERT INTO AWANTA.MODELO(mod_fabricante,mod_nombre) SELECT AWANTA.getIdFabricante(Aeronave_Fabricante), Aeronave_Modelo FROM gd_esquema.Maestra
GROUP BY Aeronave_Fabricante, Aeronave_Modelo 
ORDER BY AWANTA.getIdFabricante(Aeronave_Fabricante)

--------- MIGRACION DE LOS MODELOS ----------------

/*------MIGRACION DE LA TABLA AERONAVE------*/
GO
CREATE FUNCTION AWANTA.getIdModelo(@fabricante NVARCHAR(255), @modelo NVARCHAR(255)) RETURNS NUMERIC
AS BEGIN
RETURN (SELECT mod_id FROM AWANTA.MODELO WHERE mod_fabricante = AWANTA.getIdFabricante(@fabricante) AND mod_nombre = @modelo)
END
GO

/*OBTENCION DE CANTIDAD DE BUTACAS DE LA AERONAVE*/

CREATE FUNCTION AWANTA.obtenerButacasDeAeronave(@matricula NVARCHAR(255),@tipoButaca NVARCHAR(255))
RETURNS INT
AS
	BEGIN
		RETURN (SELECT TOP 1 Butaca_Nro FROM gd_esquema.Maestra WHERE Aeronave_Matricula = @matricula
									AND Butaca_Tipo = @tipoButaca ORDER BY Butaca_Nro desc)
	END
GO

------- MIGRACION DE AERONAVES -------

INSERT INTO AWANTA.AERONAVE(aero_matricula,aero_modelo,aero_id_servicio,aero_fecha_de_alta, aero_kgs_disponibles_encomiendas)
SELECT Aeronave_Matricula, AWANTA.getIdModelo(Aeronave_Fabricante, Aeronave_Modelo),
AWANTA.getIdServicio(Tipo_Servicio), CONVERT(date,AWANTA.getDate()),
max(Aeronave_KG_Disponibles)
FROM gd_esquema.Maestra
GROUP BY Aeronave_Matricula,  Aeronave_Fabricante, Aeronave_Modelo, Tipo_Servicio
GO

-------- MIGRACION DE BUTACAS -------
INSERT INTO AWANTA.BUTACA(but_numero, but_piso, but_tipo, but_aeronave) 
SELECT Butaca_Nro, Butaca_Piso, Butaca_Tipo, (SELECT aero_numero FROM AWANTA.AERONAVE where aero_matricula = Aeronave_Matricula) 
FROM gd_esquema.Maestra WHERE Butaca_Piso = 1 
GROUP BY Aeronave_Matricula, Butaca_Nro, Butaca_Piso, Butaca_Tipo 
GO

/*------MIGRACION DE LA TABLA VIAJE------*/

INSERT INTO AWANTA.VIAJE(via_fecha_salida,via_fecha_llegada,via_fecha_llegada_estimada,via_ruta_aerea,via_avion, via_cancelado)
SELECT T.FechaSalida, T.FechaLlegada, T.Fecha_LLegada_Estimada,
(SELECT TOP 1 rut_codigo FROM AWANTA.RUTA_AEREA 
WHERE AWANTA.getIdCiudad(T.Ruta_Ciudad_Destino) = rut_destino  AND AWANTA.getIdCiudad(T.Ruta_Ciudad_Origen) = rut_origen),
(SELECT TOP 1 aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = T.Aeronave_Matricula), 0
FROM (SELECT DISTINCT FechaSalida, FechaLlegada, Fecha_LLegada_Estimada,Ruta_Ciudad_Destino, Ruta_Ciudad_Origen, Aeronave_Matricula
FROM gd_esquema.Maestra) as T  
GO



CREATE FUNCTION AWANTA.getIdCliente(@tipo_dni char(5), @dni numeric(18)) RETURNS NUMERIC(18) AS
BEGIN
RETURN (SELECT top 1 cli_codigo FROM AWANTA.CLIENTE where cli_nro_doc = @dni and cli_tipo_doc = @tipo_dni)
END
GO
--------------- INSERCION DE TARJETAS Y MEDIOS DE PAGO ------------------

INSERT INTO AWANTA.TIPODEPAGO(tdp_cuotas_maximas, tdp_descripcion) VALUES (1, 'Efectivo')
INSERT INTO AWANTA.TIPODEPAGO(tdp_cuotas_maximas, tdp_descripcion) VALUES (2, 'VISA')
INSERT INTO AWANTA.TIPODEPAGO(tdp_cuotas_maximas, tdp_descripcion) VALUES (6, 'Mastercard')
INSERT INTO AWANTA.TIPODEPAGO(tdp_cuotas_maximas, tdp_descripcion) VALUES (24, 'American Express')

----- MIGRACION COMPRA --------
--- en este caso hacemos > 1901 porque es la fecha por defecto que pone sql cuando no seleccionamos una fecha. 
ALTER TABLE AWANTA.COMPRA ADD compra_item NUMERIC(18), compra_monto NUMERIC(18,2) -- si es 0 es paquete si es 1 es pasaje.  
GO

INSERT INTO AWANTA.COMPRA(compra_cliente, compra_fecha, compra_item, compra_monto, compra_tipo_de_pago)
SELECT DISTINCT (SELECT cli_codigo FROM AWANTA.CLIENTE WHERE m.Cli_Dni = cli_nro_doc AND m.Cli_Apellido = Cli_Apellido), m.Paquete_FechaCompra, m.Paquete_Codigo, m.Paquete_Precio, 0 FROM gd_esquema.Maestra m
where YEAR(m.Paquete_FechaCompra) > 1901 AND Butaca_Tipo = '0'
INSERT INTO AWANTA.COMPRA(compra_cliente, compra_fecha, compra_item, compra_monto, compra_tipo_de_pago)
SELECT DISTINCT (SELECT cli_codigo FROM AWANTA.CLIENTE WHERE m.Cli_Dni = cli_nro_doc AND m.Cli_Apellido = Cli_Apellido), m.Pasaje_FechaCompra, m.Pasaje_Codigo, m.Pasaje_Precio, 0 FROM gd_esquema.Maestra m
where YEAR(m.Pasaje_FechaCompra) > 1901 AND Butaca_Tipo <> '0'
GO

------ MIGRACION PASAJE ------------
-- mediante queries vimos que no estaban repetidos los pasajes (los codigos) 
-- SELECT DISTINCT Pasaje_Codigo from gd_esquema.Maestra : 265647 (el 1 que sobra es el pasaje 0 que no tiene nada)
SET IDENTITY_INSERT AWANTA.PASAJE ON
INSERT INTO AWANTA.PASAJE(pas_codigo, pas_pasajero, pas_compra, pas_precio, pas_butaca,  pas_viaje)
-- aca elegimos la butaca que pertenece a ese viaje 
SELECT m.Pasaje_Codigo, (SELECT compra_cliente FROM AWANTA.COMPRA WHERE compra_item = m.Pasaje_Codigo),(SELECT compra_id FROM AWANTA.COMPRA WHERE compra_item = m.Pasaje_Codigo) ,
(SELECT compra_monto FROM AWANTA.COMPRA WHERE compra_item = m.Pasaje_Codigo),
 (SELECT but_id FROM AWANTA.BUTACA WHERE but_aeronave IN (SELECT aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = m.Aeronave_Matricula)
AND but_piso = m.Butaca_Piso AND but_numero = m.Butaca_Nro AND m.Butaca_Tipo = but_tipo),
(SELECT via_codigo FROM AWANTA.VIAJE WHERE via_avion = (SELECT aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = m.Aeronave_Matricula) AND via_fecha_llegada = m.FechaLLegada AND
 via_fecha_llegada_estimada = m.Fecha_LLegada_Estimada AND via_fecha_salida = m.FechaSalida and via_ruta_aerea = (SELECT rut_codigo FROM AWANTA.RUTA_AEREA 
WHERE (SELECT ciu_id FROM AWANTA.CIUDAD where ciu_nombre = m.Ruta_Ciudad_Origen) = rut_origen AND 
(SELECT ciu_id FROM AWANTA.CIUDAD where ciu_nombre = m.Ruta_Ciudad_Destino) = rut_destino)) FROM gd_esquema.Maestra m
where m.Pasaje_Codigo != 0 
SET IDENTITY_INSERT AWANTA.PASAJE OFF

------------ MIGRACION DE LA ENCOMIENDA ---------------------

--- SELECT DISTINCT Paquete_Codigo from gd_esquema.Maestra : 135659 paquetes (el 1 que sobra es el paquete 0, que no tiene nada)
SET IDENTITY_INSERT AWANTA.ENCOMIENDA ON 
INSERT INTO AWANTA.ENCOMIENDA(enc_codigo, enc_encomendador, enc_compra, enc_precio, enc_kg, enc_viaje)
SELECT m.Paquete_Codigo, (SELECT compra_cliente FROM AWANTA.COMPRA WHERE compra_item = m.Paquete_Codigo), 
(SELECT compra_id FROM AWANTA.COMPRA WHERE compra_item = m.Paquete_Codigo),
(SELECT compra_monto FROM AWANTA.COMPRA WHERE compra_item = m.Paquete_Codigo), m.Paquete_KG,
(SELECT via_codigo FROM AWANTA.VIAJE WHERE via_avion = (SELECT aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = m.Aeronave_Matricula) AND via_fecha_llegada = m.FechaLLegada AND
 via_fecha_llegada_estimada = m.Fecha_LLegada_Estimada AND via_fecha_salida = m.FechaSalida and via_ruta_aerea = (SELECT rut_codigo FROM AWANTA.RUTA_AEREA 
WHERE (SELECT ciu_id FROM AWANTA.CIUDAD where ciu_nombre = m.Ruta_Ciudad_Origen) = rut_origen AND 
(SELECT ciu_id FROM AWANTA.CIUDAD where ciu_nombre = m.Ruta_Ciudad_Destino) = rut_destino)) FROM gd_esquema.Maestra m
where m.Pasaje_Codigo = 0 
SET IDENTITY_INSERT AWANTA.ENCOMIENDA OFF

ALTER TABLE AWANTA.COMPRA DROP COLUMN compra_item, compra_monto
--- Como vimos que no hay ningun registro con una fecha de llegada, quiere decir que todos los aviones registrados ya llegaron, por lo tanto no vamos a
-- poner esas butacas en butaca por viaje porque no lo necesitamos, los viajes ya pasaron, es simplemente registrarlo.
-- en cambio para los nuevos viajes si se van a registrar. 
-- en la migracion dejamos la fecha original del sistema, porque asi los aviones fueron dados de alta antes de comprar
-- en despues al usar la app siempre es la fecha del 2017, sino no seria consistente con las fechas de llegada.
------ despues de migrar todo, ahora actualizo las aeronaves para ponerle como fecha de baja la minima entre los pasajes o encomiendas.
DECLARE @aero NUMERIC(18)
DECLARE aeronaves CURSOR FOR SELECT aero_numero  FROM AWANTA.AERONAVE
OPEN aeronaves 
FETCH FROM aeronaves INTO @aero
WHILE @@FETCH_STATUS = 0
BEGIN
UPDATE AWANTA.AERONAVE SET aero_fecha_de_alta = (SELECT min(via_fecha_salida) FROM AWANTA.VIAJE WHERE via_avion = @aero)
WHERE aero_numero = @aero
FETCH FROM aeronaves INTO @aero
END
CLOSE aeronaves
DEALLOCATE aeronaves
GO

/*----------STORED PROCEDURES APLICACION----------*/ 


-- algunos mensajes de error --

-- exec sp_addmessage @msgnum = 50013, @severity = 1, @msgtext = 'El usuario ya esta repetido', @lang = us_english
 --GO

/*------LOGIN------*/

CREATE PROCEDURE AWANTA.registrar_usuario(@usuario NVARCHAR(255), @password NVARCHAR(255), @rol numeric(18))
AS
BEGIN
INSERT INTO AWANTA.USUARIO(usu_username, usu_estado, usu_fecha_alta, usu_intentos_login, usu_rol, usu_password) VALUES(@usuario, 1, AWANTA.getDate(), 0, @rol, HASHBYTES('SHA2_256', @password))
END
GO

-- registramos dos usuarios --
EXEC AWANTA.registrar_usuario 'user1', 'w23e', 0
go
EXEC AWANTA.registrar_usuario 'admin666', 'w23e', 0
go
EXEC AWANTA.registrar_usuario 'user2', 'w23e', 0
GO

EXEC AWANTA.registrar_usuario 'sudo', 'w23e', 2 
GO


CREATE TRIGGER AWANTA.username_repetido ON AWANTA.USUARIO INSTEAD OF INSERT
AS BEGIN TRANSACTION
IF (EXISTS(SELECT 1 FROM AWANTA.USUARIO WHERE usu_username = (SELECT usu_username FROM inserted)))
BEGIN 
ROLLBACK
RAISERROR(50013, 1, 1, 'Usuario repetido')
RETURN
END 
INSERT INTO AWANTA.USUARIO(usu_username, usu_estado, usu_fecha_alta, usu_intentos_login, usu_rol, usu_password) SELECT usu_username, usu_estado, usu_fecha_alta, usu_intentos_login, usu_rol, usu_password FROM INSERTED 
COMMIT
GO

 
CREATE TRIGGER AWANTA.tr_inhabilitar_usuario ON AWANTA.USUARIO AFTER UPDATE 
AS
DECLARE @intentos INT, @usuario NUMERIC(18)
SELECT @intentos = usu_intentos_login, @usuario = usu_id FROM inserted 
IF @intentos > 3 BEGIN UPDATE AWANTA.USUARIO SET usu_estado = 0 WHERE usu_id = @usuario END
GO

CREATE PROCEDURE AWANTA.aumentar_intentos(@username NVARCHAR(255)) 
AS
DECLARE @intentos INT
UPDATE AWANTA.USUARIO SET usu_intentos_login = usu_intentos_login + 1 
WHERE usu_username = @username
SELECT @intentos = usu_intentos_login FROM AWANTA.USUARIO WHERE usu_username = @username
RETURN @intentos
GO


CREATE PROCEDURE AWANTA.vaciar_intentos(@username NVARCHAR(255))
AS
UPDATE AWANTA.USUARIO SET usu_intentos_login = 0 WHERE usu_username = @username
RETURN 0
GO


CREATE PROCEDURE AWANTA.get_intentos(@username NVARCHAR(255))
AS
DECLARE @intentos int
SELECT @intentos = usu_intentos_login FROM AWANTA.USUARIO WHERE usu_username = @username
RETURN @intentos
GO


CREATE PROCEDURE [AWANTA].set_estado_usuario(@nombre_usuario NVARCHAR(255),@estado bit)
AS
	BEGIN
		
		UPDATE USUARIO SET usu_estado = @estado WHERE usu_username = @nombre_usuario
	END
GO
CREATE PROCEDURE AWANTA.validar_usuario(@username NVARCHAR(255), @password VARBINARY(32))
AS 
BEGIN
		IF EXISTS (SELECT 1 FROM AWANTA.USUARIO 
		JOIN AWANTA.ROL ON usu_rol = rol_id 
		WHERE usu_username = @username AND @password = usu_password  AND rol_estado = 1)
			BEGIN
				RETURN 1
			END
		RETURN -1
	END
GO

CREATE PROCEDURE AWANTA.existe_usuario(@username NVARCHAR(255)) AS
IF EXISTS ( SELECT 1 FROM AWANTA.USUARIO WHERE usu_username = @username ) BEGIN RETURN 1 END RETURN -1
GO


CREATE PROCEDURE AWANTA.get_rol(@username NVARCHAR(255)) 
AS 
SELECT rol_nombre FROM AWANTA.USUARIO
JOIN AWANTA.ROL ON usu_rol = rol_id 
WHERE usu_username = @username AND usu_rol = 0
GO


CREATE PROCEDURE AWANTA.inhabilitar_usuario(@nombre_usuario NVARCHAR(255))
AS BEGIN
UPDATE USUARIO SET usu_estado = -1 WHERE usu_username = @nombre_usuario
END
GO

CREATE PROCEDURE AWANTA.get_funcionalidad(@username NVARCHAR(255), @funcionalidad NVARCHAR(255))
AS 
BEGIN
	SELECT CASE WHEN EXISTS( SELECT 1 FROM AWANTA.USUARIO, AWANTA.ROL, AWANTA.FUNC_X_ROL, AWANTA.FUNCIONALIDAD
	WHERE USUARIO.usu_username = @username AND 
		usu_rol = rol_id AND
		ROL.rol_id = FUNC_X_ROL.f_x_r_rol AND 
		FUNC_X_ROL.f_x_r_funcionalidad = FUNCIONALIDAD.fun_id AND 
		FUNCIONALIDAD.fun_descripcion = @funcionalidad
	)
	THEN CAST(1 AS BIT)
	ELSE CAST(0 AS BIT)
END
END
GO
/*------ABM DE ROL------*/
ALTER PROCEDURE AWANTA.get_if_rol_habilitado(@rol numeric(18))
AS
BEGIN
	IF EXISTS(SELECT 1 FROM AWANTA.ROL WHERE rol_id=@rol AND rol_estado = 1)
		BEGIN
			RETURN 1
		END
	RETURN -1
END
GO

CREATE PROCEDURE AWANTA.get_funcionalidades(@rol numeric(18))
AS
BEGIN
	SELECT fun_id, fun_descripcion FROM AWANTA.FUNCIONALIDAD
	JOIN AWANTA.FUNC_X_ROL ON fun_id = f_x_r_funcionalidad
	WHERE f_x_r_rol = @rol
END
GO

CREATE PROCEDURE AWANTA.get_funcionalidades_que_no_tiene(@rol nvarchar(255))
AS
SELECT fun_id, fun_descripcion FROM AWANTA.FUNCIONALIDAD
WHERE NOT EXISTS (SELECT 1 FROM AWANTA.FUNC_X_ROL 
	WHERE f_x_r_funcionalidad = fun_id AND 
	f_x_r_rol = @rol)
GO

CREATE PROCEDURE AWANTA.get_id_rol_usuario(@username NVARCHAR(255))
AS
SELECT rol_id FROM AWANTA.USUARIO JOIN AWANTA.ROL ON usu_rol = rol_id
GO


CREATE PROCEDURE AWANTA.get_roles
AS
BEGIN
	SELECT rol_id, rol_nombre, rol_estado FROM AWANTA.ROL
END
GO

CREATE PROCEDURE AWANTA.get_all_funcionalidades
AS
BEGIN
SELECT fun_descripcion FROM AWANTA.FUNCIONALIDAD
END
GO

CREATE PROCEDURE AWANTA.get_id_funcionalidad(@func NVARCHAR(255))
AS
BEGIN
SELECT TOP 1 fun_id FROM AWANTA.FUNCIONALIDAD WHERE fun_descripcion = @func
END
GO

CREATE PROCEDURE AWANTA.crear_rol(@descripcion nvarchar(255), @estado bit)
AS
BEGIN
	INSERT INTO AWANTA.ROL(rol_nombre, rol_estado)
	VALUES(@descripcion, @estado)
END
GO
-- dar de baja rol: eliminar el rol de los usuarios que lo tienen. 
ALTER PROCEDURE AWANTA.bajar_rol(@id numeric(18))
AS
BEGIN
	UPDATE AWANTA.ROL SET rol_estado = 0 WHERE rol_id = @id
	UPDATE AWANTA.USUARIO SET usu_rol = NULL WHERE usu_rol = @id 

END
GO

CREATE PROCEDURE AWANTA.agregar_funcionalidad(@descripcion_func nvarchar(255))
AS
BEGIN
	INSERT INTO AWANTA.FUNCIONALIDAD(fun_descripcion)
	VALUES(@descripcion_func)
END
GO

CREATE PROCEDURE AWANTA.asignar_funcionalidad_a_rol (@rolID numeric(18), @func nvarchar(255))
AS
BEGIN
	INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_rol, f_x_r_funcionalidad) VALUES (@rolID,
	 (SELECT TOP 1 fun_id FROM AWANTA.FUNCIONALIDAD WHERE fun_descripcion = @func))
END
GO

CREATE FUNCTION AWANTA.getIdRol(@rol nvarchar(255)) RETURNS INT
AS
BEGIN
RETURN (SELECT rol_id FROM AWANTA.ROL WHERE rol_nombre = @rol)
END
GO
CREATE PROCEDURE AWANTA.borrar_funcionalidad(@rolid numeric(18), @descripcion_func nvarchar(255))
AS
BEGIN
	DELETE FROM AWANTA.FUNC_X_ROL
	WHERE f_x_r_funcionalidad = (SELECT fun_id FROM AWANTA.FUNCIONALIDAD WHERE fun_descripcion = @descripcion_func)
	AND f_x_r_rol = @rolid

END
GO

CREATE PROCEDURE AWANTA.existe_rol(@rol nvarchar(255))
AS
BEGIN
	IF(EXISTS(SELECT 1 FROM AWANTA.ROL WHERE rol_nombre = @rol)) BEGIN RETURN 1 END RETURN -1
END
GO

CREATE PROCEDURE AWANTA.modificar_nombre_rol(@rolID numeric(18), @nuevo_nombre nvarchar(255))
AS
BEGIN
	UPDATE AWANTA.ROL
	SET rol_nombre = @nuevo_nombre
	WHERE rol_id = @rolID
END
GO

CREATE PROCEDURE AWANTA.habilitar_rol(@id numeric(18))
AS
BEGIN
	UPDATE AWANTA.ROL
	SET rol_estado = 1 
	WHERE rol_id = @id
END
GO

/*------ABM DE CIUDAD------*/

CREATE PROCEDURE AWANTA.get_all_cities(@codigo numeric(18), @nombre nvarchar(255))
AS 
BEGIN
	SELECT *
	FROM AWANTA.CIUDAD
	WHERE (ciu_id = @codigo OR @codigo IS NULL) AND
	(ciu_nombre = @nombre OR @nombre IS NULL)
END
GO


CREATE FUNCTION AWANTA.obtenerNombreCiudad(@id_ciudad numeric(18))
RETURNS nvarchar(255)
AS
BEGIN
	DECLARE @nombre nvarchar(255)
	SET @nombre = (SELECT TOP 1 ciu_nombre FROM AWANTA.CIUDAD WHERE ciu_id = @id_ciudad)
	RETURN @nombre
END
GO


/*------ABM DE RUTA AEREA------*/
CREATE PROCEDURE AWANTA.get_all_rutas(@origen nvarchar(255) = null,  @destino nvarchar(255) = null, @servicio nvarchar(255) = null,
 @habilitada bit = null,  @precio_base_kg numeric(18,2) = null, @precio_base_pasaje numeric(18,2) = null)
AS 
BEGIN
DECLARE @servicios NVARCHAR(255)
	SELECT rut_codigo, AWANTA.obtenerNombreCiudad(rut_origen), AWANTA.obtenerNombreCiudad(rut_destino), 
	STUFF(
         (SELECT ', ' + serv_nombre FROM AWANTA.SERVICIO s
		 WHERE s.serv_id_servicio = s2.serv_id_servicio
          FOR XML PATH (''))
          , 1, 1, '') as servicios, rut_habilitada, rut_precio_base_x_kg, rut_precio_base
	FROM AWANTA.RUTA_AEREA
	JOIN AWANTA.SERVICIOXRUTA ON servxr_ruta = rut_codigo
	JOIN AWANTA.SERVICIO s2 ON servxr_servicio = s2.serv_id_servicio
	WHERE (@habilitada IS NULL OR rut_habilitada = @habilitada) AND
	(@destino IS NULL OR rut_destino=AWANTA.getIdCiudad(@destino)) AND
	(@origen IS NULL OR rut_origen=AWANTA.getIdCiudad(@origen)) AND
	(@precio_base_pasaje IS NULL OR rut_precio_base=@precio_base_pasaje) AND
	(@precio_base_kg IS NULL OR rut_precio_base_x_kg=@precio_base_kg) AND
	(@servicio IS NULL OR servxr_servicio=AWANTA.getIdServicio(@servicio))
	group by rut_codigo, rut_origen, rut_destino, rut_habilitada, rut_precio_base, rut_precio_base_x_kg, serv_id_servicio, rut_codigo_original
	order by rut_codigo_original
END
GO
CREATE PROCEDURE AWANTA.agregar_servicio(@servicio nvarchar(255), @ruta NUMERIC) 
AS 
BEGIN
-- hay que agregarle a la tabla asociativa los servicios, o quitarlos.  
IF NOT EXISTS (SELECT 1 FROM AWANTA.SERVICIOXRUTA WHERE servxr_ruta = @ruta AND servxr_servicio = AWANTA.getIdServicio(@servicio))
BEGIN
INSERT INTO AWANTA.SERVICIOXRUTA(servxr_ruta, servxr_servicio) values (@ruta, AWANTA.getIdServicio(@servicio)) 
END
END
GO

CREATE PROCEDURE AWANTA.borrar_servicio(@servicio nvarchar(255), @ruta NUMERIC) 
AS 
BEGIN
-- hay que agregarle a la tabla asociativa los servicios, o quitarlos.  
DELETE FROM AWANTA.SERVICIOXRUTA WHERE servxr_ruta = @ruta AND servxr_servicio = AWANTA.getIdServicio(@servicio)
END

GO
CREATE PROCEDURE AWANTA.get_servicios_rutas(@ruta NUMERIC(18))
AS
BEGIN
SELECT serv_nombre FROM AWANTA.SERVICIO JOIN AWANTA.SERVICIOXRUTA ON serv_id_servicio = servxr_servicio WHERE servxr_ruta = @ruta
END
GO


CREATE PROCEDURE AWANTA.modificar_ruta(@codigo NUMERIC(18), @origen nvarchar(255),  @destino nvarchar(255), @precio_base_kg numeric(18,2), @precio_base_pasaje numeric(18,2)) AS
 BEGIN
 DECLARE @id_servicio NUMERIC(18)
 -- si es sobre la misma ruta que quiere modificar, entonces me va a dejar hacer el update. sino, tiene que mirar que otra ruta distinta no tenga su origen y destino
 IF (NOT EXISTS(SELECT 1 FROM AWANTA.RUTA_AEREA WHERE rut_origen = AWANTA.getIdCiudad(@origen)  AND rut_destino = AWANTA.getIdCiudad(@destino)
 AND rut_codigo <> @codigo))
 BEGIN
 UPDATE AWANTA.RUTA_AEREA SET rut_origen = AWANTA.getIdCiudad(@origen), rut_destino = AWANTA.getIdCiudad(@destino), rut_precio_base_x_kg = @precio_base_kg, rut_precio_base = @precio_base_pasaje
 WHERE @codigo = rut_codigo
 RETURN 1 
 END
 RETURN -1
 END
 GO


CREATE PROCEDURE AWANTA.altaRutaAerea(@ciudadOrigen NVARCHAR(255), @ciudadDestino NVARCHAR(255), @rutaPrecioBasePasaje numeric(18,2), @rutaPrecioBaseKilo numeric(18,2), @habilitada bit)
AS
	BEGIN
	 IF (NOT EXISTS(SELECT 1 FROM AWANTA.RUTA_AEREA WHERE rut_origen = AWANTA.getIdCiudad(@ciudadOrigen) AND rut_destino = AWANTA.getIdCiudad(@ciudadDestino)))
	 BEGIN
		DECLARE @id int
		INSERT INTO AWANTA.RUTA_AEREA(rut_origen,rut_destino,rut_precio_base,rut_precio_base_x_kg, rut_habilitada)
		VALUES (AWANTA.getIdCiudad(@ciudadOrigen),AWANTA.getIdCiudad(@ciudadDestino),
					@rutaPrecioBasePasaje,@rutaPrecioBaseKilo, @habilitada)
		SELECT @id = SCOPE_IDENTITY()  -- me va a devolver la pk insertada asi puedo insertar los servicios de la ruta.
		RETURN @id
	END
	RETURN -1
	END
GO

CREATE PROCEDURE AWANTA.tiene_viajes_ruta(@ruta NUMERIC(18)) AS
IF (EXISTS(SELECT 1 FROM AWANTA.RUTA_AEREA 
JOIN AWANTA.VIAJE ON via_ruta_aerea = rut_codigo
WHERE rut_codigo = @ruta AND via_cancelado = 0 )) 
BEGIN
RETURN 1 
END
RETURN -1 
GO



CREATE PROCEDURE AWANTA.baja_ruta(@ruta NUMERIC(18)) 
AS
	UPDATE AWANTA.PASAJE SET pas_cancelado = 1 WHERE  pas_viaje IN (SELECT via_codigo FROM AWANTA.VIAJE WHERE via_ruta_aerea = @ruta) 
	UPDATE AWANTA.ENCOMIENDA SET enc_cancelado = 1 WHERE enc_viaje IN (SELECT via_codigo FROM AWANTA.VIAJE WHERE via_ruta_aerea = @ruta) 
	UPDATE AWANTA.RUTA_AEREA SET rut_habilitada = 0 WHERE rut_codigo = @ruta AND rut_habilitada = 1
	UPDATE AWANTA.VIAJE SET via_cancelado = 1 WHERE via_ruta_aerea = @ruta

	INSERT INTO AWANTA.DEVOLUCION(dev_compra, dev_fecha) SELECT compra_id, (SELECT date_today from AWANTA.CONFIG) FROM
	AWANTA.COMPRA JOIN AWANTA.PASAJE ON pas_compra = compra_id
	JOIN AWANTA.ENCOMIENDA ON enc_compra = compra_id
	WHERE (pas_viaje IN (SELECT via_codigo FROM AWANTA.VIAJE WHERE via_ruta_aerea = @ruta AND via_fecha_llegada IS NULL)
	OR enc_viaje IN (SELECT via_codigo FROM AWANTA.VIAJE WHERE via_ruta_aerea =  @ruta AND via_fecha_llegada IS NULL))
	AND NOT(EXISTS(SELECT 1 FROM AWANTA.DEVOLUCION WHERE dev_compra = compra_id))

	INSERT INTO AWANTA.DEVOLUCIONXENCOMIENDA(devxe_motivo, devxp_devolucion, devxp_encomienda) SELECT 'baja de ruta',
	 dev_codigo, enc_codigo FROM AWANTA.DEVOLUCION JOIN AWANTA.ENCOMIENDA
	  ON
	 dev_compra = enc_compra
	 JOIN AWANTA.VIAJE ON via_codigo = enc_viaje
	  WHERE NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXENCOMIENDA WHERE devxp_encomienda = enc_codigo) AND via_fecha_llegada IS NULL 

	 INSERT INTO AWANTA.DEVOLUCIONXPASAJE(devxp_motivo, devxp_devolucion, devxp_pasaje) SELECT 'baja de ruta',
	 dev_codigo, pas_codigo FROM AWANTA.DEVOLUCION JOIN AWANTA.PASAJE
	  ON
	 dev_compra = pas_compra 
	 JOIN AWANTA.VIAJE ON via_codigo = pas_viaje 
	 WHERE NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXPASAJE WHERE devxp_pasaje = pas_codigo) AND via_fecha_llegada IS NULL
GO


CREATE PROCEDURE AWANTA.baja_ciudad(@ciudad NUMERIC(18)) AS
DECLARE @ruta NUMERIC(18)
DECLARE rutas CURSOR FOR SELECT rut_codigo FROM AWANTA.RUTA_AEREA WHERE rut_destino = @ciudad OR rut_origen = @ciudad AND rut_habilitada = 1
FETCH FROM rutas INTO @ruta 
WHILE @@FETCH_STATUS = 0 
BEGIN
EXEC AWANTA.baja_ruta @ruta
END
GO




CREATE PROCEDURE AWANTA.cancelar_compra(@codigoCompra NUMERIC(18))
AS
DELETE FROM AWANTA.PASAJE WHERE pas_compra = @codigoCompra
DELETE FROM AWANTA.ENCOMIENDA WHERE enc_compra = @codigoCompra
DELETE FROM AWANTA.COMPRA WHERE compra_id = @codigoCompra
GO

CREATE FUNCTION AWANTA.obtenerCodigoRuta(@origen nvarchar(255), @destino nvarchar(255), @servicio nvarchar(255))
RETURNS NUMERIC(18)
AS
BEGIN
	DECLARE @codigo numeric(18)
	SET @codigo = (SELECT TOP 1 rut_codigo
	FROM AWANTA.RUTA_AEREA, AWANTA.CIUDAD
	WHERE (rut_origen = ciu_id AND
	ciu_nombre = @origen) AND
	(rut_destino = ciu_id AND
	ciu_nombre = @destino) AND
	(@servicio IS NULL OR (EXISTS (SELECT 1 FROM AWANTA.SERVICIOXRUTA WHERE servxr_ruta = @codigo AND servxr_servicio = AWANTA.getIdServicio(@servicio)))))
	RETURN @codigo
END
GO

/*------ABM DE AERONAVES------*/

ALTER PROCEDURE AWANTA.get_estado_aeronave(@codigo NUMERIC(18))
AS
BEGIN
DECLARE @bajaM DATETIME, @bajaU DATETIME, @fechaR DATETIME
IF EXISTS (SELECT 1 FROM AWANTA.HISTORICO_BAJAS WHERE baja_avion = @codigo AND (baja_motivo = 0 OR baja_motivo = 1 AND baja_reinicio > (select DATE_TODAY from AWANTA.CONFIG))) BEGIN RETURN -1 END
RETURN 1 
END  
GO
ALTER FUNCTION AWANTA.get_estado(@codigo NUMERIC(18)) RETURNS BIT
AS
BEGIN
DECLARE @bajaM DATETIME, @bajaU DATETIME, @fechaR DATETIME
IF EXISTS (SELECT 1 FROM AWANTA.HISTORICO_BAJAS WHERE baja_avion = @codigo AND (baja_motivo = 0 OR baja_motivo = 1 AND baja_reinicio > (select DATE_TODAY from AWANTA.CONFIG))) BEGIN RETURN 0 END
RETURN 1 
END  
GO
ALTER PROCEDURE AWANTA.get_aeronaves(@estado bit = null, @filtro nvarchar(255) = null)
AS
SELECT aero_matricula, mod_nombre, fab_nombre, serv_nombre, AWANTA.get_estado(aero_numero), aero_kgs_disponibles_encomiendas,
 aero_fecha_de_alta FROM AWANTA.AERONAVE
	JOIN AWANTA.SERVICIO ON serv_id_servicio = aero_id_servicio
	JOIN AWANTA.MODELO ON mod_id = aero_modelo
	JOIN AWANTA.FABRICANTE ON fab_id = mod_fabricante
	AND (@filtro IS NULL OR @filtro = serv_nombre)
	AND (@estado IS NULL OR @estado = AWANTA.get_estado(aero_numero))
	ORDER BY aero_matricula
GO
/*
ALTER PROCEDURE AWANTA.get_aeronaves_filtradas(@numero numeric(1), @filtro nvarchar(255))
AS 
BEGIN
SELECT * FROM AWANTA.AERONAVE ORDER BY aero_matricula
END
GO*/

CREATE PROCEDURE AWANTA.altaDeAeronave(@matricula NVARCHAR(255),@modelo NVARCHAR(255),@fabricante NVARCHAR(255),@servicio NVARCHAR(255),@kilosDisponibles INT)
AS
	BEGIN
	DECLARE @numero NUMERIC(18)
	
		IF NOT EXISTS (SELECT 1 FROM AWANTA.AERONAVE WHERE @matricula = aero_matricula)
			BEGIN
			
				INSERT INTO AWANTA.AERONAVE (aero_matricula,aero_modelo,aero_id_servicio, aero_fecha_de_alta,
				aero_kgs_disponibles_encomiendas)

				VALUES (@matricula,AWANTA.getIdModelo(@fabricante, @modelo),AWANTA.getIdServicio(@servicio), AWANTA.getDate(),@kilosDisponibles)
				SET @numero = SCOPE_IDENTITY()
				RETURN @numero
			END
			RETURN -1 
	END
GO


-- Las condiciones son que la aeronave que va a reemplazarla no tenga viajes asignados entre esas fechas. 
-- lo usamos tambien para saber las aeronaves disponibles entre dos fechas
CREATE FUNCTION AWANTA.tieneViajesAsignados(@aero_numero_de_aeronave NUMERIC(18),@fechaBaja DATETIME,@fechaReinicio DATETIME) 
RETURNS INT
AS
	BEGIN
	-- si la aeronave tiene un viaje asignado en esas fechas
		IF EXISTS(SELECT 1 FROM AWANTA.VIAJE 
		JOIN AERONAVE ON aero_numero = via_avion AND aero_numero = @aero_numero_de_aeronave 
		WHERE ((via_fecha_salida > @fechaBaja AND via_fecha_salida < @fechaReinicio) 
													OR (via_fecha_llegada > @fechaBaja AND via_fecha_llegada < @fechaReinicio)))
			BEGIN
			-- devuelve -1
				RETURN (-1)
			END
	RETURN (0)
	END
GO


CREATE FUNCTION AWANTA.es_aeronave_disponible(@numero NUMERIC(18)) RETURNS BIT 
AS
BEGIN
IF EXISTS(SELECT 1 FROM AWANTA.HISTORICO_BAJAS WHERE baja_avion = @numero AND (baja_motivo = 0 OR  (baja_motivo = 1 AND
baja_reinicio > AWANTA.getDate()))) BEGIN RETURN -1 END
RETURN 1
END
GO


CREATE FUNCTION AWANTA.hay_aeronaves_disponibles(@fechaSalida DATETIME, @fechaEstimadaLlegada DATETIME) RETURNS INT
AS 
BEGIN
IF (EXISTS(SELECT 1 FROM AWANTA.AERONAVE JOIN AWANTA.VIAJE ON via_avion = aero_numero
WHERE (SELECT AWANTA.tieneViajesAsignados(aero_numero, @fechaSalida, @fechaEstimadaLlegada)) = 0
AND AWANTA.es_aeronave_disponible(aero_numero) = 1))
BEGIN 
RETURN 1 
END
RETURN -1
END
GO

CREATE PROCEDURE AWANTA.get_aeronaves_disponibles(@fechaSalida DATETIME, @fechaEstimadaLlegada DATETIME)
AS
BEGIN
IF ((SELECT AWANTA.hay_aeronaves_disponibles(@fechaSalida, @fechaEstimadaLlegada)) = 1) 
BEGIN
(SELECT DISTINCT aero_matricula FROM AWANTA.AERONAVE JOIN AWANTA.VIAJE ON via_avion = aero_numero
WHERE (SELECT AWANTA.tieneViajesAsignados(aero_numero, @fechaSalida, @fechaEstimadaLlegada)) = 0
 AND aero_fecha_de_alta < @fechaSalida AND AWANTA.es_aeronave_disponible(aero_numero) = 1)
RETURN 1
END
RETURN -1
END
GO

 
CREATE PROCEDURE AWANTA.existeAeronaveQueReemplace(@matricula NVARCHAR(255))
AS
	BEGIN
	IF EXISTS(SELECT 1 FROM AWANTA.AERONAVE aero_reemplazo, AWANTA.AERONAVE aero_orig
	WHERE @matricula = aero_orig.aero_matricula AND aero_reemplazo.aero_id_servicio = aero_orig.aero_id_servicio AND aero_orig.aero_modelo = aero_reemplazo.aero_modelo
	AND aero_orig.aero_matricula <> aero_reemplazo.aero_matricula)
	BEGIN
	RETURN 1
	END
	RETURN -1  
END
GO

CREATE PROCEDURE AWANTA.bajaDeViajesAsociadosConAeronave(@avion NUMERIC(18), @fechaBaja DATETIME )
AS
	BEGIN
		DELETE FROM AWANTA.VIAJE WHERE via_fecha_salida > @fechaBaja
										AND via_avion = @avion
	END
GO


---------- reemplaza todos los viajes por mantenimiento o vida util (si reinicio es null) -------
CREATE PROCEDURE AWANTA.reemplazarAeronavePorMantenimiento(@numero NUMERIC(18), @fechaBaja DATETIME, @fechaReinicio DATETIME) AS
DECLARE @modelo NUMERIC(18), @fabricante NUMERIC(18), @servicio NUMERIC(18), @butacas NUMERIC(18,2), @kgs NUMERIC(18,2)
SELECT @modelo =  mod_id, @fabricante = fab_id, @servicio = aero_id_servicio FROM AWANTA.AERONAVE 
JOIN AWANTA.MODELO ON mod_id = aero_modelo 
JOIN AWANTA.FABRICANTE ON mod_fabricante = fab_id 
WHERE aero_numero = @numero
GROUP BY aero_numero, mod_id, fab_id, aero_id_servicio

SET @butacas = (SELECT COUNT(pas_butaca) FROM AWANTA.PASAJE JOIN AWANTA.VIAJE ON pas_viaje = via_codigo 
WHERE via_avion = @numero AND (via_cancelado IS NULL or via_cancelado = 0) AND pas_cancelado = 0)
SET @kgs = isnull((SELECT SUM(enc_kg) FROM AWANTA.ENCOMIENDA JOIN AWANTA.VIAJE ON enc_viaje = via_codigo WHERE via_avion = @numero
AND (via_cancelado IS NULL OR via_cancelado = 0) AND enc_cancelado = 0),0)

DECLARE @aero_reemplazo NUMERIC(18)

--- encuentro el reemplazo por mantenimiento, podria pasar que la aeronave reemplazo tenga viajes asignados en esa fecha, pero que 
--- todos sus viajes sean la misma ruta que el otro, en ese caso mirar solo los kgs y butacas restantes.
--- si no tiene ningun viaje en ese tiempo, entonces miro los kgs y butacas totales de la aeronave -------
IF (YEAR(@fechaReinicio) > 2000) BEGIN
DECLARE @posiblesReemplazos TABLE (numero NUMERIC(18), butacasDisponibles INT, kgsDisponibles NUMERIC(18,2), butacas INT, kgs NUMERIC(18,2))
INSERT INTO @posiblesReemplazos SELECT Aeronaves.aero_numero AS NumeroReemplazo,
(SELECT COUNT(pas_butaca) FROM AWANTA.PASAJE JOIN AWANTA.VIAJE ON pas_viaje = via_codigo 
WHERE via_avion = Aeronaves.aero_numero AND (via_cancelado IS NULL or via_cancelado = 0) AND pas_cancelado = 0) AS ButacasUtilizadasReemplazo,
isnull((SELECT SUM(enc_kg) FROM AWANTA.ENCOMIENDA JOIN AWANTA.VIAJE ON enc_viaje = via_codigo WHERE via_avion = aero_numero
AND (via_cancelado IS NULL OR via_cancelado = 0) AND enc_cancelado = 0),0) AS KgsUtilizadosReemplazo,
(SELECT COUNT(but_id) FROM AWANTA.BUTACA WHERE but_aeronave = Aeronaves.aero_numero) AS ButacasTotalesReemplazo,
Aeronaves.aero_kgs_disponibles_encomiendas AS KgsTotalesReemplazo
 FROM (SELECT aero_numero, aero_kgs_disponibles_encomiendas FROM AWANTA.AERONAVE
JOIN AWANTA.MODELO ON mod_id = aero_modelo
JOIN AWANTA.FABRICANTE ON fab_id = mod_fabricante
WHERE aero_numero NOT IN (SELECT via_avion FROM AWANTA.VIAJE WHERE (via_fecha_salida BETWEEN @fechaBaja AND @fechaReinicio) OR (via_fecha_llegada_estimada BETWEEN @fechaBaja AND @fechaReinicio))
AND aero_numero NOT IN (SELECT baja_avion FROM AWANTA.HISTORICO_BAJAS WHERE baja_motivo = 0 OR (baja_fecha BETWEEN @fechaBaja AND @fechaReinicio) OR
(baja_reinicio BETWEEN @fechaBaja AND @fechaReinicio)) AND aero_id_servicio = @servicio AND mod_id = @modelo AND  fab_id = @fabricante
AND aero_numero <> @numero) AS Aeronaves
GROUP BY Aeronaves.aero_numero, Aeronaves.aero_kgs_disponibles_encomiendas

SELECT TOP 1 @aero_reemplazo = numero FROM @posiblesReemplazos WHERE butacasDisponibles > @butacas AND @kgs > kgsDisponibles 

-------- Reemplazo los pasajes (las butacas) por los mismos y tambien los viajes. Se le asigna una butaca cualquiera que este disponible en esa aeronave
--- independientemente de si antes tenia una butaca ventanilla o pasillo, porque sino seria muy dificil encontrar una aeronave que tenga los mismos numeros
-- de butaca y tipo disponibles -------

IF(@aero_reemplazo IS NOT NULL) BEGIN
INSERT INTO AWANTA.HISTORICO_BAJAS(baja_avion, baja_fecha, baja_motivo, baja_reinicio) VALUES (@numero, @fechaBaja, 1, @fechaReinicio)
UPDATE AWANTA.PASAJE SET pas_butaca = (SELECT TOP 1 but_id FROM AWANTA.BUTACA JOIN AWANTA.VIAJE ON via_avion = @aero_reemplazo WHERE but_id NOT IN 
(SELECT p.pas_butaca FROM AWANTA.PASAJE p WHERE p.pas_cancelado = 0))
WHERE pas_viaje IN (SELECT via_codigo FROM AWANTA.VIAJE WHERE pas_cancelado = 0 AND (via_fecha_salida BETWEEN @fechaBaja AND @fechaReinicio) OR (via_fecha_llegada_estimada BETWEEN @fechaBaja AND @fechaReinicio))
UPDATE AWANTA.VIAJE SET via_avion = @aero_reemplazo WHERE via_avion = @numero AND ((via_fecha_salida BETWEEN @fechaBaja AND @fechaReinicio) OR (via_fecha_llegada_estimada BETWEEN @fechaBaja AND @fechaReinicio))
INSERT INTO AWANTA.HISTORICO_BAJAS(baja_avion, baja_fecha, baja_motivo, baja_reinicio) VALUES (@numero, @fechaBaja, 1, @fechaReinicio)
END
RETURN isnull(@aero_reemplazo, -1)
END
GO
--------- Si no era por mantenimiento, era por vida util y reemplazo todo por siempre, el reemplazo es otro -----------
ALTER PROCEDURE AWANTA.reemplazarAeronavePorVidaUtil(@numero NUMERIC(18), @fechaBaja DATETIME) AS
DECLARE @modelo NUMERIC(18), @fabricante NUMERIC(18), @servicio NUMERIC(18), @butacas NUMERIC(18,2), @kgs NUMERIC(18,2)
SELECT @modelo =  mod_id, @fabricante = fab_id, @servicio = aero_id_servicio FROM AWANTA.AERONAVE 
JOIN AWANTA.MODELO ON mod_id = aero_modelo 
JOIN AWANTA.FABRICANTE ON mod_fabricante = fab_id 
WHERE aero_numero = @numero
GROUP BY aero_numero, mod_id, fab_id, aero_id_servicio

SET @butacas = (SELECT COUNT(pas_butaca) FROM AWANTA.PASAJE JOIN AWANTA.VIAJE ON pas_viaje = via_codigo 
WHERE via_avion = @numero AND (via_cancelado IS NULL or via_cancelado = 0) AND pas_cancelado = 0)
SET @kgs = isnull((SELECT SUM(enc_kg) FROM AWANTA.ENCOMIENDA JOIN AWANTA.VIAJE ON enc_viaje = via_codigo WHERE via_avion = @numero
AND (via_cancelado IS NULL OR via_cancelado = 0) AND enc_cancelado = 0),0)

DECLARE @aero_reemplazo NUMERIC(18)

SELECT TOP 1 @aero_reemplazo = Aeronaves.aero_numero FROM (SELECT aero_numero, aero_kgs_disponibles_encomiendas FROM AWANTA.AERONAVE 
JOIN AWANTA.MODELO ON mod_id = aero_modelo
JOIN AWANTA.FABRICANTE ON fab_id = mod_fabricante
--- se fija que la aeronave no posea viajes en fechas posteriores a la baja
WHERE aero_numero NOT IN (SELECT via_avion FROM AWANTA.VIAJE WHERE via_fecha_salida > @fechaBaja)
AND aero_numero NOT IN (SELECT baja_avion FROM HISTORICO_BAJAS WHERE baja_motivo = 0 OR (baja_fecha > @fechaBaja) OR (baja_reinicio > @fechaBaja)
AND aero_id_servicio = @servicio AND mod_id = @modelo AND  fab_id = @fabricante)
AND aero_numero <> @numero) AS Aeronaves
JOIN AWANTA.VIAJE ON via_avion = Aeronaves.aero_numero
JOIN AWANTA.PASAJE ON via_codigo = pas_viaje
JOIN AWANTA.ENCOMIENDA ON via_codigo = enc_viaje
JOIN AWANTA.BUTACA ON but_aeronave = Aeronaves.aero_numero
WHERE pas_cancelado = 0 AND enc_cancelado = 0
GROUP BY Aeronaves.aero_numero, Aeronaves.aero_kgs_disponibles_encomiendas
--- kgs y butacas son los ocupados por la otra aeronave
HAVING (SUM(enc_kg) + @kgs < Aeronaves.aero_kgs_disponibles_encomiendas AND  COUNT(pas_codigo) + @butacas < COUNT(but_id) )

---------- Las encomiendas no se reemplazan, solo se le reemplaza al viaje la aeronave. En los pasajes si, porque habia butacas--------
IF(@aero_reemplazo IS NOT NULL) BEGIN
UPDATE AWANTA.PASAJE SET pas_butaca = (SELECT TOP 1 but_id FROM AWANTA.BUTACA JOIN AWANTA.VIAJE ON via_avion = @aero_reemplazo WHERE but_id NOT IN 
(SELECT p.pas_butaca FROM AWANTA.PASAJE p WHERE p.pas_cancelado = 0) AND via_fecha_llegada IS NULL)
WHERE pas_viaje IN (SELECT via_codigo FROM AWANTA.VIAJE WHERE pas_cancelado = 0 AND (via_fecha_salida > @fechaBaja  OR via_fecha_llegada_estimada > @fechaBaja) AND via_fecha_llegada IS NULL)
UPDATE AWANTA.VIAJE SET via_avion = @aero_reemplazo WHERE via_avion = @numero AND (via_fecha_salida > @fechaBaja OR via_fecha_llegada_estimada > @fechaBaja) AND via_fecha_llegada IS NULL
INSERT INTO AWANTA.HISTORICO_BAJAS(baja_avion, baja_fecha, baja_motivo) VALUES (@numero, @fechaBaja, 0)
END
RETURN isnull(@aero_reemplazo, -1)
GO 
 

--------------- cancela todos los viajes por mantenimiento o vida util ----------------
CREATE PROCEDURE AWANTA.cancelarViajesAeronavePorMantenimiento(@numero NUMERIC(18), @fechaBaja DATETIME, @fechaReinicio DATETIME) AS 
IF (YEAR(@fechaReinicio) > 2000)
BEGIN
DECLARE @viajes table(viaje numeric(18))
INSERT INTO @viajes SELECT via_codigo FROM AWANTA.VIAJE where via_avion = @numero AND (via_fecha_salida BETWEEN @fechaBaja AND @fechaReinicio) OR (via_fecha_llegada_estimada BETWEEN @fechaBaja AND @fechaReinicio)
AND via_cancelado = 0 AND via_fecha_llegada IS NULL
DECLARE @pasajes table(pasaje numeric(18), compra_p numeric(18)) 
DECLARE @encomiendas table(encomienda numeric(18), compra_e numeric(18))
INSERT INTO @pasajes SELECT pas_codigo, pas_compra FROM @viajes JOIN AWANTA.PASAJE ON pas_viaje = viaje JOIN AWANTA.COMPRA ON pas_compra = compra_id WHERE pas_cancelado = 0
INSERT INTO @encomiendas SELECT enc_codigo, enc_compra FROM @viajes JOIN AWANTA.ENCOMIENDA ON enc_viaje = viaje JOIN AWANTA.COMPRA ON enc_compra = compra_id  WHERE enc_cancelado = 0
UPDATE AWANTA.VIAJE SET via_cancelado = 1 WHERE via_codigo IN (SELECT viaje FROM @viajes)
UPDATE AWANTA.PASAJE SET pas_cancelado = 1 WHERE pas_codigo IN (SELECT pasaje FROM @pasajes)
UPDATE AWANTA.ENCOMIENDA SET enc_cancelado = 1 WHERE enc_codigo IN (SELECT encomienda FROM @encomiendas)

DECLARE @compra NUMERIC(18)
DECLARE compras CURSOR FOR SELECT compra_id FROM AWANTA.COMPRA WHERE compra_id IN (SELECT compra_e FROM @encomiendas) OR compra_id IN (SELECT compra_p FROM @pasajes)
OPEN compras
FETCH FROM compras INTO @compra 
WHILE @@FETCH_STATUS = 0 
BEGIN
IF NOT EXISTS (SELECT 1 FROM DEVOLUCION WHERE dev_compra = @compra)
INSERT INTO DEVOLUCION VALUES(@compra, @fechaBaja)
FETCH FROM compras INTO @compra
END
CLOSE compras
DEALLOCATE compras

INSERT INTO DEVOLUCIONXENCOMIENDA(devxp_devolucion, devxp_encomienda, devxe_motivo) SELECT dev_codigo, dev_compra, 'baja aeronave' FROM @encomiendas
JOIN DEVOLUCION ON dev_compra = compra_e
INSERT INTO DEVOLUCIONXPASAJE(devxp_devolucion, devxp_pasaje, devxp_motivo) SELECT dev_codigo, dev_compra, 'baja aeronave' FROM @pasajes
JOIN DEVOLUCION ON dev_compra = compra_p
END
INSERT INTO AWANTA.HISTORICO_BAJAS(baja_avion, baja_fecha, baja_motivo, baja_reinicio) VALUES (@numero, @fechaBaja, 1, @fechaReinicio)
GO
---------------- si la fecha de reinicio era null, reemplazo todos los futuros --------------

ALTER PROCEDURE AWANTA.cancelarViajesAeronavePorVidaUtil(@numero NUMERIC(18), @fechaBaja DATETIME) AS
DECLARE @viajes_futuros table(viaje numeric(18))
INSERT INTO @viajes_futuros SELECT via_codigo FROM AWANTA.VIAJE where via_avion = @numero AND via_fecha_salida >= @fechaBaja  OR via_fecha_llegada_estimada >= @fechaBaja AND via_fecha_llegada IS NULL
AND via_cancelado = 0
DECLARE @pasajes_futuros table(pasaje numeric(18), compra_p numeric(18)) 
DECLARE @encomiendas_futuros table(encomienda numeric(18), compra_e numeric(18))
INSERT INTO @pasajes_futuros SELECT pas_codigo, pas_compra FROM @viajes_futuros JOIN AWANTA.PASAJE ON pas_viaje = viaje JOIN AWANTA.COMPRA ON pas_compra = compra_id WHERE pas_cancelado = 0
INSERT INTO @encomiendas_futuros SELECT enc_codigo, enc_compra FROM @viajes_futuros JOIN AWANTA.ENCOMIENDA ON enc_viaje = viaje JOIN AWANTA.COMPRA ON enc_compra = compra_id  WHERE enc_cancelado = 0
UPDATE AWANTA.VIAJE SET via_cancelado = 1 WHERE via_codigo IN (SELECT viaje FROM @viajes_futuros)
UPDATE AWANTA.PASAJE SET pas_cancelado = 1 WHERE pas_codigo IN (SELECT pasaje FROM @pasajes_futuros)
UPDATE AWANTA.ENCOMIENDA SET enc_cancelado = 1 WHERE enc_codigo IN (SELECT encomienda FROM @encomiendas_futuros)
DECLARE @compra NUMERIC(18)
DECLARE compras CURSOR FOR SELECT compra_id FROM AWANTA.COMPRA WHERE compra_id IN (SELECT compra_e FROM @encomiendas_futuros) OR compra_id IN (SELECT compra_p FROM @pasajes_futuros)
OPEN compras
FETCH FROM compras INTO @compra 
WHILE @@FETCH_STATUS = 0 
BEGIN
IF NOT EXISTS (SELECT 1 FROM DEVOLUCION WHERE dev_compra = @compra)
INSERT INTO DEVOLUCION VALUES(@compra, @fechaBaja)
FETCH FROM compras INTO @compra
END
CLOSE compras
DEALLOCATE compras

INSERT INTO DEVOLUCIONXENCOMIENDA(devxp_devolucion, devxp_encomienda, devxe_motivo) SELECT dev_codigo, dev_compra, 'baja aeronave' FROM @encomiendas_futuros
JOIN DEVOLUCION ON dev_compra = compra_e
INSERT INTO DEVOLUCIONXPASAJE(devxp_devolucion, devxp_pasaje, devxp_motivo) SELECT dev_codigo, dev_compra, 'baja aeronave' FROM @pasajes_futuros
JOIN DEVOLUCION ON dev_compra = compra_p
INSERT INTO AWANTA.HISTORICO_BAJAS(baja_avion, baja_fecha, baja_motivo) VALUES (@numero, @fechaBaja, 0)
GO



CREATE PROCEDURE AWANTA.obtenerCodigoAeronave(@matricula nvarchar(255))
AS
BEGIN
	DECLARE @codigo numeric(18)
	SET @codigo = (SELECT aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = @matricula)
	RETURN @codigo
END
GO

CREATE PROCEDURE AWANTA.modificarAeronave(@numero numeric(18), @matricula nvarchar(255), @modelo nvarchar(255), @fabricante nvarchar(255), @servicio nvarchar(255), 
@cantidadKgsEncomiendas numeric, @estado bit) 
AS 
BEGIN
IF EXISTS(SELECT 1 FROM AWANTA.AERONAVE WHERE aero_matricula = @matricula AND aero_numero <> @numero) BEGIN RETURN -1 END
DECLARE @numero_servicio NUMERIC(18), @matricula_vieja NVARCHAR(255)
SELECT @matricula_vieja = aero_matricula FROM AWANTA.AERONAVE WHERE aero_numero = @numero
SELECT @numero_servicio = serv_id_servicio FROM SERVICIO WHERE serv_nombre = @servicio
UPDATE AWANTA.AERONAVE 
SET aero_matricula = @matricula, aero_modelo = AWANTA.getIdModelo(@fabricante, @modelo), aero_id_servicio = @numero_servicio,
aero_kgs_disponibles_encomiendas = @cantidadKgsEncomiendas
WHERE aero_numero = @numero
END
GO 

CREATE PROCEDURE AWANTA.get_id_aeronave(@matricula nvarchar(255))
AS
BEGIN
DECLARE @numero NUMERIC(18)
SELECT @numero = aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = @matricula
RETURN @numero
END
GO

CREATE PROCEDURE AWANTA.get_butacas(@codigo NUMERIC(18))
AS
BEGIN
SELECT but_numero, but_tipo FROM AWANTA.BUTACA WHERE but_aeronave = @codigo
ORDER BY but_numero
END
GO

CREATE PROCEDURE AWANTA.set_butacas(@aeronave NUMERIC(18), @butaca INT, @tipo nvarchar(255))
AS
BEGIN
IF NOT EXISTS(SELECT 1 FROM AWANTA.BUTACA WHERE  but_aeronave = @aeronave AND but_numero = @butaca)
BEGIN
INSERT INTO AWANTA.BUTACA(but_numero, but_tipo, but_piso, but_aeronave) VALUES (@butaca, @tipo, 1, @aeronave)
RETURN
END
UPDATE AWANTA.BUTACA SET but_numero = @butaca, but_tipo = @tipo WHERE but_aeronave = @aeronave AND but_numero = @butaca
END
GO
------------ ADMINISTRADOR DE MODELOS --------------------------
CREATE PROCEDURE AWANTA.modificarModelo(@viejoModelo nvarchar(255), @nuevoModelo nvarchar(255), @fabricante nvarchar(255))
AS
BEGIN
IF(EXISTS(SELECT 1 FROM AWANTA.MODELO WHERE mod_nombre = @nuevoModelo AND mod_fabricante = AWANTA.getIdFabricante(@fabricante)))
BEGIN RETURN -1 END
UPDATE AWANTA.MODELO SET mod_nombre = @nuevoModelo WHERE mod_nombre = @viejoModelo AND mod_fabricante = AWANTA.getIdFabricante(@fabricante)
RETURN 1
END
GO

CREATE PROCEDURE AWANTA.agregarModelo(@modelo nvarchar(255), @fabricante nvarchar(255))
AS
BEGIN
IF(NOT EXISTS(SELECT 1 FROM AWANTA.MODELO WHERE mod_nombre = @modelo AND mod_fabricante = AWANTA.getIdFabricante(@fabricante)))
BEGIN
INSERT INTO AWANTA.MODELO(mod_nombre, mod_fabricante) VALUES (@modelo, AWANTA.getIdFabricante(@fabricante))
RETURN 1
END
RETURN -1
END
GO 

CREATE PROCEDURE AWANTA.getModelos(@fabricante nvarchar(255))
AS
BEGIN
SELECT mod_nombre FROM AWANTA.MODELO WHERE mod_fabricante = AWANTA.getIdFabricante(@fabricante)
END
GO

CREATE PROCEDURE AWANTA.getFabricantes
AS
BEGIN 
SELECT fab_nombre FROM AWANTA.FABRICANTE 
END
GO

ALTER PROCEDURE AWANTA.bajaSinViajes(@aeronave NUMERIC(18), @fechaBaja DATETIME, @fechaReinicio DATETIME)
AS
IF (@fechaReinicio <2000) BEGIN
INSERT INTO AWANTA.HISTORICO_BAJAS(baja_avion, baja_fecha, baja_motivo) 
VALUES (@aeronave, @fechaBaja,0)
RETURN END
INSERT INTO AWANTA.HISTORICO_BAJAS(baja_avion, baja_fecha, baja_motivo, baja_reinicio) VALUES
(@aeronave, @fechaBaja, 1, @fechaReinicio)
GO



--------------- VALIDACIONES AERONAVE ------------------------


CREATE FUNCTION AWANTA.es_aprox_esa_fecha(@fechaLlegada DATETIME, @fechaLlegadaEstimada DATETIME)
RETURNS INT
AS 
BEGIN
IF (DATEDIFF(MINUTE, @fechaLlegadaEstimada, @fechaLlegada) BETWEEN -10 AND 10) BEGIN RETURN 1 END RETURN -1 END
GO
-- PARA SABER SI UNA AERONAVE, CIUDAD ORIGEN Y DESTINO Y LLEGADA SE CORRESPONDEN CON ESA FECHA
CREATE PROCEDURE AWANTA.aeronave_coincide_registro(@matricula NVARCHAR(255), @origen NVARCHAR(255), @destino NVARCHAR(255), @llegada DATETIME)
AS 
BEGIN
IF(EXISTS(SELECT 1 FROM AWANTA.AERONAVE 
JOIN AWANTA.VIAJE ON via_avion = aero_numero
JOIN AWANTA.RUTA_AEREA ON via_ruta_aerea = rut_codigo AND rut_origen = AWANTA.getIdCiudad(@origen)
 AND rut_destino = AWANTA.getIdCiudad(@destino) WHERE aero_matricula = @matricula 
 AND (AWANTA.es_aprox_esa_fecha(@llegada, via_fecha_llegada_estimada) = 1)))
 BEGIN 
 RETURN 1 END 
 RETURN -1
END 
GO 

-- A NIVEL DE LA APLICACION, DIRECTAMENTE NO DEJAMOS QUE EL USUARIO INGRESE A LA DATA GRID UN VIAJE QUE YA FUE REGISTRADO COMO LLEGADA
ALTER PROCEDURE AWANTA.aeronave_ya_registrada(@matricula NVARCHAR(255), @origen NVARCHAR(255), @destino NVARCHAR(255), @llegada DATETIME) AS 
BEGIN
IF (EXISTS(SELECT 1 FROM AWANTA.AERONAVE 
JOIN AWANTA.VIAJE ON via_avion = aero_numero
JOIN AWANTA.RUTA_AEREA ON via_ruta_aerea = rut_codigo AND rut_origen = AWANTA.getIdCiudad(@origen) AND rut_destino = AWANTA.getIdCiudad(@destino)
WHERE aero_matricula = @matricula AND (AWANTA.es_aprox_esa_fecha(@llegada, via_fecha_llegada_estimada) = 1) AND via_fecha_llegada IS NOT NULL))
BEGIN RETURN 1 END RETURN -1 END 
GO

CREATE PROCEDURE AWANTA.registrar_llegada_viaje(@matricula NVARCHAR(255), @origen NVARCHAR(255), @destino NVARCHAR(255), @llegada DATETIME)
AS
BEGIN
DECLARE @numero NUMERIC(18)
SELECT @numero = aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = @matricula
UPDATE AWANTA.VIAJE SET via_fecha_llegada = @llegada  WHERE via_codigo = (SELECT TOP 1 V.via_codigo FROM AWANTA.VIAJE V
JOIN AWANTA.RUTA_AEREA ON V.via_ruta_aerea = rut_codigo AND rut_origen = AWANTA.getIdCiudad(@origen) AND rut_destino = AWANTA.getIdCiudad(@destino)
AND via_avion = @numero AND (AWANTA.es_aprox_esa_fecha(@llegada, V.via_fecha_llegada_estimada) = 1) AND via_fecha_llegada IS NULL)
END
GO

/*------ALTA VIAJE------*/

CREATE PROCEDURE AWANTA.hay_rutas(@origen NVARCHAR(255), @destino NVARCHAR(255))
AS
BEGIN
IF NOT EXISTS(SELECT 1 FROM AWANTA.RUTA_AEREA JOIN AWANTA.CIUDAD d ON rut_destino = d.ciu_id AND d.ciu_nombre = @destino
JOIN AWANTA.CIUDAD o ON rut_origen = o.ciu_id AND o.ciu_nombre = @origen
WHERE rut_habilitada = 1) BEGIN RETURN -1 END
RETURN 1 END
GO

CREATE PROCEDURE AWANTA.get_rutas(@origen NVARCHAR(255), @destino NVARCHAR(255),@salida DATETIME, @llegada DATETIME)
AS 
BEGIN
DECLARE @servicios NVARCHAR(255) 
SELECT rut_codigo, @salida as salida, @llegada as llegada, o.ciu_nombre as origen, d.ciu_nombre as destino,  COALESCE(@servicios + ', ', '') + serv_nombre, rut_precio_base, rut_precio_base_x_kg FROM AWANTA.RUTA_AEREA 
JOIN AWANTA.SERVICIOXRUTA ON servxr_ruta = rut_codigo
JOIN AWANTA.SERVICIO ON serv_id_servicio = servxr_servicio
JOIN AWANTA.CIUDAD d ON rut_destino = d.ciu_id AND d.ciu_nombre = @destino
JOIN AWANTA.CIUDAD o ON rut_origen = o.ciu_id AND o.ciu_nombre = @origen
WHERE rut_habilitada = 1
END
GO

ALTER PROCEDURE AWANTA.hay_aeronaves_compatibles(@origen NVARCHAR(255), @destino NVARCHAR(255),@fechaSalida DATETIME, @fechaLlegada DATETIME)
AS
DECLARE @servicios NVARCHAR(255) 
IF EXISTS(
SELECT 1 FROM AWANTA.RUTA_AEREA 
JOIN AWANTA.SERVICIOXRUTA ON servxr_ruta = rut_codigo
JOIN AWANTA.CIUDAD d ON rut_destino = d.ciu_id AND d.ciu_nombre = @destino
JOIN AWANTA.CIUDAD o ON rut_origen = o.ciu_id AND o.ciu_nombre = @origen
WHERE rut_habilitada = 1 AND servxr_servicio IN (SELECT aero_id_servicio FROM AWANTA.AERONAVE WHERE
NOT EXISTS (SELECT 1 FROM AWANTA.VIAJE WHERE via_avion = aero_numero AND
((via_fecha_salida BETWEEN @fechaSalida AND @fechaLlegada) OR (via_fecha_llegada BETWEEN @fechaSalida AND @fechaLlegada))
AND via_cancelado = 0)
AND NOT EXISTS (SELECT 1 FROM AWANTA.HISTORICO_BAJAS WHERE baja_avion = aero_numero AND
(baja_motivo = 0) OR (baja_motivo = 1 AND (baja_fecha BETWEEN @fechaSalida AND @fechaLlegada
AND baja_reinicio >= @fechaLlegada))))) BEGIN RETURN 1 END RETURN -1
GO


ALTER PROCEDURE AWANTA.get_aeronaves_compatibles(@ruta NUMERIC(18), @fechaSalida DATETIME, @fechaLlegada DATETIME) 
AS
BEGIN
SELECT aero_matricula FROM AWANTA.AERONAVE 
WHERE aero_id_servicio IN (SELECT servxr_servicio FROM AWANTA.SERVICIOXRUTA WHERE servxr_ruta = @ruta)
AND NOT EXISTS (SELECT 1 FROM AWANTA.VIAJE WHERE via_avion = aero_numero AND
((via_fecha_salida BETWEEN @fechaSalida AND @fechaLlegada) OR (via_fecha_llegada BETWEEN @fechaSalida AND @fechaLlegada))
AND via_cancelado = 0 AND via_fecha_llegada IS NULL)
AND NOT EXISTS (SELECT 1 FROM AWANTA.HISTORICO_BAJAS WHERE baja_avion = aero_numero AND
(baja_motivo = 0) OR (baja_motivo = 1 AND (baja_fecha BETWEEN @fechaSalida AND @fechaLlegada
AND baja_reinicio >= @fechaLlegada)))
END
GO

ALTER PROCEDURE AWANTA.hay_viajes_disponibles(@fechaSalida datetime, @fechaLlegada datetime, @origen nvarchar(255), @destino nvarchar(255)) 
AS
BEGIN
RETURN (CASE WHEN EXISTS(SELECT 1 FROM AWANTA.VIAJE JOIN AWANTA.RUTA_AEREA ON rut_codigo = via_ruta_aerea
WHERE DATEDIFF(DAY, via_fecha_salida, @fechaSalida) < 1 AND DATEDIFF(DAY, via_fecha_llegada_estimada, @fechaLlegada) < 1 AND
rut_origen = (SELECT ciu_id FROM AWANTA.CIUDAD WHERE ciu_nombre = @origen) AND
	 rut_destino = (SELECT ciu_id FROM AWANTA.CIUDAD WHERE ciu_nombre = @destino) AND via_cancelado = 0 AND
	 via_fecha_llegada IS NULL) THEN 1 ELSE -1 END)
END
GO

ALTER FUNCTION AWANTA.cant_butacas_disponibles(@viaje NUMERIC(18)) RETURNS INT
AS
BEGIN
RETURN ISNULL((SELECT count(1) FROM AWANTA.AERONAVE
JOIN AWANTA.BUTACA ON but_aeronave = aero_numero
JOIN AWANTA.VIAJE ON via_avion = aero_numero AND via_codigo = @viaje
WHERE NOT EXISTS(SELECT 1 FROM AWANTA.PASAJE WHERE pas_viaje = @viaje AND but_id = pas_butaca AND pas_cancelado = 0) /* OR
NOT EXISTS(SELECT 1 FROM AWANTA.PASAJE
JOIN AWANTA.DEVOLUCIONXPASAJE ON pas_codigo = devxp_pasaje
WHERE pas_viaje = @viaje AND pas_butaca = but_id) */),0)
END
GO


ALTER FUNCTION AWANTA.cant_kgs_disponibles(@viaje NUMERIC(18)) RETURNS DECIMAL(18,2)
AS
BEGIN 
DECLARE @cant_kgs DECIMAL(18,2), @utilizados DECIMAL(18,2)
/*SET @cant_kgs = isnull((SELECT SUM(enc_kg) FROM AWANTA.ENCOMIENDA WHERE 
enc_viaje = @viaje AND NOT EXISTS(SELECT 1 FROM  AWANTA.DEVOLUCIONXENCOMIENDA JOIN AWANTA.ENCOMIENDA ON enc_codigo = devxp_encomienda
WHERE enc_viaje = @viaje)),0)
RETURN (SELECT sum(aero_kgs_disponibles_encomiendas - @CANT_KGS) FROM AWANTA.AERONAVE
JOIN AWANTA.VIAJE ON via_avion = aero_numero AND via_codigo = @viaje)*/
SELECT @cant_kgs = aero_kgs_disponibles_encomiendas FROM AWANTA.AERONAVE WHERE 
EXISTS(SELECT 1 FROM AWANTA.VIAJE WHERE via_codigo = @viaje AND via_avion = aero_numero)
SELECT @utilizados = SUM(enc_kg) FROM AWANTA.AERONAVE 
JOIN AWANTA.VIAJE ON via_avion = aero_numero AND via_codigo = @viaje
JOIN AWANTA.ENCOMIENDA ON enc_viaje = via_codigo
WHERE enc_cancelado = 0
RETURN (@cant_kgs - ISNULL(@utilizados,0))
END
GO

ALTER PROCEDURE AWANTA.get_viajes(@fechaSalida datetime, @fechaLlegada datetime, @origen nvarchar(255), @destino nvarchar(255))
AS
BEGIN
	SELECT via_codigo, via_fecha_salida, via_fecha_llegada_estimada,
	 (select ciu_nombre from awanta.ciudad where ciu_id = rut_origen),
	 (select ciu_nombre from awanta.ciudad where ciu_id = rut_destino),
	(SELECT serv_nombre FROM AWANTA.SERVICIO WHERE serv_id_servicio = aero_id_servicio),
	AWANTA.get_precio_pasaje(via_codigo),
	AWANTA.get_precio_encomienda(via_codigo, 1),
	 AWANTA.cant_butacas_disponibles(via_codigo),
	  AWANTA.cant_kgs_disponibles(via_codigo)
	
	FROM AWANTA.VIAJE, AWANTA.RUTA_AEREA, AWANTA.AERONAVE
	WHERE (@fechaSalida is null or (YEAR(via_fecha_salida) = YEAR(@fechaSalida) AND
	MONTH(via_fecha_salida) = MONTH(@fechaSalida) AND
	DAY(via_fecha_salida) = DAY(@fechaSalida) ))
	AND (@fechaLlegada is null or (YEAR(via_fecha_llegada_estimada) = YEAR(@fechaLlegada) AND MONTH(via_fecha_llegada_estimada) = MONTH(@fechaLlegada) AND DAY(via_fecha_llegada_estimada) = DAY(@fechaLlegada)))
	AND via_ruta_aerea = rut_codigo AND aero_numero = via_avion AND 
	(@origen is null or rut_origen = (SELECT ciu_id FROM AWANTA.CIUDAD WHERE ciu_nombre = @origen) ) AND
	(@destino is null or rut_destino =(SELECT ciu_id FROM AWANTA.CIUDAD WHERE ciu_nombre = @destino)) AND
	via_fecha_llegada IS NULL 
	AND (AWANTA.cant_butacas_disponibles(via_codigo) <> 0 OR AWANTA.cant_kgs_disponibles(via_codigo) <> 0) AND via_cancelado = 0
END
GO


-- se fija si existe una ruta que es la ruta que le pasamos, que tenga ese servicio (en la asociativa)
ALTER PROCEDURE AWANTA.create_viaje(@avion nvarchar(255), @llegada_estimada DATETIME, @salida DATETIME, @ruta numeric)
AS
	DECLARE @serv_avion numeric(18), @numero_avion numeric(18)
	SELECT @serv_avion = aero_id_servicio, @numero_avion = aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = @avion
	IF NOT EXISTS(SELECT 1 FROM AWANTA.VIAJE WHERE via_avion = (SELECT aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = @avion)
	AND ((via_fecha_llegada_estimada = @llegada_estimada AND via_fecha_salida = @salida AND via_ruta_aerea = @ruta AND via_cancelado = 0)
	OR (EXISTS(SELECT 1 FROM AWANTA.VIAJE v WHERE v.via_avion = @numero_avion AND (v.via_fecha_salida BETWEEN @salida AND @llegada_estimada OR
	v.via_fecha_llegada_estimada BETWEEN @salida AND @llegada_estimada) AND v.via_cancelado = 0 AND v.via_fecha_llegada_estimada IS NULL))))
	BEGIN
			INSERT INTO AWANTA.VIAJE(via_avion, via_fecha_llegada_estimada, via_fecha_salida, via_ruta_aerea, via_cancelado)
			VALUES(@numero_avion, @llegada_estimada, @salida, @ruta, 0)
	RETURN 1 END
	RETURN -1

GO

-- devuelve las butacas disponibles con numero y tipo para poder seleccionarlas
ALTER PROCEDURE AWANTA.get_butacas_disponibles(@viaje NUMERIC(18))
AS
BEGIN
SELECT but_numero, but_tipo FROM AWANTA.AERONAVE
JOIN AWANTA.BUTACA ON but_aeronave = aero_numero
JOIN AWANTA.VIAJE ON via_avion = aero_numero AND via_codigo = @viaje
WHERE NOT EXISTS(SELECT 1 FROM AWANTA.PASAJE WHERE pas_viaje = @viaje AND pas_butaca = but_id AND pas_cancelado = 0) /*OR
but_id IN (SELECT pas_butaca FROM AWANTA.PASAJE
JOIN AWANTA.DEVOLUCIONXPASAJE ON pas_codigo = devxp_pasaje
WHERE pas_viaje = @viaje)  */
ORDER BY but_numero
END
GO

ALTER PROCEDURE AWANTA.tiene_viajes_asignados_siempre(@numero NUMERIC(18))
AS
IF EXISTS (SELECT 1 FROM AWANTA.VIAJE WHERE via_avion = @numero AND via_cancelado = 0 AND via_fecha_llegada IS NULL) BEGIN RETURN 1 END RETURN -1 
GO

CREATE PROCEDURE AWANTA.tiene_viajes_asignados(@numero NUMERIC(18), @fechaBaja DATETIME, @fechaReinicio DATETIME)
AS
IF (YEAR(@fechaReinicio) > 2000) BEGIN
IF EXISTS (SELECT 1 FROM AWANTA.VIAJE WHERE via_avion = @numero AND via_fecha_salida BETWEEN @fechaBaja AND @fechaReinicio 
OR via_fecha_llegada_estimada BETWEEN @fechaBaja AND @fechaReinicio AND via_fecha_llegada IS NULL) RETURN 1 END
IF EXISTS(SELECT 1 FROM AWANTA.VIAJE WHERE via_avion = @numero AND via_fecha_salida > @fechaBaja OR via_fecha_llegada_estimada > @fechaBaja) BEGIN RETURN 1 END
RETURN -1
GO


/*------LLEGADA A DESTINO------*/

CREATE PROCEDURE AWANTA.llegada_a_destino(@avion nvarchar(255), @ciudad_origen nvarchar(255), @servicio nvarchar(255), 
												@ciudad_destino nvarchar(255), @llegada date)
AS
BEGIN
	UPDATE AWANTA.VIAJE 
	SET via_fecha_llegada = @llegada
	WHERE via_avion = (SELECT TOP 1 aero_numero FROM AWANTA.AERONAVE WHERE @avion = aero_matricula) AND
	via_ruta_aerea = AWANTA.obtenerCodigoRuta(@ciudad_origen, @ciudad_destino, @servicio)
END
GO

/*------VENTA PASAJE------*/

CREATE PROCEDURE AWANTA.get_ciudades
AS
BEGIN
SELECT c.ciu_nombre FROM AWANTA.CIUDAD c
ORDER BY c.ciu_nombre
END
GO

ALTER FUNCTION AWANTA.get_precio_pasaje(@viaje NUMERIC(18)) RETURNS DECIMAL(12,2)
AS
BEGIN
RETURN (SELECT rut_precio_base +  (rut_precio_base * (SELECT serv_porcentaje_adicional FROM AWANTA.SERVICIO WHERE serv_id_servicio = aero_id_servicio)/100) FROM AWANTA.RUTA_AEREA 
JOIN AWANTA.VIAJE ON via_ruta_aerea = rut_codigo 
JOIN AWANTA.AERONAVE ON aero_numero = via_avion
WHERE via_codigo = @viaje)
END
GO

ALTER FUNCTION AWANTA.get_precio_encomienda(@viaje NUMERIC(18), @kg DECIMAL(12,2)) RETURNS DECIMAL(12,2)
AS
BEGIN
RETURN (SELECT @kg * (rut_precio_base_x_kg + rut_precio_base_x_kg * (SELECT serv_porcentaje_adicional FROM AWANTA.SERVICIO WHERE serv_id_servicio = aero_id_servicio)/100) FROM AWANTA.RUTA_AEREA 
JOIN AWANTA.VIAJE ON via_ruta_aerea = rut_codigo 
JOIN AWANTA.AERONAVE ON aero_numero = via_avion
WHERE via_codigo = @viaje)
END
GO
--------------------- DEVOLUCION --------------------------
-- solo traigo las compras que tienen algun pasaje o encomienda sin devolver y que la fecha del viaje no haya llegado ya. 
-- (para que devolver una compra que ya paso?)
ALTER PROCEDURE AWANTA.get_compras(@tipoDoc CHAR(5), @doc NUMERIC(18))
AS
DECLARE @codigoCliente NUMERIC(18)
SELECT @codigoCliente = cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = @doc AND cli_tipo_doc = @tipoDoc
SELECT compra_id FROM AWANTA.COMPRA WHERE compra_cliente = @codigoCliente
AND ((EXISTS(SELECT 1 FROM AWANTA.VIAJE JOIN AWANTA.PASAJE ON pas_viaje = via_codigo
  WHERE pas_compra = compra_id AND via_fecha_llegada IS NULL
  AND --NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXPASAJE WHERE devxp_pasaje = pas_codigo)
 pas_cancelado = 0)) 
  OR
   (EXISTS(SELECT 1 FROM AWANTA.VIAJE JOIN AWANTA.ENCOMIENDA ON enc_viaje = via_codigo
  WHERE enc_compra = compra_id AND via_fecha_llegada IS NULL
  AND --NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXENCOMIENDA WHERE devxp_encomienda = enc_codigo)
  enc_cancelado = 0)))
GO
--- crea un cliente si no exsite  y sino lo actualiza
CREATE PROCEDURE AWANTA.update_cliente(@tipo CHAR(5), @dni NUMERIC(18), @nombre NVARCHAR(255), @apellido NVARCHAR(255), @direccion NVARCHAR(255), @telefono NVARCHAR(255), @mail NVARCHAR(255), @nac DATETIME, @codigo NUMERIC(18) output) AS
BEGIN
DECLARE @cli NUMERIC(18)
SET @cli = AWANTA.existe_cliente_(@tipo, @dni)
IF (@cli = -1) BEGIN INSERT INTO AWANTA.CLIENTE VALUES(@tipo, @dni, @nombre, @apellido, @direccion, @telefono, @nac, @mail) 
SET @codigo = SCOPE_IDENTITY() RETURN END
UPDATE AWANTA.CLIENTE SET  cli_nombre = @nombre, cli_apellido = @apellido, cli_direccion = @direccion, cli_telefono = @telefono, cli_mail = @mail, cli_fecha_nac = @nac
WHERE cli_codigo = @cli
SET @codigo = @cli
RETURN
END
GO 

CREATE PROCEDURE AWANTA.update_cliente_noreturn(@tipo CHAR(5), @dni NUMERIC(18), @nombre NVARCHAR(255), @apellido NVARCHAR(255), @direccion NVARCHAR(255), @telefono NVARCHAR(255), @mail NVARCHAR(255), @nac DATETIME) AS
BEGIN
DECLARE @cli NUMERIC(18)
SET @cli = AWANTA.existe_cliente_(@tipo, @dni)
IF (@cli = -1) BEGIN INSERT INTO AWANTA.CLIENTE VALUES(@tipo, @dni, @nombre, @apellido, @direccion, @telefono, @nac, @mail) 
RETURN SCOPE_IDENTITY() END
UPDATE AWANTA.CLIENTE SET  cli_nombre = @nombre, cli_apellido = @apellido, cli_direccion = @direccion, cli_telefono = @telefono, cli_mail = @mail, cli_fecha_nac = @nac
WHERE cli_codigo = @cli
RETURN @cli 
END
GO 

CREATE PROCEDURE AWANTA.get_cliente(@tipo_dni CHAR(5), @dni NUMERIC(18))
AS
BEGIN
SELECT cli_nombre, cli_apellido, cli_direccion, cli_telefono, cli_mail, cli_fecha_nac FROM AWANTA.CLIENTE WHERE @tipo_dni = cli_tipo_doc AND @dni = cli_nro_doc
END
GO

CREATE PROCEDURE AWANTA.crear_compra 
AS
BEGIN
INSERT INTO AWANTA.COMPRA(compra_fecha) VALUES(AWANTA.getDate())
RETURN SCOPE_IDENTITY()
END
GO

ALTER PROCEDURE AWANTA.preparar_compra(@codigoCompra NUMERIC(18), @tipo CHAR(5), @dni NUMERIC(18), @nombre NVARCHAR(255), @apellido NVARCHAR(255), @direccion NVARCHAR(255), @telefono NVARCHAR(255), @mail NVARCHAR(255), @nac DATETIME, @butaca NUMERIC(3), @tipo_butaca NVARCHAR(255), @encomienda NUMERIC(18,2), @viaje NUMERIC(18))
AS
BEGIN
DECLARE @pasajero NUMERIC(18)
EXEC AWANTA.update_cliente @tipo, @dni, @nombre, @apellido, @direccion, @telefono, @mail, @nac, @pasajero output
IF(@butaca IS NOT NULL AND @tipo_butaca IS NOT NULL) BEGIN 
INSERT INTO AWANTA.PASAJE(pas_compra, pas_pasajero, pas_butaca, pas_precio, pas_viaje, pas_cancelado) VALUES (@codigoCompra, @pasajero, (SELECT but_id FROM AWANTA.BUTACA
JOIN AWANTA.AERONAVE ON aero_numero = but_aeronave
JOIN AWANTA.VIAJE ON via_avion = aero_numero
WHERE but_tipo = @tipo_butaca AND but_numero = @butaca AND via_codigo = @viaje), AWANTA.get_precio_pasaje(@viaje), @viaje, 0)
RETURN @codigoCompra
END
IF (@encomienda IS NOT NULL OR @encomienda <> 0) BEGIN
INSERT INTO AWANTA.ENCOMIENDA(enc_compra, enc_encomendador, enc_kg, enc_precio, enc_viaje, enc_cancelado) VALUES (@codigoCompra, @pasajero, @encomienda, AWANTA.get_precio_encomienda(@viaje, @encomienda), @viaje, 0)
END
RETURN @codigoCompra
END
GO

GO
CREATE PROCEDURE AWANTA.getTipoPago(@tarjeta NVARCHAR(255)) AS BEGIN
SELECT tdp_codigo FROM AWANTA.TIPODEPAGO WHERE tdp_descripcion = @tarjeta
END
GO

CREATE PROCEDURE AWANTA.cuotas_maximas_tarjeta(@tarjeta NVARCHAR(255)) AS 
BEGIN
return (SELECT tdp_cuotas_maximas FROM AWANTA.TIPODEPAGO WHERE tdp_descripcion = @tarjeta)
END
GO
CREATE PROCEDURE AWANTA.efectuar_compra(@codigoCompra NUMERIC(18), @codigoCliente NUMERIC(18), @tipoPago NUMERIC(18), @cuotas INT) AS
BEGIN
UPDATE AWANTA.COMPRA SET compra_cliente = @codigoCliente, compra_cuotas = @cuotas, compra_tipo_de_pago = @tipoPago  
WHERE compra_id = @codigoCompra
END
GO

CREATE PROCEDURE AWANTA.cliente_tiene_tarjeta(@codigoCliente NUMERIC(18), @tipoTarjeta NVARCHAR(255),
@numeroTarjeta NUMERIC(18), @digito_verif NUMERIC(18), @vencimiento DATETIME)AS 
BEGIN
RETURN isnull((SELECT tarjeta_id FROM AWANTA.TARJETA
JOIN AWANTA.TIPODEPAGO ON tarjeta_tipo = tdp_codigo
WHERE tarjeta_cliente = @codigoCliente AND tarjeta_codigo_seguridad = @digito_verif AND tarjeta_nro = @numeroTarjeta
AND tarjeta_fecha_vencimiento = @vencimiento AND tdp_descripcion = @tipoTarjeta), -1)
END
GO

CREATE PROCEDURE AWANTA.cliente_nueva_tarjeta(@codigoCliente NUMERIC(18), @tipoTarjeta NVARCHAR(255),
@numeroTarjeta NUMERIC(18), @digito_verif NUMERIC(18), @vencimiento DATETIME) AS
BEGIN
DECLARE @tarjeta NUMERIC(18), @tipo NUMERIC(18)
SELECT @tipo = tdp_codigo FROM AWANTA.TIPODEPAGO WHERE tdp_descripcion = @tipoTarjeta
SELECT @tarjeta = tarjeta_id FROM AWANTA.TARJETA
WHERE tarjeta_cliente = @codigoCliente AND tarjeta_codigo_seguridad = @digito_verif AND tarjeta_nro = @numeroTarjeta
AND tarjeta_fecha_vencimiento = @vencimiento AND @tipo is not null AND @tipo = tarjeta_tipo
IF (@tarjeta IS NOT NULL) BEGIN
UPDATE AWANTA.TARJETA SET tarjeta_nro = @numeroTarjeta, tarjeta_codigo_seguridad = @digito_verif, tarjeta_fecha_vencimiento = @vencimiento,
tarjeta_tipo = @tipo WHERE tarjeta_id = @tarjeta AND tarjeta_cliente = @codigoCliente 
RETURN @tarjeta
END
INSERT INTO AWANTA.TARJETA VALUES(@tipo, @codigoCliente, @numeroTarjeta, @digito_verif, @vencimiento)
RETURN SCOPE_IDENTITY()
END
GO

--- saber si el cliente ya presenta un pasaje en esa fecha
ALTER PROCEDURE AWANTA.ya_tiene_pasaje(@fechaSalida DATETIME, @fechaLlegada DATETIME, @tipo CHAR(5), @doc NUMERIC(18))
AS
IF EXISTS(SELECT 1 FROM AWANTA.PASAJE 
JOIN AWANTA.VIAJE ON via_codigo = pas_viaje
WHERE EXISTS(SELECT 1 FROM AWANTA.CLIENTE WHERE pas_pasajero = cli_codigo AND 
cli_tipo_doc = @tipo AND cli_nro_doc = @doc) AND pas_cancelado = 0  AND
 (via_fecha_llegada_estimada BETWEEN @fechaSalida AND @fechaLlegada OR via_fecha_salida BETWEEN @fechaSalida AND @fechaLlegada))
 BEGIN RETURN 1 END RETURN -1
 GO

---------------- DEVOLUCION ------------------

CREATE PROCEDURE AWANTA.get_encomiendas(@codigo NUMERIC(18)) AS 
BEGIN
SELECT enc_codigo FROM AWANTA.ENCOMIENDA WHERE enc_compra = @codigo AND
NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXENCOMIENDA WHERE devxp_encomienda = @codigo)
END
GO

CREATE PROCEDURE AWANTA.get_pasajes(@codigo NUMERIC(18)) AS 
BEGIN
SELECT pas_codigo FROM AWANTA.PASAJE WHERE pas_compra = @codigo AND
NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXPASAJE WHERE devxp_pasaje = @codigo)
END
GO

CREATE PROCEDURE AWANTA.crear_devolucion(@compra NUMERIC(18))
AS
BEGIN
IF NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCION WHERE dev_compra = @compra)
BEGIN
INSERT INTO AWANTA.DEVOLUCION(dev_compra, dev_fecha) VALUES (@compra, AWANTA.getDate())
RETURN SCOPE_IDENTITY()
END
DECLARE @cod NUMERIC(18)
SELECT @cod = dev_codigo FROM AWANTA.DEVOLUCION WHERE dev_compra = @compra
RETURN @cod 
END
GO


CREATE PROCEDURE AWANTA.devolver_items(@devolucion NUMERIC(18), @item NUMERIC(18), @motivo NVARCHAR)
AS
BEGIN
IF EXISTS(SELECT 1 FROM AWANTA.PASAJE WHERE pas_codigo = @item) BEGIN
INSERT INTO AWANTA.DEVOLUCIONXPASAJE(devxp_pasaje, devxp_devolucion, devxp_motivo) VALUES (@item, @devolucion, @motivo)
UPDATE AWANTA.PASAJE SET pas_cancelado = 1 WHERE pas_codigo = @item
RETURN
END
-- no necesito liberar nada, cuando haga el calculo no tengo en cuenta a los kg de los pasajes que figuren aca 
IF EXISTS(SELECT 1 FROM AWANTA.ENCOMIENDA WHERE enc_codigo = @item) BEGIN
INSERT INTO AWANTA.DEVOLUCIONXENCOMIENDA(devxp_encomienda, devxp_devolucion, devxe_motivo) VALUES (@item, @devolucion, @motivo)
UPDATE AWANTA.ENCOMIENDA SET enc_cancelado = 1 WHERE enc_codigo = @item
RETURN
END
END
GO






/*------MILLAS VIAJERO------*/

CREATE FUNCTION AWANTA.get_millas_pasajes(@tipo_dni char(5), @dni numeric(18)) returns int
AS
BEGIN
RETURN isnull((SELECT SUM(pas_precio) FROM AWANTA.CLIENTE
	JOIN AWANTA.PASAJE ON pas_pasajero = cli_codigo 
	JOIN AWANTA.COMPRA ON pas_compra = compra_id 
	WHERE cli_tipo_doc = @tipo_dni AND cli_nro_doc = @dni AND DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1 AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXPASAJE 
	WHERE devxp_pasaje = pas_codigo)
	GROUP BY cli_codigo	),0)
END 
GO

CREATE FUNCTION AWANTA.get_millas_encomiendas(@tipo_dni char(5), @dni numeric(18)) returns int
AS
BEGIN
RETURN isnull((SELECT SUM(enc_precio) FROM AWANTA.CLIENTE
	JOIN AWANTA.ENCOMIENDA ON enc_encomendador = cli_codigo 
	JOIN AWANTA.COMPRA ON enc_compra = compra_id 
	WHERE cli_tipo_doc = @tipo_dni AND cli_nro_doc = @dni 
	AND DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1 
	AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXENCOMIENDA
	WHERE enc_codigo = devxp_encomienda)
	GROUP BY cli_codigo	),0)

END
GO
CREATE FUNCTION AWANTA.get_millas_canjes(@tipo_dni char(5), @dni numeric(18)) returns int AS 
BEGIN
RETURN isnull((SELECT SUM(prod_millas * can_cantidad) FROM AWANTA.CLIENTE
JOIN AWANTA.CANJE ON can_canjeador = cli_codigo 
JOIN AWANTA.PRODUCTO ON prod_id = can_producto
WHERE  cli_tipo_doc = @tipo_dni AND cli_nro_doc = @dni AND DATEDIFF(YEAR, can_fecha, AWANTA.getDate()) < 1  
GROUP BY cli_codigo),0)
END
GO
ALTER FUNCTION AWANTA.get_millas(@tipo_dni char(5), @dni numeric(18)) RETURNS INT 
AS
BEGIN
RETURN (SELECT isnull((SELECT SUM(enc_precio)/10 FROM AWANTA.CLIENTE
	JOIN AWANTA.ENCOMIENDA ON enc_encomendador = cli_codigo 
	JOIN AWANTA.COMPRA ON enc_compra = compra_id 
	WHERE cli_tipo_doc = @tipo_dni AND cli_nro_doc = @dni AND DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1 
	--AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXENCOMIENDA WHERE enc_codigo = devxp_encomienda)
	AND enc_cancelado = 0
	GROUP BY cli_codigo	),0) - isnull((SELECT SUM(prod_millas * can_cantidad) FROM AWANTA.CLIENTE
JOIN AWANTA.CANJE ON can_canjeador = cli_codigo 
JOIN AWANTA.PRODUCTO ON prod_id = can_producto
WHERE  cli_tipo_doc = @tipo_dni AND cli_nro_doc = @dni AND DATEDIFF(YEAR, can_fecha, AWANTA.getDate()) < 1  
GROUP BY cli_codigo),0) + isnull((SELECT SUM(pas_precio)/10 FROM AWANTA.CLIENTE
	JOIN AWANTA.PASAJE ON pas_pasajero = cli_codigo 
	JOIN AWANTA.COMPRA ON pas_compra = compra_id 
	WHERE cli_tipo_doc = @tipo_dni AND cli_nro_doc = @dni AND DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1
	-- AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXPASAJE WHERE devxp_pasaje = pas_codigo)
	AND pas_cancelado = 0 
	GROUP BY cli_codigo),0))
END
GO

CREATE PROCEDURE AWANTA.get_millas_cliente(@tipo_dni char(5), @dni numeric(18)) AS
BEGIN
RETURN (SELECT AWANTA.get_millas(@tipo_dni, @dni))
END
GO

CREATE PROCEDURE AWANTA.info_canjes(@tipo_dni char(5), @dni numeric(18))
AS
BEGIN
SELECT can_fecha, prod_nombre, can_cantidad, prod_millas FROM AWANTA.CANJE JOIN 
AWANTA.PRODUCTO ON can_producto = prod_id 
WHERE DATEDIFF(YEAR, can_fecha, (SELECT date_today FROM AWANTA.CONFIG)) < 1 AND can_canjeador = AWANTA.getIdCliente(@tipo_dni, @dni)
END
GO
CREATE PROCEDURE AWANTA.info_pasajes(@tipo_dni char(5), @dni numeric(18))
AS
BEGIN
SELECT compra_fecha, AWANTA.obtenerNombreCiudad(rut_origen),AWANTA.obtenerNombreCiudad(rut_destino), (pas_precio/10) FROM AWANTA.PASAJE JOIN
AWANTA.COMPRA ON compra_id = pas_compra 
JOIN VIAJE ON via_codigo = pas_viaje 
JOIN RUTA_AEREA ON rut_codigo = via_ruta_aerea
WHERE DATEDIFF(YEAR, ISNULL(via_fecha_llegada, '1901-01-01 00:00:00' ), (SELECT date_today FROM AWANTA.CONFIG)) < 1 AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXPASAJE WHERE devxp_pasaje = pas_codigo) 
AND pas_pasajero = (SELECT cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = @tipo_dni)
END
GO

CREATE PROCEDURE AWANTA.info_encomiendas(@tipo_dni char(5), @dni numeric(18))
AS
BEGIN
 SELECT compra_fecha, AWANTA.obtenerNombreCiudad(rut_origen), AWANTA.obtenerNombreCiudad(rut_destino), (enc_precio/10) FROM AWANTA.ENCOMIENDA JOIN
AWANTA.COMPRA ON compra_id = enc_compra 
JOIN VIAJE ON via_codigo = enc_viaje 
JOIN RUTA_AEREA ON rut_codigo = via_ruta_aerea
WHERE DATEDIFF(YEAR, ISNULL(via_fecha_llegada, '1901-01-01 00:00:00' ), (SELECT date_today FROM AWANTA.CONFIG)) < 1 AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXENCOMIENDA WHERE devxp_encomienda = enc_codigo)
 AND enc_encomendador = (SELECT cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = @tipo_dni)
END
GO

---------------- PRODUCTOS
GO
CREATE FUNCTION AWANTA.get_id_producto(@nombre nvarchar(255)) RETURNS NUMERIC(18)
AS
BEGIN
RETURN (SELECT prod_id FROM AWANTA.PRODUCTO WHERE prod_nombre = @nombre)
END
GO

CREATE PROCEDURE AWANTA.get_productos_disponibles
AS
BEGIN
SELECT prod_nombre, prod_millas, prod_stock FROM AWANTA.PRODUCTO WHERE prod_stock > 0
END
GO


CREATE PROCEDURE AWANTA.canjear_productos(@tipo_dni CHAR(5), @dni NUMERIC(18), @producto nvarchar(255), @cantidad int)
AS
BEGIN
INSERT INTO AWANTA.CANJE(can_fecha, can_canjeador, can_producto, can_cantidad) VALUES (AWANTA.getDate(), AWANTA.getIdCliente(@tipo_dni, @dni), AWANTA.get_id_producto(@producto), @cantidad)
END
GO


------------- CLIENTES


CREATE PROCEDURE AWANTA.existe_cliente(@tipo_dni CHAR(5), @dni NUMERIC(18))
AS
BEGIN
IF EXISTS(SELECT 1 FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = @tipo_dni)
BEGIN RETURN 1 END 
RETURN -1 END
GO


CREATE FUNCTION AWANTA.existe_cliente_(@tipo_dni CHAR(5), @dni NUMERIC(18)) RETURNS INT
AS
BEGIN
IF EXISTS(SELECT 1 FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = @tipo_dni)
BEGIN RETURN (SELECT cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = @tipo_dni)  END 
RETURN -1 END
GO
--------------------- LISTADOS ESTADISTICOS -------------

CREATE PROCEDURE AWANTA.destinos_pasajes_comprados(@inicio datetime, @fin datetime)
AS
BEGIN
SELECT TOP 5 ciu_id AS Codigo, ciu_nombre AS Nombre, COUNT(*) AS Compras FROM AWANTA.PASAJE 
JOIN AWANTA.VIAJE ON pas_viaje = via_codigo
JOIN AWANTA.RUTA_AEREA ON via_ruta_aerea = rut_codigo
JOIN AWANTA.COMPRA ON pas_compra = compra_id
JOIN AWANTA.CIUDAD ON rut_destino = ciu_id
WHERE @inicio < compra_fecha AND compra_fecha < @fin  
GROUP BY ciu_id, ciu_nombre
ORDER BY COUNT(*) DESC
END
GO


CREATE PROCEDURE AWANTA.destinos_aeronaves_mas_vacias(@inicio datetime, @fin datetime)
AS
BEGIN
SELECT TOP 5 ciu_nombre AS Destino, COUNT(but_id) AS Vacios FROM AWANTA.VIAJE
JOIN AWANTA.RUTA_AEREA ON via_ruta_aerea = rut_codigo
JOIN AWANTA.CIUDAD ON rut_destino = ciu_id
JOIN AWANTA.AERONAVE ON via_avion = aero_numero
JOIN AWANTA.BUTACA ON aero_numero = but_aeronave
WHERE (but_id NOT IN (SELECT pas_butaca FROM AWANTA.PASAJE where pas_viaje = via_codigo) OR
but_id IN (SELECT pas_butaca FROM AWANTA.PASAJE 
JOIN AWANTA.DEVOLUCIONXPASAJE ON pas_codigo = devxp_pasaje AND pas_viaje = via_codigo))
AND  @inicio < via_fecha_salida AND via_fecha_salida < @fin
GROUP BY ciu_id, ciu_nombre 
ORDER BY COUNT(but_id) DESC
END
GO

CREATE PROCEDURE AWANTA.destinos_con_mas_pasajes_cancelados(@inicio datetime, @fin datetime) AS
BEGIN
SELECT TOP 5 ciu_id AS Codigo, ciu_nombre AS Destino, COUNT(pas_codigo) AS Cancelaciones FROM AWANTA.PASAJE 
JOIN AWANTA.VIAJE ON pas_viaje = via_codigo
JOIN AWANTA.RUTA_AEREA ON via_ruta_aerea = rut_codigo
JOIN AWANTA.CIUDAD ON rut_destino = ciu_id
JOIN AWANTA.DEVOLUCIONXPASAJE ON  devxp_pasaje = pas_codigo
JOIN AWANTA.DEVOLUCION ON devxp_devolucion = dev_codigo
WHERE @inicio < dev_fecha AND dev_fecha < @fin  
GROUP BY ciu_id, ciu_nombre
ORDER BY COUNT(pas_codigo) DESC
END
GO

CREATE PROCEDURE AWANTA.aeronaves_mas_fuera_de_servicio(@inicio datetime, @fin datetime) AS
BEGIN
SELECT TOP 5 aero_numero AS 'Codigo de aeronave', aero_matricula AS Matricula, COUNT(baja_avion) AS Veces FROM AWANTA.AERONAVE
JOIN HISTORICO_BAJAS ON aero_numero = baja_avion
WHERE baja_motivo = 1 AND  @inicio < baja_fecha AND baja_fecha < @fin
GROUP BY aero_numero, aero_matricula
ORDER BY COUNT(aero_matricula)
END 
GO

CREATE PROCEDURE AWANTA.clientes_con_mas_millas_acumuladas(@inicio datetime, @fin datetime)
AS
BEGIN
DECLARE @date DATETIME
SET @date = AWANTA.getDate()
SELECT TOP 5 M.cli_codigo AS Codigo, M.cli_nro_doc AS Documento, M.cli_nombre AS Nombre, M.cli_apellido AS Apellido, SUM(M.Millas) AS Millas FROM
 ((SELECT cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, SUM(pas_precio/10) as Millas FROM AWANTA.CLIENTE
	JOIN AWANTA.PASAJE ON pas_codigo = cli_codigo
	JOIN AWANTA.VIAJE ON via_codigo = pas_viaje
	WHERE @inicio < isnull(via_fecha_llegada,'1901-01-01 00:00:00') AND isnull(via_fecha_llegada,'1901-01-01 00:00:00') < @fin
	AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXPASAJE WHERE devxp_pasaje = pas_codigo)
	GROUP BY cli_codigo, cli_nro_doc, cli_nombre, cli_apellido) 
	UNION ALL 
(SELECT cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, SUM(enc_precio/10) as Millas FROM AWANTA.CLIENTE
	JOIN AWANTA.ENCOMIENDA ON enc_encomendador = cli_codigo 
	JOIN AWANTA.VIAJE ON enc_viaje = via_codigo
	WHERE @inicio < isnull(via_fecha_llegada,'1901-01-01 00:00:00') AND isnull(via_fecha_llegada,'1901-01-01 00:00:00') < @fin 
	AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXENCOMIENDA WHERE enc_codigo = devxp_encomienda)
	GROUP BY cli_codigo, cli_nro_doc, cli_nombre, cli_apellido)
	 UNION ALL
(SELECT cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, SUM(-prod_millas * can_cantidad) AS Millas FROM AWANTA.CLIENTE
	JOIN AWANTA.CANJE ON can_canjeador = cli_codigo 
	JOIN AWANTA.PRODUCTO ON prod_id = can_producto
	WHERE @inicio < can_fecha AND can_fecha < @fin
	GROUP BY cli_codigo, cli_nro_doc, cli_nombre, cli_apellido)) AS M
	GROUP BY M.cli_codigo, M.cli_nro_doc, M.cli_nombre, M.cli_apellido
	ORDER BY SUM(M.Millas) DESC
END
GO


CREATE PROCEDURE AWANTA.detalle_compra(@codigo NUMERIC(18))
AS
SELECT compra_id AS Codigo, cli_tipo_doc AS Documento, cli_nro_doc AS Numero, SUM(coalesce(pas_precio,0) + coalesce(enc_precio,0)) AS Monto FROM AWANTA.COMPRA 
JOIN AWANTA.CLIENTE ON compra_cliente = cli_codigo
LEFT JOIN AWANTA.PASAJE ON compra_id = pas_compra
LEFT JOIN AWANTA.ENCOMIENDA ON compra_id = enc_compra
WHERE compra_id = @codigo
GROUP BY compra_id, cli_tipo_doc, cli_nro_doc
GO

CREATE PROCEDURE AWANTA.detalle_pasajes(@codigo NUMERIC(18))
AS
SELECT pas_codigo AS Codigo,  cli_tipo_doc AS Documento, cli_nro_doc AS Numero, pas_precio AS Precio, but_numero AS Butaca, but_tipo AS Tipo FROM AWANTA.PASAJE
JOIN AWANTA.CLIENTE ON pas_pasajero = cli_codigo
JOIN AWANTA.BUTACA ON pas_butaca = but_id
WHERE pas_compra = @codigo
GO

CREATE PROCEDURE AWANTA.detalle_encomiendas(@codigo NUMERIC(18))
AS
SELECT enc_codigo AS Codigo,  cli_tipo_doc AS Documento, cli_nro_doc AS Numero, enc_kg AS KGs FROM AWANTA.ENCOMIENDA
JOIN AWANTA.CLIENTE ON enc_encomendador = cli_codigo
WHERE enc_compra = @codigo
GO


