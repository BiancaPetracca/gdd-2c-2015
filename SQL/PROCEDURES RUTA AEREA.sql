/*------STORED PROCEDURES PARA ABM DE RUTA AEREA------*/

CREATE PROCEDURE AWANTA.altaRutaAerea(@ciudadOrigen NVARCHAR(255),@ciudadDestino NVARCHAR(255),@tipoServicio NVARCHAR(255)
											,@rutaPrecioBasePasaje MONEY,@rutaPrecioBaseKilo MONEY)
AS
	BEGIN
		INSERT INTO AWANTA.RUTA_AEREA(rut_origen,rut_destino,rut_tipo_servicio,rut_precio_base,rut_precio_base_x_kg)
		VALUES (AWANTA.obtenerIdCiudad(@ciudadOrigen),AWANTA.obtenerIdCiudad(@ciudadDestino),AWANTA.buscarIdServicio(@tipoServicio),
					@rutaPrecioBasePasaje,@rutaPrecioBaseKilo)
	END
GO

CREATE PROCEDURE AWANTA.darDeBajaPasajesAsociadosPorBajaDeRutaAerea(@ruta_codigo NUMERIC(18))
AS		
	BEGIN
		DELETE FROM AWANTA.VIAJE WHERE via_fecha_salida > (SELECT CONVERT(date,SYSDATETIME()))
										AND via_ruta_aerea = @ruta_codigo
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
		SET rut_habilitada = 'D'
		WHERE rut_codigo = @pkDeLaRuta
		EXEC AWANTA.darDeBajaPasajesAsociadosPorBajaDeRutaAerea @pkDeLaRuta
	END
GO

/*FALTA HACER UPDATE, BIANCAAA AYUDAAA :P */

