CREATE TABLE [cliente] (
  [id] varchar(10) PRIMARY KEY,
  [nombre] varchar(64) NOT NULL,
  [apellido] varchar(64) NOT NULL,
  [email] varchar(128) NOT NULL,
  [creado_en] datetime
)
GO

CREATE TABLE [suscripcion] (
  [id] varchar(255) PRIMARY KEY,
  [cliente_id] varchar(10),
  [plan_id] varchar(10),
  [fecha_suscripcion] date NOT NULL,
  [creado_en] datetime
)
GO

CREATE TABLE [planes] (
  [id] varchar(10) PRIMARY KEY,
  [nombre] varchar(20) NOT NULL,
  [tipo] varchar(10) NOT NULL,
  [precio] decimal(8,2) NOT NULL,
  [creado_en] datetime
)
GO

CREATE TABLE [factura] (
  [id] varchar(255) PRIMARY KEY,
  [suscripcion_id] varchar(255),
  [plan_historial_id] int,
  [fecha_inicio] date NOT NULL,
  [fecha_final] date NOT NULL,
  [total] decimal(8,2) NOT NULL,
  [factura_cancelada] datetime
)
GO

CREATE TABLE [historial_plan] (
  [id] int PRIMARY KEY,
  [suscripcion_id] varchar(255),
  [plan_id] varchar(10),
  [fecha_comienzo] date NOT NULL,
  [fecha_final] date NOT NULL,
  [creado_en] datetime
)
GO

ALTER TABLE [suscripcion] ADD FOREIGN KEY ([cliente_id]) REFERENCES [cliente] ([id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [historial_plan] ADD FOREIGN KEY ([plan_id]) REFERENCES [planes] ([id]) ON UPDATE CASCADE
GO

ALTER TABLE [factura] ADD FOREIGN KEY ([plan_historial_id]) REFERENCES [historial_plan] ([id]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [factura] ADD FOREIGN KEY ([suscripcion_id]) REFERENCES [suscripcion] ([id])
GO

ALTER TABLE [suscripcion] ADD FOREIGN KEY ([plan_id]) REFERENCES [planes] ([id])
GO

ALTER TABLE [historial_plan] ADD FOREIGN KEY ([suscripcion_id]) REFERENCES [suscripcion] ([id])
GO
