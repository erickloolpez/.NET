CREATE PROCEDURE sp_TotalFacturadoPorCliente
AS
BEGIN
    SELECT c.nombre, SUM(f.total) AS 'Total facturado'
    FROM cliente c
    JOIN suscripcion s ON c.id = s.cliente_id
    JOIN factura f ON s.id = f.suscripcion_id
    GROUP BY c.nombre;
END;


exec sp_TotalFacturadoPorCliente