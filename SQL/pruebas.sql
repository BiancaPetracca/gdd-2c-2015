-------- PRUEBAS -----------
DECLARE @fechaBaja DATETIME, @fechaReinicio DATETIME,  @numero NUMERIC(18)
--set @fechaBaja = AWANTA.getDate()
set @fechaBaja = DATETIMEFROMPARTS(2017, 06, 13, 13, 13, 13, 00) 
set @fechaReinicio = DATETIMEFROMPARTS(2019, 03, 03, 00,00,00,00)
set @numero = 36

select * from awanta.AERONAVE where aero_numero = 32
select * from awanta.RUTA_AEREA where rut_codigo = 71
SELECT * FROM AWANTA.CIUDAD WHERE ciu_id = 26
select * from awanta.DEVOLUCIONXENCOMIENDA
select * from awanta.DEVOLUCIONXPASAJE
select * from awanta.encomienda JOIN AWANTA.VIAJE ON enc_viaje = via_codigo where enc_encomendador = 1 and YEAR(via_fecha_llegada) = 2017
select * from awanta.pasaje JOIN AWANTA.VIAJE ON pas_viaje = via_codigo where pas_PASAJERO = 1 and YEAR(via_fecha_llegada) = 2017
select * from awanta.HISTORICO_BAJAS
select * from awanta.encomienda
select * from awanta.viaje where via_codigo = 8520

select * from awanta.butaca where but_id = 1340

select * from gd_esquema.Maestra

select awanta.get_millas_pasajes('DNI', 1122696)

select awanta.get_millas_encomiendas('DNI', 1122696)