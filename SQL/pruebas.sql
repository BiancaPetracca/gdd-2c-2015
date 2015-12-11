-------- PRUEBAS -----------
DECLARE @fechaBaja DATETIME, @fechaReinicio DATETIME,  @numero NUMERIC(18)
--set @fechaBaja = AWANTA.getDate()
set @fechaBaja = DATETIMEFROMPARTS(2017, 06, 13, 13, 13, 13, 00) 
set @fechaReinicio = DATETIMEFROMPARTS(2019, 03, 03, 00,00,00,00)
set @numero = 36


select * from awanta.RUTA_AEREA