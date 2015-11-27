USE [GD2C2015]
GO

IF (NOT EXISTS ( SELECT  1 FROM sys.schemas WHERE name = 'AWANTA' )) 
	BEGIN 
    EXEC('CREATE SCHEMA [AWANTA] AUTHORIZATION [gd]')
	END
GO

/*---------------------------DROP DE LAS TABLAS---------------------------*/

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'HISTORICO_BAJAS')
	DROP TABLE AWANTA.HISTORICO_BAJAS

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

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'TIPO_DE_PAGO')
	DROP TABLE AWANTA.TIPO_DE_PAGO

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

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'SERVICIO')
	DROP TABLE AWANTA.SERVICIO

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'AWANTA' AND  TABLE_NAME = 'CIUDAD')
	DROP TABLE AWANTA.CIUDAD
GO
/*---------------------------CREACION DE TABLAS Y CONSTRAINTS---------------------------*/

CREATE FUNCTION AWANTA.getDate() RETURNS DATETIME
AS BEGIN 
RETURN DATETIMEFROMPARTS(2017, 05, 13, 13, 13, 13, 000)
END
GO

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
	rut_precio_base money not null,
	rut_precio_base_x_kg money not null,
	rut_habilitada bit not null,
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
	aero_baja_fuera_de_servicio datetime,
	aero_fecha_reinicio_servicio datetime,
	aero_fecha_baja_definitiva datetime,
	aero_cantidad_butacas_pasillo int, -- estos vendrian a ser el maximo de butacas pasillo y ventanilla que puede tener.
	aero_cantidad_butacas_ventanilla int,
	aero_kgs_disponibles_encomiendas int not null,
	aero_estado bit not null,

)

CREATE TABLE AWANTA.VIAJE
(
	via_codigo numeric(18) identity(1,1) primary key,
	via_fecha_salida datetime not null,
	via_fecha_llegada datetime,
	via_fecha_llegada_estimada datetime not null,
	via_avion numeric(18) foreign key
	references AWANTA.AERONAVE(aero_numero),
	via_ruta_aerea numeric(18) foreign key
	references AWANTA.RUTA_AEREA(rut_codigo),
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
	butxv_viaje numeric(18) foreign key references AWANTA.VIAJE(via_codigo),
	butxv_butaca numeric(18) foreign key references AWANTA.BUTACA(but_id),
	butxv_ocupada bit
	PRIMARY KEY (butxv_viaje, butxv_butaca)
	)

CREATE TABLE AWANTA.TIPO_DE_PAGO
(

	tarjeta_tipo_pago char primary key,
	tarjeta_nro numeric(18),
	tarjeta_codigo_seguridad numeric(18),
	tarjeta_fecha_vencimiento datetime,
	tarjeta_tipo nvarchar(255),
	tarjeta_cliente numeric(18) references AWANTA.CLIENTE(cli_codigo)
)

CREATE TABLE AWANTA.COMPRA
(
	compra_id numeric(18) identity(1,1) primary key,
	compra_cliente numeric(18) foreign key
	references AWANTA.CLIENTE(cli_codigo),
	compra_fecha DATETIME,
	compra_monto numeric(18,2)
)

CREATE TABLE AWANTA.PASAJE
(
	pas_codigo numeric(18) identity (1,1) primary key,
	pas_pasajero numeric(18) foreign key references AWANTA.CLIENTE(cli_codigo),
	pas_compra numeric(18) foreign key references AWANTA.COMPRA(compra_id),
	pas_viaje numeric(18) foreign key references AWANTA.VIAJE(via_codigo),
	pas_butaca numeric(18) foreign key references AWANTA.BUTACA(but_id) 
	-- referencio a la butaca, cuando quiera consultar me fijo en el viaje tambien y en butacas por viaje salta si esta ocupada o no.
)

CREATE TABLE AWANTA.ENCOMIENDA
(
	enc_codigo numeric(18) identity(1,1) primary key,
	enc_kg int not null,
	enc_viaje numeric(18) foreign key references AWANTA.VIAJE(via_codigo),
	enc_encomendador numeric(18) foreign key references AWANTA.CLIENTE(cli_codigo),
	enc_compra numeric(18) foreign key references AWANTA.COMPRA(compra_id),
)


CREATE TABLE AWANTA.DEVOLUCION
(
	dev_codigo numeric(18) identity(1,1) primary key,
	dev_motivo nvarchar(255) not null,
	dev_fecha datetime not null,
	dev_pasaje numeric(18) 
	references AWANTA.PASAJE(pas_codigo),
	dev_encomienda numeric(18)
	references AWANTA.ENCOMIENDA(enc_codigo)
)


CREATE TABLE AWANTA.HISTORICO_BAJAS 
(
	baja_codigo NUMERIC(18) identity (1,1) PRIMARY KEY,
	baja_avion NUMERIC(18) not null foreign key references AWANTA.AERONAVE(aero_numero),
	baja_avion_reemplazo NUMERIC(18) foreign key references AWANTA.AERONAVE(aero_numero),
	baja_fecha DATETIME not null,
	baja_reinicio DATETIME,
	baja_motivo bit,  -- 0 si fue por fin de vida util, 1 si era por mantenimiento
	baja_ciudad NUMERIC(18) -- le pongo la ciudad en la que estaba cuando fue dado de baja
)

GO
/*---------------------------MIGRACION DE LA TABLA MAESTRA---------------------------*/

/*------MIGRACION DE LA TABLA CIUDAD------*/
INSERT INTO AWANTA.CIUDAD(ciu_nombre)
	SELECT DISTINCT Ruta_Ciudad_Origen
	FROM gd_esquema.Maestra
	WHERE NOT EXISTS (SELECT 1 FROM AWANTA.CIUDAD where ciu_nombre = Ruta_Ciudad_Origen)
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

ALTER FUNCTION AWANTA.buscarIdServicio(@Tipo_Servicio NVARCHAR(255))
RETURNS NUMERIC(18)
AS
	BEGIN
		RETURN (SELECT TOP 1 serv_id_servicio FROM AWANTA.SERVICIO WHERE @Tipo_Servicio LIKE '%' + serv_nombre)
	END 
GO

ALTER FUNCTION AWANTA.obtenerIdCiudad(@nombreCiudad NVARCHAR(255))
RETURNS NUMERIC(18)
AS
	BEGIN
		RETURN (SELECT TOP 1 ciu_id FROM AWANTA.CIUDAD WHERE ciu_nombre LIKE '%' + @nombreCiudad)
	END
GO

----- MIGRACION DE RUTAS -------
--decidimos que el precio del pasaje va a ser el maximo que aparecio en la ruta  y que el original lo dejamos como forma de manejar 
-- a las rutas que repetian el mismo codigo, despues para validar que sean distintas comparamos por el resto de los campos.
-- como ahora las rutas que tienen el mismo codigo difieren en origen o destino, en la migracion comparamos directamente por eso.
-- despues no va a ser asi, porque ya utilizamos solo el codigo de la ruta (el auto generado) y no hace falta.  
-- para los servicios, vimos que en la tabla ninguna ruta tiene mas de uno entonces para migrar directamente 
--- añadimos a la asociativa desde aca, pero para la creacion de nuevas rutas se hace distinto. 



DECLARE curs_rutas CURSOR FOR SELECT DISTINCT Ruta_Codigo, AWANTA.obtenerIdCiudad(Ruta_Ciudad_Origen), AWANTA.obtenerIdCiudad(Ruta_Ciudad_Destino),AWANTA.buscarIdServicio(Tipo_Servicio),max(Ruta_Precio_BaseKG),max(Ruta_Precio_BasePasaje)
FROM gd_esquema.Maestra
GROUP BY Ruta_Codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, Tipo_Servicio
ORDER BY Ruta_Codigo
OPEN curs_rutas 
-- sabemos que incrementa de a uno el codigo entonces hacemos lo mismo 
DECLARE @codigo numeric, @origen numeric, @destino numeric, @servicio numeric, @basekg numeric, @basepasaje numeric	
FETCH FROM curs_rutas INTO @codigo, @origen, @destino, @servicio, @basekg, @basepasaje	
WHILE @@FETCH_STATUS = 0
BEGIN						
INSERT INTO AWANTA.RUTA_AEREA(rut_codigo_original, rut_origen, rut_destino, rut_precio_base_x_kg,rut_precio_base,rut_habilitada)
VALUES (@codigo, @origen , @destino, @basekg, @basepasaje, 1)
INSERT INTO AWANTA.SERVICIOXRUTA(servxr_ruta, servxr_servicio) VALUES (SCOPE_IDENTITY(), @servicio)
FETCH FROM curs_rutas INTO @codigo, @origen, @destino, @servicio, @basekg, @basepasaje	
END
CLOSE curs_rutas
DEALLOCATE curs_rutas
GO



/*------MIGRACION DE LA TABLA ROL------*/
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
		INSERT INTO AWANTA.PRODUCTO(prod_nombre,prod_millas,prod_stock)
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

--------- MIGRACION DE LOS FABRICANTES ------------
-- con este trigger sabemos que es unico el nombre, de todas formas lo prohibimos a nivel app. 
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

INSERT INTO AWANTA.MODELO(mod_fabricante,mod_nombre) SELECT AWANTA.getIdFabricante(Aeronave_Fabricante), Aeronave_Modelo from gd_esquema.Maestra group by Aeronave_Fabricante, Aeronave_Modelo order by AWANTA.getIdFabricante(Aeronave_Fabricante)
--------- MIGRACION DE LOS MODELOS ----------------

/*------MIGRACION DE LA TABLA AERONAVE------*/
GO
CREATE FUNCTION AWANTA.getIdModelo(@fabricante NVARCHAR(255), @modelo NVARCHAR(255)) RETURNS NUMERIC
AS BEGIN
RETURN (SELECT mod_id FROM AWANTA.MODELO WHERE mod_fabricante = AWANTA.getIdFabricante(@fabricante) AND mod_nombre = @modelo)
END
GO

---- insertar los modelos de la aeronave --- 
INSERT INTO AWANTA.AERONAVE(aero_modelo) SELECT AWANTA.getIdModelo(Aeronave_Fabricante, Aeronave_Modelo) from gd_esquema.Maestra
GROUP BY Aeronave_Modelo, Aeronave_Fabricante, Tipo_Servicio, Aeronave_Matricula
ORDER BY Aeronave_Matricula
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

/*TESTEADO*/
-- Suponemos que las butacas (cantidad o tipos) no van a ser modificadas. 
/*CREATE TRIGGER tr_butaca_insert ON AWANTA.AERONAVE AFTER INSERT 
AS 
BEGIN
DECLARE @avion NUMERIC, @pasillo INT, @ventanilla INT, @i INT = 0
SELECT @avion = aero_numero, @pasillo = aero_cantidad_butacas_pasillo, @ventanilla = aero_cantidad_butacas_ventanilla FROM inserted
-- luego de esto tengo que insertar tanta cantidad de butacas como haya aviones y asientos. 
WHILE (@i < @pasillo) 
BEGIN
INSERT INTO AWANTA.BUTACA(but_numero, but_tipo, but_aeronave, but_piso) VALUES (@i, 'Pasillo', @avion, 0)
SET @i = @i + 1
END
SET @i = 0 
WHILE (@i < @ventanilla) 
BEGIN 
INSERT INTO AWANTA.BUTACA(but_numero, but_tipo, but_aeronave, but_piso) VALUES (@i, 'Ventanilla', @avion, 0)
SET @i = @i + 1
END
END 
GO*/
------- MIGRACION DE AERONAVES -------

INSERT INTO AWANTA.AERONAVE(aero_matricula,aero_modelo,aero_id_servicio,aero_fecha_de_alta, aero_cantidad_butacas_pasillo, aero_cantidad_butacas_ventanilla, aero_kgs_disponibles_encomiendas, aero_estado)
SELECT Aeronave_Matricula, AWANTA.getIdModelo(Aeronave_Fabricante, Aeronave_Modelo),
AWANTA.buscarIdServicio(Tipo_Servicio), CONVERT(date,AWANTA.getDate()),
AWANTA.obtenerButacasDeAeronave(Aeronave_Matricula, 'Pasillo'), AWANTA.obtenerButacasDeAeronave(Aeronave_Matricula, 'Ventanilla'),
max(Aeronave_KG_Disponibles), 1
FROM gd_esquema.Maestra
GROUP BY Aeronave_Matricula,  Aeronave_Fabricante, Aeronave_Modelo, Tipo_Servicio
GO

-------- MIGRACION DE BUTACAS -------
INSERT INTO AWANTA.BUTACA(but_numero, but_piso, but_tipo, but_aeronave) 
SELECT Butaca_Nro, Butaca_Piso, Butaca_Tipo, (SELECT aero_numero FROM AWANTA.AERONAVE where aero_matricula = Aeronave_Matricula) 
FROM gd_esquema.Maestra WHERE Butaca_Piso = 1 
GROUP BY Aeronave_Matricula, Butaca_Nro, Butaca_Piso, Butaca_Tipo 
GO
-- UNA VEZ INSERTADAS LAS BUTACAS QUE YA HAY, RELLENO LAS QUE QUEDARON EN EL MEDIO QUE NO ESTABAN. 	

/*------MIGRACION DE LA TABLA VIAJE------*/
INSERT INTO AWANTA.VIAJE(via_fecha_salida,via_fecha_llegada,via_fecha_llegada_estimada,via_avion,via_ruta_aerea)
SELECT FechaSalida,FechaLlegada,Fecha_LLegada_Estimada,(SELECT aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = Aeronave_Matricula),
			(SELECT TOP 1 rut_codigo FROM AWANTA.RUTA_AEREA 
			 WHERE (AWANTA.obtenerIdCiudad(Ruta_Ciudad_Destino) = rut_destino) AND 
			 (AWANTA.obtenerIdCiudad(Ruta_Ciudad_Origen) = rut_origen) and (Ruta_Codigo = rut_codigo_original))
FROM gd_esquema.Maestra
GO
------- MIGRACION DE BUTACAS POR VIAJE -------- como no hay otras butacas ahora le ponemos que tome de estas dos tablas, despues se hace diferente.
 /* HACERLO DESPUES DE LA INSERCION DE COMPRA, ENCOMIENDA Y PASAJE ASI DIRECTAMENTE HAGO EL SELECT EN PASAJE. 
 INSERT INTO AWANTA.BUTACAXVIAJE
SELECT aero_numero, but_id, 1 FROM AWANTA.AERONAVE JOIN AWANTA.BUTACA on but_aeronave = aero_numero */
/*------MIGRACION DE LA TABLA COMPRA revisar!------*/

CREATE FUNCTION AWANTA.getIdCliente(@dni numeric(18)) RETURNS NUMERIC(18) AS
BEGIN
RETURN (SELECT top 1 cli_codigo FROM AWANTA.CLIENTE where cli_nro_doc = @dni)
END
GO

----- MIGRACION COMPRA --------
--- en este caso hacemos > 1901 porque es la fecha por defecto que pone sql cuando una fecha es null. 
INSERT INTO AWANTA.COMPRA(compra_cliente, compra_fecha, compra_monto)
SELECT (SELECT TOP 1 cli_codigo FROM AWANTA.CLIENTE WHERE m.Cli_Dni = cli_nro_doc AND m.Cli_Apellido = Cli_Apellido), m.Paquete_FechaCompra, m.Paquete_Precio FROM gd_esquema.Maestra m
where YEAR(m.Paquete_FechaCompra) > 1901 AND Butaca_Tipo = '0'
INSERT INTO AWANTA.COMPRA(compra_cliente, compra_fecha, compra_monto)
SELECT (SELECT TOP 1 cli_codigo FROM AWANTA.CLIENTE WHERE m.Cli_Dni = cli_nro_doc), m.Pasaje_FechaCompra, m.Pasaje_Precio FROM gd_esquema.Maestra m
where YEAR(m.Pasaje_FechaCompra) > 1901 AND Butaca_Tipo <> '0'
GO

SELECT * FROM AWANTA.COMPRA

SELECT COUNT(*) FROM AWANTA.VIAJE
SELECT * FROM gd_esquema.Maestra
/*(SELECT butxv_butaca FROM AWANTA.BUTACAXVIAJE WHERE butxv_viaje =
(SELECT via_codigo FROM AWANTA.VIAJE WHERE via_avion = n.Aeronave_Matricula AND via_fecha_llegada = n.FechaLLegada AND
 via_fecha_llegada_estimada = n.Fecha_LLegada_Estimada AND via_fecha_salida = n.FechaSalida and via_ruta_aerea = (SELECT TOP 1 rut_codigo FROM AWANTA.RUTA_AEREA 
WHERE (AWANTA.obtenerIdCiudad(Ruta_Ciudad_Destino) = rut_destino) AND 
(AWANTA.obtenerIdCiudad(Ruta_Ciudad_Origen) = rut_origen) and (Ruta_Codigo = rut_codigo_original)))) FROM gd_esquema.Maestra n
*/
------ MIGRACION PASAJE ------------
-- mediante queries vimos que no estaban repetidos los pasajes (los codigos) 
SET IDENTITY_INSERT AWANTA.PASAJE ON
INSERT INTO AWANTA.PASAJE(pas_codigo, pas_pasajero, pas_compra, pas_butaca,  pas_viaje)
-- aca elegimos la butaca que pertenece a ese viaje 
SELECT DISTINCT m.Pasaje_Codigo, (SELECT TOP 1 cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = Cli_Dni and Cli_Nombre = cli_nombre), (SELECT TOP 1 compra_id FROM AWANTA.COMPRA WHERE compra_cliente = (SELECT TOP 1 cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = Cli_Dni and Cli_Nombre = cli_nombre) AND compra_fecha = m.Pasaje_FechaCompra AND m.Pasaje_Precio = compra_monto),
 (SELECT but_id FROM AWANTA.BUTACA WHERE but_aeronave IN (SELECT aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = m.Aeronave_Matricula)
AND but_piso = m.Butaca_Piso AND but_numero = m.Butaca_Nro AND m.Butaca_Tipo = but_tipo),
(SELECT top 1 via_codigo FROM AWANTA.VIAJE WHERE via_avion = (SELECT TOP 1 aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = m.Aeronave_Matricula) AND via_fecha_llegada = m.FechaLLegada AND
 via_fecha_llegada_estimada = m.Fecha_LLegada_Estimada AND via_fecha_salida = m.FechaSalida and via_ruta_aerea = (SELECT TOP 1 rut_codigo FROM AWANTA.RUTA_AEREA 
WHERE (SELECT ciu_id FROM AWANTA.CIUDAD where ciu_nombre = m.Ruta_Ciudad_Origen) = rut_origen AND 
(SELECT ciu_id FROM AWANTA.CIUDAD where ciu_nombre = m.Ruta_Ciudad_Destino) = rut_destino and (m.Ruta_Codigo = rut_codigo_original))) FROM gd_esquema.Maestra m
where m.Pasaje_Codigo != 0 
SET IDENTITY_INSERT AWANTA.PASAJE OFF

SET IDENTITY_INSERT AWANTA.ENCOMIENDA ON 
INSERT INTO AWANTA.ENCOMIENDA(enc_codigo, enc_encomendador, enc_compra, enc_kg, enc_viaje)
SELECT DISTINCT m.Paquete_Codigo, (SELECT TOP 1 cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = Cli_Dni and Cli_Nombre = cli_nombre), (SELECT TOP 1 compra_id FROM AWANTA.COMPRA WHERE compra_cliente = (SELECT TOP 1 cli_codigo FROM AWANTA.CLIENTE WHERE cli_nro_doc = Cli_Dni and Cli_Nombre = cli_nombre) AND compra_fecha = m.Paquete_FechaCompra AND m.Paquete_Precio = compra_monto), m.Paquete_KG,
(SELECT top 1 via_codigo FROM AWANTA.VIAJE WHERE via_avion = (SELECT TOP 1 aero_numero FROM AWANTA.AERONAVE WHERE aero_matricula = m.Aeronave_Matricula) AND via_fecha_llegada = m.FechaLLegada AND
 via_fecha_llegada_estimada = m.Fecha_LLegada_Estimada AND via_fecha_salida = m.FechaSalida and via_ruta_aerea = (SELECT TOP 1 rut_codigo FROM AWANTA.RUTA_AEREA 
WHERE (SELECT ciu_id FROM AWANTA.CIUDAD where ciu_nombre = m.Ruta_Ciudad_Origen) = rut_origen AND 
(SELECT ciu_id FROM AWANTA.CIUDAD where ciu_nombre = m.Ruta_Ciudad_Destino) = rut_destino and (m.Ruta_Codigo = rut_codigo_original))) FROM gd_esquema.Maestra m
where m.Pasaje_Codigo = 0 
SET IDENTITY_INSERT AWANTA.ENCOMIENDA OFF

--- Como vimos que no hay ningun registro con una fecha de llegada, quiere decir que todos los aviones registrados ya llegaron, por lo tanto no vamos a
-- poner esas butacas en butaca por viaje porque no lo necesitamos, los viajes ya pasaron, es simplemente registrarlo.
-- en cambio para los nuevos viajes si se van a registrar. 
-- en la migracion dejamos la fecha original del sistema, porque asi los aviones fueron dados de alta antes de comprar
-- en despues al usar la app siempre es la fecha del 2017, sino no seria consistente con las fechas de llegada.


/*----------STORED PROCEDURES APLICACION----------*/ 
GO


 exec sp_addmessage @msgnum = 50013, @severity = 1, @msgtext = 'El usuario ya esta repetido', @lang = us_english
 GO




/*------LOGIN------*/

ALTER PROCEDURE AWANTA.registrar_usuario(@usuario NVARCHAR(255), @password NVARCHAR(255), @rol BIT)
AS
BEGIN
INSERT INTO AWANTA.USUARIO(usu_username, usu_estado, usu_fecha_alta, usu_intentos_login, usu_rol, usu_password) VALUES(@usuario, 0, AWANTA.getDate(), 0, @rol, HASHBYTES('SHA2_256', @password))
END
GO

EXEC AWANTA.registrar_usuario 'admin667', 'w23e', 1
go
EXEC AWANTA.registrar_usuario 'admin666', 'w23e', 1
go

alter TRIGGER AWANTA.username_repetido ON AWANTA.USUARIO INSTEAD OF INSERT
AS BEGIN TRANSACTION
IF (EXISTS(SELECT 1 FROM AWANTA.USUARIO WHERE usu_username = (SELECT usu_username FROM inserted)))
BEGIN 
ROLLBACK
RAISERROR(50013, 1, 1, 'Usuario repetido')
RETURN
END 
INSERT INTO AWANTA.USUARIO SELECT usu_username, usu_estado, usu_fecha_alta, usu_intentos_login, usu_rol, usu_password FROM INSERTED 
COMMIT
GO

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
ALTER PROCEDURE AWANTA.validar_usuario(@username NVARCHAR(255), @password VARBINARY(32), @rol NVARCHAR(255))
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

ALTER PROCEDURE AWANTA.get_estado_usuario(@nombre_usuario NVARCHAR(255))
AS BEGIN
IF EXISTS (SELECT 1 FROM AWANTA.USUARIO WHERE usu_username = @nombre_usuario AND usu_estado = 1)
BEGIN RETURN 1 END RETURN -1
END
GO


ALTER PROCEDURE AWANTA.get_rol_usuario(@nombre_usuario NVARCHAR(255)) 
AS BEGIN
IF (EXISTS (SELECT 1 FROM AWANTA.USUARIO WHERE @nombre_usuario = usu_username AND usu_rol = 1))
BEGIN RETURN 1 END RETURN 2 
END
GO

ALTER PROCEDURE AWANTA.inhabilitar_usuario(@nombre_usuario NVARCHAR(255))
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
ALTER PROCEDURE AWANTA.get_funcionalidades(@rol nvarchar(255))
AS
BEGIN
	SELECT fun_id, fun_descripcion FROM AWANTA.FUNCIONALIDAD, AWANTA.FUNC_X_ROL, AWANTA.ROL
	WHERE fun_id = f_x_r_funcionalidad AND
	f_x_r_rol = rol_id AND
	rol_nombre = @rol
END
GO

ALTER PROCEDURE AWANTA.get_funcionalidades_que_no_tiene(@rol nvarchar(255))
AS
BEGIN 
SELECT fun_id, fun_descripcion FROM AWANTA.FUNCIONALIDAD
WHERE NOT EXISTS (SELECT 1 FROM AWANTA.FUNC_X_ROL, AWANTA.ROL
	WHERE f_x_r_funcionalidad = fun_id AND 
	f_x_r_rol = rol_id AND
	rol_nombre = @rol)
END
GO


ALTER PROCEDURE AWANTA.get_roles
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

ALTER PROCEDURE AWANTA.get_id_funcionalidad(@func NVARCHAR(255))
AS
BEGIN
SELECT TOP 1 fun_id FROM AWANTA.FUNCIONALIDAD WHERE fun_descripcion = @func
END
GO


ALTER PROCEDURE AWANTA.crear_rol(@descripcion nvarchar(255), @estado bit)
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

ALTER PROCEDURE AWANTA.asignar_funcionalidad_a_rol (@rol nvarchar(255), @func nvarchar(255))
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

ALTER PROCEDURE AWANTA.borrar_funcionalidad(@rol nvarchar(255), @descripcion_func nvarchar(255))
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
 @habilitada int = 1,  @precio_base_kg money = null, @precio_base_pasaje money = null)
AS 
BEGIN
	SELECT rut_codigo, AWANTA.obtenerNombreCiudad(rut_origen), AWANTA.obtenerNombreCiudad(rut_destino), serv_nombre, rut_habilitada, rut_precio_base_x_kg, rut_precio_base
	FROM AWANTA.RUTA_AEREA
	JOIN AWANTA.SERVICIOXRUTA ON servxr_ruta = rut_codigo
	JOIN AWANTA.SERVICIO ON servxr_servicio = serv_id_servicio
	WHERE (rut_habilitada = @habilitada) AND
	(@destino IS NULL OR rut_destino=AWANTA.obtenerIdCiudad(@destino)) AND
	(@origen IS NULL OR rut_origen=AWANTA.obtenerIdCiudad(@origen)) AND
	(@precio_base_pasaje IS NULL OR rut_precio_base=@precio_base_pasaje) AND
	(@precio_base_kg IS NULL OR rut_precio_base_x_kg=@precio_base_kg) AND
	(@servicio IS NULL OR servxr_servicio=AWANTA.buscarIdServicio(@servicio))
END

GO
ALTER PROCEDURE AWANTA.modificar_ruta(@codigo NUMERIC, @origen nvarchar(255),  @destino nvarchar(255),  @habilitada int, @servicio nvarchar(255), @precio_base_kg money, @precio_base_pasaje money) AS
 BEGIN
 DECLARE @id_servicio NUMERIC(18)
 SET @id_servicio = AWANTA.buscarIdServicio(@servicio)
 UPDATE AWANTA.RUTA_AEREA SET rut_origen = AWANTA.obtenerIdCiudad(@origen), rut_destino = AWANTA.obtenerIdCiudad(@destino),
  rut_habilitada = @habilitada, rut_precio_base_x_kg = @precio_base_kg, rut_precio_base = @precio_base_pasaje
 WHERE @codigo = rut_codigo 
 END
 GO


ALTER PROCEDURE AWANTA.altaRutaAerea(@ciudadOrigen NVARCHAR(255), @ciudadDestino NVARCHAR(255), @tipoServicio NVARCHAR(255), @rutaPrecioBasePasaje MONEY, @rutaPrecioBaseKilo MONEY, @habilitada bit)
AS
	BEGIN
		INSERT INTO AWANTA.RUTA_AEREA(rut_origen,rut_destino,rut_precio_base,rut_precio_base_x_kg, rut_habilitada)
		VALUES (AWANTA.obtenerIdCiudad(@ciudadOrigen),AWANTA.obtenerIdCiudad(@ciudadDestino),
					@rutaPrecioBasePasaje,@rutaPrecioBaseKilo, @habilitada)
					RETURN 1
	END
GO

ALTER PROCEDURE AWANTA.darDeBajaPasajesAsociadosPorBajaDeRutaAerea(@ruta NUMERIC(18))
AS		
	BEGIN
	UPDATE AWANTA.VIAJE SET via_cancelado = 0 WHERE via_ruta_aerea = @ruta -- en un trigger mejor me parece
	DELETE FROM AWANTA.COMPRA WHERE EXISTS (SELECT 1 FROM AWANTA.VIAJE, AWANTA.ENCOMIENDA, AWANTA.PASAJE 
	WHERE (enc_viaje = via_codigo OR pas_viaje = via_codigo)
		 AND via_fecha_salida > (SELECT CONVERT(date,AWANTA.getDate()))
										AND via_ruta_aerea = @ruta)
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


ALTER PROCEDURE AWANTA.bajaRutaAerea(@codigo NUMERIC(18))
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
	(@servicio IS NULL OR rut_tipo_servicio = AWANTA.buscarIdServicio(@servicio)))
	RETURN @codigo
END
GO

/*------ABM DE AERONAVES------*/

ALTER PROCEDURE AWANTA.get_aeronaves(@estado numeric(1) = null, @filtro nvarchar(255) = null)
AS
BEGIN
SET @estado = nullif(@estado, 0)
SELECT aero_matricula, aero_modelo, aero_fabricante, serv_nombre, aero_cantidad_butacas_pasillo, aero_cantidad_butacas_ventanilla, aero_kgs_disponibles_encomiendas,
	 aero_estado, aero_fecha_de_alta, aero_fecha_baja_definitiva, aero_baja_fuera_de_servicio, aero_fecha_reinicio_servicio FROM AWANTA.AERONAVE
	JOIN AWANTA.SERVICIO ON serv_id_servicio = aero_id_servicio
	AND (@estado IS NULL OR @estado = aero_estado) AND (@filtro IS NULL OR @filtro = serv_nombre)
END
GO

CREATE PROCEDURE AWANTA.get_aeronaves_filtradas(@numero numeric(1), @filtro nvarchar(255))
AS 
BEGIN
SELECT * FROM AWANTA.AERONAVE
END
GO

ALTER PROCEDURE AWANTA.get_all_aeronaves(@numero numeric(18) = null, @modelo nvarchar(255) = null, @matricula nvarchar(255) = null,
 @butacas_pasillo numeric(18) = null, @butacas_ventanilla numeric(18) = null, @kilos_disponibles numeric(18) = null,
 @fabricante nvarchar(255) = null, @fecha_alta date = null, @fecha_baja_temporal date = null, 
@fecha_alta_temporal date = null, @fecha_baja_definitiva date = null)
AS 
BEGIN
	SELECT aero_matricula, aero_cantidad_butacas_pasillo, aero_cantidad_butacas_ventanilla, aero_kgs_disponibles_encomiendas, 
	aero_fabricante, aero_fecha_de_alta, aero_baja_fuera_de_servicio, aero_fecha_reinicio_servicio, aero_fecha_baja_definitiva, serv_nombre, aero_estado
	FROM AWANTA.AERONAVE, AWANTA.SERVICIO
	WHERE (@modelo IS NULL OR aero_modelo=@modelo) AND
	(@matricula IS NULL OR aero_matricula=@matricula) AND
	(@butacas_pasillo IS NULL OR aero_cantidad_butacas_pasillo=@butacas_pasillo) AND
	(@butacas_ventanilla IS NULL OR aero_cantidad_butacas_ventanilla=@butacas_ventanilla) AND
	(@kilos_disponibles IS NULL OR aero_kgs_disponibles_encomiendas=@kilos_disponibles) AND
	(@fabricante IS NULL OR aero_fabricante=@fabricante) AND
	(@fecha_alta IS NULL OR aero_fecha_de_alta=@fecha_alta) AND
	(@fecha_baja_temporal IS NULL OR aero_baja_fuera_de_servicio=@fecha_baja_temporal) AND
	(@fecha_alta_temporal IS NULL OR aero_fecha_reinicio_servicio=@fecha_alta_temporal) AND
	(@fecha_baja_definitiva IS NULL OR aero_fecha_baja_definitiva=@fecha_baja_definitiva) AND
	(@numero IS NULL OR aero_numero=@numero) AND
	aero_id_servicio = serv_id_servicio
END
GO 


ALTER PROCEDURE AWANTA.altaDeAeronave(@matricula NVARCHAR(255),@modelo NVARCHAR(255),@fabricante NVARCHAR(255),@servicio NVARCHAR(255),
											@butacasPasillo INT,@butacasVentanilla INT,@kilosDisponibles INT)
AS
	BEGIN
		IF NOT EXISTS (SELECT 1 FROM AWANTA.AERONAVE WHERE @matricula = aero_matricula)
			BEGIN
			
				INSERT INTO AWANTA.AERONAVE (aero_matricula,aero_modelo,aero_fabricante,aero_id_servicio, aero_fecha_de_alta,
				aero_cantidad_butacas_pasillo,aero_cantidad_butacas_ventanilla,aero_kgs_disponibles_encomiendas, aero_estado)

				VALUES (@matricula,@modelo,@fabricante,AWANTA.buscarIdServicio(@servicio), AWANTA.getDate(), @butacasPasillo,@butacasVentanilla,@kilosDisponibles, 1)
				RETURN(0)
			END
			RETURN -1 
	END
GO
SELECT aero_matricula FROM AWANTA.AERONAVE 
EXEC AWANTA.altaDeAeronave 'GGG-666', asd, asdd, 'Ejecutivo', 2, 2 , 234
GO
ALTER PROCEDURE AWANTA.bajaDeViajesAsociadosConAeronave(@numero NVARCHAR(255))
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
		JOIN AERONAVE ON aero_matricula = via_avion AND aero_numero = @aero_numero_de_aeronave 
		WHERE ((via_fecha_salida > @fechaBaja AND via_fecha_salida < @fechaReinicio) 
													OR (via_fecha_llegada > @fechaBaja AND via_fecha_llegada < @fechaReinicio)))
			BEGIN
			-- devuelve -1
				RETURN (-1)
			END
	RETURN (0)
	END
GO

ALTER FUNCTION AWANTA.hay_aeronaves_disponibles(@fechaSalida DATETIME, @fechaEstimadaLlegada DATETIME) RETURNS INT
AS 
BEGIN
IF (EXISTS(SELECT 1 FROM AWANTA.AERONAVE JOIN AWANTA.VIAJE ON via_avion = aero_matricula
WHERE (SELECT AWANTA.tieneViajesAsignados(aero_numero, @fechaSalida, @fechaEstimadaLlegada)) = 0
AND aero_estado = 1 AND aero_fecha_de_alta < @fechaSalida))
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
(SELECT DISTINCT aero_matricula FROM AWANTA.AERONAVE JOIN AWANTA.VIAJE ON via_avion = aero_matricula
WHERE (SELECT AWANTA.tieneViajesAsignados(aero_numero, @fechaSalida, @fechaEstimadaLlegada)) = 0
AND aero_estado = 1 AND aero_fecha_de_alta < @fechaSalida)
END
RETURN -1
END
GO

SELECT * FROM AWANTA.RUTA_AEREA  ORDER BY rut_origen, rut_destino
GO
 
ALTER PROCEDURE AWANTA.existeAeronaveQueReemplace(@matricula NVARCHAR(255))
AS
	BEGIN
	IF EXISTS(SELECT 1 FROM AWANTA.AERONAVE aero_reemplazo, AWANTA.AERONAVE aero_orig
	WHERE @matricula = aero_orig.aero_matricula AND aero_reemplazo.aero_fabricante = aero_orig.aero_fabricante AND aero_reemplazo.id_servicio = aero_orig.id_servicio AND aero_orig.aero_modelo = aero_reemplazo.aero_modelo
	AND aero_orig.aero_matricula <> aero_reemplazo.aero_matricula)
	BEGIN
	RETURN 1
	END
	RETURN -1  
END
GO


ALTER PROCEDURE AWANTA.reemplazoDeAeronaveEnViajes (@numero NUMERIC(18), @fechaReinicio DATETIME)
AS
	BEGIN
	DECLARE @numeroAvionDeReemplazo NUMERIC(18), @matriculaAvionDeReemplazo NVARCHAR(255)
	-- hallo la que va a reemplazar 
	SELECT @numeroAvionDeReemplazo = aero_reemplazo.aero_numero, @matriculaAvionDeReemplazo = aero_reemplazo.aero_matricula FROM AWANTA.AERONAVE aero_reemplazo, AWANTA.AERONAVE aero_orig
	WHERE aero_reemplazo.aero_fabricante = aero_orig.aero_fabricante AND aero_reemplazo.aero_id_servicio = aero_orig.aero_id_servicio AND aero_orig.aero_modelo = aero_reemplazo.aero_modelo
	AND aero_orig.aero_matricula <> aero_reemplazo.aero_matricula AND aero_reemplazo.aero_estado = 1 AND 
	(SELECT AWANTA.tieneViajesAsignados(aero_reemplazo.aero_numero, aero_orig.aero_baja_fuera_de_servicio, aero_orig.aero_fecha_reinicio_servicio)) = 0
	
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
		IF (@numero IS NOT NULL)
			IF (@reemplazo = 1)
				BEGIN
					DECLARE @fecha  SMALLDATETIME
					SET @fecha = AWANTA.getDate()
					-- REEMPLAZAR LA AERONAVE CON OTRA SI SE QUERIA REEMPLAZAR 
					EXEC AWANTA.reemplazoDeAeronaveEnViajes @numero,@fecha
				END
			ELSE
				BEGIN
					UPDATE AWANTA.AERONAVE
					SET aero_fecha_baja_definitiva = (SELECT CONVERT(date,AWANTA.getDate())), aero_estado = 0
					WHERE aero_numero = @numero
					-- CANCELAR LOS VIAJES DE ESA AERONAVE SI NO SE QUERIA REEMPLAZAR
					EXEC AWANTA.bajaDeViajesAsociadosConAeronave @numero
					RETURN(0)
				END
		ELSE RETURN (-2) --ERROR EN LA INSERCION, NO SE COMO MANDARLO
		RETURN(-1)
	END
GO


ALTER PROCEDURE AWANTA.bajaLogicaDeAeronavePorMantenimiento(@matricula NVARCHAR(255),@fechaReinicio DATETIME,@reemplazo INT)
AS
	BEGIN
		DECLARE @numero NUMERIC
		SELECT @numero = aero_numero FROM AWANTA.AERONAVE WHERE @matricula = aero_matricula
		IF (@numero IS NOT NULL)
			BEGIN
				UPDATE AWANTA.AERONAVE
				SET aero_baja_fuera_de_servicio = (SELECT CONVERT(date,AWANTA.getDate())),
				aero_fecha_reinicio_servicio = @fechaReinicio,
				aero_estado = 0
				WHERE aero_numero = @numero
				--Me fijo si hay que cancelar los viajes o reemplazarlos
				--SI ES 1 REEMPLAZO SINO 0 PARA CANCELACION
				IF (@reemplazo = 1)
					BEGIN
						EXEC AWANTA.reemplazoDeAeronaveEnViajes @numero,@fechaReinicio
					END
				ELSE
					BEGIN
						EXEC AWANTA.bajaDeViajesAsociadosConAeronave @matricula
					END
			END
		RETURN(-1)
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
@cantidadKgsEncomiendas numeric, @cantidadButacasVentanilla  numeric, @cantidadButacasPasillo numeric, @estado bit) 
AS 
BEGIN
IF EXISTS(SELECT 1 FROM AWANTA.AERONAVE WHERE aero_matricula = @matricula AND aero_numero <> @numero) BEGIN RETURN -1 END
DECLARE @numero_servicio NUMERIC(18), @matricula_vieja NVARCHAR(255)
SELECT @matricula_vieja = aero_matricula FROM AWANTA.AERONAVE WHERE aero_numero = @numero
SELECT @numero_servicio = serv_id_servicio FROM SERVICIO WHERE serv_nombre = @servicio
ALTER TABLE AWANTA.VIAJE NOCHECK CONSTRAINT ALL
UPDATE AWANTA.AERONAVE 
SET aero_matricula = @matricula, aero_modelo = @modelo, aero_fabricante = @fabricante, aero_id_servicio = @numero_servicio,
aero_kgs_disponibles_encomiendas = @cantidadKgsEncomiendas, aero_cantidad_butacas_ventanilla = @cantidadButacasVentanilla, 
aero_cantidad_butacas_pasillo = @cantidadButacasPasillo, aero_estado = @estado
WHERE aero_numero = @numero
UPDATE AWANTA.VIAJE SET via_avion = @matricula WHERE via_avion = @matricula_vieja
ALTER TABLE AWANTA.VIAJE CHECK CONSTRAINT ALL 
END
GO 

ALTER FUNCTION AWANTA.es_aprox_esa_fecha(@fechaLlegada DATETIME, @fechaLlegadaEstimada DATETIME)
RETURNS INT
AS 
BEGIN
IF (DATEDIFF(MINUTE, @fechaLlegadaEstimada, @fechaLlegada) BETWEEN -10 AND 10) BEGIN RETURN 1 END RETURN -1 END
GO
-- PARA SABER SI UNA AERONAVE, CIUDAD ORIGEN Y DESTINO Y LLEGADA SE CORRESPONDEN CON ESA FECHA
ALTER PROCEDURE AWANTA.aeronave_coincide_registro(@matricula NVARCHAR(255), @origen NVARCHAR(255), @destino NVARCHAR(255), @llegada DATETIME)
AS 
BEGIN
IF(EXISTS(SELECT 1 FROM AWANTA.AERONAVE 
JOIN AWANTA.VIAJE ON via_avion = aero_matricula
JOIN AWANTA.RUTA_AEREA ON via_ruta_aerea = rut_codigo AND rut_origen = AWANTA.obtenerIdCiudad(@origen) AND rut_destino = AWANTA.obtenerIdCiudad(@destino)
WHERE aero_matricula = @matricula AND (AWANTA.es_aprox_esa_fecha(@llegada, via_fecha_llegada_estimada) = 1)))
BEGIN RETURN 1 END RETURN -1
END 
GO 

-- A NIVEL DE LA APLICACION, DIRECTAMENTE NO DEJAMOS QUE EL USUARIO INGRESE A LA DATA GRID UN VIAJE QUE YA FUE REGISTRADO COMO LLEGADA
CREATE PROCEDURE AWANTA.aeronave_ya_registrada(@matricula NVARCHAR(255), @origen NVARCHAR(255), @destino NVARCHAR(255), @llegada DATETIME) AS 
BEGIN
IF (EXISTS(SELECT 1 FROM AWANTA.AERONAVE 
JOIN AWANTA.VIAJE ON via_avion = aero_matricula
JOIN AWANTA.RUTA_AEREA ON via_ruta_aerea = rut_codigo AND rut_origen = AWANTA.obtenerIdCiudad(@origen) AND rut_destino = AWANTA.obtenerIdCiudad(@destino)
WHERE aero_matricula = @matricula AND (AWANTA.es_aprox_esa_fecha(@llegada, via_fecha_llegada_estimada) = 1) AND via_fecha_llegada IS NOT NULL))
BEGIN RETURN 1 END RETURN -1 END 
GO

ALTER PROCEDURE AWANTA.registrar_llegada_viaje(@matricula NVARCHAR(255), @origen NVARCHAR(255), @destino NVARCHAR(255), @llegada DATETIME)
AS
BEGIN
UPDATE V SET via_fecha_llegada = @llegada FROM AWANTA.AERONAVE 
JOIN AWANTA.VIAJE V ON V.via_avion = aero_matricula
JOIN AWANTA.RUTA_AEREA ON V.via_ruta_aerea = rut_codigo AND rut_origen = AWANTA.obtenerIdCiudad(@origen) AND rut_destino = AWANTA.obtenerIdCiudad(@destino)
WHERE aero_matricula = @matricula AND (AWANTA.es_aprox_esa_fecha(@llegada, V.via_fecha_llegada_estimada) = 1)
END
GO




EXEC AWANTA.validar_usuario 'admin666', 'w23e', 'Administrativo'
 GO
/*------ALTA VIAJE------*/

ALTER PROCEDURE AWANTA.get_rutas(@aeronave NVARCHAR(255))
AS 
BEGIN
SELECT rut_codigo, o.ciu_nombre as origen, d.ciu_nombre as destino, serv_nombre as servicio, rut_precio_base, rut_precio_base_x_kg FROM AWANTA.RUTA_AEREA JOIN AWANTA.SERVICIO ON
rut_tipo_servicio = serv_id_servicio
JOIN AWANTA.AERONAVE ON aero_matricula = @aeronave AND rut_tipo_servicio = aero_id_servicio
JOIN AWANTA.CIUDAD d ON rut_destino = d.ciu_id
JOIN AWANTA.CIUDAD o ON rut_origen = o.ciu_id
WHERE rut_habilitada = 1
ORDER BY rut_codigo
END
GO

CREATE PROCEDURE AWANTA.get_viajes(@fecha date, @origen nvarchar(255), @destino nvarchar(255))
AS
BEGIN
	SELECT via_codigo, AWANTA.obtenerNombreCiudad(rut_origen), AWANTA.obtenerNombreCiudad(rut_destino), aero_matricula
	
	FROM AWANTA.VIAJE, AWANTA.RUTA_AEREA, AWANTA.AERONAVE
	WHERE YEAR(via_fecha_salida) = YEAR(@fecha) AND
	MONTH(via_fecha_salida) = MONTH(@fecha) AND
	DAY(via_fecha_salida) = DAY(@fecha) AND
	via_ruta_aerea = rut_codigo AND
	rut_origen = AWANTA.obtenerIdCiudad(@origen) AND
	rut_destino = AWANTA.obtenerIdCiudad(@destino) AND
	via_avion = aero_numero
END
GO

ALTER PROCEDURE AWANTA.create_viaje(@avion nvarchar(255), @llegada_estimada date, @salida date, @ruta numeric)
AS
BEGIN
	DECLARE @serv_viaje numeric(18), @serv_avion numeric(18)
	SET @serv_viaje = (SELECT TOP 1 rut_tipo_servicio FROM AWANTA.RUTA_AEREA WHERE rut_codigo = @ruta)
	SET  @serv_avion = (SELECT TOP 1 aero_id_servicio FROM AWANTA.AERONAVE WHERE aero_matricula = @avion)
	
	DECLARE @avion_libre int
	SET @avion_libre = (SELECT count(1) FROM AWANTA.AERONAVE, AWANTA.VIAJE WHERE aero_matricula = @avion AND aero_matricula = via_avion AND
							via_fecha_llegada_estimada BETWEEN @salida AND @llegada_estimada)

	IF(@serv_viaje = @serv_avion AND @avion_libre = 0)
		BEGIN
		
			INSERT INTO AWANTA.VIAJE(via_avion, via_fecha_llegada_estimada, via_fecha_salida, via_ruta_aerea)
			VALUES(@avion, @llegada_estimada, @salida, @ruta)
			RETURN 1
		END

			RETURN -1
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
	WHERE via_avion = AWANTA.obtenerCodigoAeronave(@avion) AND
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
	(SELECT terminal_id FROM AWANTA.TERMINAL 
	WHERE terminal_tipo = @terminal))

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

/*------MILLAS VIAJERO------*/


/*

CREATE PROCEDURE get_millas_cliente(@dni nvarchar(255))
AS
BEGIN
	SELECT FROM AWANTA.CLIENTE 
	JOIN AWANTA.COMPRA ON compra_cliente = cli_codigo
	JOIN AWANTA.PASAJE ON compra_id = pas_compra
	JOIN AWANTA.ENCOMIENDA ON compra_id = enc_compra
	WHERE datediff(YEAR, AWANTA.getDate(), compra_) < 1

*/

---------------- PRODUCTOS
CREATE PROCEDURE AWANTA.get_productos_disponibles
AS
BEGIN
SELECT prod_nombre FROM AWANTA.PRODUCTO WHERE prod_stock > 0
END
GO

ALTER PROCEDURE AWANTA.get_stock_producto(@prod NVARCHAR(255))
AS
BEGIN
RETURN (SELECT TOP 1 prod_stock FROM AWANTA.PRODUCTO WHERE prod_nombre = @prod)
END
GO

ALTER PROCEDURE AWANTA.get_puntos_producto(@prod NVARCHAR(255))
AS
BEGIN
RETURN (SELECT TOP 1 prod_puntos FROM AWANTA.PRODUCTO WHERE prod_nombre = @prod)
END
GO

------------- CLIENTES

CREATE PROCEDURE AWANTA.existe_cliente(@dni NUMERIC(8))
AS
BEGIN
IF(EXISTS(SELECT 1 FROM AWANTA.CLIENTE WHERE cli_nro_doc = @dni AND cli_tipo_doc = 'DNI'))
BEGIN RETURN 1 END RETURN -1 END
GO

SELECT count(1) AS AERONAVE FROM AWANTA.AERONAVE
SELECT count(1) AS BUTACA FROM AWANTA.BUTACA
SELECT count(1) AS CANJE FROM AWANTA.CANJE
SELECT count(1) AS CIUDAD FROM AWANTA.CIUDAD
SELECT count(1) AS CLIENTE FROM AWANTA.CLIENTE
SELECT count(1) AS COMPRA FROM AWANTA.COMPRA
SELECT count(1) AS DEVOLUCION FROM AWANTA.DEVOLUCION
SELECT count(1) AS ENCOMIENDA FROM AWANTA.ENCOMIENDA
SELECT count(1) AS FUNC_X_ROL FROM AWANTA.FUNC_X_ROL
SELECT count(1) AS FUNCIONALIDAD FROM AWANTA.FUNCIONALIDAD
SELECT count(1) AS PASAJE FROM AWANTA.PASAJE
SELECT count(1) AS PRODUCTO FROM AWANTA.PRODUCTO
SELECT count(1) AS ROL FROM AWANTA.ROL
SELECT count(1) AS RUTA FROM AWANTA.RUTA_AEREA
SELECT count(1) AS SERVICIO FROM AWANTA.SERVICIO
SELECT count(1) AS TERMINAL FROM AWANTA.TERMINAL
SELECT count(1) AS PAGO FROM AWANTA.TIPO_DE_PAGO
SELECT count(1) AS USUARIO FROM AWANTA.USUARIO
SELECT count(1) AS VIAJE FROM AWANTA.VIAJE
