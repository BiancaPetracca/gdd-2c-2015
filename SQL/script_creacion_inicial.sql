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

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'BUTACAXVIAJE')
	DROP TABLE AWANTA.BUTACAXVIAJE


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
GO

--------------- GET DATE CON FECHA CONFIGURADA  -------------------------

CREATE TABLE AWANTA.CONFIG(
	
	date_today DATETIME
	)
GO

ALTER PROCEDURE AWANTA.set_date(@date DATETIME)
AS
BEGIN
DELETE FROM AWANTA.CONFIG
INSERT INTO AWANTA.CONFIG(date_today) VALUES(@date)
END
GO


alter FUNCTION AWANTA.getDate() RETURNS DATETIME
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

CREATE TABLE AWANTA.RUTAS_VIEJAS (
	rut_codigo numeric(18) identity(1,1) primary key,
	rut_codigo_original numeric(18),
	rut_origen numeric(18) not null foreign key
	references AWANTA.CIUDAD(ciu_id),
	rut_destino numeric(18) not null foreign key
	references AWANTA.CIUDAD(ciu_id),
	rut_precio_base numeric(18,2) not null,
	rut_precio_base_x_kg numeric(18,2) not null,
	rut_servicio numeric(18)
	)

CREATE TABLE AWANTA.SERVICIOXRUTA (
	servxr_ruta numeric(18) NOT NULL foreign key references AWANTA.RUTA_AEREA(rut_codigo),
	servxr_servicio numeric(18) NOT NULL foreign key references AWANTA.SERVICIO(serv_id_servicio)
)
CREATE TABLE AWANTA.ROL
(
	rol_id numeric(18) identity(1,1) primary key,
	rol_nombre nvarchar(255) not null,
	rol_funcionalidades nvarchar(255),
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
	usu_rol numeric(18) not null foreign key
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

CREATE TABLE AWANTA.BUTACAXVIAJE (
	butxv_viaje numeric(18) not null foreign key references AWANTA.VIAJE(via_codigo),
	butxv_butaca numeric(18) not null foreign key references AWANTA.BUTACA(but_id),
	butxv_ocupada bit
	PRIMARY KEY (butxv_viaje, butxv_butaca)
	)


CREATE TABLE AWANTA.TARJETA(
	tarjeta_nro numeric(18) primary key,
	tarjeta_codigo_seguridad numeric(18),
	tarjeta_fecha_vencimiento datetime,
	tarjeta_tipo nvarchar(255),
	tarjeta_cliente numeric(18) not null references AWANTA.CLIENTE(cli_codigo),
)

CREATE TABLE AWANTA.COMPRA
(
	compra_id numeric(18) identity(1,1) primary key,
	compra_cliente numeric(18) not null references AWANTA.CLIENTE(cli_codigo),
	compra_fecha DATETIME,
	compra_cuotas int,
	compra_tarjeta numeric(18) references AWANTA.TARJETA(tarjeta_nro)
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
las migramos con codigos diferentes. */

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

SELECT * FROM AWANTA.RUTA_AEREA -- 33: 17, 8 (VIENA) , 16: 17 -31 
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
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (1,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (2,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (3,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (4,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (5,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (6,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (7,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (8,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (9,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (10,1)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (11,1)

INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (7,2)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (9,2)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (10,2)
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

/*------MIGRACION DE LA TABLA PRODUCTO------*/

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

CREATE TRIGGER AWANTA.tr_updatear_fabricantes ON AWANTA.FABRICANTE INSTEAD OF UPDATE 
AS
BEGIN
DECLARE @insertado NVARCHAR(255)
DECLARE @id NUMERIC
SELECT @insertado = fab_nombre from inserted  
SELECT @id = fab_id from inserted
IF (EXISTS(SELECT 1 FROM AWANTA.FABRICANTE where @insertado = fab_nombre))
BEGIN 
RAISERROR(50300, -1, -1, 'Repetido el fabricante')
RETURN
END
UPDATE AWANTA.FABRICANTE SET fab_nombre = @insertado WHERE fab_id = @id 
END
GO

CREATE FUNCTION AWANTA.getIdFabricante(@fabricante NVARCHAR(255)) RETURNS NUMERIC
AS BEGIN
RETURN (SELECT fab_id FROM AWANTA.FABRICANTE WHERE fab_nombre = @fabricante)
END
GO

----------- MIGRACION DE LOS MODELOS -------------
-- interpretamos que como el modelo forma parte de la aeronave, es un modelo distinto por aeronave. cada fabricante tiene 
-- el modelo 

INSERT INTO AWANTA.MODELO(mod_fabricante,mod_nombre) SELECT AWANTA.getIdFabricante(Aeronave_Fabricante), Aeronave_Modelo from gd_esquema.Maestra group by Aeronave_Fabricante, Aeronave_Modelo order by AWANTA.getIdFabricante(Aeronave_Fabricante)
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
SELECT T.FechaSalida, T.FechaLlegada, T.Fecha_LLegada_Estimada, (SELECT TOP 1 rut_codigo FROM AWANTA.RUTA_AEREA 
			 WHERE AWANTA.getIdCiudad(T.Ruta_Ciudad_Destino) = rut_destino  AND 
			 AWANTA.getIdCiudad(T.Ruta_Ciudad_Origen) = rut_origen), (SELECT TOP 1 aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = T.Aeronave_Matricula), 0 FROM (SELECT DISTINCT FechaSalida, FechaLlegada, Fecha_LLegada_Estimada,Ruta_Ciudad_Destino, Ruta_Ciudad_Origen, Aeronave_Matricula FROM gd_esquema.Maestra) as T
GO


ALTER FUNCTION AWANTA.getIdCliente(@tipo_dni char(5), @dni numeric(18)) RETURNS NUMERIC(18) AS
BEGIN
RETURN (SELECT top 1 cli_codigo FROM AWANTA.CLIENTE where cli_nro_doc = @dni and cli_tipo_doc = @tipo_dni)
END
GO

----- MIGRACION COMPRA --------
--- en este caso hacemos > 1901 porque es la fecha por defecto que pone sql cuando no seleccionamos una fecha. 
ALTER TABLE AWANTA.COMPRA ADD compra_item NUMERIC(18), compra_monto NUMERIC(18,2) -- si es 0 es paquete si es 1 es pasaje.  
GO

INSERT INTO AWANTA.COMPRA(compra_cliente, compra_fecha, compra_item, compra_monto)
SELECT DISTINCT (SELECT cli_codigo FROM AWANTA.CLIENTE WHERE m.Cli_Dni = cli_nro_doc AND m.Cli_Apellido = Cli_Apellido), m.Paquete_FechaCompra, m.Paquete_Codigo, m.Paquete_Precio FROM gd_esquema.Maestra m
where YEAR(m.Paquete_FechaCompra) > 1901 AND Butaca_Tipo = '0'
INSERT INTO AWANTA.COMPRA(compra_cliente, compra_fecha, compra_item, compra_monto)
SELECT DISTINCT (SELECT cli_codigo FROM AWANTA.CLIENTE WHERE m.Cli_Dni = cli_nro_doc AND m.Cli_Apellido = Cli_Apellido), m.Pasaje_FechaCompra, m.Pasaje_Codigo, m.Pasaje_Precio FROM gd_esquema.Maestra m
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

/*----------STORED PROCEDURES APLICACION----------*/ 
GO

-- algunos mensajes de error --

-- exec sp_addmessage @msgnum = 50013, @severity = 1, @msgtext = 'El usuario ya esta repetido', @lang = us_english
 --GO

/*------LOGIN------*/

CREATE PROCEDURE AWANTA.registrar_usuario(@usuario NVARCHAR(255), @password NVARCHAR(255), @rol BIT)
AS
BEGIN
INSERT INTO AWANTA.USUARIO(usu_username, usu_estado, usu_fecha_alta, usu_intentos_login, usu_rol, usu_password) VALUES(@usuario, 0, AWANTA.getDate(), 0, @rol, HASHBYTES('SHA2_256', @password))
END
GO
-- registramos dos usuarios --
EXEC AWANTA.registrar_usuario 'user1', 'w23e', 1
go
EXEC AWANTA.registrar_usuario 'admin666', 'w23e', 1
go
EXEC AWANTA.registrar_usuario 'user2', 'w23e', 1
GO
/*
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
GO */ 

CREATE PROCEDURE [AWANTA].set_intentos_login(@nombre_usuario NVARCHAR(255),@intentos INT) 
AS
	BEGIN
		UPDATE AWANTA.USUARIO SET usu_intentos_login = @intentos 
		WHERE usu_username = @nombre_usuario
	END
GO

CREATE PROCEDURE [AWANTA].get_intentos_login(@nombre_usuario NVARCHAR(255))
AS
	BEGIN
		RETURN (SELECT usu_intentos_login FROM AWANTA.USUARIO WHERE
					usu_intentos_login = @nombre_usuario)
	END
GO

CREATE PROCEDURE [AWANTA].set_estado_usuario(@nombre_usuario NVARCHAR(255),@estado bit)
AS
	BEGIN
		
		UPDATE USUARIO SET usu_estado = @estado WHERE usu_username = @nombre_usuario
	END
GO
CREATE PROCEDURE AWANTA.validar_usuario(@username NVARCHAR(255), @password VARBINARY(32), @rol NVARCHAR(255))
AS 
BEGIN
		IF EXISTS (SELECT 1 FROM AWANTA.USUARIO 
		WHERE usu_username = @username AND @password = usu_password)
			BEGIN
				RETURN 1
			END
		RETURN -1
	END
GO

CREATE PROCEDURE AWANTA.get_estado_usuario(@nombre_usuario NVARCHAR(255))
AS BEGIN
IF EXISTS (SELECT 1 FROM AWANTA.USUARIO WHERE usu_username = @nombre_usuario AND usu_estado = 1)
BEGIN RETURN 1 END RETURN -1
END
GO


CREATE PROCEDURE AWANTA.get_rol_usuario(@nombre_usuario NVARCHAR(255)) 
AS BEGIN
IF (EXISTS (SELECT 1 FROM AWANTA.USUARIO WHERE @nombre_usuario = usu_username AND usu_rol = 1))
BEGIN RETURN 1 END RETURN 2 
END
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
CREATE PROCEDURE AWANTA.get_funcionalidades(@rol nvarchar(255))
AS
BEGIN
	SELECT fun_id, fun_descripcion FROM AWANTA.FUNCIONALIDAD, AWANTA.FUNC_X_ROL, AWANTA.ROL
	WHERE fun_id = f_x_r_funcionalidad AND
	f_x_r_rol = rol_id AND
	rol_nombre = @rol
END
GO

CREATE PROCEDURE AWANTA.get_funcionalidades_que_no_tiene(@rol nvarchar(255))
AS
BEGIN 
SELECT fun_id, fun_descripcion FROM AWANTA.FUNCIONALIDAD
WHERE NOT EXISTS (SELECT 1 FROM AWANTA.FUNC_X_ROL, AWANTA.ROL
	WHERE f_x_r_funcionalidad = fun_id AND 
	f_x_r_rol = rol_id AND
	rol_nombre = @rol)
END
GO

CREATE PROCEDURE AWANTA.get_roles
AS
BEGIN
	SELECT rol_nombre, rol_estado FROM AWANTA.ROL
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


CREATE PROCEDURE AWANTA.bajar_rol(@descripcion nvarchar(255))
AS
BEGIN
	UPDATE AWANTA.ROL
	SET rol_estado = 0
	WHERE rol_nombre = @descripcion

	UPDATE AWANTA.USUARIO
	SET usu_rol = NULL 
	WHERE usu_rol = (SELECT rol_id FROM AWANTA.ROL WHERE rol_nombre = @descripcion)
END
GO

CREATE PROCEDURE AWANTA.agregar_funcionalidad(@descripcion_func nvarchar(255))
AS
BEGIN
	INSERT INTO AWANTA.FUNCIONALIDAD(fun_descripcion)
	VALUES(@descripcion_func)
END
GO

CREATE PROCEDURE AWANTA.asignar_funcionalidad_a_rol (@rol nvarchar(255), @func nvarchar(255))
AS
BEGIN
	INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_rol, f_x_r_funcionalidad) VALUES ((SELECT TOP 1 rol_id FROM AWANTA.ROL WHERE rol_nombre = @rol),
	 (SELECT TOP 1 fun_id FROM AWANTA.FUNCIONALIDAD WHERE fun_descripcion = @func))
END
GO

CREATE FUNCTION AWANTA.getIdRol(@rol nvarchar(255)) RETURNS INT
AS
BEGIN
RETURN (SELECT rol_id FROM AWANTA.ROL WHERE rol_nombre = @rol)
END
GO

CREATE PROCEDURE AWANTA.borrar_funcionalidad(@rol nvarchar(255), @descripcion_func nvarchar(255))
AS
BEGIN
	DELETE FROM AWANTA.FUNC_X_ROL
	WHERE f_x_r_funcionalidad = (SELECT fun_id FROM AWANTA.FUNCIONALIDAD WHERE fun_descripcion = @descripcion_func)
	AND f_x_r_rol = (SELECT AWANTA.getIdRol(@rol))

END
GO

CREATE PROCEDURE AWANTA.existe_rol(@rol nvarchar(255))
AS
BEGIN
	IF(EXISTS(SELECT 1 FROM AWANTA.ROL WHERE rol_nombre = @rol)) BEGIN RETURN 1 END RETURN -1
END
GO

CREATE PROCEDURE AWANTA.modificar_nombre_rol(@nombre nvarchar(255), @nuevo_nombre nvarchar(255))
AS
BEGIN
	UPDATE AWANTA.ROL
	SET rol_nombre = @nuevo_nombre
	WHERE rol_nombre = @nombre
END
GO

CREATE PROCEDURE AWANTA.habilitar_rol(@nombre nvarchar(255))
AS
BEGIN
	UPDATE AWANTA.ROL
	SET rol_estado = 1 
	WHERE rol_nombre = @nombre
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
ALTER PROCEDURE AWANTA.get_all_rutas(@origen nvarchar(255) = null,  @destino nvarchar(255) = null, @servicio nvarchar(255) = null,
 @habilitada bit = null,  @precio_base_kg numeric(18,2) = null, @precio_base_pasaje numeric(18,2) = null)
AS 
BEGIN
	SELECT rut_codigo, AWANTA.obtenerNombreCiudad(rut_origen), AWANTA.obtenerNombreCiudad(rut_destino), serv_nombre, rut_habilitada, rut_precio_base_x_kg, rut_precio_base
	FROM AWANTA.RUTA_AEREA
	JOIN AWANTA.SERVICIOXRUTA ON servxr_ruta = rut_codigo
	JOIN AWANTA.SERVICIO ON servxr_servicio = serv_id_servicio
	WHERE (@habilitada IS NULL OR rut_habilitada = @habilitada) AND
	(@destino IS NULL OR rut_destino=AWANTA.getIdCiudad(@destino)) AND
	(@origen IS NULL OR rut_origen=AWANTA.getIdCiudad(@origen)) AND
	(@precio_base_pasaje IS NULL OR rut_precio_base=@precio_base_pasaje) AND
	(@precio_base_kg IS NULL OR rut_precio_base_x_kg=@precio_base_kg) AND
	(@servicio IS NULL OR servxr_servicio=AWANTA.getIdServicio(@servicio))
	order by rut_codigo
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
CREATE PROCEDURE AWANTA.get_servicios_rutas(@ruta NUMERIC)
AS
BEGIN
SELECT serv_nombre FROM AWANTA.SERVICIO JOIN AWANTA.SERVICIOXRUTA ON serv_id_servicio = servxr_servicio WHERE servxr_ruta = @ruta
END
GO
-- modificar ruta hacen todo lo que sea que no sea el update de servicios. 

ALTER PROCEDURE AWANTA.modificar_ruta(@codigo NUMERIC, @origen nvarchar(255),  @destino nvarchar(255),  @habilitada int, @precio_base_kg numeric(18,2), @precio_base_pasaje numeric(18,2)) AS
 BEGIN
 DECLARE @id_servicio NUMERIC(18)
 IF (NOT EXISTS(SELECT 1 FROM AWANTA.RUTA_AEREA WHERE rut_origen = AWANTA.getIdCiudad(@origen) AND rut_destino = AWANTA.getIdCiudad(@destino)))
 BEGIN
 UPDATE AWANTA.RUTA_AEREA SET rut_origen = AWANTA.getIdCiudad(@origen), rut_destino = AWANTA.getIdCiudad(@destino),
  rut_habilitada = @habilitada, rut_precio_base_x_kg = @precio_base_kg, rut_precio_base = @precio_base_pasaje
 WHERE @codigo = rut_codigo
 RETURN 1 
 END
 RETURN -1
 END
 GO


ALTER PROCEDURE AWANTA.altaRutaAerea(@ciudadOrigen NVARCHAR(255), @ciudadDestino NVARCHAR(255), @rutaPrecioBasePasaje numeric(18,2), @rutaPrecioBaseKilo numeric(18,2), @habilitada bit)
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


CREATE PROCEDURE AWANTA.darDeBajaPasajesAsociadosPorBajaDeRutaAerea(@ruta NUMERIC(18))
AS		
	BEGIN

	UPDATE AWANTA.PASAJE SET pas_cancelado = 1 WHERE (SELECT via_codigo FROM AWANTA.VIAJE WHERE via_ruta_aerea = @ruta) = pas_viaje
	UPDATE AWANTA.ENCOMIENDA SET enc_cancelado = 1 WHERE (SELECT via_codigo FROM AWANTA.VIAJE WHERE via_ruta_aerea = @ruta) = enc_viaje
	END
GO

CREATE TRIGGER AWANTA.tr_baja_pasajes ON AWANTA.COMPRA INSTEAD OF DELETE 
AS 
BEGIN 
	DELETE FROM AWANTA.PASAJE WHERE EXISTS (SELECT 1 FROM deleted WHERE compra_id = pas_compra)
	DELETE FROM AWANTA.ENCOMIENDA WHERE EXISTS (SELECT 1 FROM deleted WHERE compra_id = enc_compra)
	DELETE FROM AWANTA.COMPRA WHERE EXISTS (SELECT 1 FROM deleted d WHERE compra_id = d.compra_id)
END
GO


CREATE PROCEDURE AWANTA.bajaRutaAerea(@codigo NUMERIC(18))
AS
	BEGIN
		UPDATE AWANTA.RUTA_AEREA
		SET rut_habilitada = 0
		WHERE rut_codigo = @codigo
		EXEC AWANTA.darDeBajaPasajesAsociadosPorBajaDeRutaAerea @codigo
	END
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

CREATE PROCEDURE AWANTA.get_estado_aeronave(@codigo NUMERIC(18))
AS
BEGIN
DECLARE @bajaM DATETIME, @bajaU DATETIME, @fechaR DATETIME
IF EXISTS (SELECT 1 FROM AWANTA.HISTORICO_BAJAS WHERE baja_avion = @codigo AND (baja_motivo = 0 OR baja_motivo = 1 AND baja_reinicio > AWANTA.getDate())) BEGIN RETURN -1 END
RETURN 1 
END  
GO
ALTER FUNCTION AWANTA.get_estado(@codigo NUMERIC(18)) RETURNS BIT
AS
BEGIN
DECLARE @bajaM DATETIME, @bajaU DATETIME, @fechaR DATETIME
IF EXISTS (SELECT 1 FROM AWANTA.HISTORICO_BAJAS WHERE baja_avion = @codigo AND (baja_motivo = 0 OR baja_motivo = 1 AND baja_reinicio > AWANTA.getDate())) BEGIN RETURN 0 END
RETURN 1 
END  
GO
ALTER PROCEDURE AWANTA.get_aeronaves(@estado numeric(1) = null, @filtro nvarchar(255) = null)
AS
BEGIN
SET @estado = nullif(@estado, 0)
SELECT aero_matricula, mod_nombre, fab_nombre, serv_nombre, AWANTA.get_estado(aero_numero), aero_kgs_disponibles_encomiendas,
 aero_fecha_de_alta FROM AWANTA.AERONAVE
	JOIN AWANTA.SERVICIO ON serv_id_servicio = aero_id_servicio
	JOIN AWANTA.MODELO ON mod_id = aero_modelo
	JOIN AWANTA.FABRICANTE ON fab_id = mod_fabricante
	AND (@filtro IS NULL OR @filtro = serv_nombre)
END
GO

CREATE PROCEDURE AWANTA.get_aeronaves_filtradas(@numero numeric(1), @filtro nvarchar(255))
AS 
BEGIN
SELECT * FROM AWANTA.AERONAVE
END
GO

ALTER PROCEDURE AWANTA.get_all_aeronaves(@numero numeric(18) = null, @modelo nvarchar(255) = null, @matricula nvarchar(255) = null, @kilos_disponibles numeric(18) = null,
 @fabricante nvarchar(255) = null, @fecha_alta date = null, @fecha_baja_temporal date = null, 
@fecha_alta_temporal date = null, @fecha_baja_definitiva date = null)
AS 
BEGIN
	SELECT aero_matricula, aero_cantidad_butacas_pasillo, aero_cantidad_butacas_ventanilla, aero_kgs_disponibles_encomiendas, 
	fab_nombre, mod_nombre, aero_fecha_de_alta, aero_baja_fuera_de_servicio, aero_fecha_reinicio_servicio, aero_fecha_baja_definitiva, serv_nombre, aero_estado
	FROM AWANTA.AERONAVE, AWANTA.SERVICIO, AWANTA.FABRICANTE, AWANTA.MODELO
	WHERE aero_modelo = mod_id AND mod_fabricante = fab_id AND 
	 (@modelo IS NULL OR mod_id=@modelo) AND
	(@matricula IS NULL OR aero_matricula=@matricula) AND
	(@kilos_disponibles IS NULL OR aero_kgs_disponibles_encomiendas=@kilos_disponibles) AND
	(@fabricante IS NULL OR fab_nombre=@fabricante) AND
	(@fecha_alta IS NULL OR aero_fecha_de_alta=@fecha_alta) AND
	(@fecha_baja_temporal IS NULL OR aero_baja_fuera_de_servicio=@fecha_baja_temporal) AND
	(@fecha_alta_temporal IS NULL OR aero_fecha_reinicio_servicio=@fecha_alta_temporal) AND
	(@fecha_baja_definitiva IS NULL OR aero_fecha_baja_definitiva=@fecha_baja_definitiva) AND
	(@numero IS NULL OR aero_numero=@numero) AND
	aero_id_servicio = serv_id_servicio
END
GO 

ALTER PROCEDURE AWANTA.altaDeAeronave(@matricula NVARCHAR(255),@modelo NVARCHAR(255),@fabricante NVARCHAR(255),@servicio NVARCHAR(255),@kilosDisponibles INT)
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

CREATE PROCEDURE AWANTA.bajaDeViajesAsociadosConAeronave(@numero NVARCHAR(255))
AS
	BEGIN
		DELETE FROM AWANTA.VIAJE WHERE via_fecha_salida > (SELECT CONVERT(date,AWANTA.getDate()))
										AND via_avion = @numero
	END
GO

-- Las condiciones son que la aeronave que va a reemplazarla no tenga viajes asignados entre esas fechas. 
-- lo usamos tambien para saber las aeronaves disponibles entre dos fechas
ALTER FUNCTION AWANTA.tieneViajesAsignados(@aero_numero_de_aeronave NUMERIC(18),@fechaBaja DATETIME,@fechaReinicio DATETIME) 
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


ALTER FUNCTION AWANTA.hay_aeronaves_disponibles(@fechaSalida DATETIME, @fechaEstimadaLlegada DATETIME) RETURNS INT
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

ALTER PROCEDURE AWANTA.get_aeronaves_disponibles(@fechaSalida DATETIME, @fechaEstimadaLlegada DATETIME)
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


CREATE PROCEDURE AWANTA.reemplazoDeAeronaveEnViajes (@numero NUMERIC(18), @fechaReinicio DATETIME)
AS
	BEGIN
	DECLARE @numeroAvionDeReemplazo NUMERIC(18), @matriculaAvionDeReemplazo NVARCHAR(255)
	-- hallo la que va a reemplazar 
	SELECT @numeroAvionDeReemplazo = aero_reemplazo.aero_numero, @matriculaAvionDeReemplazo = aero_reemplazo.aero_matricula FROM AWANTA.AERONAVE aero_reemplazo, AWANTA.AERONAVE aero_orig
	WHERE aero_reemplazo.aero_id_servicio = aero_orig.aero_id_servicio AND aero_orig.aero_modelo = aero_reemplazo.aero_modelo
	AND aero_orig.aero_matricula <> aero_reemplazo.aero_matricula AND AWANTA.es_aeronave_disponible(aero_reemplazo.aero_numero) = 1 
	
	-- si la fecha de reinicio no es null, quiere decir que entonces era por una aeronave que se dio de baja por mantenimiento
	DECLARE @fechaSalida DATETIME
				DECLARE @fechaLlegada DATETIME
				DECLARE @matriculaAeronave NVARCHAR(255)
				DECLARE @fechaDelDia DATETIME
				SET @fechaDelDia = (SELECT CONVERT(date,AWANTA.getDate()))
				DECLARE @codigoViaje NUMERIC
		IF (@fechaReinicio != NULL)
			BEGIN
				-- cursor para todos los viajes que tengan asignados esa aeronave en ese periodo
				DECLARE miCursor CURSOR FOR SELECT via_codigo, via_fecha_salida,via_fecha_llegada,via_avion FROM AWANTA.VIAJE WHERE via_avion = @matriculaAvionDeReemplazo
											 AND via_fecha_salida > @fechaDelDia
											 AND via_fecha_salida < @fechaReinicio
				OPEN miCursor
			
				FETCH FROM miCursor INTO @codigoViaje,@fechaSalida,@fechaLlegada,@matriculaAeronave
				
				WHILE @@FETCH_STATUS = 0
					BEGIN
		
								UPDATE AWANTA.VIAJE
								SET via_avion = @matriculaAvionDeReemplazo
								WHERE via_codigo = @codigoViaje

						FETCH FROM miCursor INTO @codigoViaje,@fechaSalida,@fechaLlegada,@matriculaAeronave	 
					END 
					CLOSE miCursor
					DEALLOCATE miCursor 
			END
		ELSE
		-- si era null, entonces era una aeronave que se dio de baja por fin de vida util y se reemplazan todos los viajes posteriores a la fecha 
			BEGIN
				DECLARE curs_viaje CURSOR FOR SELECT via_codigo, via_fecha_salida, via_fecha_llegada, via_avion FROM AWANTA.VIAJE WHERE via_avion = @matriculaAvionDeReemplazo
				AND via_fecha_salida > @fechaDelDia
				OPEN curs_viaje
				FETCH FROM curs_viaje INTO @codigoViaje, @fechaSalida, @fechaLlegada,@matriculaAeronave
				WHILE @@FETCH_STATUS = 0
				BEGIN
				UPDATE AWANTA.VIAJE SET via_avion = @matriculaAvionDeReemplazo WHERE via_codigo = @codigoViaje
				FETCH FROM curs_viaje INTO @codigoViaje,@fechaSalida,@fechaLlegada,@matriculaAeronave
				END
				CLOSE curs_viaje
				DEALLOCATE curs_viaje
			END
			END

GO

ALTER PROCEDURE AWANTA.bajaLogicaDeAeronavePorFinDeVidaUtil(@matricula NVARCHAR(255),@reemplazo INT)
AS
	BEGIN
		DECLARE @numero NUMERIC
		SELECT @numero = aero_numero FROM AWANTA.AERONAVE WHERE @matricula = aero_matricula
		INSERT INTO AWANTA.HISTORICO_BAJAS(baja_avion, baja_fecha, baja_motivo) VALUES (@numero,(SELECT CONVERT(date,AWANTA.getDate())), 0)
			IF (@reemplazo = 1)
				BEGIN
					DECLARE @fecha  SMALLDATETIME
					SET @fecha = AWANTA.getDate()
					-- REEMPLAZAR LA AERONAVE CON OTRA SI SE QUERIA REEMPLAZAR 
					EXEC AWANTA.reemplazoDeAeronaveEnViajes @numero,@fecha
				END
				RETURN
					-- CANCELAR LOS VIAJES DE ESA AERONAVE SI NO SE QUERIA REEMPLAZAR
					EXEC AWANTA.bajaDeViajesAsociadosConAeronave @numero
				END
GO


ALTER PROCEDURE AWANTA.bajaLogicaDeAeronavePorMantenimiento(@matricula NVARCHAR(255),@fechaReinicio DATETIME,@reemplazo INT)
AS
	BEGIN
		DECLARE @numero NUMERIC
		SELECT @numero = aero_numero FROM AWANTA.AERONAVE WHERE @matricula = aero_matricula
		INSERT INTO AWANTA.HISTORICO_BAJAS(baja_avion, baja_fecha, baja_motivo, baja_reinicio) VALUES (@numero, AWANTA.getDate(), 1, @fechaReinicio)
				--Me fijo si hay que cancelar los viajes o reemplazarlos
				--SI ES 1 REEMPLAZO SINO 0 PARA CANCELACION
				IF (@reemplazo = 1)
					BEGIN
						EXEC AWANTA.reemplazoDeAeronaveEnViajes @numero,@fechaReinicio
					END
					RETURN
						EXEC AWANTA.bajaDeViajesAsociadosConAeronave @matricula

	END
GO


CREATE PROCEDURE AWANTA.obtenerCodigoAeronave(@matricula nvarchar(255))
AS
BEGIN
	DECLARE @codigo numeric(18)
	SET @codigo = (SELECT aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = @matricula)
	RETURN @codigo
END
GO

ALTER PROCEDURE AWANTA.modificarAeronave(@numero numeric(18), @matricula nvarchar(255), @modelo nvarchar(255), @fabricante nvarchar(255), @servicio nvarchar(255), 
@cantidadKgsEncomiendas numeric, @estado bit) 
AS 
BEGIN
IF EXISTS(SELECT 1 FROM AWANTA.AERONAVE WHERE aero_matricula = @matricula AND aero_numero <> @numero) BEGIN RETURN -1 END
DECLARE @numero_servicio NUMERIC(18), @matricula_vieja NVARCHAR(255)
SELECT @matricula_vieja = aero_matricula FROM AWANTA.AERONAVE WHERE aero_numero = @numero
SELECT @numero_servicio = serv_id_servicio FROM SERVICIO WHERE serv_nombre = @servicio
UPDATE AWANTA.AERONAVE 
SET aero_matricula = @matricula, aero_modelo = AWANTA.getIdModelo(@fabricante, @modelo), aero_id_servicio = @numero_servicio,
aero_kgs_disponibles_encomiendas = @cantidadKgsEncomiendas, aero_estado = @estado
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

ALTER PROCEDURE AWANTA.set_butacas(@aeronave NUMERIC(18), @butaca INT, @tipo nvarchar(255))
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
ALTER PROCEDURE AWANTA.modificarModelo(@viejoModelo nvarchar(255), @nuevoModelo nvarchar(255), @fabricante nvarchar(255))
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
JOIN AWANTA.VIAJE ON via_avion = aero_matricula
JOIN AWANTA.RUTA_AEREA ON via_ruta_aerea = rut_codigo AND rut_origen = AWANTA.getIdCiudad(@origen) AND rut_destino = AWANTA.getIdCiudad(@destino)
WHERE aero_matricula = @matricula AND (AWANTA.es_aprox_esa_fecha(@llegada, via_fecha_llegada_estimada) = 1)))
BEGIN RETURN 1 END RETURN -1
END 
GO 

-- A NIVEL DE LA APLICACION, DIRECTAMENTE NO DEJAMOS QUE EL USUARIO INGRESE A LA DATA GRID UN VIAJE QUE YA FUE REGISTRADO COMO LLEGADA
CREATE PROCEDURE AWANTA.aeronave_ya_registrada(@matricula NVARCHAR(255), @origen NVARCHAR(255), @destino NVARCHAR(255), @llegada DATETIME) AS 
BEGIN
IF (EXISTS(SELECT 1 FROM AWANTA.AERONAVE 
JOIN AWANTA.VIAJE ON via_avion = aero_matricula
JOIN AWANTA.RUTA_AEREA ON via_ruta_aerea = rut_codigo AND rut_origen = AWANTA.getIdCiudad(@origen) AND rut_destino = AWANTA.getIdCiudad(@destino)
WHERE aero_matricula = @matricula AND (AWANTA.es_aprox_esa_fecha(@llegada, via_fecha_llegada_estimada) = 1) AND via_fecha_llegada IS NOT NULL))
BEGIN RETURN 1 END RETURN -1 END 
GO

CREATE PROCEDURE AWANTA.registrar_llegada_viaje(@matricula NVARCHAR(255), @origen NVARCHAR(255), @destino NVARCHAR(255), @llegada DATETIME)
AS
BEGIN
UPDATE V SET via_fecha_llegada = @llegada FROM AWANTA.AERONAVE 
JOIN AWANTA.VIAJE V ON V.via_avion = aero_matricula
JOIN AWANTA.RUTA_AEREA ON V.via_ruta_aerea = rut_codigo AND rut_origen = AWANTA.getIdCiudad(@origen) AND rut_destino = AWANTA.getIdCiudad(@destino)
WHERE aero_matricula = @matricula AND (AWANTA.es_aprox_esa_fecha(@llegada, V.via_fecha_llegada_estimada) = 1)
END
GO

/*------ALTA VIAJE------*/

CREATE PROCEDURE AWANTA.get_rutas(@aeronave NVARCHAR(255))
AS 
BEGIN
SELECT rut_codigo, o.ciu_nombre as origen, d.ciu_nombre as destino, serv_nombre as servicio, rut_precio_base, rut_precio_base_x_kg FROM AWANTA.RUTA_AEREA 
JOIN AWANTA.SERVICIOXRUTA ON servxr_ruta = rut_codigo
JOIN AWANTA.SERVICIO ON
servxr_servicio = serv_id_servicio
JOIN AWANTA.AERONAVE ON aero_matricula = @aeronave AND servxr_servicio = aero_id_servicio
JOIN AWANTA.CIUDAD d ON rut_destino = d.ciu_id
JOIN AWANTA.CIUDAD o ON rut_origen = o.ciu_id
WHERE rut_habilitada = 1
ORDER BY rut_codigo
END
GO

CREATE PROCEDURE AWANTA.hay_viajes_disponibles(@fechaSalida datetime, @fechaLlegada datetime, @origen nvarchar(255), @destino nvarchar(255)) 
AS
BEGIN
RETURN (CASE WHEN EXISTS(SELECT 1 FROM AWANTA.VIAJE JOIN AWANTA.RUTA_AEREA ON rut_codigo = via_ruta_aerea
WHERE DATEDIFF(DAY, via_fecha_salida, @fechaSalida) < 1 AND DATEDIFF(DAY, via_fecha_llegada_estimada, @fechaLlegada) < 1 AND
rut_origen = (SELECT ciu_id FROM AWANTA.CIUDAD WHERE ciu_nombre = @origen) AND
	 rut_destino = (SELECT ciu_id FROM AWANTA.CIUDAD WHERE ciu_nombre = @destino)) THEN 1 ELSE -1 END)
END
GO

ALTER PROCEDURE AWANTA.get_viajes(@fechaSalida datetime, @fechaLlegada datetime, @origen nvarchar(255), @destino nvarchar(255))
AS
BEGIN
	SELECT via_codigo, via_fecha_salida, via_fecha_llegada_estimada, AWANTA.obtenerNombreCiudad(rut_origen), AWANTA.obtenerNombreCiudad(rut_destino),
	(SELECT serv_nombre FROM AWANTA.SERVICIO WHERE serv_id_servicio = aero_id_servicio), 1, 1
	
	FROM AWANTA.VIAJE, AWANTA.RUTA_AEREA, AWANTA.AERONAVE
	WHERE (@fechaSalida is null or (YEAR(via_fecha_salida) = YEAR(@fechaSalida) AND
	MONTH(via_fecha_salida) = MONTH(@fechaSalida) AND
	DAY(via_fecha_salida) = DAY(@fechaSalida) ))
	AND (@fechaLlegada is null or (YEAR(via_fecha_llegada_estimada) = YEAR(@fechaLlegada) AND MONTH(via_fecha_llegada_estimada) = MONTH(@fechaLlegada) AND DAY(via_fecha_llegada_estimada) = DAY(@fechaLlegada)))
	AND via_ruta_aerea = rut_codigo AND aero_numero = via_avion AND 
	(@origen is null or rut_origen = (SELECT ciu_id FROM AWANTA.CIUDAD WHERE ciu_nombre = @origen) ) AND
	(@destino is null or rut_destino =(SELECT ciu_id FROM AWANTA.CIUDAD WHERE ciu_nombre = @destino)) AND
	via_fecha_llegada IS NULL 
END
GO
-- se fija si existe una ruta que es la ruta que le pasamos, que tenga ese servicio (en la asociativa)
ALTER PROCEDURE AWANTA.create_viaje(@avion nvarchar(255), @llegada_estimada date, @salida date, @ruta numeric)
AS
BEGIN
	DECLARE @serv_avion numeric(18), @numero_avion numeric(18)
	SELECT @serv_avion = aero_id_servicio, @numero_avion = aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = @avion
	DECLARE @avion_libre int
	SET @avion_libre = (SELECT count(1) FROM AWANTA.AERONAVE, AWANTA.VIAJE WHERE aero_matricula = @avion AND aero_numero = via_avion AND
							via_fecha_llegada_estimada BETWEEN @salida AND @llegada_estimada)

	IF(EXISTS(SELECT 1 FROM AWANTA.SERVICIOXRUTA WHERE servxr_ruta = @ruta AND servxr_servicio = @serv_avion) AND @avion_libre = 0)
		BEGIN
		
			INSERT INTO AWANTA.VIAJE(via_avion, via_fecha_llegada_estimada, via_fecha_salida, via_ruta_aerea)
			VALUES(@numero_avion, @llegada_estimada, @salida, @ruta)
			RETURN 1
		END

			RETURN -1
		END

GO

CREATE TRIGGER tr_butacas_por_viaje ON AWANTA.VIAJE AFTER INSERT 
AS
BEGIN
DECLARE @avion NUMERIC(18), @viaje NUMERIC(18), @butaca NUMERIC(18)
SELECT @avion = via_avion, @viaje = via_codigo FROM inserted
DECLARE butacas CURSOR FOR SELECT but_id FROM AWANTA.BUTACA WHERE but_aeronave = @avion
OPEN butacas
FETCH FROM butacas INTO @butaca
WHILE @@FETCH_STATUS = 0
BEGIN
INSERT INTO AWANTA.BUTACAXVIAJE(butxv_butaca, butxv_viaje, butxv_ocupada) VALUES (@butaca, @viaje, 0)
FETCH FROM butacas INTO @butaca
END
CLOSE butacas
DEALLOCATE butacas
END
GO
SELECT * FROM AWANTA.VIAJE WHERE via_codigo = 8512
ALTER PROCEDURE AWANTA.set_butaca_ocupada(@viaje NUMERIC(18), @numero NUMERIC(18), @ocupada bit)
AS
BEGIN
UPDATE AWANTA.BUTACAXVIAJE SET butxv_ocupada = @ocupada WHERE butxv_viaje = @viaje AND
butxv_butaca = (SELECT but_id FROM AWANTA.BUTACA WHERE but_numero = @numero AND but_aeronave = (SELECT via_avion FROM AWANTA.VIAJE WHERE via_codigo = @viaje))
END
GO

CREATE PROCEDURE AWANTA.get_butacas_disponibles(@viaje NUMERIC(18))
AS
BEGIN
SELECT but_numero, but_tipo FROM AWANTA.BUTACAXVIAJE JOIN AWANTA.BUTACA ON butxv_butaca = but_id WHERE butxv_ocupada = 0 AND butxv_viaje = @viaje
ORDER BY but_numero 
END
GO
CREATE PROCEDURE AWANTA.tiene_viajes_asignados(@matricula nvarchar(255))
AS
BEGIN
IF EXISTS(SELECT 1 FROM AWANTA.VIAJE WHERE via_avion = @matricula) BEGIN RETURN 1 END
RETURN 0
END
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

CREATE PROCEDURE AWANTA.vender_pasaje (@terminal nvarchar(255), @tipo_doc nvarchar(255), @numero_doc numeric(18), 
@salida date, @origen nvarchar(255), @destino nvarchar(255), @tipo nvarchar(255), @piso int)
AS
BEGIN
	INSERT INTO AWANTA.COMPRA(compra_viaje, compra_cliente, compra_terminal)
	VALUES((SELECT via_codigo 
	FROM AWANTA.VIAJE, AWANTA.RUTA_AEREA 
	WHERE via_fecha_salida = @salida AND
	via_ruta_aerea = rut_codigo AND
	rut_origen = @origen AND
	rut_destino = @destino),
	(SELECT cli_codigo
	FROM AWANTA.CLIENTE 
	WHERE cli_tipo_doc = @tipo_doc AND cli_nro_doc = @numero_doc), 

	DECLARE @compra_pasaje numeric(18)
	SET @compra_pasaje = (SELECT compra_id
	FROM AWANTA.COMPRA, AWANTA.CLIENTE, AWANTA.VIAJE, AWANTA.RUTA_AEREA
	WHERE compra_cliente = cli_codigo AND 
	cli_tipo_doc = @tipo_doc AND
	cli_nro_doc = @numero_doc AND
	compra_viaje = via_codigo AND
	via_fecha_salida = @salida AND
	via_ruta_aerea = rut_codigo AND
	rut_origen = @origen AND
	rut_destino = @destino)
	
	DECLARE @butaca_pasaje numeric(18)
	SET @butaca_pasaje = (SELECT but_id 
	FROM AWANTA.BUTACA
	WHERE but_estado = 0 AND
	but_tipo = @tipo AND
	but_piso = @piso)

	UPDATE AWANTA.BUTACA
	SET but_estado = 1
	WHERE but_id = @butaca_pasaje

	INSERT INTO AWANTA.PASAJE(pas_compra, pas_butaca)
	VALUES(@compra_pasaje, @butaca_pasaje)
END
GO

--------------------- DEVOLUCION --------------------------
-- solo traigo las compras que tienen algun pasaje o encomienda sin devolver y que la fecha del viaje no haya llegado ya. 
-- (para que devolver una compra que ya paso?)
ALTER PROCEDURE AWANTA.get_compras(@dni NUMERIC(18))
AS
BEGIN
SELECT compra_id FROM AWANTA.COMPRA WHERE compra_cliente = (SELECT TOP 1 cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = 'DNI')
AND ((EXISTS(SELECT 1 FROM AWANTA.VIAJE JOIN AWANTA.PASAJE ON pas_viaje = via_codigo
  WHERE pas_compra = compra_id AND via_fecha_llegada IS NULL
  AND pas_codigo NOT IN (SELECT devxp_pasaje FROM AWANTA.DEVOLUCIONXPASAJE))) 
  AND
   (EXISTS(SELECT 1 FROM AWANTA.VIAJE JOIN AWANTA.ENCOMIENDA ON enc_viaje = via_codigo
  WHERE enc_compra = compra_id AND via_fecha_llegada IS NULL
  AND enc_codigo NOT IN (SELECT devxp_encomienda FROM AWANTA.DEVOLUCIONXENCOMIENDA))))
END
GO

ALTER PROCEDURE AWANTA.existe_cliente(@tipo_dni CHAR(5), @dni NUMERIC(18))
AS
BEGIN
IF EXISTS(SELECT 1 FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = @tipo_dni)
BEGIN RETURN 1 END 
RETURN -1 END
GO

ALTER PROCEDURE AWANTA.get_cliente(@tipo_dni CHAR(5), @dni NUMERIC(18))
AS
BEGIN
SELECT cli_nombre, cli_apellido, cli_direccion, cli_telefono, cli_mail, cli_fecha_nac FROM AWANTA.CLIENTE WHERE @tipo_dni = cli_tipo_doc AND @dni = cli_nro_doc
END
GO

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

ALTER PROCEDURE AWANTA.crear_devolucion(@compra NUMERIC(18))
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

go
ALTER PROCEDURE AWANTA.devolver_items(@devolucion NUMERIC(18), @item NUMERIC(18), @motivo NVARCHAR)
AS
BEGIN
IF EXISTS(SELECT 1 FROM AWANTA.PASAJE WHERE pas_codigo = @item) BEGIN
INSERT INTO AWANTA.DEVOLUCIONXPASAJE(devxp_pasaje, devxp_devolucion, devxp_motivo) VALUES (@item, @devolucion, @motivo)
-- liberacion de butacas
UPDATE AWANTA.BUTACAXVIAJE SET butxv_ocupada = 0 WHERE EXISTS (SELECT 1 FROM AWANTA.PASAJE WHERE 
pas_butaca = butxv_butaca  AND butxv_viaje = pas_viaje AND pas_codigo = @item)
RETURN
END
-- no necesito liberar nada, cuando haga el calculo no tengo en cuenta a los kg de los pasajes que figuren aca 
IF EXISTS(SELECT 1 FROM AWANTA.ENCOMIENDA WHERE enc_codigo = @item) BEGIN
INSERT INTO AWANTA.DEVOLUCIONXENCOMIENDA(devxp_encomienda, devxp_devolucion, devxe_motivo) VALUES (@item, @devolucion, @motivo)
RETURN
END
END
GO






/*------MILLAS VIAJERO------*/

ALTER FUNCTION AWANTA.get_millas_pasajes(@tipo_dni char(5), @dni numeric(18)) returns int
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

ALTER FUNCTION AWANTA.get_millas_encomiendas(@tipo_dni char(5), @dni numeric(18)) returns int
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
ALTER FUNCTION AWANTA.get_millas_canjes(@tipo_dni char(5), @dni numeric(18)) returns int AS 
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
RETURN (SELECT isnull((SELECT SUM(enc_precio) FROM AWANTA.CLIENTE
	JOIN AWANTA.ENCOMIENDA ON enc_encomendador = cli_codigo 
	JOIN AWANTA.COMPRA ON enc_compra = compra_id 
	WHERE cli_tipo_doc = @tipo_dni AND cli_nro_doc = @dni AND DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1 AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXENCOMIENDA
	WHERE enc_codigo = devxp_encomienda)
	GROUP BY cli_codigo	),0) - isnull((SELECT SUM(prod_millas * can_cantidad) FROM AWANTA.CLIENTE
JOIN AWANTA.CANJE ON can_canjeador = cli_codigo 
JOIN AWANTA.PRODUCTO ON prod_id = can_producto
WHERE  cli_tipo_doc = @tipo_dni AND cli_nro_doc = @dni AND DATEDIFF(YEAR, can_fecha, AWANTA.getDate()) < 1  
GROUP BY cli_codigo),0) + isnull((SELECT SUM(pas_precio) FROM AWANTA.CLIENTE
	JOIN AWANTA.PASAJE ON pas_pasajero = cli_codigo 
	JOIN AWANTA.COMPRA ON pas_compra = compra_id 
	WHERE cli_tipo_doc = @tipo_dni AND cli_nro_doc = @dni AND DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1 AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXPASAJE 
	WHERE devxp_pasaje = pas_codigo)
	GROUP BY cli_codigo),0))
END
GO

CREATE PROCEDURE AWANTA.get_millas_cliente(@tipo_dni char(5), @dni numeric(18)) AS
BEGIN
RETURN (SELECT AWANTA.get_millas(@tipo_dni, @dni))
END
GO

ALTER PROCEDURE AWANTA.info_canjes(@tipo_dni char(5), @dni numeric(18))
AS
BEGIN
SELECT can_fecha, prod_nombre, can_cantidad, prod_millas FROM AWANTA.CANJE JOIN 
AWANTA.PRODUCTO ON can_producto = prod_id 
WHERE DATEDIFF(YEAR, can_fecha, AWANTA.getDate()) < 1 AND can_canjeador = AWANTA.getIdCliente(@tipo_dni, @dni)
END
GO
ALTER PROCEDURE AWANTA.info_pasajes(@tipo_dni char(5), @dni numeric(18))
AS
BEGIN
SELECT compra_fecha, AWANTA.obtenerNombreCiudad(rut_origen),AWANTA.obtenerNombreCiudad(rut_destino), (pas_precio/10) FROM AWANTA.PASAJE JOIN
AWANTA.COMPRA ON compra_id = pas_compra 
JOIN VIAJE ON via_codigo = pas_viaje 
JOIN RUTA_AEREA ON rut_codigo = via_ruta_aerea
WHERE DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1 AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXPASAJE WHERE devxp_pasaje = pas_codigo) 
AND pas_pasajero = (SELECT cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = @tipo_dni)
END
GO

ALTER PROCEDURE AWANTA.info_encomiendas(@tipo_dni char(5), @dni numeric(18))
AS
BEGIN
 SELECT compra_fecha, AWANTA.obtenerNombreCiudad(rut_origen), AWANTA.obtenerNombreCiudad(rut_destino), (enc_precio/10) FROM AWANTA.ENCOMIENDA JOIN
AWANTA.COMPRA ON compra_id = enc_compra 
JOIN VIAJE ON via_codigo = enc_viaje 
JOIN RUTA_AEREA ON rut_codigo = via_ruta_aerea
WHERE DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1 AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXENCOMIENDA WHERE devxp_encomienda = enc_codigo)
 AND enc_encomendador = (SELECT cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = @tipo_dni)
END
GO


ALTER PROCEDURE AWANTA.info_millas(@tipo_dni char(5), @dni numeric(18))
AS
BEGIN
SELECT 'Canje', can_fecha, prod_nombre, can_cantidad, prod_millas FROM AWANTA.CANJE JOIN 
AWANTA.PRODUCTO ON can_producto = prod_id 
WHERE DATEDIFF(YEAR, can_fecha, AWANTA.getDate()) < 1 AND can_canjeador = AWANTA.getIdCliente(@tipo_dni, @dni)
UNION ALL
SELECT 'Pasaje', compra_fecha, pas_codigo, compra_cliente, (pas_precio/10) FROM AWANTA.PASAJE JOIN
AWANTA.COMPRA ON compra_id = pas_compra
WHERE DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1 AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXPASAJE WHERE devxp_pasaje = pas_codigo) 
AND pas_pasajero IN (SELECT cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = @tipo_dni)
UNION ALL
 SELECT 'Encomienda', compra_fecha, enc_codigo, compra_cliente, (enc_precio/10) FROM AWANTA.ENCOMIENDA JOIN
AWANTA.COMPRA ON compra_id = enc_compra 
WHERE DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1 AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXENCOMIENDA WHERE devxp_encomienda = enc_codigo)
  AND enc_encomendador IN (SELECT cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = @tipo_dni)
END
GO
EXEC AWANTA.info_millas 'DNI', 1122696
---------------- PRODUCTOS

CREATE FUNCTION AWANTA.get_id_producto(@nombre nvarchar(255)) RETURNS NUMERIC(18)
AS
BEGIN
RETURN (SELECT prod_id FROM AWANTA.PRODUCTO WHERE prod_nombre = @nombre)
END
GO

ALTER PROCEDURE AWANTA.get_productos_disponibles
AS
BEGIN
SELECT prod_nombre, prod_millas, prod_stock FROM AWANTA.PRODUCTO WHERE prod_stock > 0
END
GO


ALTER PROCEDURE AWANTA.canjear_productos(@tipo_dni CHAR(5), @dni NUMERIC(18), @producto nvarchar(255), @cantidad int)
AS
BEGIN
INSERT INTO AWANTA.CANJE(can_fecha, can_canjeador, can_producto, can_cantidad) VALUES (AWANTA.getDate(), AWANTA.getIdCliente(@tipo_dni, @dni), AWANTA.get_id_producto(@producto), @cantidad)
END
GO


------------- CLIENTES

CREATE PROCEDURE AWANTA.existe_cliente(@dni NUMERIC(8))
AS
BEGIN
IF(EXISTS(SELECT 1 FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = 'DNI'))
BEGIN RETURN 1 END RETURN -1 END
GO



--------------------- LISTADOS ESTADISTICOS -------------

ALTER PROCEDURE AWANTA.destinos_pasajes_comprados(@inicio datetime, @fin datetime)
AS
BEGIN
SELECT TOP 5 ciu_nombre FROM AWANTA.PASAJE 
JOIN AWANTA.VIAJE ON pas_viaje = via_codigo
JOIN AWANTA.RUTA_AEREA ON via_ruta_aerea = rut_codigo
JOIN AWANTA.CIUDAD ON rut_destino = ciu_id
WHERE @inicio < via_fecha_salida AND via_fecha_salida < @fin  
GROUP BY ciu_id, ciu_nombre
ORDER BY COUNT(pas_codigo) DESC
END
GO

ALTER PROCEDURE AWANTA.destinos_aeronaves_mas_vacias(@inicio datetime, @fin datetime)
AS
BEGIN
SELECT TOP 5 COUNT(butxv_butaca) FROM AWANTA.PASAJE 
JOIN AWANTA.VIAJE ON pas_viaje = via_codigo
JOIN AWANTA.RUTA_AEREA ON via_ruta_aerea = rut_codigo
JOIN AWANTA.BUTACAXVIAJE ON butxv_viaje = via_codigo
JOIN AWANTA.CIUDAD ON rut_destino = ciu_id
WHERE butxv_ocupada = 0 AND  @inicio < via_fecha_salida AND via_fecha_salida < @fin
GROUP BY ciu_id, ciu_nombre
ORDER BY COUNT(butxv_butaca) DESC
END
GO

CREATE PROCEDURE AWANTA.destinos_con_mas_pasajes_cancelados(@inicio datetime, @fin datetime) AS
BEGIN
SELECT TOP 5 ciu_nombre FROM AWANTA.PASAJE 
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

ALTER PROCEDURE AWANTA.aeronaves_mas_fuera_de_servicio(@inicio datetime, @fin datetime) AS
BEGIN
SELECT TOP 5 COUNT(aero_matricula) FROM AWANTA.AERONAVE
JOIN HISTORICO_BAJAS ON aero_numero = baja_avion
WHERE baja_motivo = 1 AND  @inicio < baja_fecha AND baja_fecha < @fin
ORDER BY COUNT(aero_matricula)
END 
GO

CREATE PROCEDURE AWANTA.clientes_con_mas_millas_acumuladas(@inicio datetime, @fin datetime)
AS
BEGIN
declare @millas_pasajes table (cli_codigo numeric(18), cli_nro_doc numeric(18), cli_nombre varchar(255), cli_apellido varchar(255), millas int)
INSERT INTO @millas_pasajes(cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, millas) (SELECT cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, SUM(pas_precio/10) FROM AWANTA.CLIENTE
	JOIN AWANTA.PASAJE ON pas_pasajero = cli_codigo 
	JOIN AWANTA.COMPRA ON pas_compra = compra_id  AND DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1 
	AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXPASAJE WHERE devxp_pasaje = pas_codigo)
	GROUP BY cli_codigo, cli_nro_doc, cli_nombre, cli_apellido)

declare @millas_encomiendas table (cli_codigo numeric(18), cli_nro_doc numeric(18), cli_nombre varchar(255), cli_apellido varchar(255), millas int)
INSERT INTO @millas_encomiendas(cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, millas) (SELECT cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, SUM(enc_precio/10) FROM AWANTA.CLIENTE
	JOIN AWANTA.ENCOMIENDA ON enc_encomendador = cli_codigo 
	JOIN AWANTA.COMPRA ON enc_compra = compra_id  AND DATEDIFF(YEAR, compra_fecha, AWANTA.getDate()) < 1
	AND NOT EXISTS(SELECT 1 FROM AWANTA.DEVOLUCIONXENCOMIENDA WHERE enc_codigo = devxp_encomienda)
	GROUP BY cli_codigo, cli_nro_doc, cli_nombre, cli_apellido)

declare @millas_canjes  table (cli_codigo numeric(18), cli_nro_doc numeric(18), cli_nombre varchar(255), cli_apellido varchar(255), millas int)
INSERT INTO @millas_canjes(cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, millas)(SELECT cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, SUM(prod_millas * can_cantidad) FROM AWANTA.CLIENTE
JOIN AWANTA.CANJE ON can_canjeador = cli_codigo 
JOIN AWANTA.PRODUCTO ON prod_id = can_producto AND DATEDIFF(YEAR, can_fecha, AWANTA.getDate()) < 1  
	GROUP BY cli_codigo, cli_nro_doc, cli_nombre, cli_apellido)

	declare @millas table (cli_codigo numeric(18), cli_nro_doc numeric(18), cli_nombre varchar(255), cli_apellido varchar(255), millas int)
	INSERT INTO @millas (cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, millas)
	(SELECT cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, millas FROM @millas_encomiendas UNION
	 SELECT cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, millas FROM @millas_pasajes)

	declare @millasPositivas table (cli_codigo numeric(18), cli_nro_doc numeric(18), cli_nombre varchar(255), cli_apellido varchar(255), millas int)
	INSERT INTO @millasPositivas (cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, millas)
	(SELECT cli_codigo, cli_nro_doc, cli_nombre, cli_apellido, SUM(millas) FROM @millas 
	GROUP BY  cli_codigo, cli_nro_doc, cli_nombre, cli_apellido)

	SELECT TOP 5 * FROM @millasPositivas ORDER BY millas DESC

END
GO
select * from awanta.compra
declare @d datetime = DATETIMEFROMPARTS(2016,04,30,0,0,0,0)
declare @dd datetime = awanta.getDate()
EXEC AWANTA.clientes_con_mas_millas_acumuladas  @d, @dd