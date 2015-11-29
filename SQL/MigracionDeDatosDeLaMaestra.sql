USE [GD2C2015]
GO

IF (NOT EXISTS ( SELECT  1 FROM sys.schemas WHERE name = 'AWANTA' )) 
	BEGIN 
    EXEC('CREATE SCHEMA [AWANTA] AUTHORIZATION [gd]')
	END
GO

/*---------------------------DROP DE LAS TABLAS---------------------------*/

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'MILLAS_ACUMULADAS')
	DROP TABLE AWANTA.MILLAS_ACUMULADAS

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'PASAJE')
	DROP TABLE AWANTA.PASAJE

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'ENCOMIENDA')
	DROP TABLE AWANTA.ENCOMIENDA

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'BUTACA')
	DROP TABLE AWANTA.BUTACA

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'DEVOLUCION')
	DROP TABLE AWANTA.DEVOLUCION

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'COMPRA')
	DROP TABLE AWANTA.COMPRA

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'CANJE')
	DROP TABLE AWANTA.CANJE

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'PRODUCTO')
	DROP TABLE AWANTA.PRODUCTO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'CLIENTE')
	DROP TABLE AWANTA.CLIENTE

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'USUARIO')
	DROP TABLE AWANTA.USUARIO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'TERMINAL')
	DROP TABLE AWANTA.TERMINAL

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'TIPO_DE_PAGO')
	DROP TABLE AWANTA.TIPO_DE_PAGO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'FUNC_X_ROL')
	DROP TABLE AWANTA.FUNC_X_ROL

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'FUNCIONALIDAD')
	DROP TABLE AWANTA.FUNCIONALIDAD

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'ROL')
	DROP TABLE AWANTA.ROL

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'VIAJE')
	DROP TABLE AWANTA.VIAJE

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'RUTA_AEREA')
	DROP TABLE AWANTA.RUTA_AEREA

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'AERONAVE')
	DROP TABLE AWANTA.AERONAVE

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'SERVICIO')
	DROP TABLE AWANTA.SERVICIO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'CIUDAD')
	DROP TABLE AWANTA.CIUDAD

/*---------------------------CREACION DE TABLAS Y CONSTRAINTS---------------------------*/


CREATE TABLE AWANTA.CIUDAD
(
	ciu_id numeric(18) identity primary key,
	ciu_nombre nvarchar(255) not null,
)

CREATE TABLE AWANTA.SERVICIO
(
	serv_id_servicio numeric(18) identity primary key,
	serv_nombre nvarchar(255) not null,
	serv_porcentaje_adicional int not null,		
)

CREATE TABLE AWANTA.RUTA_AEREA
(
	rut_codigo numeric(18) identity primary key,
	rut_origen numeric(18) not null foreign key
	references AWANTA.CIUDAD(ciu_id),
	rut_destino numeric(18) not null foreign key
	references AWANTA.CIUDAD(ciu_id),
	rut_tipo_servicio numeric(18) not null foreign key
	references AWANTA.SERVICIO(serv_id_servicio),
	rut_precio_base money not null,
	rut_precio_base_x_kg money not null,
	rut_habilitada bit not null,
)

CREATE TABLE AWANTA.ROL
(
	rol_id numeric(18) identity primary key,
	rol_nombre nvarchar(255) not null,
	rol_funcionalidades nvarchar(255),
	rol_estado bit not null,
)

CREATE TABLE AWANTA.FUNCIONALIDAD
(
	fun_id numeric(18) identity primary key,
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
	usu_id numeric(18) identity primary key,
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
	cli_codigo numeric(18) identity primary key,
	cli_tipo_doc nvarchar(255) not null,
	cli_nro_doc numeric(18) not null,
	cli_nombre nvarchar(255) not null,
	cli_apellido nvarchar(255) not null,
	cli_direccion nvarchar(255) not null,
	cli_telefono numeric(18) not null,
	cli_fecha_nac datetime not null,
	cli_mail nvarchar(255),
	cli_usuario numeric(18) foreign key
	references AWANTA.USUARIO(usu_id),

)

CREATE TABLE AWANTA.PRODUCTO
(
	prod_id numeric(18) identity primary key,
	prod_nombre nvarchar(255) not null,
	prod_puntos bigint not null,
	prod_stock numeric(18),
)

CREATE TABLE AWANTA.CANJE
(
	can_codigo numeric(18) identity primary key,
	can_usuario numeric(18) foreign key
	references AWANTA.CLIENTE(cli_codigo),
	can_producto numeric(18) foreign key
	references AWANTA.PRODUCTO(prod_id),
	can_cantidad numeric(18) not null,
	can_fecha datetime not null,
)

CREATE TABLE AWANTA.BUTACA
(
	but_id numeric(18) identity primary key,
	but_piso int not null,
	but_tipo nvarchar(255) not null,
	but_estado bit not null, 
)

CREATE TABLE AWANTA.AERONAVE
(
	aero_numero_de_aeronave numeric(18) identity primary key,
	aero_matricula nvarchar(255) unique not null,
	aero_modelo nvarchar(255) not null,
	aero_fabricante nvarchar(255) not null,
	aero_id_servicio numeric(18) not null foreign key
	references AWANTA.SERVICIO (serv_id_servicio),
	aero_fecha_de_alta datetime not null,
	aero_baja_fuera_de_servicio datetime,
	aero_fecha_reinicio_servicio datetime,
	aero_fecha_baja_definitiva datetime,
	aero_cantidad_butacas_pasillo int ,
	aero_cantidad_butacas_ventanilla int,
	aero_kgs_disponibles_encomiendas int not null,
	aero_estado bit not null,

)

CREATE TABLE AWANTA.VIAJE
(
	via_codigo numeric(18) identity primary key,
	via_fecha_salida datetime not null,
	via_fecha_llegada datetime,
	via_fecha_llegada_estimada datetime not null,
	via_avion nvarchar(255) foreign key
	references AWANTA.AERONAVE(aero_matricula),
	via_ruta_aerea numeric(18) foreign key
	references AWANTA.RUTA_AEREA(rut_codigo),
	via_cancelado bit,
)

CREATE TABLE AWANTA.TIPO_DE_PAGO
(
	pago_tipo char primary key,
	tarjeta_nro numeric(18),
	tarjeta_codigo_seguridad numeric(18),
	tarjeta_fecha_vencimiento datetime,
	tarjeta_tipo nvarchar(255),

)

CREATE TABLE AWANTA.TERMINAL
(
	terminal_id numeric(18) identity primary key,
	terminal_tipo nvarchar(255),
	tipo_pago char foreign key
	references AWANTA.TIPO_DE_PAGO(pago_tipo)
)

CREATE TABLE AWANTA.COMPRA
(
	compra_id numeric(18) identity primary key,
	compra_viaje numeric(18) foreign key 
	references AWANTA.VIAJE (via_codigo),
	compra_cliente numeric(18) foreign key
	references AWANTA.CLIENTE(cli_codigo),
	compra_terminal numeric(18) foreign key 
	references AWANTA.TERMINAL(terminal_id),
	compra_fecha DATETIME
)


CREATE TABLE AWANTA.PASAJE
(
	pas_codigo numeric(18) identity primary key,
	pas_compra numeric(18) foreign key
	references AWANTA.COMPRA(compra_id),
	pas_butaca numeric(18) foreign key
	references AWANTA.BUTACA(but_id),
)

CREATE TABLE AWANTA.ENCOMIENDA
(
	enc_codigo numeric(18) identity primary key,
	enc_kg int not null,
	enc_compra numeric(18) foreign key
	references AWANTA.COMPRA(compra_id),
)


CREATE TABLE AWANTA.DEVOLUCION
(
	dev_codigo numeric(18) identity primary key,
	dev_motivo nvarchar(255) not null,
	dev_fecha datetime not null,
	dev_pasaje numeric(18)
	references AWANTA.PASAJE(pas_codigo),
	dev_encomienda numeric(18)
	references AWANTA.ENCOMIENDA(enc_codigo)
)

CREATE TABLE AWANTA.MILLAS_ACUMULADAS
(
	cliente_id numeric(18) primary key foreign key
	references AWANTA.CLIENTE(cli_codigo),
	total_millas int not null,
	fecha_vencimiento datetime not null,
)

CREATE TABLE AWANTA.HISTORICO_BAJAS 
(
	baja_codigo NUMERIC(18) identity PRIMARY KEY,
	baja_avion NUMERIC(18) foreign key references AWANTA.AERONAVE(aero_numero_de_aeronave),
	baja_avion_reemplazo NUMERIC(18) foreign key references AWANTA.AERONAVE(aero_numero_de_aeronave),
	baja_fecha DATETIME not null,
	baja_reinicio DATETIME,
	baja_motivo bit,  -- 0 si fue por fin de vida util, 1 si era por mantenimiento
	baja_ciudad NUMERIC(18) -- le pongo la ciudad en la que estaba cuando fue dado de baja
)


/*---------------------------MIGRACION DE LA TABLA MAESTRA---------------------------*/

/*------MIGRACION DE LA TABLA CIUDAD------*/
/*TESTEADO*/
INSERT INTO AWANTA.CIUDAD(ciu_nombre)
	SELECT DISTINCT Ruta_Ciudad_Origen
	FROM gd_esquema.Maestra
	WHERE NOT Ruta_Ciudad_Origen in (SELECT ciu_nombre FROM AWANTA.CIUDAD)
GO

INSERT INTO AWANTA.CIUDAD(ciu_nombre)
	SELECT DISTINCT Ruta_Ciudad_Destino
	FROM gd_esquema.Maestra
	WHERE NOT Ruta_Ciudad_Destino in (SELECT ciu_nombre FROM AWANTA.CIUDAD)
GO

/*------MIGRACION DE LA TABLA SERVICIO------*/

/*CALCULO DE PORCENTAJES ADICIONAL DE RUTA POR TIPO DE SERVICIO*/
/*TESTEADO*/

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

/*TESTEADO*/
INSERT INTO AWANTA.SERVICIO(serv_nombre,serv_porcentaje_adicional) VALUES('Turista',AWANTA.porcentajeDadoUnServicio('Turista'));
GO
INSERT INTO AWANTA.SERVICIO(serv_nombre,serv_porcentaje_adicional) VALUES('Primera Clase',AWANTA.porcentajeDadoUnServicio('Primera Clase'));
GO
INSERT INTO AWANTA.SERVICIO(serv_nombre,serv_porcentaje_adicional) VALUES('Ejecutivo',AWANTA.porcentajeDadoUnServicio('Ejecutivo'));
GO
/*------MIGRACION DE LA TABLA RUTA_AEREA------*/

CREATE FUNCTION AWANTA.buscarIdServicio(@Tipo_Servicio NVARCHAR(255))
RETURNS NUMERIC(18)
AS
	BEGIN
		DECLARE @numeroServicio NUMERIC(18)
			SET @numeroServicio = (SELECT  TOP 1 serv_id_servicio FROM AWANTA.SERVICIO WHERE @Tipo_Servicio = serv_nombre)
		RETURN @numeroServicio
	END 
GO

/*TESTEADO*/


CREATE FUNCTION AWANTA.obtenerIdCiudad(@nombreCiudad NVARCHAR(255))
RETURNS NUMERIC(18)
AS
	BEGIN
		DECLARE @idCiudad NUMERIC(18)   
			SET @idCiudad = (SELECT ciu_id FROM AWANTA.CIUDAD WHERE ciu_nombre LIKE '%' + @nombreCiudad)
		RETURN @idCiudad
	END
GO

/*TESTEADO*/

----va por este lado pero no estoy segura, habria que probrarlo desde el principio 
SET IDENTITY_INSERT AWANTA.RUTA_AEREA ON												
INSERT INTO AWANTA.RUTA_AEREA(rut_codigo, rut_origen, rut_destino,rut_tipo_servicio,rut_precio_base,rut_precio_base_x_kg,rut_habilitada)
	SELECT DISTINCT Ruta_Codigo, AWANTA.obtenerIdCiudad(Ruta_Ciudad_Origen),AWANTA.obtenerIdCiudad(Ruta_Ciudad_Destino),AWANTA.buscarIdServicio(Tipo_Servicio),sum(Ruta_Precio_BasePasaje),sum(Ruta_Precio_BaseKG),1
FROM gd_esquema.Maestra
GROUP BY AWANTA.obtenerIdCiudad(Ruta_Ciudad_Origen),AWANTA.obtenerIdCiudad(Ruta_Ciudad_Destino),AWANTA.buscarIdServicio(Tipo_Servicio)
SET IDENTITY_INSERT AWANTA.RUTA_AEREA OFF 
GO
/*
CREATE TABLE AWANTA.ASD
(
	rut_codigo numeric(18) identity primary key,
	rut_origen numeric(18) not null foreign key
	references AWANTA.CIUDAD(ciu_id),
	rut_destino numeric(18) not null foreign key
	references AWANTA.CIUDAD(ciu_id),
	rut_tipo_servicio numeric(18) not null foreign key
	references AWANTA.SERVICIO(serv_id_servicio),
	rut_precio_base money not null,
	rut_precio_base_x_kg money not null,
	rut_habilitada bit not null,
)



SET IDENTITY_INSERT AWANTA.ASD ON												
INSERT INTO AWANTA.ASD(rut_codigo, rut_origen, rut_destino,rut_tipo_servicio,rut_precio_base,rut_precio_base_x_kg,rut_habilitada)
	SELECT DISTINCT Ruta_Codigo, AWANTA.obtenerIdCiudad(Ruta_Ciudad_Origen),AWANTA.obtenerIdCiudad(Ruta_Ciudad_Destino),AWANTA.buscarIdServicio(Tipo_Servicio),sum(Ruta_Precio_BasePasaje),sum(Ruta_Precio_BaseKG),1
FROM gd_esquema.Maestra
GROUP BY AWANTA.obtenerIdCiudad(Ruta_Ciudad_Origen),AWANTA.obtenerIdCiudad(Ruta_Ciudad_Destino),AWANTA.buscarIdServicio(Tipo_Servicio)
SET IDENTITY_INSERT AWANTA.ASD OFF 
GO

SELECT Ruta_Ciudad_Origen, Ruta_Ciudad_Destino FROM gd_esquema.Maestra */


/*------MIGRACION DE LA TABLA ROL------*/
/*TESTEADO*/
INSERT INTO AWANTA.ROL(rol_nombre,rol_estado)
	VALUES('Administrativo',1)
GO

INSERT INTO AWANTA.ROL(rol_nombre,rol_estado)
	VALUES('Cliente',1)
GO

/*------MIGRACION DE LA TABLA FUNCIONALIDAD------*/
/*TESTEADO*/
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

	/*----FUNCIONALIDADES DEL ADMIN----*/ /*TESTEADO*/
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

	/*----FUNCIONALIDADES DEL CLIENTE----*//*TESTEADO*/
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (7,2)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (9,2)
INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES (10,2)
GO



CREATE PROCEDURE [AWANTA].set_funcionalidades_x_rol(@id_rol numeric(18),@id_funcionalidad numeric(18))
AS
	INSERT INTO AWANTA.FUNC_X_ROL(f_x_r_funcionalidad,f_x_r_rol) VALUES(@id_funcionalidad,@id_rol);
GO
/*EXEC DE ESTE PROCEDURE MAS ABAJO PARA INSERTAR FUNCIONALIDADES PARA CADA ROL*/

/*TODO CREAR INDICES PARA MEJORAR LA PERFORMANCE*/



/*------MIGRACION USUARIO(PROCEDURE PARA INSERCION NO HACE FALTA EL ABM)------*/



CREATE PROCEDURE [AWANTA].insertar_usuario(@username VARCHAR(50), @password VARCHAR(100),@fechaAlta DATETIME)
AS BEGIN
	BEGIN TRY
		INSERT INTO [AWANTA].USUARIO (usu_username, usu_password,usu_estado,usu_fecha_alta,usu_intentos_login) VALUES (@username, @password,'H', @fechaAlta,0)
	END TRY
	BEGIN CATCH
		print '@@error=' print @@error
		/*TODO VER ERROR QUE TIRAR*/
	END CATCH
END
GO

/*------MIGRACION DE LA TABLA CLIENTE------*/
/*TESTEADO*/
INSERT INTO AWANTA.CLIENTE(cli_tipo_doc,cli_nro_doc,cli_nombre,cli_apellido,cli_direccion,cli_telefono,cli_fecha_nac,cli_mail)
SELECT DISTINCT 'DNI',Cli_Dni,Cli_Nombre,Cli_Apellido,Cli_Dir,Cli_Telefono,Cli_Fecha_Nac,Cli_Mail
FROM gd_esquema.Maestra
GO

/*------MIGRACION DE LA TABLA PRODUCTO------*/
/*TESTEADO*/

CREATE PROCEDURE [AWANTA].insertar_nuevo_producto(@nombreProducto NVARCHAR(255),@puntosNecesarios BIGINT,@stockProducto NUMERIC(18))
AS	
	IF NOT EXISTS(SELECT prod_nombre FROM AWANTA.PRODUCTO WHERE prod_nombre=@nombreProducto)
	BEGIN
		INSERT INTO AWANTA.PRODUCTO(prod_nombre,prod_puntos,prod_stock)
		VALUES(@nombreProducto,@puntosNecesarios,@stockProducto);
	END
GO
/*TESTEADO*/
	/*------INSERTO PRODUCTOS INICIALES------*/
EXEC AWANTA.insertar_nuevo_producto 'Televisor LCD',5000,100
EXEC AWANTA.insertar_nuevo_producto 'Notebook',6000,50
EXEC AWANTA.insertar_nuevo_producto 'Home Theatre',4500,60
EXEC AWANTA.insertar_nuevo_producto 'Playstation 4 ',3000,1000
EXEC AWANTA.insertar_nuevo_producto 'Heladera',2500,1000
EXEC AWANTA.insertar_nuevo_producto 'Smartphone',3500,2000
EXEC AWANTA.insertar_nuevo_producto 'Tablet',3000,1500

GO

/*------MIGRACION DE LA TABLA AERONAVE------*/

/*OBTENCION DE CANTIDAD DE BUTACAS DE LA AERONAVE*/


CREATE FUNCTION AWANTA.obtenerButacasDeAeronave(@matricula NVARCHAR(255),@tipoButaca NVARCHAR(255))
RETURNS INT
AS
	BEGIN
		DECLARE @cantidadButacas INT
		SET @cantidadButacas = (SELECT COUNT(DISTINCT Butaca_Nro) FROM gd_esquema.Maestra WHERE Aeronave_Matricula = @matricula
									AND Butaca_Tipo = @tipoButaca)
		RETURN @cantidadButacas
	END
GO

/*TESTEADO*/
INSERT INTO AWANTA.AERONAVE(aero_matricula,aero_modelo,aero_fabricante,aero_id_servicio,aero_fecha_de_alta,aero_kgs_disponibles_encomiendas, aero_estado)
SELECT DISTINCT Aeronave_Matricula,Aeronave_Modelo,Aeronave_Fabricante,AWANTA.buscarIdServicio(Tipo_Servicio),
				(SELECT CONVERT(date,SYSDATETIME())),Aeronave_KG_Disponibles, 1
FROM gd_esquema.Maestra
GO

	/*------MIGRACION DE LA CANTIDAD DE BUTACAS------*/
	/*TESTEADO*/
	DECLARE miCursor CURSOR FOR SELECT aero_matricula FROM AWANTA.AERONAVE
	OPEN miCursor
	DECLARE @matricula NVARCHAR(255)
	DECLARE @cantButacasPasillo INT
	DECLARE @cantButacasVentanilla INT

	FETCH FROM miCursor INTO @matricula

	WHILE @@FETCH_STATUS = 0
		BEGIN
			SET @cantButacasPasillo = (AWANTA.obtenerButacasDeAeronave(@matricula,'Pasillo'))
			SET @cantButacasVentanilla = (AWANTA.obtenerButacasDeAeronave(@matricula,'Ventanilla'))
			UPDATE AWANTA.AERONAVE  
			SET aero_cantidad_butacas_pasillo = @cantButacasPasillo
			WHERE aero_matricula = @matricula;
			UPDATE AWANTA.AERONAVE  
			SET aero_cantidad_butacas_ventanilla = @cantButacasVentanilla
			WHERE aero_matricula = @matricula;

			FETCH FROM miCursor INTO @matricula
		END
	CLOSE miCursor
	DEALLOCATE miCursor
GO			

/*------MIGRACION DE LA TABLA VIAJE------*/
/*TESTEADO*/
INSERT INTO AWANTA.VIAJE(via_fecha_salida,via_fecha_llegada,via_fecha_llegada_estimada,via_avion,via_ruta_aerea)
SELECT FechaSalida,FechaLlegada,Fecha_LLegada_Estimada,Aeronave_Matricula,
			(SELECT TOP 1 rut_codigo FROM AWANTA.RUTA_AEREA 
			 WHERE AWANTA.obtenerIdCiudad(Ruta_Ciudad_Destino) = rut_destino AND 
			 AWANTA.obtenerIdCiudad(Ruta_Ciudad_Origen) = rut_origen)
FROM gd_esquema.Maestra
GO

/*------MIGRACION DE LA TABLA COMPRA revisar!------*//*
INSERT INTO AWANTA.COMPRA(compra_viaje, compra_cliente)
SELECT via_codigo, cli_codigo 
FROM AWANTA.VIAJE JOIN gd_esquema.Maestra ON
via_fecha_salida = FechaSalida JOIN AWANTA.CLIENTE ON
Cli_Dni = cli_nro_doc 

SELECT TOP 2 * FROM AWANTA.VIAJE
DECLARE curs_fechas FOR SELECT Pasaje_FechaCompra FROM gd_esquema.Maestra
JOIN AWANTA.COMPRA ON Pasaje_codigo = compra_id
 SELECT * FROM AWANTA.compra
SELECT * FROM gd_esquema.Maestra
/*TODO BUTACA?*/


INSERT INTO AWANTA.PASAJE(pas_butaca, pas_compra)
SELECT compra_id, Paquete_KG 
FROM gd_esquema.Maestra JOIN AWANTA.VIAJE ON
via_fecha_salida = FechaSalida AND via_fecha_llegada = FechaLLegada JOIN AWANTA.COMPRA ON
via_codigo = compra_viaje
WHERE Butaca_Nro = 0

INSERT INTO AWANTA.ENCOMIENDA(enc_compra, enc_kg)
SELECT compra_id, Paquete_KG 
FROM gd_esquema.Maestra JOIN AWANTA.VIAJE ON
via_fecha_salida = FechaSalida AND via_fecha_llegada = FechaLLegada JOIN AWANTA.COMPRA ON
via_codigo = compra_viaje
WHERE Butaca_Nro = 0 */


-- en la migracion dejamos la fecha original del sistema, porque asi los aviones fueron dados de alta antes de comprar
-- en despues al usar la app siempre es la fecha del 2017, sino no seria consistente con las fechas de llegada.