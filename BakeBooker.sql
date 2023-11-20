create database BakeBooker;
use BakeBooker;

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
RFC varchar(13)
constraint PK_ID_cliente primary key (ID_cliente)
)

create table Empleado
(
ID_empleado smallint identity(1,1),
Nombre varchar(30) not null,
Apellido varchar(30),
Puesto Varchar(30) not null,
Usuario varchar(30) not null,
Contraseña Varchar (30) not null
constraint PK_ID_empleado primary key (ID_empleado),
CONSTRAINT CK_puesto CHECK (Puesto = 'Administrador' OR Puesto = 'General')
)


create table Pedido 
(
    ID_pedido smallint identity(1,1),
    ID_cliente smallint not null,
    ID_empleado smallint not null,
    Fecha_de_pedido datetime default getdate(),
    Anticipo DECIMAL(10, 2),
    Total DECIMAL(10, 2) not null,
    Estado VARCHAR(20) not null,
    Foto VARCHAR(100),
	Falta_Liquidar AS (Total - Anticipo)
    CONSTRAINT PK_ID_pedido PRIMARY KEY (ID_pedido),
    CONSTRAINT FK_ID_cliente FOREIGN KEY (ID_cliente) REFERENCES Cliente (ID_cliente),
    CONSTRAINT FK_ID_empleado FOREIGN KEY (ID_empleado) REFERENCES Empleado (ID_empleado)
)

create table Pedido_detalles 
(
ID_detalle smallint identity(1,1),
ID_pedido smallint not null,
Cantidad_Pisos INT not null default 1,
Sabor_Pan VARCHAR(50) not null,
Relleno_Pan VARCHAR(50) ,
Tamaño_Pastel VARCHAR(50) not null,
Forma_Pastel VARCHAR(50) not null,
Cantidad_Personas INT default 4,
constraint PK_ID_detalle primary key (ID_detalle),
Constraint FK_ID_Pedido foreign key (ID_pedido) references Pedido (ID_pedido)
)

create table Inventario 
(
ID_inventario smallint identity(1,1),
Nombre varchar(30),
Descripcion varchar(80),
Medicion_de_producto varchar(20),
Cantidad_de_producto int,
Expiracion datetime,
Precio_producto money,
constraint PK_ID_inventario primary key (ID_inventario),
constraint CK_medicion CHECK (Medicion_de_producto ='Unidad' or Medicion_de_producto='Miligramo')
)

create table Producto
(
ID_producto INT IDENTITY(1,1),
Nombre VARCHAR(50) NOT NULL,
Descripcion VARCHAR(80),
Precio DECIMAL(10, 2),
Fecha_Ingreso DATETIME DEFAULT GETDATE(),
Cantidad_Disponible INT DEFAULT 0,
Fecha_expiracion datetime DEFAULT DATEADD(WEEK, 1, GETDATE())
constraint PK_ID_producto primary key (ID_producto)
)
-- Insertar datos en la tabla Cliente
INSERT INTO Cliente (Nombre, Apellido, Calle, Numero_Exterior, Numero_interior, Telefono, Correo_electronico, RFC)
VALUES 
    ('Juan', 'López', 'Calle 1', 10, NULL, '1234567890', 'juan@email.com', 'ABC12345678'),
    ('María', 'García', 'Calle 2', 20, 3, '9876543210', 'maria@email.com', 'XYZ9876543210'),
    ('Pedro', 'Martínez', 'Calle 3', 30, NULL, '5551112233', 'pedro@email.com', 'PQR5678901234'),
    ('Ana', 'Pérez', 'Calle 4', 40, 5, '7778889999', 'ana@email.com', 'DEF6789012345'),
    ('Luis', 'Sánchez', 'Calle 5', 50, NULL, '3332221111', 'luis@email.com', 'GHI4567890123');
--Insertar datos en la tabla Empleado, tuve que agregar el usuario y contraseña
INSERT INTO Empleado (Nombre, Apellido, Puesto, Usuario, Contraseña)
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

-- Insertar datos en la tabla Producto
INSERT INTO Producto (Nombre, Descripcion, Precio, Cantidad_Disponible)
VALUES 
    ('Pastel de Vainilla', 'Pastel suave y esponjoso de vainilla', 25.00, 10),
    ('Pastel de Chocolate', 'Delicioso pastel de chocolate', 30.00, 8),
    ('Pastel de Fresa', 'Pastel fresco con sabor a fresa', 28.00, 12),
    ('Pastel Mixto', 'Pastel variado de sabores', 32.00, 6),
    ('Cupcakes', 'Cupcakes decorados', 3.50, 20);

--un index por si acaso
CREATE INDEX IX_Pedido_detalles_ID_pedido ON Pedido_detalles (ID_pedido);
select * from Pedido_detalles order by ID_pedido asc;


-- Crear el rol para el Administrador
CREATE ROLE Administrador;

-- Crear el rol para el Empleado General
CREATE ROLE EmpleadoGeneral;

GRANT SELECT, INSERT, UPDATE,ALTER  ON Cliente TO Administrador;
GRANT SELECT, INSERT, UPDATE, DELETE,ALTER ON Empleado TO Administrador;
GRANT SELECT, INSERT, UPDATE,ALTER ON Pedido TO Administrador;
GRANT SELECT, INSERT, UPDATE,ALTER ON Pedido_detalles TO Administrador;
GRANT SELECT, INSERT, UPDATE,ALTER ON Inventario TO Administrador;
GRANT SELECT, INSERT, UPDATE,ALTER ON Producto TO Administrador;

GRANT SELECT,INSERT ON Cliente TO EmpleadoGeneral;
GRANT SELECT,INSERT ON Pedido TO EmpleadoGeneral;
GRANT SELECT,INSERT,UPDATE ON Pedido_detalles TO EmpleadoGeneral;
GRANT SELECT,UPDATE ON Inventario TO EmpleadoGeneral;
GRANT SELECT,UPDATE ON Producto TO EmpleadoGeneral;

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

/* falta
Procedimientos almacenados.
Funciones definidas.
Disparadores de evento.
*/