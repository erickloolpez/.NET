CREATE PROCEDURE CrearHistorialPlan
    @n int
AS
BEGIN
    DECLARE @i int = 1;
    WHILE @i <= @n
    BEGIN
        DECLARE @ID_Historial int = @i;
        DECLARE @Suscripcion_ID nvarchar(255) = 'SUS-' + CAST(@i AS NVARCHAR);
        DECLARE @Plan_ID nvarchar(255) = 'PLAN-' + CAST(FLOOR((RAND() * 5 + 1)) as nvarchar);
        DECLARE @Fecha_Comienzo date = DATEADD(day, (RAND() * 365), GETDATE());
        DECLARE @Fecha_Final date = DATEADD(day, ABS(CHECKSUM(NewId())) % 365, @Fecha_Comienzo);

        INSERT INTO historial_plan(id, suscripcion_id, plan_id, fecha_comienzo, fecha_final)
        VALUES (@ID_Historial, @Suscripcion_ID, @Plan_ID, @Fecha_Comienzo, @Fecha_Final);

        SET @i = @i + 1;
    END
END
GO

exec CrearHistorialPlan @n = 100

select * from historial_plan

drop procedure CrearHistorialPlan