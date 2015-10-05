USE [GD2C2015]
GO

IF NOT EXISTS ( SELECT  *
                FROM    sys.schemas
                WHERE   name = N'AWANTA' ) 
    EXEC('CREATE SCHEMA [AWANTA] AUTHORIZATION [gd]');
GO

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_rut_tipo_servicio') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.RUTA_AEREA DROP CONSTRAINT FK_rut_tipo_servicio;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_f_x_r_funcionalidad') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.FUNC_X_ROL DROP CONSTRAINT FK_f_x_r_funcionalidad;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_f_x_r_rol') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.FUNC_X_ROL DROP CONSTRAINT FK_f_x_r_rol;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_cli_usuario') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.CLIENTE DROP CONSTRAINT FK_cli_usuario;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_can_usuario') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.CANJE DROP CONSTRAINT FK_can_usuario ;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_can_producto') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.CANJE DROP CONSTRAINT FK_can_producto ;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_id_servicio') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.AERONAVE DROP CONSTRAINT FK_id_servicio ;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_via_avion') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.VIAJE DROP CONSTRAINT FK_via_avion;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_tipo_pago') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.TERMINAL DROP CONSTRAINT FK_tipo_pago;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_compra_viaje') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.COMPRA DROP CONSTRAINT FK_compra_viaje;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_compra_cliente') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.COMPRA DROP CONSTRAINT FK_compra_cliente;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_compra_terminal') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.COMPRA DROP CONSTRAINT FK_compra_terminal;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_pas_compra') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.PASAJE DROP CONSTRAINT FK_pas_compra;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_pas_butaca') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.PASAJE DROP CONSTRAINT FK_pas_butaca ;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_pas_butaca') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.PASAJE DROP CONSTRAINT FK_pas_butaca ;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_enc_codigo') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.ENCOMIENDA DROP CONSTRAINT FK_enc_codigo;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_enc_compra') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.ENCOMIENDA DROP CONSTRAINT FK_enc_compra ;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_dev_compra') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.DEVOLUCION DROP CONSTRAINT FK_dev_compra;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_reg_viaje_avion') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.REGISTRO_LLEGADA_DESTINO DROP CONSTRAINT FK_reg_viaje_avion;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FK_cliente_id') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE AWANTA.MILLAS_ACUMULADAS DROP CONSTRAINT FK_cliente_id;


/*---------------------------DROP DE LAS TABLAS---------------------------*/


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.AERONAVE') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.AERONAVE;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.BUTACA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.BUTACA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.CANJE') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.CANJE;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.CUIDAD') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.CUIDAD;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.CLIENTE') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.CLIENTE;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.COMPRA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.COMPRA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.DEVOLUCION') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.DEVOLUCION;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.ENCOMIENDA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.ENCOMIENDA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FUNC_X_ROL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.FUNC_X_ROL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.FUNCIONALIDAD') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.FUNCIONALIDAD;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.MILLAS_ACUMULADAS') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.MILLAS_ACUMULADAS;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.PASAJE') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.PASAJE;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.PRODUCTO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.PRODUCTO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.REGISTRO_LLEGADA_DESTINO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.REGISTRO_LLEGADA_DESTINO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.ROL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.ROL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.RUTA_AEREA') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.RUTA_AEREA;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.SERVICIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.SERVICIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.TERMINAL') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.TERMINAL;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.TIPO_DE_PAGO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.TIPO_DE_PAGO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.USUARIO') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.USUARIO;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('AWANTA.VIAJE') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE AWANTA.VIAJE;


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
)

CREATE TABLE AWANTA.ROL
(
	rol_id numeric(18) identity primary key,
	rol_nombre nvarchar(255) not null,
	rol_funcionalidades nvarchar(255),
	rol_estado char not null,
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
	usu_estado char not null,
	usu_fecha_alta datetime not null,
	usu_intentos_login int not null,
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
	prod_nombre varchar(255) not null,
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

CREATE TABLE AWANTA.AERONAVE
(
	aero_matricula nvarchar(255) primary key,
	aero_numero_de_aeronave int not null,
	aero_modelo nvarchar(255) not null,
	aero_fabricante nvarchar(255) not null,
	id_servicio numeric(18) not null foreign key
	references AWANTA.SERVICIO (serv_id_servicio),
	aero_fecha_de_alta datetime not null,
	aero_baja_fuera_de_servicio datetime,
	aero_fecha_reinicio_servicio datetime,
	aero_fecha_baja_definitiva datetime,
	aero_cantidad_butacas_pasillo int not null,
	aero_cantidad_butacas_ventanilla int not null,
	aero_kgs_disponibles_encomiendas int not null,

)

CREATE TABLE AWANTA.VIAJE
(
	via_codigo numeric(18) identity primary key,
	via_fecha_salida datetime not null,
	via_fecha_llegada datetime not null,
	via_fecha_llegada_estimada datetime not null,
	via_avion nvarchar(255) foreign key
	references AWANTA.AERONAVE(aero_matricula),

)

CREATE TABLE AWANTA.BUTACA
(
	but_id numeric(18) identity primary key,
	but_piso int not null,
	but_tipo nvarchar(255) not null,
	but_estado char not null, 
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
	termina_id numeric(18) identity primary key,
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
	references AWANTA.TERMINAL(termina_id),
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
	dev_compra numeric(18) foreign key
	references AWANTA.COMPRA(compra_id),
)

CREATE TABLE AWANTA.REGISTRO_LLEGADA_DESTINO
(
	reg_viaje_avion numeric(18) identity foreign key
	references AWANTA.VIAJE(via_codigo),
	reg_fecha_llegada_real datetime,
	reg_hora_llegada_real time,
	reg_aeropuerto_salida nvarchar(255),
	reg_aeropuerto_llegada nvarchar(255),

)

CREATE TABLE AWANTA.MILLAS_ACUMULADAS
(
	cliente_id numeric(18) identity foreign key
	references AWANTA.CLIENTE(cli_codigo),
	total_millas int not null,
	fecha_vencimiento datetime not null,
)


/*---------------------------MIGRACION DE LA TABLA MAESTRA---------------------------*/

/*------MIGRACION DE LA TABLA CIUDAD------*/
INSERT INTO AWANTA.CIUDAD(ciu_id,ciu_nombre)
	SELECT DISTINCT Ruta_Ciudad_Origen
	FROM gd_esquema.Maestra
	ORDER BY Ruta_Codigo ASC;

INSERT INTO AWANTA.CIUDAD(ciu_id,ciu_nombre)
	SELECT DISTINCT Ruta_Ciudad_Destino
	FROM gd_esquema.Maestra
	ORDER BY Ruta_Codigo ASC;

/*------MIGRACION DE LA TABLA SERVICIO------*/

INSERT INTO AWANTA.SERVICIO(serv_id_servicio,serv_nombre)
	SELECT 'Turista'
	UNION ALL
	SELECT 'Primera Clase'
	UNION ALL
	SELECT 'Ejecutivo';

/*------MIGRACION DE LA TABLA RUTA_AEREA------*/

INSERT INTO AWANTA.RUTA_AEREA(rut_codigo,rut_origen, rut_destino,rut_tipo)
	