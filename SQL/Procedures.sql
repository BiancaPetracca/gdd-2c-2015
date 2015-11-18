/*----------STORED PROCEDURES APLICACION----------*/ 

CREATE FUNCTION AWANTA.getDate() RETURNS DATETIME
AS BEGIN 
RETURN DATETIMEFROMPARTS(2017, 05, 13, 13, 13, 13, 000)
END
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


SELECT * FROM AWANTA.USUARIO

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
EXEC AWANTA.get_funcionalidades_que_no_tiene 'Cliente'


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

SELECT * FROM AWANTA.ROL
DELETE  FROM AWANTA.ROL WHERE rol_id > 2

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
	JOIN AWANTA.SERVICIO ON serv_id_servicio = rut_tipo_servicio
	WHERE (rut_habilitada = @habilitada) AND
	(@destino IS NULL OR rut_destino=AWANTA.obtenerIdCiudad(@destino)) AND
	(@origen IS NULL OR rut_origen=AWANTA.obtenerIdCiudad(@origen)) AND
	(@precio_base_pasaje IS NULL OR rut_precio_base=@precio_base_pasaje) AND
	(@precio_base_kg IS NULL OR rut_precio_base_x_kg=@precio_base_kg) AND
	(@servicio IS NULL OR rut_tipo_servicio=AWANTA.buscarIdServicio(@servicio))
END

GO
ALTER PROCEDURE AWANTA.modificar_ruta(@codigo NUMERIC, @origen nvarchar(255),  @destino nvarchar(255),  @habilitada int, @servicio nvarchar(255), @precio_base_kg money, @precio_base_pasaje money) AS
 BEGIN
 DECLARE @id_servicio NUMERIC(18)
 SET @id_servicio = AWANTA.buscarIdServicio(@servicio)
 UPDATE AWANTA.RUTA_AEREA SET rut_origen = AWANTA.obtenerIdCiudad(@origen), rut_destino = AWANTA.obtenerIdCiudad(@destino), rut_tipo_servicio = @id_servicio,
  rut_habilitada = @habilitada, rut_precio_base_x_kg = @precio_base_kg, rut_precio_base = @precio_base_pasaje
 WHERE @codigo = rut_codigo 
 END
 GO

 EXEC AWANTA.modificar_ruta 1, 'Bruselas', 'Buenos Aires', 1, 'Turista', 666, 0 

ALTER PROCEDURE AWANTA.altaRutaAerea(@ciudadOrigen NVARCHAR(255), @ciudadDestino NVARCHAR(255), @tipoServicio NVARCHAR(255), @rutaPrecioBasePasaje MONEY, @rutaPrecioBaseKilo MONEY, @habilitada bit)
AS
	BEGIN
		INSERT INTO AWANTA.RUTA_AEREA(rut_origen,rut_destino,rut_tipo_servicio,rut_precio_base,rut_precio_base_x_kg, rut_habilitada)
		VALUES (AWANTA.obtenerIdCiudad(@ciudadOrigen),AWANTA.obtenerIdCiudad(@ciudadDestino),AWANTA.buscarIdServicio(@tipoServicio),
					@rutaPrecioBasePasaje,@rutaPrecioBaseKilo, @habilitada)
					RETURN 1
	END
GO
SELECT * FROM AWANTA.RUTA_AEREA where rut_precio_base = 666
EXEC AWANTA.altaRutaAerea 'Buenos Aires', 'Bruselas', 'Ejecutivo', 666, 0, 1

ALTER PROCEDURE AWANTA.darDeBajaPasajesAsociadosPorBajaDeRutaAerea(@ruta NUMERIC(18))
AS		
	BEGIN
	UPDATE AWANTA.VIAJE SET via_cancelado = 0 WHERE via_ruta_aerea = @ruta -- en un trigger mejor me parece
	DELETE FROM AWANTA.COMPRA WHERE EXISTS (SELECT 1 FROM AWANTA.VIAJE WHERE compra_viaje = via_codigo
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

CREATE PROCEDURE AWANTA.get_aeronaves(@estado numeric(1) = null, @filtro nvarchar(255) = null)
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
	(@numero IS NULL OR aero_numero_de_aeronave=@numero) AND
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
		JOIN AERONAVE ON aero_matricula = via_avion AND aero_numero_de_aeronave = @aero_numero_de_aeronave 
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
WHERE (SELECT AWANTA.tieneViajesAsignados(aero_numero_de_aeronave, @fechaSalida, @fechaEstimadaLlegada)) = 0
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
WHERE (SELECT AWANTA.tieneViajesAsignados(aero_numero_de_aeronave, @fechaSalida, @fechaEstimadaLlegada)) = 0
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
	SELECT @numeroAvionDeReemplazo = aero_reemplazo.aero_numero_de_aeronave, @matriculaAvionDeReemplazo = aero_reemplazo.aero_matricula FROM AWANTA.AERONAVE aero_reemplazo, AWANTA.AERONAVE aero_orig
	WHERE aero_reemplazo.aero_fabricante = aero_orig.aero_fabricante AND aero_reemplazo.aero_id_servicio = aero_orig.aero_id_servicio AND aero_orig.aero_modelo = aero_reemplazo.aero_modelo
	AND aero_orig.aero_matricula <> aero_reemplazo.aero_matricula AND aero_reemplazo.aero_estado = 1 AND 
	(SELECT AWANTA.tieneViajesAsignados(aero_reemplazo.aero_numero_de_aeronave, aero_orig.aero_baja_fuera_de_servicio, aero_orig.aero_fecha_reinicio_servicio)) = 0
	
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
		SELECT @numero = aero_numero_de_aeronave FROM AWANTA.AERONAVE WHERE @matricula = aero_matricula
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
					WHERE aero_numero_de_aeronave = @numero
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
		SELECT @numero = aero_numero_de_aeronave FROM AWANTA.AERONAVE WHERE @matricula = aero_matricula
		IF (@numero IS NOT NULL)
			BEGIN
				UPDATE AWANTA.AERONAVE
				SET aero_baja_fuera_de_servicio = (SELECT CONVERT(date,AWANTA.getDate())),
				aero_fecha_reinicio_servicio = @fechaReinicio,
				aero_estado = 0
				WHERE aero_numero_de_aeronave = @numero
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
	SET @codigo = (SELECT aero_numero_de_aeronave FROM AWANTA.AERONAVE WHERE aero_matricula = @matricula)
	RETURN @codigo
END
GO

ALTER PROCEDURE AWANTA.modificarAeronave(@numero numeric(18), @matricula nvarchar(255), @modelo nvarchar(255), @fabricante nvarchar(255), @servicio nvarchar(255), 
@cantidadKgsEncomiendas numeric, @cantidadButacasVentanilla  numeric, @cantidadButacasPasillo numeric, @estado bit) 
AS 
BEGIN
IF EXISTS(SELECT 1 FROM AWANTA.AERONAVE WHERE aero_matricula = @matricula AND aero_numero_de_aeronave <> @numero) BEGIN RETURN -1 END
DECLARE @numero_servicio NUMERIC(18), @matricula_vieja NVARCHAR(255)
SELECT @matricula_vieja = aero_matricula FROM AWANTA.AERONAVE WHERE aero_numero_de_aeronave = @numero
SELECT @numero_servicio = serv_id_servicio FROM SERVICIO WHERE serv_nombre = @servicio
ALTER TABLE AWANTA.VIAJE NOCHECK CONSTRAINT ALL
UPDATE AWANTA.AERONAVE 
SET aero_matricula = @matricula, aero_modelo = @modelo, aero_fabricante = @fabricante, aero_id_servicio = @numero_servicio,
aero_kgs_disponibles_encomiendas = @cantidadKgsEncomiendas, aero_cantidad_butacas_ventanilla = @cantidadButacasVentanilla, 
aero_cantidad_butacas_pasillo = @cantidadButacasPasillo, aero_estado = @estado
WHERE aero_numero_de_aeronave = @numero
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
	via_avion = aero_numero_de_aeronave
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


ALTER PROCEDURE consultar_millas (@dni nvarchar(255))
AS
BEGIN
	SELECT total_millas AS 'Millas Acumuladas' FROM AWANTA.MILLAS_ACUMULADAS, AWANTA.CLIENTE
	WHERE datediff(DAY, AWANTA.getDate(), fecha_vencimiento) < 365 AND
	cli_codigo = cliente_id AND
	cli_nro_doc = @dni
END
GO

SELECT * FROM AWANTA.CLIENTE

INSERT INTO AWANTA.MILLAS_ACUMULADAS(cliente_id, total_millas, fecha_vencimiento) VALUES((SELECT TOP 1 cli_codigo FROM AWANTA.CLIENTE), 1230, GETDATE())

GO

/*------LISTADOS ESTADISTICOS------*/

CREATE PROCEDURE destinos_con_mas_pasajes_vendidos
AS
	BEGIN
		SELECT TOP 5  C.ciu_nombre
		FROM AWANTA.CIUDAD C 
		JOIN AWANTA.RUTA_AEREA R ON C.ciu_id = R.rut_destino 
		JOIN AWANTA.VIAJE V ON R.rut_codigo = V.via_ruta_aerea
		JOIN AWANTA.COMPRA COM ON COM.compra_viaje = V.via_codigo
		JOIN AWANTA.PASAJE P ON P.pas_compra = COM.compra_id
		GROUP BY C.ciu_nombre
		ORDER BY COUNT(R.rut_destino) DESC
	END
GO
/*test bobo*/
SELECT COUNT(1) FROM gd_esquema.Maestra M WHERE Ruta_Ciudad_Destino LIKE '%Nueva York' AND Pasaje_Codigo != 0
go

CREATE PROCEDURE destinos_con_aeronaves_mas_vacias
AS
	BEGIN
		SELECT 
	END
GO

INSERT INTO AWANTA.MILLAS_ACUMULADAS(cliente_id, total_millas, fecha_vencimiento) VALUES((SELECT TOP 1 cli_codigo FROM AWANTA.CLIENTE), 1230, AWANTA.getDate())

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
