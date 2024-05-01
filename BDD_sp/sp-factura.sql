CREATE PROCEDURE CrearFacturas
    @n int
AS
BEGIN
    -- Crear una tabla de valores para el total
    DECLARE @Total TABLE (Valor decimal);
    INSERT INTO @Total VALUES (9.99), (12), (15), (200), (400), (600);

    DECLARE @i int = 1;
    WHILE @i <= @n
    BEGIN
        DECLARE @ID_Factura nvarchar(255) = 'FAC-' + CAST(@i AS NVARCHAR);
        DECLARE @Suscripcion_ID nvarchar(10) = 'SUS-' + CAST(@i AS NVARCHAR);
        DECLARE @Plan_Historial_ID int = @i;
        DECLARE @Fecha_Inicio date = DATEADD(month, -(@i % 12), GETDATE());
        DECLARE @Fecha_Final date = DATEADD(month, (@i % 12), @Fecha_Inicio);

        -- Seleccionar un valor aleatorio para el total
        DECLARE @TotalRandom decimal;
        SELECT TOP 1 @TotalRandom = Valor FROM @Total ORDER BY NEWID();

        IF @Fecha_Final > @Fecha_Inicio
        BEGIN
            INSERT INTO factura(id, suscripcion_id, plan_historial_id, fecha_inicio, fecha_final, total)
            VALUES (@ID_Factura, @Suscripcion_ID, @Plan_Historial_ID, @Fecha_Inicio, @Fecha_Final, @TotalRandom);
        END

        SET @i = @i + 1;
    END
END
GO


exec CrearFacturas @n = 100

select * from factura