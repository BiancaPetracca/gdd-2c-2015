/*----------STORED PROCEDURES APLICACION----------*/ 


/*------LOGIN------*/

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
	SELECT fun_descripcion FROM AWANTA.FUNCIONALIDAD, AWANTA.FUNC_X_ROL, AWANTA.ROL
	WHERE fun_id = f_x_r_funcionalidad AND
	f_x_r_rol = rol_id AND
	rol_nombre = @rol
END
GO

CREATE PROCEDURE AWANTA.get_roles
AS
BEGIN
	SELECT * FROM AWANTA.ROL
END
GO

CREATE PROCEDURE AWANTA.crear_rol(@descripcion nvarchar(255))
AS
BEGIN
	INSERT INTO AWANTA.ROL(rol_nombre, rol_estado)
	VALUES(@descripcion, 1)
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
	INSERT INTO AWANTA.FUNC_X_ROL VALUES ((SELECT TOP 1 rol_id FROM AWANTA.ROL WHERE rol_nombre = @rol),
	 (SELECT TOP 1 fun_id FROM AWANTA.FUNCIONALIDAD WHERE fun_descripcion = @func))
END
GO

CREATE PROCEDURE AWANTA.borrar_funcionalidad(@descripcion_func nvarchar(255))
AS
BEGIN
	DELETE FROM AWANTA.FUNC_X_ROL
	WHERE f_x_r_funcionalidad = (SELECT fun_id FROM AWANTA.FUNCIONALIDAD WHERE fun_descripcion = @descripcion_func)

	DELETE FROM AWANTA.FUNCIONALIDAD
	WHERE @descripcion_func = fun_descripcion
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

CREATE PROCEDURE AWANTA.get_all_rutas(@codigo numeric(18), @destino nvarchar(255), @origen nvarchar(255), @precio_base money, @precio_base_kg money, @servicio nvarchar(255))
AS 
BEGIN
	SELECT rut_codigo, AWANTA.obtenerNombreCiudad(rut_origen), AWANTA.obtenerNombreCiudad(rut_destino), rut_precio_base, rut_precio_base_x_kg, serv_nombre
	FROM AWANTA.RUTA_AEREA, AWANTA.SERVICIO
	WHERE (rut_habilitada = 1) AND
	(@codigo IS NULL OR rut_codigo=@codigo) AND
	(@destino IS NULL OR rut_destino=AWANTA.obtenerIdCiudad(@destino)) AND
	(@origen IS NULL OR rut_origen=AWANTA.obtenerIdCiudad(@origen)) AND
	(@precio_base IS NULL OR rut_precio_base=@precio_base) AND
	(@precio_base_kg IS NULL OR rut_precio_base_x_kg=@precio_base_kg) AND
	(@servicio IS NULL OR rut_tipo_servicio=AWANTA.buscarIdServicio(@servicio))
END
GO

CREATE PROCEDURE AWANTA.altaRutaAerea(@ciudadOrigen NVARCHAR(255),@ciudadDestino NVARCHAR(255),@tipoServicio NVARCHAR(255), 
											@rutaPrecioBasePasaje MONEY,@rutaPrecioBaseKilo MONEY)
AS
	BEGIN
		INSERT INTO AWANTA.RUTA_AEREA(rut_origen,rut_destino,rut_tipo_servicio,rut_precio_base,rut_precio_base_x_kg)
		VALUES (AWANTA.obtenerIdCiudad(@ciudadOrigen),AWANTA.obtenerIdCiudad(@ciudadDestino),AWANTA.buscarIdServicio(@tipoServicio),
					@rutaPrecioBasePasaje,@rutaPrecioBaseKilo)
	END
GO

CREATE PROCEDURE AWANTA.darDeBajaPasajesAsociadosPorBajaDeRutaAerea(@origen nvarchar(255), @destino nvarchar(255), @servicio nvarchar(255))
AS		
	BEGIN
		DELETE FROM AWANTA.VIAJE WHERE via_fecha_salida > (SELECT CONVERT(date,SYSDATETIME()))
										AND via_ruta_aerea = AWANTA.obtenerCodigoRuta(@origen, @destino, @servicio)
	END
GO

CREATE PROCEDURE AWANTA.bajaRutaAerea(@ciudadOrigen NVARCHAR(255),@ciudadDestino NVARCHAR(255),@tipoServicio NVARCHAR(255))
AS
	BEGIN
		DECLARE @pkDeLaRuta NUMERIC(18)
		SET @pkDeLaRuta = (SELECT rut_codigo FROM AWANTA.RUTA_AEREA 
		WHERE rut_origen = @ciudadOrigen 
		AND rut_destino = @ciudadDestino 
		AND rut_tipo_servicio = (SELECT serv_id_servicio FROM AWANTA.SERVICIO WHERE serv_nombre = @tipoServicio))
		
		UPDATE AWANTA.RUTA_AEREA
		SET rut_habilitada = 0
		WHERE rut_codigo = @pkDeLaRuta
		EXEC AWANTA.darDeBajaPasajesAsociadosPorBajaDeRutaAerea @pkDeLaRuta
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
SELECT aero_matricula, aero_fabricante, aero_cantidad_butacas_pasillo, aero_cantidad_butacas_ventanilla, aero_kgs_disponibles_encomiendas as asd, aero_kgs_disponibles_encomiendas,
	 aero_estado, aero_fecha_de_alta, aero_fecha_reinicio_servicio, serv_nombre FROM AWANTA.AERONAVE
	JOIN AWANTA.SERVICIO ON aero_id_servicio = serv_id_servicio
	AND (@estado IS NULL OR @estado = aero_estado) AND (@filtro IS NULL OR @filtro = serv_nombre)
END
GO



CREATE PROCEDURE AWANTA.get_aeronaves_filtradas(@numero numeric(1), @filtro nvarchar(255))
AS 
BEGIN
SELECT * FROM AWANTA.AERONAVE
END
GO
/* LO PODEMOS BORRAR ME PARECE 
CREATE PROCEDURE AWANTA.get_all_aeronaves(@numero numeric(18), @modelo nvarchar(255), @matricula nvarchar(255), @butacas_pasillo numeric(18), 
@butacas_ventanilla numeric(18), @kilos_disponibles numeric(18), @fabricante nvarchar(255), @fecha_alta date, @fecha_baja_temporal date, 
@fecha_alta_temporal date, @fecha_baja_definitiva date)
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
	(@numero IS NULL OR aero_numero_de_aeronave=@numero) AND
	aero_id_servicio = serv_id_servicio
END
GO */

CREATE PROCEDURE AWANTA.altaDeAeronave(@matricula NVARCHAR(255),@modelo NVARCHAR(255),@fabricante NVARCHAR(255),@servicio NVARCHAR(255),
											@butacasPasillo INT,@butacasVentanilla INT,@kilosDisponibles INT)
AS
	BEGIN
		BEGIN TRY
		IF NOT EXISTS (SELECT 1 FROM AWANTA.AERONAVE WHERE @matricula = aero_matricula)
			BEGIN
				INSERT INTO AWANTA.AERONAVE (aero_matricula,aero_modelo,aero_fabricante,aero_id_servicio,
				aero_cantidad_butacas_pasillo,aero_cantidad_butacas_ventanilla,aero_kgs_disponibles_encomiendas)

				VALUES (@matricula,@modelo,@fabricante,AWANTA.buscarIdServicio(@servicio),@butacasPasillo,@butacasVentanilla,@kilosDisponibles)
				RETURN(0)
			END
		END TRY
		BEGIN CATCH
			IF @@ERROR = 2627 --CODIGO DE ERROR PARA REPETIDOS EN UN INSERT
			RETURN(-1) 
		END CATCH
	END
GO

CREATE PROCEDURE AWANTA.bajaDeViajesAsociadosConAeronave(@numero NVARCHAR(255))
AS
	BEGIN
		DELETE FROM AWANTA.VIAJE WHERE via_fecha_salida > (SELECT CONVERT(date,SYSDATETIME()))
										AND via_avion = @numero
	END
GO

CREATE FUNCTION AWANTA.cumpleCondiciones(@aero_numero_de_aeronave NUMERIC(18),@fechaBaja DATETIME,@fechaReinicio DATETIME) 
RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT 1 FROM AWANTA.VIAJE WHERE via_avion = @aero_numero_de_aeronave 
											 AND ((via_fecha_salida > @fechaBaja AND via_fecha_salida < @fechaReinicio) 
													OR (via_fecha_llegada > @fechaBaja AND via_fecha_llegada < @fechaReinicio)))
			BEGIN
				RETURN (-1)
			END
	RETURN (0)
	END
GO

CREATE PROCEDURE AWANTA.notificarInsercionDeAeronavePorFaltaDeReemplazo
AS
	BEGIN
		--todo ver como avisarle a la aplicacion
	END
GO

CREATE PROCEDURE AWANTA.reemplazoDeAeronaveEnViajes (@numero NUMERIC(18),@fechaReinicio DATETIME)
AS
	BEGIN
		IF (@fechaReinicio != NULL)
			BEGIN
				DECLARE @fechaSalida DATETIME
				DECLARE @fechaLlegada DATETIME
				DECLARE @numeroAeronave INT
				DECLARE @fechaDelDia DATETIME
				SET @fechaDelDia = (SELECT CONVERT(date,SYSDATETIME()))

				DECLARE miCursor CURSOR FOR SELECT via_fecha_salida,via_fecha_llegada,via_avion FROM AWANTA.VIAJE WHERE via_avion = @numero 
											 AND via_fecha_salida > @fechaDelDia
											 AND via_fecha_salida < @fechaReinicio
				OPEN miCursor
			
				FETCH FROM miCursor INTO @fechaSalida,@fechaLlegada,@numeroAeronave
				
				WHILE @@FETCH_STATUS = 0
					BEGIN
						DECLARE @numAvion NUMERIC(18)
						SELECT TOP 1 @numAvion = aero_numero_de_aeronave FROM AWANTA.AERONAVE WHERE AWANTA.cumpleCondiciones(aero_numero_de_aeronave,@fechaDelDia,@fechaReinicio) = 0 
						IF (@numAvion IS NOT NULL)
							BEGIN
								UPDATE AWANTA.VIAJE
								SET via_avion = @numAvion
							END
						ELSE
							BEGIN
								EXEC AWANTA.notificarInsercionDeAeronavePorFaltaDeReemplazo 
							END
						FETCH FROM miCursor INTO @fechaSalida,@fechaLlegada,@numeroAeronave	 
					END  
			END
		ELSE
			BEGIN
				EXEC AWANTA.bajaDeViajesAsociadosConAeronave @numero
			END
		
	END
GO

CREATE PROCEDURE AWANTA.bajaLogicaDeAeronavePorFinDeVidaUtil(@matricula NVARCHAR(255),@reemplazo INT)
AS
	BEGIN
		DECLARE @numero INT
		SELECT @numero = aero_numero_de_aeronave FROM AWANTA.AERONAVE WHERE @matricula = aero_matricula
		IF (@numero IS NOT NULL)
			IF (@reemplazo = 1)
				BEGIN
					DECLARE @fecha INT
					SET @fecha = NULL
					EXEC AWANTA.reemplazoDeAeronaveEnViajes @numero,@fecha
				END
			ELSE
				BEGIN
					UPDATE AWANTA.AERONAVE
					SET aero_fecha_baja_definitiva = (SELECT CONVERT(date,SYSDATETIME()))
					EXEC AWANTA.bajaDeViajesAsociadosConAeronave @numero
					RETURN(0)
				END
		ELSE RETURN (-2) --ERROR EN LA INSERCION, NO SE COMO MANDARLO
		RETURN(-1)
	END
GO

exec AWANTA.bajaLogicaDeAeronavePorFinDeVidaUtil "BZD-177", 1
GO
CREATE PROCEDURE AWANTA.bajaLogicaDeAeronavePorMantenimiento(@matricula NVARCHAR(255),@fechaReinicio DATETIME,@reemplazo INT)
AS
	BEGIN
		DECLARE @numero INT
		SELECT @numero = aero_numero_de_aeronave FROM AWANTA.AERONAVE WHERE @matricula = aero_matricula
		IF (@numero IS NOT NULL)
			BEGIN
				UPDATE AWANTA.AERONAVE
				SET aero_baja_fuera_de_servicio = (SELECT CONVERT(date,SYSDATETIME()))
				UPDATE AWANTA.AERONAVE
				SET aero_fecha_reinicio_servicio = @fechaReinicio
				--Me fijo si hay que cancelar los viajes o reemplazarlos
				--SI ES 1 REEMPLAZO SINO 0 PARA CANCELACION
				IF (@reemplazo = 1)
					BEGIN
						EXEC AWANTA.reemplazoDeAeronaveEnViajes @numero,@fechaReinicio
					END
				ELSE
					BEGIN
						EXEC AWANTA.bajaDeViajesAsociadosConAeronave @numero
					END
			END
		RETURN(-1)
	END
GO

CREATE FUNCTION AWANTA.obtenerCodigoAeronave(@matricula nvarchar(255))
RETURNS NUMERIC(18)
AS
BEGIN
	DECLARE @codigo numeric(18)
	SET @codigo = (SELECT aero_numero_de_aeronave FROM AWANTA.AERONAVE WHERE aero_matricula = @matricula)
	RETURN @codigo
END
GO

/*------ALTA VIAJE------*/

CREATE PROCEDURE AWANTA.get_viajes(@fecha date, @origen nvarchar(255), @destino nvarchar(255))
AS
BEGIN
	SELECT via_codigo, AWANTA.obtenerNombreCiudad(rut_origen), AWANTA.obtenerNombreCiudad(rut_destino), aero_
	
	FROM AWANTA.VIAJE, AWANTA.RUTA_AEREA, AWANTA.AERONAVE
	WHERE YEAR(via_fecha_salida) = YEAR(@fecha) AND
	MONTH(via_fecha_salida) = MONTH(@fecha) AND
	DAY(via_fecha_salida) = DAY(@fecha) AND
	via_ruta_aerea = rut_codigo AND
	rut_origen = AWANTA.obtenerIdCiudad(@origen) AND
	rut_destino = AWANTA.obtenerIdCiudad(@destino) AND
	via_avion = aero_numero_de_aeronave
END
GO

CREATE PROCEDURE AWANTA.create_viaje(@avion nvarchar(255), @llegada_estimada date, @salida date, @ciudad_origen nvarchar(255), 
										@ciudad_destino nvarchar(255))
AS
BEGIN
	DECLARE @serv_viaje numeric(18), @serv_avion numeric(18)
	SET @serv_viaje = (SELECT TOP 1 rut_tipo_servicio FROM AWANTA.RUTA_AEREA WHERE rut_codigo = AWANTA.obtenerCodigoRuta(@ciudad_origen, @ciudad_destino, null))
	SET  @serv_avion = (SELECT TOP 1 aero_id_servicio FROM AWANTA.AERONAVE WHERE aero_matricula = @avion)
	
	DECLARE @avion_libre int
	SET @avion_libre = (SELECT count(1) FROM AWANTA.AERONAVE, AWANTA.VIAJE WHERE aero_matricula = @avion AND aero_numero_de_aeronave = via_avion AND
							via_fecha_llegada_estimada BETWEEN @salida AND @llegada_estimada)

	IF(@serv_viaje = @serv_avion AND @avion_libre = 0)
		BEGIN
			INSERT INTO AWANTA.VIAJE(via_avion, via_fecha_llegada_estimada, via_fecha_salida, via_ruta_aerea)
			VALUES(AWANTA.obtenerCodigoAeronave(@avion), @llegada_estimada, @salida,
			AWANTA.obtenerCodigoRuta(@ciudad_origen, @ciudad_destino, null))
		END
	ELSE
		BEGIN
			RETURN NULL
		END
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


CREATE PROCEDURE consultar_millas (@dni nvarchar(255))
AS
BEGIN
	SELECT total_millas AS 'Millas Acumuladas' FROM AWANTA.MILLAS_ACUMULADAS, AWANTA.CLIENTE
	WHERE datediff(DAY, getdate(), fecha_vencimiento) < 365 AND
	cli_codigo = cliente_id AND
	cli_nro_doc = @dni
END
GO

SELECT * FROM AWANTA.CLIENTE

INSERT INTO AWANTA.MILLAS_ACUMULADAS(cliente_id, total_millas, fecha_vencimiento) VALUES((SELECT TOP 1 cli_codigo FROM AWANTA.CLIENTE), 1230, GETDATE())

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
SELECT count(1) AS MILLAS FROM AWANTA.MILLAS_ACUMULADAS
SELECT count(1) AS PASAJE FROM AWANTA.PASAJE
SELECT count(1) AS PRODUCTO FROM AWANTA.PRODUCTO
SELECT count(1) AS ROL FROM AWANTA.ROL
SELECT count(1) AS RUTA FROM AWANTA.RUTA_AEREA
SELECT count(1) AS SERVICIO FROM AWANTA.SERVICIO
SELECT count(1) AS TERMINAL FROM AWANTA.TERMINAL
SELECT count(1) AS PAGO FROM AWANTA.TIPO_DE_PAGO
SELECT count(1) AS USUARIO FROM AWANTA.USUARIO
SELECT count(1) AS VIAJE FROM AWANTA.VIAJE
