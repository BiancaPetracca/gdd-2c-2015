-------- PRUEBAS -----------
DECLARE @fechaBaja DATETIME, @fechaReinicio DATETIME,  @numero NUMERIC(18)
--set @fechaBaja = AWANTA.getDate()
set @fechaBaja = DATETIMEFROMPARTS(2017, 06, 13, 13, 13, 13, 00) 
set @fechaReinicio = DATETIMEFROMPARTS(2019, 03, 03, 00,00,00,00)
set @numero = 36

 SELECT via_codigo FROM AWANTA.VIAJE where via_avion = 38-- @numero 
AND (via_fecha_salida >= @fechaBaja  OR via_fecha_llegada_estimada >= @fechaBaja) AND via_fecha_llegada IS NULL
AND via_cancelado = 0


EXEC AWANTA.encontrarReemplazosMantenimiento @numero, @fechaBaja, @fechaReinicio

EXEC AWANTA.encontrarReemplazosVidaUtil @numero, @fechaBaja 

DECLARE @butacaReemplazar NUMERIC(18), @viaje NUMERIC(18)
DECLARE butacas_reemplazar CURSOR FOR SELECT pas_butaca, via_codigo FROM AWANTA.VIAJE JOIN AWANTA.PASAJE ON pas_viaje = via_codigo 
WHERE via_avion = @numero AND ((via_fecha_salida BETWEEN @fechaBaja AND @fechaReinicio) OR (via_fecha_llegada_estimada BETWEEN @fechaBaja AND @fechaReinicio))
AND via_cancelado = 0
OPEN butacas_reemplazar
FETCH FROM butacas_reemplazar INTO @butacaReemplazar, @viaje
WHILE @@FETCH_STATUS = 0
BEGIN
UPDATE AWANTA.PASAJE SET pas_butaca = (SELECT TOP 1 but_id FROM AWANTA.BUTACA WHERE but_aeronave = 37 AND
but_id NOT IN(SELECT p.pas_butaca FROM AWANTA.PASAJE p WHERE p.pas_viaje = @viaje))
WHERE pas_butaca = @butacaReemplazar AND pas_viaje = @viaje 
FETCH FROM butacas_reemplazar INTO @butacaReemplazar, @viaje
END
CLOSE butacas_reemplazar
DEALLOCATE butacas_reemplazar
select * from awanta.aeronave where aero_numero = 37
select * from awanta.BUTACA where but_aeronave = 33
select * from awanta.pasaje where pas_viaje = 1
select * from awanta.DEVOLUCIONXPASAJE
select * from awanta.ruta_aerea
 join awanta.ciudad o on rut_origen = o.ciu_id join awanta.ciudad d on rut_destino = d.ciu_id
 where rut_codigo = 47

select * from awanta.viaje where via_avion = 37
select  * from awanta.HISTORICO_BAJAS where baja_avion = 37
delete from awanta.HISTORICO_BAJAS where baja_avion = 38
update awanta.pasaje set pas_butaca = 1349 where pas_butaca = 1353 and pas_viaje = 8520
update awanta.pasaje set pas_butaca = 1350 where pas_butaca = 1354 and pas_viaje = 8520
update awanta.pasaje set pas_butaca = 1351 where pas_butaca = 1355 and pas_viaje = 8520

select * from awanta.pasaje where pas_viaje = 8510