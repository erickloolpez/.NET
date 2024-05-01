select * from factura

select * from historial_plan

select * from suscripcion

delete from factura where id ='PMA-102';

delete from historial_plan where id = 102

delete from suscripcion where id = 'puto'


create procedure sp_ID_Suscripcion
as
begin
	SELECT TOP 1 *
	FROM suscripcion
	ORDER BY creado_en DESC;
end;

