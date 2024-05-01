CREATE PROCEDURE sp_IngresosPorPlan
AS
BEGIN
    SELECT pl.nombre, SUM(f.total) AS 'Ingresos Totales'
    FROM factura f
    JOIN suscripcion s ON f.suscripcion_id = s.id
    JOIN planes pl ON s.plan_id = pl.id
    WHERE f.factura_cancelada IS NULL
    GROUP BY pl.nombre;
END;
