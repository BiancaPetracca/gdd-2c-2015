/*----------STORED PROCEDURES APLICACION----------*/

/*LOGIN*/

/*1.dado un nombre encontrar el username
2. cantidad de intentos de un username 
3. dado un username obtener su password
4. setear usuario invalido*/


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

CREATE PROCEDURE [AWANTA].set_estado_usuario(@nombre_usuario NVARCHAR(255),@estado CHAR)
AS
	BEGIN
		
		UPDATE USUARIO SET usu_estado = @estado WHERE usu_username = @nombre_usuario
	END
GO
CREATE PROCEDURE AWANTA.validar_usuario(@username NVARCHAR(255), @password NVARCHAR(255))
AS 
	BEGIN
		IF EXISTS ( SELECT 1 FROM AWANTA.USUARIO WHERE usu_username = @username AND usu_password = @password)
			BEGIN
				RETURN 1
			END
		ELSE 
			BEGIN
				RETURN 0
			END
	END
GO

CREATE PROCEDURE AWANTA.get_funcionalidad(@username NVARCHAR(255), @funcionalidad NVARCHAR(255))
AS 
BEGIN
	SELECT CASE WHEN EXISTS ( SELECT *
	FROM AWANTA.USUARIO, AWANTA.ROL, AWANTA.FUNC_X_ROL, AWANTA.FUNCIONALIDAD
	WHERE USUARIO.usu_username = @username AND 
		ROL.rol_id = FUNC_X_ROL.f_x_r_rol AND 
		FUNC_X_ROL.f_x_r_funcionalidad = FUNCIONALIDAD.fun_id AND 
		FUNCIONALIDAD.fun_descripcion = @funcionalidad
	)
	THEN CAST(1 AS BIT)
	ELSE CAST(0 AS BIT)
END
END
GO

/*ABM CIUDAD*/
/*NO ES NECESARIO, PERO SI ANDA, GENIAL*/

CREATE PROCEDURE AWANTA.get_all_cities(@codigo numeric(18), @nombre nvarchar(255))
AS 
BEGIN
	SELECT *
	FROM AWANTA.CIUDAD
	WHERE (ciu_id = @codigo OR @codigo IS NULL) AND
	(ciu_nombre = @nombre OR @nombre IS NULL)
END
GO

/*ABM RUTA AEREA*/

CREATE PROCEDURE AWANTA.get_all_rutas(@codigo numeric(18), @destino nvarchar(255), @origen nvarchar(255), @precio_base money, @precio_base_kg money, @servicio nvarchar(255))
AS 
BEGIN
	SELECT *
	FROM AWANTA.RUTA_AEREA
	WHERE (rut_habilitada = 'H') AND
	(@codigo IS NULL OR rut_codigo=@codigo) AND
	(@destino IS NULL OR rut_destino=AWANTA.obtenerIdCiudad(@destino)) AND
	(@origen IS NULL OR rut_origen=AWANTA.obtenerIdCiudad(@origen)) AND
	(@precio_base IS NULL OR rut_precio_base=@precio_base) AND
	(@precio_base_kg IS NULL OR rut_precio_base_x_kg=@precio_base_kg) AND
	(@servicio IS NULL OR rut_tipo_servicio=AWANTA.buscarIdServicio(@servicio))
END
GO


CREATE PROCEDURE AWANTA.set_ruta(@ciudad_origen nvarchar(255), @ciudad_destino nvarchar(255), @servicio nvarchar(255), @precio_por_pasajero money, @precio_por_kilo money)
AS 
BEGIN
	INSERT INTO AWANTA.RUTA_AEREA(rut_origen, rut_destino, rut_tipo_servicio, rut_precio_base, rut_precio_base_x_kg)
	VALUES(
	AWANTA.obtenerIdCiudad(@ciudad_origen), 
	AWANTA.obtenerIdCiudad(@ciudad_destino), 
	AWANTA.buscarIdServicio(@servicio), 
	@precio_por_pasajero, @precio_por_kilo)
END
GO

CREATE FUNCTION AWANTA.get_codigo_ruta(@origen nvarchar(255), @destino nvarchar(255), @avion nvarchar(255))
RETURNS NUMERIC(18)
AS
BEGIN
	DECLARE @codigo numeric(18)
	SET @codigo = (SELECT TOP 1 rut_codigo
	FROM AWANTA.RUTA_AEREA, AWANTA.CIUDAD, AWANTA.SERVICIO, AWANTA.AERONAVE
	WHERE (rut_origen = ciu_id AND
	ciu_nombre = @origen) AND
	(rut_destino = ciu_id AND
	ciu_nombre = @destino) AND
	rut_tipo_servicio = serv_id_servicio AND
	serv_id_servicio = aer
	RETURN @codigo
END
GO

CREATE PROCEDURE AWANTA.bajar_ruta (@codigo numeric(18))
AS
BEGIN
	/*TODO CANCELAR TODOS LOS PASAJES QUE TENGAN LA RUTA*/
	DELETE FROM AWANTA.RUTA_AEREA
	WHERE rut_codigo = @codigo
END
GO


/*ALTA VIAJE*/

CREATE PROCEDURE AWANTA.create_viaje(@avion nvarchar(255), @llegada_estimada date, @salida date, @ciudad_origen nvarchar(255), @ciudad_destino nvarchar(255))
AS
BEGIN
	INSERT INTO AWANTA.VIAJE(via_avion, via_fecha_llegada_estimada, via_fecha_salida, via_ruta_aerea)
	VALUES(@avion/*TODO ESTO CON LA FUNCION DE LA MATRICULA*/, @llegada_estimada, @salida,
	AWANTA.get_codigo_ruta(@ciudad_origen, @ciudad_destino, @avion))
END
GO

/*LLEGADA A DESTINO*/

CREATE PROCEDURE AWANTA.llegada_a_destino(@avion nvarchar(255), @ciudad_origen nvarchar(255), @servicio nvarchar(255), @ciudad_destino nvarchar(255), @llegada date)
AS
BEGIN
	UPDATE AWANTA.VIAJE 
	SET via_fecha_llegada = @llegada
	WHERE via_avion = @avion /*TODO ESTO CON LA FUNCION DE LA MATRICULA*/ AND
	via_ruta_aerea = (SELECT rut_codigo 
	FROM AWANTA.RUTA_AEREA
	WHERE rut_origen = AWANTA.get_codigo_ruta(@ciudad_origen, @ciudad_destino, @servicio))
END
GO

/*VENTA DE UN PASAJE*/

CREATE PROCEDURE AWANTA.vender_pasaje (@terminal nvarchar(255), @tipo_doc nvarchar(255), @numero_doc numeric(18), @salida date, @origen nvarchar(255), @destino nvarchar(255),
	@tipo nvarchar(255), @piso int)
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
	(SELECT termina_id FROM AWANTA.TERMINAL 
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
	WHERE but_estado LIKE '%L%' AND
	but_tipo = @tipo AND
	but_piso = @piso)

	UPDATE AWANTA.BUTACA
	SET but_estado = '%R%'
	WHERE but_id = @butaca_pasaje

	INSERT INTO AWANTA.PASAJE(pas_compra, pas_butaca)
	VALUES(@compra_pasaje, @butaca_pasaje)
END
GO