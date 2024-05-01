drop procedure CrearSuscripciones

CREATE PROCEDURE CrearSuscripciones
    @n int
AS
BEGIN
    DECLARE @i int = 1;
    WHILE @i <= @n
    BEGIN
        DECLARE @ID_Suscripcion nvarchar(255) = 'SUS-' + CAST(@i AS NVARCHAR);
        DECLARE @Cliente_ID nvarchar(10) = CAST(@i as nvarchar);
        DECLARE @Plan_ID nvarchar(10) = 'PLAN-' + CAST(FLOOR((RAND() * 5 + 1)) as nvarchar);
        DECLARE @Fecha_Suscripcion date = DATEADD(day, (RAND() * 365), GETDATE());

        INSERT INTO suscripcion(ID, cliente_id, plan_id, fecha_suscripcion)
        VALUES (@ID_Suscripcion, @Cliente_ID, @Plan_ID, @Fecha_Suscripcion);

        SET @i = @i + 1;
    END
END
GO


exec CrearSuscripciones @n = 100

select * from suscripcion;