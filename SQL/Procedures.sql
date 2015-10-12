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
/*NO EXISTE UN MODIFY PORQUE LAS CIUDADES NO CAMBIAN*/

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
	WHERE ciu_nombre = @nombre_ciudad
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
	ciu_nombre = @destino
END
GO

CREATE PROCEDURE AWANTA.get_all_rutas_by_origen(@origen nvarchar(255))
AS 
BEGIN
	SELECT rut_codigo, rut_destino, rut_origen, rut_tipo_servicio, rut_precio_base, rut_precio_base_x_kg
	FROM AWANTA.RUTA_AEREA, AWANTA.CIUDAD
	WHERE rut_destino = ciu_id AND
	ciu_nombre = @origen
END
GO

CREATE PROCEDURE AWANTA.get_all_rutas_by_servicio(@servicio nvarchar(255))
AS 
BEGIN
	SELECT rut_codigo, rut_destino, rut_origen, rut_tipo_servicio, rut_precio_base, rut_precio_base_x_kg
	FROM AWANTA.RUTA_AEREA, AWANTA.SERVICIO
	WHERE rut_tipo_servicio = serv_id_servicio AND
	serv_nombre = @servicio
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
	WHERE c.ciu_nombre = @ciudad_origen), 
	(SELECT c.ciu_id
	FROM AWANTA.CIUDAD c
	WHERE c.ciu_nombre = @ciudad_destino), 
	(SELECT s.serv_id_servicio
	FROM AWANTA.SERVICIO s
	WHERE s.serv_nombre = @servicio), 
	@precio_por_pasajero, @precio_por_pasajero)
END
GO



