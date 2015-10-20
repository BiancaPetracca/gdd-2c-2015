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
CREATE PROCEDURE AWANTA.get_password(@username NVARCHAR(255), @password NVARCHAR(255))
AS 
	BEGIN
		SELECT CASE WHEN EXISTS ( SELECT *
		FROM AWANTA.USUARIO
		WHERE usu_username = @username AND usu_password = @password
		)
		THEN CAST(1 AS BIT)
		ELSE CAST(0 AS BIT)
	END
	END
GO

CREATE PROCEDURE AWANTA.get_username(@username NVARCHAR(255))
AS 
	BEGIN
		SELECT CASE WHEN EXISTS ( SELECT *
		FROM AWANTA.USUARIO
		WHERE usu_username = @username
		)
		THEN CAST(1 AS BIT)
		ELSE CAST(0 AS BIT)
	END
	END
GO

CREATE PROCEDURE AWANTA.get_funcionalidad(@username NVARCHAR(255), @funcionalidad NVARCHAR(255))
AS 
BEGIN
	SELECT CASE WHEN EXISTS ( SELECT *
	FROM AWANTA.USUARIO, AWANTA.ROL_X_USUARIO, AWANTA.ROL, AWANTA.FUNC_X_ROL, AWANTA.FUNCIONALIDAD
	WHERE USUARIO.usu_username = @username AND 
		USUARIO.usu_rol = ROL.rol_id AND
		ROL.rol_id = FUNC_X_ROL.f_x_r_rol AND 
		FUNC_X_ROL.f_x_r_funcionalidad = FUNCIONALIDAD.fun_id AND 
		FUNCIONALIDAD.fun_descripcion = @funcionalidad
	)
	THEN CAST(1 AS BIT)
	ELSE CAST(0 AS BIT)
END
END
GO

/* TESTS DE LOS PROCEDURES
INSERT INTO [AWANTA].USUARIO (usu_username, usu_password, usu_estado, usu_fecha_alta)
VALUES ('NicoBanana', 'w23e', 'H', CONVERT(DATETIME,'03:30:00.000'));
GO

EXEC AWANTA.get_password 'NicoBanana', 'w23e';
EXEC AWANTA.get_username'NicoBananaa';
*/


/*ABM CIUDAD*/
/*NO ES NECESARIO, PERO SI ANDA, GENIAL*/

CREATE PROCEDURE AWANTA.get_all_cities
AS 
BEGIN
	SELECT *
	FROM AWANTA.CIUDAD
END
GO

CREATE PROCEDURE AWANTA.get_all_cities_by_codigo(@codigo numeric(18))
AS
BEGIN
	SELECT *
	FROM AWANTA.CIUDAD
	WHERE ciu_id = @codigo
END
GO

CREATE PROCEDURE AWANTA.get_all_cities_by_nombre(@nombre_ciudad nvarchar(255))
AS
BEGIN
	SELECT *
	FROM AWANTA.CIUDAD
	WHERE ciu_nombre LIKE @nombre_ciudad
END
GO

CREATE PROCEDURE AWANTA.set_city(@nombre_ciudad nvarchar(255))
AS 
BEGIN
	INSERT INTO AWANTA.CIUDAD(AWANTA.CIUDAD.ciu_nombre) VALUES(@nombre_ciudad)
END
GO


/*ABM RUTA AEREA*/

CREATE PROCEDURE AWANTA.get_all_rutas
AS 
BEGIN
	SELECT *
	FROM AWANTA.RUTA_AEREA
END
GO

CREATE PROCEDURE AWANTA.get_all_rutas_by_codigo(@codigo numeric(18))
AS 
BEGIN
	SELECT *
	FROM AWANTA.RUTA_AEREA
	WHERE rut_codigo = @codigo
END
GO

CREATE PROCEDURE AWANTA.get_all_rutas_by_destino(@destino nvarchar(255))
AS 
BEGIN
	SELECT rut_codigo, rut_destino, rut_origen, rut_tipo_servicio, rut_precio_base, rut_precio_base_x_kg
	FROM AWANTA.RUTA_AEREA, AWANTA.CIUDAD
	WHERE rut_destino = ciu_id AND
	ciu_nombre LIKE @destino
END
GO

CREATE PROCEDURE AWANTA.get_all_rutas_by_origen(@origen nvarchar(255))
AS 
BEGIN
	SELECT rut_codigo, rut_destino, rut_origen, rut_tipo_servicio, rut_precio_base, rut_precio_base_x_kg
	FROM AWANTA.RUTA_AEREA, AWANTA.CIUDAD
	WHERE rut_destino = ciu_id AND
	ciu_nombre LIKE @origen
END
GO

CREATE PROCEDURE AWANTA.get_all_rutas_by_servicio(@servicio nvarchar(255))
AS 
BEGIN
	SELECT rut_codigo, rut_destino, rut_origen, rut_tipo_servicio, rut_precio_base, rut_precio_base_x_kg
	FROM AWANTA.RUTA_AEREA, AWANTA.SERVICIO
	WHERE rut_tipo_servicio = serv_id_servicio AND
	serv_nombre LIKE @servicio
END
GO

CREATE PROCEDURE AWANTA.get_all_rutas_by_precio_base_pasajero(@precioMinimo money, @precioMaximo money)
AS 
BEGIN
	SELECT rut_codigo, rut_destino, rut_origen, rut_tipo_servicio, rut_precio_base, rut_precio_base_x_kg
	FROM AWANTA.RUTA_AEREA
	WHERE rut_precio_base BETWEEN @precioMinimo AND @precioMaximo
END
GO

CREATE PROCEDURE AWANTA.get_all_rutas_by_precio_base_kg(@precioMinimo money, @precioMaximo money)
AS 
BEGIN
	SELECT rut_codigo, rut_destino, rut_origen, rut_tipo_servicio, rut_precio_base, rut_precio_base_x_kg
	FROM AWANTA.RUTA_AEREA
	WHERE rut_precio_base_x_kg BETWEEN @precioMinimo AND @precioMaximo
END
GO

CREATE PROCEDURE AWANTA.set_ruta(@ciudad_origen nvarchar(255), @ciudad_destino nvarchar(255), @servicio nvarchar(255), @precio_por_pasajero money, @precio_por_kilo money)
AS 
BEGIN
	INSERT INTO AWANTA.RUTA_AEREA(rut_origen, rut_destino, rut_tipo_servicio, rut_precio_base, rut_precio_base_x_kg)
	VALUES(
	(SELECT c.ciu_id
	FROM AWANTA.CIUDAD c
	WHERE c.ciu_nombre LIKE @ciudad_origen), 
	(SELECT c.ciu_id
	FROM AWANTA.CIUDAD c
	WHERE c.ciu_nombre LIKE @ciudad_destino), 
	(SELECT s.serv_id_servicio
	FROM AWANTA.SERVICIO s
	WHERE s.serv_nombre LIKE @servicio), 
	@precio_por_pasajero, @precio_por_pasajero)
END
GO

CREATE FUNCTION AWANTA.get_codigo_ruta(@origen nvarchar(255), @destino nvarchar(255), @servicio nvarchar(255))
RETURNS NUMERIC(18)
AS
BEGIN
	DECLARE @codigo numeric(18)
	SET @codigo = (SELECT TOP 1 rut_codigo
	FROM AWANTA.RUTA_AEREA, AWANTA.CIUDAD, AWANTA.SERVICIO
	WHERE (rut_origen = ciu_id AND
	ciu_nombre = @origen) AND
	(rut_destino = ciu_id AND
	ciu_nombre = @destino) AND
	rut_tipo_servicio = serv_id_servicio AND
	serv_nombre = @servicio)
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

CREATE PROCEDURE AWANTA.create_viaje(@avion nvarchar(255), @llegada_estimada date, @salida date, @ciudad_origen nvarchar(255), @ciudad_destino nvarchar(255), @servicio nvarchar(255))
AS
BEGIN
	INSERT INTO AWANTA.VIAJE(via_avion, via_fecha_llegada_estimada, via_fecha_salida, via_ruta_aerea)
	VALUES(@avion/*TODO ESTO CON LA FUNCION DE LA MATRICULA*/, @llegada_estimada, @salida,
	AWANTA.get_codigo_ruta(@ciudad_origen, @ciudad_destino, @servicio))
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
	INSERT INTO AWANTA.COMPRA(compra_cliente, compra_terminal, compra_viaje)
	VALUES((SELECT cli_codigo
	FROM AWANTA.CLIENTE 
	WHERE cli_tipo_doc = @tipo_doc AND cli_nro_doc = @numero_doc), 
	(SELECT termina_id FROM AWANTA.TERMINAL 
	WHERE terminal_tipo = @terminal), 
	(SELECT via_codigo 
	FROM AWANTA.VIAJE, AWANTA.RUTA_AEREA 
	WHERE via_fecha_salida = @salida AND
	via_ruta_aerea = rut_codigo AND
	rut_origen = @origen AND
	rut_destino = @destino))

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
	SET but_estado = 'R'
	WHERE but_id = @butaca_pasaje

	INSERT INTO AWANTA.PASAJE(pas_compra, pas_butaca)
	VALUES(@compra_pasaje, @butaca_pasaje)
END
GO