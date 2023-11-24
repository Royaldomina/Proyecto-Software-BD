create database BakeBooker;
use BakeBooker;
--crear todos los stores procedures o trigger para implementarlos en windows form

create table Cliente
(
ID_cliente smallint identity(1,1),
Nombre Varchar(30) not null,
Apellido Varchar(30),
Calle Varchar(30) not null,
Numero_Exterior int not null,
Numero_interior int,
Telefono char(10) not null,
Correo_electronico varchar(50),
RFC varchar(13),
Fecha_alta datetime default getdate(),
constraint PK_ID_cliente primary key (ID_cliente)
)
--alter table cliente
--add Fecha_alta datetime default getdate();
--alter table Cliente
--add Fecha_alta datetime default getdate();


create table Empleado
(
ID_empleado smallint identity(1,1),
Nombre varchar(30) not null,
Apellido varchar(30),
Puesto Varchar(30) not null,
constraint PK_ID_empleado primary key (ID_empleado),
CONSTRAINT CK_puesto CHECK (Puesto = 'Administrador' OR Puesto = 'General')
)
--alter table Empleado
--drop column Usuario, Contraseña;

create table Pedido 
(
    ID_pedido smallint identity(1,1),
    ID_cliente smallint not null,
    ID_empleado smallint not null,
    Fecha_de_pedido datetime default getdate(),
    Anticipo MONEY,
    Total MONEY,
	Falta_Liquidar AS (Total - Anticipo),
	Fecha_de_entrega datetime,
	Fecha_de_entrega datetime DEFAULT DATEADD(MINUTE, 5, GETDATE())
	CONSTRAINT PK_ID_pedido PRIMARY KEY (ID_pedido),
    CONSTRAINT FK_ID_cliente FOREIGN KEY (ID_cliente) REFERENCES Cliente (ID_cliente),
    CONSTRAINT FK_ID_empleado FOREIGN KEY (ID_empleado) REFERENCES Empleado (ID_empleado),
	CONSTRAINT CK_Forma_entrega CHECK (Forma_entrega='Recoger' or Forma_entrega='Llevar')
)

--falta liquidar=0 hacer un trigger, total se sumara al reporte como ingreso en ese mes o semana

--agregar fecha de entrega con alter
--en windows forms, checar la fecha de entrega y modificar color o notificacion en base fecha de entrega
--agregar varchar de sera para llevar
--en windows forms intentar aplicar el correo a traves de txtbox

create table Pedido_detalles 
(
ID_detalle smallint identity(1,1),
ID_pedido smallint not null,
Cantidad_Pisos INT not null default 1,
Sabor_Pan VARCHAR(50),
Relleno_Pan VARCHAR(50) ,
Tamaño_Pastel VARCHAR(50) not null,
Cantidad_Personas INT default 10,
Foto varchar(100),
Precio money not null default 100,
Notas varchar(100),
constraint PK_ID_detalle primary key (ID_detalle),
Constraint FK_ID_Pedido foreign key (ID_pedido) references Pedido (ID_pedido),
)

--agregar foto
--alter cantidad a 10 personas txt
--precio en txt
--combobox hasta 6 en cantidad pisos, en relleno_pan textbox,
--tamano_pastel en txtbox
--sabor pan en not null por cosas como flan o postres
--eliminar forma_pastel
--agregar notas
CREATE TABLE Detalles_Inventario_Pedido (
    ID_detalle_inventario smallint identity(1,1),
    ID_detalle_pedido smallint not null,
    ID_inventario smallint not null,
    Cantidad_inventario int not null,
    CONSTRAINT PK_ID_detalle_inventario PRIMARY KEY (ID_detalle_inventario),
    CONSTRAINT FK_ID_detalle_pedido FOREIGN KEY (ID_detalle_pedido) REFERENCES Pedido_detalles (ID_detalle),
    CONSTRAINT FK_ID_inventario FOREIGN KEY (ID_inventario) REFERENCES Inventario (ID_inventario)
);
--automatizar cantidad_de_producto dependiendo de la cantida de persona de pedido_detalle

create table Inventario 
(
ID_inventario smallint identity(1,1),
Nombre varchar(30),
Medicion_de_producto varchar(20),
Cantidad_de_producto int,
Expiracion datetime,
constraint PK_ID_inventario primary key (ID_inventario),
CONSTRAINT CK_medicion CHECK (Medicion_de_producto ='Unidad' or Medicion_de_producto='Miligramo' or Medicion_de_producto ='Gramo' or Medicion_de_producto='Litro')
)

--son ingredientes o insumos dejar como inventario
--quitar descripcion
--modificar CK con gramo y mililitro y litro con combobox
--automatizar por tamaño y evitar escribirlo tanto en windows forms
--como quitar precio_producto


create table Producto
(
ID_producto INT IDENTITY(1,1),
Nombre VARCHAR(50) NOT NULL,
Descripcion VARCHAR(80),
Precio money not null,
Fecha_Ingreso DATETIME DEFAULT GETDATE(),
Cantidad_Disponible INT DEFAULT 0,
Fecha_expiracion datetime DEFAULT DATEADD(DAY, 3, GETDATE()),
Foto varchar(100),
constraint PK_ID_producto primary key (ID_producto),
)

--quitar ID_pedido se utiliza ya
--posiblemente cambiar nombre 
--agregar foto predeterminada
--modificar fecha de expiracion y agregarlo a windows forms

CREATE TABLE Pedido_Producto (
    ID_PEDIDOPRODUCTO INT IDENTITY(1,1) PRIMARY KEY,
    ID_pedido smallint not null,
    ID_producto INT not null,
    Cantidad INT not null,
    CONSTRAINT UQ_ID_PEDIDOPRODUCTO UNIQUE (ID_PEDIDOPRODUCTO), -- Constraint para garantizar unicidad
    CONSTRAINT FK_ID_pedido_pedido_producto FOREIGN KEY (ID_pedido) REFERENCES Pedido (ID_pedido),
    CONSTRAINT FK_ID_pedido_pedido_producto FOREIGN KEY (ID_pedido) REFERENCES Pedido (ID_pedido)
);
-- Insertar datos en la tabla Cliente
--posiblemente agregfar nombre de producto si utilizo el combobox
--combobox con nombre de producto
--cantidad en txt
/*
INSERT INTO Cliente (Nombre, Apellido, Calle, Numero_Exterior, Numero_interior, Telefono, Correo_electronico, RFC)
VALUES 
    ('Juan', 'López', 'Calle 1', 10, NULL, '1234567890', 'juan@email.com', 'ABC12345678'),
    ('María', 'García', 'Calle 2', 20, 3, '9876543210', 'maria@email.com', 'XYZ9876543210'),
    ('Pedro', 'Martínez', 'Calle 3', 30, NULL, '5551112233', 'pedro@email.com', 'PQR5678901234'),
    ('Ana', 'Pérez', 'Calle 4', 40, 5, '7778889999', 'ana@email.com', 'DEF6789012345'),
    ('Luis', 'Sánchez', 'Calle 5', 50, NULL, '3332221111', 'luis@email.com', 'GHI4567890123');
--Insertar datos en la tabla Empleado, tuve que agregar el usuario y contraseña
INSERT INTO Empleado (Nombre, Apellido, Puesto)
VALUES 
    ('Carlos', 'Gómez', 'Administrador', 'CGomez', 'P@ssw0rd1'),
    ('Laura', 'Hernández', 'General', 'LHernandez', 'P@ssw0rd2'),
    ('Roberto', 'Díaz', 'Administrador', 'RDiaz', 'P@ssw0rd3'),
    ('Sofía', 'Fernández', 'General', 'SFernandez', 'P@ssw0rd4'),
    ('Javier', 'López', 'Administrador', 'JLopez', 'P@ssw0rd5');
-- Insertar datos en la tabla Pedido
INSERT INTO Pedido (ID_cliente, ID_empleado, Anticipo, Total, Estado, Foto)
VALUES 
    (1, 2, 50.00, 200.00, 'En proceso', 'foto1.jpg'),
    (3, 4, 30.00, 150.00, 'Entregado', 'foto2.jpg'),
    (2, 5, 80.00, 300.00, 'Enviado', 'foto3.jpg'),
    (4, 1, 20.00, 100.00, 'En proceso', 'foto4.jpg'),
    (5, 3, 40.00, 180.00, 'Enviado', 'foto5.jpg');
-- Insertar datos en la tabla Pedido_detalles
INSERT INTO Pedido_detalles (ID_pedido, Cantidad_Pisos, Sabor_Pan, Relleno_Pan, Tamaño_Pastel, Forma_Pastel, Cantidad_Personas)
VALUES 
    (1, 2, 'Vainilla', 'Chocolate', 'Mediano', 'Redondo', 8),
    (1, 1, 'Fresa', NULL, 'Pequeño', 'Cuadrado', 4),
    (2, 3, 'Chocolate', 'Dulce de leche', 'Grande', 'Corazón', 12),
    (2, 2, 'Limón', 'Crema de avellanas', 'Mediano', 'Redondo', 6),
    (3, 1, 'Vainilla', 'Frutos secos', 'Pequeño', 'Cuadrado', 4),
    (3, 1, 'Chocolate', NULL, 'Pequeño', 'Redondo', 4),
    (4, 2, 'Fresa', 'Crema de fresa', 'Mediano', 'Redondo', 8),
    (4, 1, 'Chocolate', 'Manjar', 'Pequeño', 'Cuadrado', 4),
    (5, 3, 'Vainilla', 'Dulce de leche', 'Grande', 'Corazón', 12),
    (5, 2, 'Chocolate', 'Crema de avellanas', 'Mediano', 'Redondo', 6);
-- Insertar datos en la tabla Inventario
INSERT INTO Inventario (Nombre, Descripcion, Medicion_de_producto, Cantidad_de_producto, Expiracion, Precio_producto)
VALUES 
    ('Harina', 'Harina de trigo', 'Unidad', 100, '2024-12-31', 5.99),
    ('Azúcar', 'Azúcar blanca', 'Unidad', 150, '2023-10-15', 3.50),
    ('Huevos', 'Huevos frescos', 'Unidad', 200, '2023-11-20', 6.25),
    ('Leche', 'Leche entera', 'Unidad', 80, '2023-11-30', 4.75),
    ('Chocolate', 'Chocolate en barra', 'Unidad', 120, NULL, 2.99);
INSERT INTO Detalles_Inventario_Pedido (ID_detalle_pedido, ID_inventario, Cantidad_inventario)
VALUES 
    (1, 1, 2), -- Pedido detalle ID 1 con Producto de inventario ID 1 (Harina) y cantidad 2
	(1, 2, 2),
	(1, 3, 6),
	(1, 4, 1),
    (2, 1, 2), -- Pedido detalle ID 2 con Producto de inventario ID 1 (Harina) y cantidad 2
	(2, 2, 2),
	(2, 3, 6),
	(2, 4, 1),
    (3, 1, 2), -- Pedido detalle ID 3 con Producto de inventario ID 1 (Harina) y cantidad 2
	(3, 2, 2),
	(3, 3, 6),
	(3, 4, 1),
    (3, 5, 1), 
    (4, 1, 2), -- Pedido detalle ID 4 con Producto de inventario ID 1 (Harina) y cantidad 2
	(4, 2, 2),
	(4, 3, 6),
	(4, 4, 1),
	(5, 1, 2), -- Pedido detalle ID 5 con Producto de inventario ID 1 (Harina) y cantidad 2
	(5, 2, 2),
	(5, 3, 6),
	(5, 4, 1),
    (6, 1, 2), -- Pedido detalle ID 6 con Producto de inventario ID 1 (Harina) y cantidad 2
	(6, 2, 2),
	(6, 3, 6),
	(6, 4, 1),
	(6, 5, 3),
    (7, 1, 2), -- Pedido detalle ID 7 con Producto de inventario ID 1 (Harina) y cantidad 2
	(7, 2, 2),
	(7, 3, 6),
	(7, 4, 1),
    (8, 1, 2), -- Pedido detalle ID 8 con Producto de inventario ID 1 (Harina) y cantidad 2
	(8, 2, 2),
	(8, 3, 6),
	(8, 4, 1),
	(8, 5, 3),
	(9, 1, 2), -- Pedido detalle ID 9 con Producto de inventario ID 1 (Harina) y cantidad 2
	(9, 2, 2),
	(9, 3, 6),
	(9, 4, 1),
    (10, 1, 2), -- Pedido detalle ID 10 con Producto de inventario ID 1 (Harina) y cantidad 2
	(10, 2, 2),
	(10, 3, 6),
	(10, 4, 1),
	(10, 5, 3);
-- Insertar datos en la tabla Producto
INSERT INTO Producto (Nombre, Descripcion, Precio, Cantidad_Disponible)
VALUES 
    ('Pastel de Vainilla', 'Pastel suave y esponjoso de vainilla', 25, 10),
    ('Pastel de Chocolate', 'Delicioso pastel de chocolate', 30, 8),
    ('Pastel de Fresa', 'Pastel fresco con sabor a fresa', 28, 12),
    ('Pastel Mixto', 'Pastel variado de sabores', 32, 6),
    ('Cupcakes', 'Cupcakes decorados', 30, 20);
INSERT INTO Pedido_Producto (ID_pedido, ID_producto, Cantidad)
VALUES
    -- Inserción 1: Pedido 1 con Producto 1
    (1, 1, 3),
    -- Inserción 2: Pedido 2 con Producto 2
    (2, 2, 2),
    -- Inserción 3: Pedido 3 con Producto 3
    (3, 3, 4),
    -- Inserción 4: Pedido 4 con Producto 4
    (4, 4, 1),
    -- Inserción 5: Pedido 5 con Producto 5
    (5, 5, 5);
*/

--un index por si acaso
CREATE INDEX IX_Pedido_detalles_ID_pedido ON Pedido_detalles (ID_pedido);
select * from Pedido_detalles order by ID_pedido asc;


-- Crear el rol para el Administrador
CREATE ROLE Administrador;

-- Crear el rol para el Empleado General
CREATE ROLE EmpleadoGeneral;

GRANT SELECT, INSERT, UPDATE,DELETE,ALTER  ON Cliente TO Administrador;
GRANT SELECT, INSERT, UPDATE,DELETE,ALTER ON Empleado TO Administrador;
GRANT SELECT, INSERT, UPDATE,DELETE,ALTER ON Pedido TO Administrador;
GRANT SELECT, INSERT, UPDATE,DELETE,ALTER ON Pedido_detalles TO Administrador;
GRANT SELECT, INSERT, UPDATE,DELETE,ALTER ON Inventario TO Administrador;
GRANT SELECT, INSERT, UPDATE,DELETE,ALTER ON Producto TO Administrador;
GRANT SELECT, INSERT, UPDATE,DELETE,ALTER ON Pedido_Producto TO Administrador;

GRANT SELECT,INSERT ON Cliente TO EmpleadoGeneral;
GRANT SELECT,INSERT ON Pedido TO EmpleadoGeneral;
GRANT SELECT,INSERT,UPDATE ON Pedido_detalles TO EmpleadoGeneral;
GRANT SELECT,UPDATE ON Inventario TO EmpleadoGeneral;
GRANT SELECT,UPDATE ON Producto TO EmpleadoGeneral;
GRANT EXECUTE ON sp_InsertarCliente TO EmpleadoGeneral;

--todos select,insert,delete, menos empleado
--el admin puede ver otro tab o form, que sera el de estadisticas

--Podemos implementar el agregar un empleado en la interfaz, , con esto creamos un usuario
CREATE LOGIN CGomez WITH PASSWORD = 'P@ssw0rd1';
CREATE USER CGomez FOR LOGIN CGomez;
ALTER ROLE Administrador ADD MEMBER CGomez;

CREATE LOGIN RDiaz WITH PASSWORD = 'P@ssw0rd3';
CREATE USER RDiaz FOR LOGIN RDiaz;
ALTER ROLE Administrador ADD MEMBER RDiaz;

CREATE LOGIN JLopez WITH PASSWORD = 'P@ssw0rd5';
CREATE USER JLopez FOR LOGIN JLopez;
ALTER ROLE Administrador ADD MEMBER JLopez;

CREATE LOGIN LHernandez WITH PASSWORD = 'P@ssw0rd2';
CREATE USER LHernandez FOR LOGIN LHernandez;
ALTER ROLE EmpleadoGeneral ADD MEMBER LHernandez;

CREATE LOGIN SFernandez WITH PASSWORD = 'P@ssw0rd4';
CREATE USER SFernandez FOR LOGIN SFernandez;
ALTER ROLE EmpleadoGeneral ADD MEMBER SFernandez;

CREATE LOGIN prueba WITH PASSWORD = '123';
CREATE USER prueba FOR LOGIN prueba;
ALTER ROLE EmpleadoGeneral ADD MEMBER prueba;

/* falta
Procedimientos almacenados.
Funciones definidas.
Disparadores de evento.
*/

CREATE PROCEDURE sp_InsertarCliente
    @Nombre VARCHAR(30),
    @Apellido VARCHAR(30),
    @Calle VARCHAR(30),
    @Numero_Exterior INT,
    @Numero_interior INT,
    @Telefono CHAR(10),
    @Correo_electronico VARCHAR(50),
    @RFC VARCHAR(13)
AS
BEGIN
    INSERT INTO Cliente (Nombre, Apellido, Calle, Numero_Exterior, Numero_interior, Telefono, Correo_electronico, RFC)
    VALUES (@Nombre, @Apellido, @Calle, @Numero_Exterior, @Numero_interior, @Telefono, @Correo_electronico, @RFC);
END;
CREATE PROCEDURE sp_InsertarPedido
    @ID_cliente SMALLINT,
    @ID_empleado SMALLINT,
    @Anticipo MONEY,
    @Total MONEY,
    @Fecha_de_entrega DATETIME
AS
BEGIN
    INSERT INTO Pedido (ID_cliente, ID_empleado, Anticipo, Total, Fecha_de_entrega)
    VALUES (@ID_cliente, @ID_empleado, @Anticipo, @Total, @Fecha_de_entrega);
END;
	CREATE PROCEDURE sp_InsertarPedidoDetalles
		@ID_pedido SMALLINT,
		@Cantidad_Pisos INT,
		@Sabor_Pan VARCHAR(50),
		@Relleno_Pan VARCHAR(50),
		@Tamaño_Pastel VARCHAR(50),
		@Cantidad_Personas INT,
		@Foto VARCHAR(100),
		@Precio MONEY,
		@Notas VARCHAR(100)
	AS
	BEGIN
		INSERT INTO Pedido_detalles (ID_pedido, Cantidad_Pisos, Sabor_Pan, Relleno_Pan, Tamaño_Pastel, Cantidad_Personas, Foto, Precio, Notas)
		VALUES (@ID_pedido, @Cantidad_Pisos, @Sabor_Pan, @Relleno_Pan, @Tamaño_Pastel, @Cantidad_Personas, @Foto, @Precio, @Notas);
	END;
CREATE PROCEDURE sp_InsertarDetallesInventarioPedido
    @ID_detalle_pedido SMALLINT,
    @ID_inventario SMALLINT,
    @Cantidad_inventario INT
AS
BEGIN
    INSERT INTO Detalles_Inventario_Pedido (ID_detalle_pedido, ID_inventario, Cantidad_inventario)
    VALUES (@ID_detalle_pedido, @ID_inventario, @Cantidad_inventario);
END;
CREATE PROCEDURE sp_InsertarInventario
    @Nombre VARCHAR(30),
    @Medicion_de_producto VARCHAR(20),
    @Cantidad_de_producto INT,
    @Expiracion DATETIME
AS
BEGIN
    INSERT INTO Inventario (Nombre, Medicion_de_producto, Cantidad_de_producto, Expiracion)
    VALUES (@Nombre, @Medicion_de_producto, @Cantidad_de_producto, @Expiracion);
END;
CREATE PROCEDURE sp_InsertarProducto
    @Nombre VARCHAR(50),
    @Descripcion VARCHAR(80),
    @Precio MONEY,
    @Fecha_Ingreso DATETIME,
    @Cantidad_Disponible INT,
    @Fecha_expiracion DATETIME,
    @Foto VARCHAR(100)
AS
BEGIN
    INSERT INTO Producto (Nombre, Descripcion, Precio, Fecha_Ingreso, Cantidad_Disponible, Fecha_expiracion, Foto)
    VALUES (@Nombre, @Descripcion, @Precio, @Fecha_Ingreso, @Cantidad_Disponible, @Fecha_expiracion, @Foto);
END;
CREATE PROCEDURE sp_InsertarPedidoProducto
    @ID_pedido SMALLINT,
    @ID_producto INT,
    @Cantidad INT
AS
BEGIN
    INSERT INTO Pedido_Producto (ID_pedido, ID_producto, Cantidad)
    VALUES (@ID_pedido, @ID_producto, @Cantidad);
END;






-- Crear o modificar un disparador AFTER INSERT en la tabla Pedido_Producto
CREATE OR ALTER TRIGGER trg_ActualizarCantidadDisponible
	ON Pedido_Producto
	AFTER INSERT
	AS
	BEGIN
    DECLARE @IDProducto INT, @CantidadInsertada INT, @CantidadDisponible INT;

    SELECT @IDProducto = ins.ID_producto, @CantidadInsertada = ins.Cantidad
    FROM inserted ins;
    -- Obtener la cantidad disponible antes de la actualización
    SELECT @CantidadDisponible = Cantidad_Disponible
    FROM Producto
    WHERE ID_producto = @IDProducto;
    -- Calcular la nueva cantidad disponible luego de la actualización
    DECLARE @NuevaCantidadDisponible INT;
    SET @NuevaCantidadDisponible = @CantidadDisponible - @CantidadInsertada;
        -- Actualizar la cantidad disponible en la tabla Producto
        UPDATE Producto
        SET Cantidad_Disponible = @NuevaCantidadDisponible
        WHERE ID_producto = @IDProducto;

        -- Verificar si la cantidad disponible es menor a 2 y mostrar el mensaje
        IF (@NuevaCantidadDisponible < 2)
        BEGIN
            -- Mensaje de alerta (puedes adaptarlo a tu sistema de registro o notificación)
        RAISERROR('por favor pedir mas producto.',5, 1);
        END;
		    IF (@NuevaCantidadDisponible < 0)
    BEGIN
        RAISERROR('La actualización resultará en una cantidad de producto negativa.',11, 1);
        -- Revertir la actualización para evitar valores negativos
        ROLLBACK;
    END;
END;


CREATE OR ALTER TRIGGER trg_RestarCantidadInventario
	ON Detalles_Inventario_Pedido
		AFTER INSERT
					AS
						BEGIN
			DECLARE @IDInventario INT, @CantidadInsertada INT;

			SELECT @IDInventario = ins.ID_inventario, @CantidadInsertada = ins.Cantidad_inventario
			FROM inserted ins;

			-- Restar la cantidad insertada a la tabla Inventario
			UPDATE Inventario
			SET Cantidad_de_producto = Cantidad_de_producto - @CantidadInsertada
			WHERE ID_inventario = @IDInventario;

			-- Verificar si la cantidad disponible es menor que 2 y mostrar un mensaje
			DECLARE @NuevaCantidad INT;
			SELECT @NuevaCantidad = Cantidad_de_producto
			FROM Inventario
			WHERE ID_inventario = @IDInventario;

			IF (@NuevaCantidad < 2)
			BEGIN
				-- Mensaje de alerta mediante PRINT
				RAISERROR('por favor pedir mas inventario.',5, 1);
			END;
			IF (@NuevaCantidad < 0)
			BEGIN
				RAISERROR('La actualización resultará en una cantidad de inventario negativa.',11, 1);
				-- Revertir la actualización para evitar valores negativos
				ROLLBACK;
    END;
END;


select * from Pedido where ID_pedido=5;
select * from Pedido_Producto where ID_pedido=5;
select * from Producto;

DELETE FROM Pedido
WHERE ID_pedido = 5;



select * from Producto;
select * from Pedido_Producto;
INSERT INTO Pedido_Producto (ID_pedido, ID_producto, Cantidad)
VALUES
    -- Inserción 1: Pedido 1 con Producto 1 cantidad 3
    (1, 1, 3)
select * from Inventario;
select * from Detalles_Inventario_Pedido;
INSERT INTO Detalles_Inventario_Pedido (ID_detalle_pedido, ID_inventario, Cantidad_inventario)VALUES (1, 1, 50)




