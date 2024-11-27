CREATE DATABASE db_gestorPedidos
GO
USE db_gestorPedidos;
GO

CREATE TABLE [Remitentes] (
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [nombre] VARCHAR(100) NOT NULL,
    [direcc_rem] VARCHAR(100) NOT NULL
);
GO

--INSERTAR INFO E IMPRIMIRLA
INSERT INTO [Remitentes] ([nombre], [direcc_rem]) VALUES ('Jaime', 'carrera 1#33');
SELECT * FROM [Remitentes];
--

CREATE TABLE [Productos] (
    [id_prod] INT PRIMARY KEY IDENTITY(1,1),
    [nom_prod] VARCHAR(100) NOT NULL,
    [precio] DECIMAL(10, 2) NOT NULL,
    [cantidad] INT NOT NULL,
    [iva] DECIMAL(5, 2) NOT NULL
);
GO

CREATE TABLE [Pedidos] (
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [cod_pedido] INT NOT NULL,
    [descripcion] TEXT NOT NULL,
    [medidas] VARCHAR(255) NOT NULL,
    [estado] VARCHAR(50) NOT NULL,
    [remitente_id] INT,
    FOREIGN KEY ([remitente_id]) REFERENCES [Remitentes]([id])
);
GO

CREATE TABLE [Metodos_de_pago] (
    [id_pag] INT PRIMARY KEY IDENTITY(1,1),
    [tipo] VARCHAR(50) NOT NULL
);
GO

CREATE TABLE [Mensajeros] (
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [transportista] VARCHAR(100) NOT NULL
);
GO

CREATE TABLE [Clientes] (
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [cedula] VARCHAR(20) NOT NULL,
    [nombre] VARCHAR(100) NOT NULL,
    [telefono] VARCHAR(15) NOT NULL,
    [direcc] VARCHAR(255) NOT NULL
);
GO

CREATE TABLE [Detalles] (
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [producto_id] INT,
    [pedido_id] INT,
    FOREIGN KEY ([producto_id]) REFERENCES [Productos]([id_prod]),
    FOREIGN KEY ([pedido_id]) REFERENCES [Pedidos]([id])
);
GO

CREATE TABLE [Facturas] (
    [id_fac] INT PRIMARY KEY IDENTITY(1,1),
    [cliente_id] INT,
    [fecha] DATE NOT NULL,
    [m_pago_id] INT,
    [iva] DECIMAL(5, 2) NOT NULL,
    [total] DECIMAL(10, 2) NOT NULL,
    [remitente_id] INT,
    [mensajero_id] INT,
    [detalle_id] INT,
    FOREIGN KEY ([cliente_id]) REFERENCES [Clientes]([id]),
    FOREIGN KEY ([m_pago_id]) REFERENCES [Metodos_de_pago]([id_pag]),
    FOREIGN KEY ([remitente_id]) REFERENCES [Remitentes]([id]),
    FOREIGN KEY ([mensajero_id]) REFERENCES [Mensajeros]([id]),
    FOREIGN KEY ([detalle_id]) REFERENCES [Detalles]([id])
);
GO

CREATE TABLE [Usuarios] (
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [usuario] NVARCHAR(255) NULL,
    [password] NVARCHAR(255) NULL
);
GO

CREATE TABLE [Roles] (
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [rol] NVARCHAR(255) NULL
);
GO

CREATE TABLE [Auditorias] (
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [tabla] NVARCHAR(255) NULL,
    [referencia] INT NOT NULL,
    [accion] NVARCHAR(255) NOT NULL
);

