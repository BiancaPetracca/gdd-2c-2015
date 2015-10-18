/*------ABM DE AERONAVES------*/

CREATE PROCEDURE AWANTA.altaDeAeronave(@matricula NVARCHAR(255),@modelo NVARCHAR(255),@fabricante NVARCHAR(255),@servicio NVARCHAR(255)
										,@butacasPasillo INT,@butacasVentanilla INT,@kilosDisponibles INT)
AS
	BEGIN
		BEGIN TRY
		IF NOT EXISTS (SELECT 1 FROM AWANTA.AERONAVE WHERE @matricula = aero_matricula)
			BEGIN
				INSERT INTO AWANTA.AERONAVE (aero_matricula,aero_modelo,aero_fabricante,id_servicio,
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

CREATE PROCEDURE AWANTA.bajaDeViajesAsociadosConAeronave(@numero NUMERIC(18))
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