CREATE PROCEDURE sp_SuscripcionesPorPlan
AS
BEGIN
    SELECT p.nombre AS 'Nombre del plan', COUNT(s.id) AS 'Número de suscripciones'
    FROM planes p
    JOIN suscripcion s ON p.id = s.plan_id
    GROUP BY p.nombre;
END;

exec sp_SuscripcionesPorPlan;
