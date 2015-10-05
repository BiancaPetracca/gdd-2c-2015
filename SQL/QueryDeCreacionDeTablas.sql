CREATE TABLE [AWANTA].CIUDAD
(
	ciu_id numeric(18) primary key,
	ciu_nombre nvarchar(255) not null,
)

CREATE TABLE [AWANTA].SERVICIO
(
	serv_id_servicio numeric(18) primary key,
	serv_nombre nvarchar(255) not null,
	serv_porcentaje_adicional int not null,		
)

CREATE TABLE [AWANTA].RUTA_AEREA
(
	rut_codigo numeric(18) primary key,
	rut_origen numeric(18) not null foreign key
	references [AWANTA].CIUDAD(ciu_id),
	rut_destino numeric(18) not null foreign key
	references [AWANTA].CIUDAD(ciu_id),
	rut_tipo_servicio numeric(18) not null foreign key
	references [AWANTA].SERVICIO(serv_id_servicio),
	rut_precio_base money not null,
	rut_precio_base_x_kg money not null,
)

CREATE TABLE [AWANTA].ROL
(
	rol_id numeric(18) primary key,
	rol_nombre nvarchar(255) not null,
	rol_funcionalidades nvarchar(255),
	rol_estado char not null,
)

CREATE TABLE [AWANTA].FUNCIONALIDAD
(
	fun_id numeric(18) primary key,
	fun_descripcion nvarchar(255) not null,
)

CREATE TABLE [AWANTA].FUNC_X_ROL
(
	f_x_r_funcionalidad numeric(18) not null foreign key
	references [AWANTA].FUNCIONALIDAD(fun_id) ,
	f_x_r_rol numeric(18) not null foreign key 
	references [AWANTA].ROL(rol_id),
)

CREATE TABLE [AWANTA].USUARIO
(
	usu_id numeric(18) primary key,
	usu_username nvarchar(255) unique not null,
	usu_password nvarchar(255) not null,
	usu_estado char not null,
	usu_rol numeric(18) foreign key
	references [AWANTA].ROL(rol_id),
	usu_fecha_alta datetime not null,
	usu_intentos_login int not null,
)

CREATE TABLE [AWANTA].CLIENTE
(	
	cli_codigo numeric(18) primary key,
	cli_tipo_doc nvarchar(255) not null,
	cli_nro_doc numeric(18) not null,
	cli_nombre nvarchar(255) not null,
	cli_apellido nvarchar(255) not null,
	cli_direccion nvarchar(255) not null,
	cli_telefono numeric(18) not null,
	cli_fecha_nac datetime not null,
	cli_mail nvarchar(255),
	cli_usuario numeric(18) foreign key
	references [AWANTA].USUARIO(usu_id),

)

CREATE TABLE [AWANTA].PRODUCTO
(
	prod_id numeric(18) primary key,
	prod_nombre varchar(255) not null,
	prod_puntos bigint not null,
	prod_stock numeric(18),
)

CREATE TABLE [AWANTA].CANJE
(
	can_codigo numeric(18) primary key,
	can_usuario numeric(18) foreign key
	references [AWANTA].CLIENTE(cli_codigo),
	can_producto numeric(18) foreign key
	references [AWANTA].PRODUCTO(prod_id),
	can_cantidad numeric(18) not null,
	can_fecha datetime not null,
)

CREATE TABLE [AWANTA].AERONAVE
(
	aero_matricula nvarchar(255) primary key,
	aero_numero_de_aeronave int not null,
	aero_modelo nvarchar(255) not null,
	aero_fabricante nvarchar(255) not null,
	id_servicio numeric(18) not null foreign key
	references [AWANTA].SERVICIO (serv_id_servicio),
	aero_fecha_de_alta datetime not null,
	aero_baja_fuera_de_servicio datetime,
	aero_fecha_reinicio_servicio datetime,
	aero_fecha_baja_definitiva datetime,
	aero_cantidad_butacas_pasillo int not null,
	aero_cantidad_butacas_ventanilla int not null,
	aero_kgs_disponibles_encomiendas int not null,

)

CREATE TABLE [AWANTA].VIAJE
(
	via_codigo numeric(18) primary key,
	via_fecha_salida datetime not null,
	via_fecha_llegada datetime not null,
	via_fecha_llegada_estimada datetime not null,
	via_avion nvarchar(255) foreign key
	references [AWANTA].AERONAVE(aero_matricula),

)

CREATE TABLE [AWANTA].BUTACA
(
	but_id numeric(18) primary key,
	but_piso int not null,
	but_tipo nvarchar(255) not null,
	but_estado char not null, 
)

CREATE TABLE [AWANTA].TIPO_DE_PAGO
(
	pago_tipo char primary key,
	tarjeta_nro numeric(18),
	tarjeta_codigo_seguridad numeric(18),
	tarjeta_fecha_vencimiento datetime,
	tarjeta_tipo nvarchar(255),

)

CREATE TABLE [AWANTA].TERMINAL
(
	termina_id numeric(18) primary key,
	terminal_tipo nvarchar(255),
	tipo_pago char foreign key
	references [AWANTA].TIPO_DE_PAGO(pago_tipo)
)

CREATE TABLE [AWANTA].COMPRA
(
	compra_id numeric(18) primary key,
	compra_viaje numeric(18) foreign key 
	references [AWANTA].VIAJE (via_codigo),
	compra_cliente numeric(18) foreign key
	references [AWANTA].CLIENTE(cli_codigo),
	compra_terminal numeric(18) foreign key 
	references [AWANTA].TERMINAL(termina_id),
)

CREATE TABLE [AWANTA].PASAJE
(
	pas_codigo numeric(18) primary key,
	pas_compra numeric(18) foreign key
	references [AWANTA].COMPRA(compra_id),
	pas_butaca numeric(18) foreign key
	references [AWANTA].BUTACA(but_id),
)

CREATE TABLE [AWANTA].ENCOMIENDA
(
	enc_codigo numeric(18) primary key,
	enc_kg int not null,
	enc_compra numeric(18) foreign key
	references [AWANTA].COMPRA(compra_id),
)

CREATE TABLE [AWANTA].DEVOLUCION
(
	dev_codigo numeric(18) primary key,
	dev_motivo nvarchar(255) not null,
	dev_fecha datetime not null,
	dev_compra numeric(18) foreign key
	references [AWANTA].COMPRA(compra_id),
)

CREATE TABLE [AWANTA].REGISTRO_LLEGADA_DESTINO
(
	reg_viaje_avion numeric(18) foreign key
	references [AWANTA].VIAJE(via_codigo),
	reg_fecha_llegada_real datetime,
	reg_hora_llegada_real time,
	reg_aeropuerto_salida nvarchar(255),
	reg_aeropuerto_llegada nvarchar(255),

)

CREATE TABLE [AWANTA].MILLAS_ACUMULADAS
(
	cliente_id numeric(18) foreign key
	references [AWANTA].CLIENTE(cli_codigo),
	total_millas int not null,
	fecha_vencimiento datetime not null,
)
