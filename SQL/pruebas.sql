-------- PRUEBAS -----------
DECLARE @modelo NUMERIC(18), @fabricante NUMERIC(18), @servicio NUMERIC(18), @butacas NUMERIC(18,2), @kgs NUMERIC(18,2)
SELECT @modelo =  mod_id, @fabricante = fab_id, @servicio = aero_id_servicio FROM AWANTA.AERONAVE 
JOIN AWANTA.MODELO ON mod_id = aero_modelo 
JOIN AWANTA.FABRICANTE ON mod_fabricante = fab_id 
WHERE aero_numero = 33
GROUP BY aero_numero, mod_id, fab_id, aero_id_servicio

SET @butacas = (SELECT COUNT(pas_butaca) FROM AWANTA.PASAJE JOIN AWANTA.VIAJE ON pas_viaje = via_codigo 
WHERE via_avion = 33 AND (via_cancelado IS NULL or via_cancelado = 0) AND pas_cancelado = 0)
SET @kgs = isnull((SELECT SUM(enc_kg) FROM AWANTA.ENCOMIENDA JOIN AWANTA.VIAJE ON enc_viaje = via_codigo WHERE via_avion = 33
AND (via_cancelado IS NULL OR via_cancelado = 0) AND enc_cancelado = 0),0)

DECLARE @aero_reemplazo NUMERIC(18)

DECLARE @fechaBaja DATETIME, @fechaReinicio DATETIME
set @fechaBaja = AWANTA.getDate()
set @fechaReinicio = DATETIMEFROMPARTS(2019, 03, 03, 00,00,00,00)

SELECT Aeronaves.aero_numero as Numero,
(SELECT COUNT(pas_butaca) FROM AWANTA.PASAJE JOIN AWANTA.VIAJE ON pas_viaje = via_codigo 
WHERE via_avion = Aeronaves.aero_numero AND (via_cancelado IS NULL or via_cancelado = 0) AND pas_cancelado = 0) AS ButacasOcupadas,
isnull((SELECT SUM(enc_kg) FROM AWANTA.ENCOMIENDA JOIN AWANTA.VIAJE ON enc_viaje = via_codigo WHERE via_avion = Aeronaves.aero_numero
AND (via_cancelado IS NULL OR via_cancelado = 0) AND enc_cancelado = 0),0) AS KgsOcupados,
(SELECT COUNT(but_id) FROM AWANTA.BUTACA WHERE but_aeronave = Aeronaves.aero_numero) AS ButacasTotales,
Aeronaves.aero_kgs_disponibles_encomiendas as KgsTotales
 FROM (SELECT aero_numero, aero_kgs_disponibles_encomiendas FROM AWANTA.AERONAVE
JOIN AWANTA.MODELO ON mod_id = aero_modelo
JOIN AWANTA.FABRICANTE ON fab_id = mod_fabricante
WHERE aero_numero NOT IN (SELECT via_avion FROM AWANTA.VIAJE WHERE (via_fecha_salida BETWEEN @fechaBaja AND @fechaReinicio) OR (via_fecha_llegada_estimada BETWEEN @fechaBaja AND @fechaReinicio))
AND aero_numero NOT IN (SELECT baja_avion FROM AWANTA.HISTORICO_BAJAS WHERE baja_motivo = 0 OR (baja_fecha BETWEEN @fechaBaja AND @fechaReinicio) OR
(baja_reinicio BETWEEN @fechaBaja AND @fechaReinicio)) AND aero_id_servicio = @servicio AND mod_id = @modelo AND  fab_id = @fabricante
AND aero_numero <> 33) AS Aeronaves
GROUP BY Aeronaves.aero_numero, Aeronaves.aero_kgs_disponibles_encomiendas


select * from awanta.DEVOLUCIONXENCOMIENDA
select * from awanta.DEVOLUCIONXPASAJE

select * from awanta.pasaje where pas_pasajero = 2595
select * from awanta.encomienda where enc_encomendador = 2595