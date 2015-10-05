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