select * from suscripcion


insert into suscripcion(id, cliente_id, plan_id, fecha_suscripcion) values('SUS-102','2','PLAN-3',getdate())

drop trigger tr_Historial_Factura



CREATE TRIGGER tr_Historial_Factura
ON suscripcion
AFTER INSERT
AS
BEGIN
	DECLARE @suscripcion_id varchar(10), @plan_id varchar(10), @fecha_suscripcion DATETIME, @plan_precio decimal(8,2), @id_historial int , @fecha_final date, @id_factura varchar(10) = 'PMA-';
	SELECT @suscripcion_id = id, @plan_id = plan_id, @fecha_suscripcion = fecha_suscripcion
	FROM inserted;

	SELECT TOP 1 @id_historial = id
	FROM historial_plan
	ORDER BY id DESC;

	set @id_historial = @id_historial+1;


	if @plan_id in ('PLAN-1', 'PLAN-2', 'PLAN-3')
		begin
			set @fecha_final = dateadd(month,1,@fecha_suscripcion);
			INSERT INTO historial_plan (id, suscripcion_id, plan_id, fecha_comienzo, fecha_final)
			VALUES (@id_historial ,@suscripcion_id, @plan_id, @fecha_suscripcion,@fecha_final);
		end
	else
		begin
			set @fecha_final = dateadd(year,1,@fecha_suscripcion);
			INSERT INTO historial_plan (id, suscripcion_id, plan_id, fecha_comienzo, fecha_final)
			VALUES (@id_historial ,@suscripcion_id, @plan_id, @fecha_suscripcion,@fecha_final);
		end


	SELECT @plan_precio = precio FROM planes WHERE id = @plan_id;

	set @id_factura = @id_factura + cast(@id_historial as varchar);

	INSERT INTO factura (id,suscripcion_id, plan_historial_id, fecha_inicio,fecha_final, total)
	VALUES (@id_factura, @suscripcion_id,@id_historial ,@fecha_suscripcion,@fecha_final,@plan_precio);
END;
