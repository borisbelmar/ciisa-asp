CREATE TABLE Administradores (
	admin_ID int primary key identity(1,1) not null,
	admin_usuario varchar(50) not null,
	admin_password varchar(50) not null,
);

INSERT INTO Administradores VALUES('admin', 'admin');

CREATE TABLE Articulos (
	articulos_ID int primary key identity(1,1) not null,
	articulos_nombre varchar(50) not null,
	articulos_descripcion varchar(max),
	articulos_ficha varchar(max),
	articulos_valor varchar(50) not null,
	articulos_fecha varchar(50) not null,
	articulos_foto image not null,
);

CREATE TABLE Vendedores (
	vendedores_ID int primary key identity(1,1) not null,
	vendedores_usuario varchar(50) not null,
	vendedores_password varchar(50) not null,
	vendedores_correo varchar(50),
	vendedores_fono varchar(50),
);