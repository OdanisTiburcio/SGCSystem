CREATE TABLE ciudad (
	codigo_ciudad	INTEGER PRIMARY KEY AUTOINCREMENT,
	descripcion_ciudad VARCHAR (30) NOT NULL
);
CREATE TABLE departamento (
	codigo_departamento INTEGER PRIMARY KEY AUTOINCREMENT,
	descripcion_departamento VARCHAR (30) NOT NULL
);
CREATE TABLE estado (
	codigo_estado INTEGER PRIMARY KEY AUTOINCREMENT,
	descripcion_estado VARCHAR (15) NOT NULL
);
CREATE TABLE posicion (
	codigo_posicion INTEGER PRIMARY KEY AUTOINCREMENT,
	descripcion_posicion VARCHAR (50) NOT NULL
);
CREATE TABLE sector (
	codigo_sector INTEGER PRIMARY KEY AUTOINCREMENT,
	descripcion_sector VARCHAR (50) NOT NULL
);
CREATE TABLE servicio (
	codigo_servicio INTEGER PRIMARY KEY AUTOINCREMENT,
	descripcion_servicio VARCHAR (50) NOT NULL,
	precio_servicio REAL NOT NULL,
	dias INTEGER
);
CREATE TABLE tipo_factura (
	codigo_tipo_factura INTEGER PRIMARY KEY AUTOINCREMENT,
	descripcion_tipo_factura VARCHAR (15) NOT NULL
);
CREATE TABLE tipo_ingreso (
	codigo_tipo_ingreso INTEGER PRIMARY KEY AUTOINCREMENT,
	descripcion_tipo_ingreso VARCHAR (20) NOT NULL
);
CREATE TABLE tipo_usuario (
	codigo_tipo_usuario INTEGER PRIMARY KEY AUTOINCREMENT,
	descripcion_tipo_usuario VARCHAR (20) NOT NULL
);
CREATE TABLE cliente (
	numero_cliente	INTEGER PRIMARY KEY AUTOINCREMENT,
	cedula_cliente VARCHAR (13) NOT NULL,
	nombre_cliente VARCHAR (30) NOT NULL,
	apellido_cliente VARCHAR (30) NOT NULL,
	fecha_nacimiento DATE,
	direccion_cliente VARCHAR (50),
	codigo_sector INTEGER,
	codigo_ciudad INTEGER,
	telefono VARCHAR (13),
	inicio_periodo DATE,
	fin_periodo	DATE,
	codigo_estado INTEGER,
	foto VARCHAR (500),
	FOREIGN KEY(codigo_sector) REFERENCES sector(codigo_sector),
	FOREIGN KEY(codigo_estado) REFERENCES estado(codigo_estado),
	FOREIGN KEY(codigo_ciudad) REFERENCES ciudad(codigo_ciudad)
);
CREATE TABLE empleado (
	numero_empleado INTEGER PRIMARY KEY AUTOINCREMENT,
	codigo_posicion INTEGER,
	codigo_departamento INTEGER,
	sueldo REAL NOT NULL,
	cedula_empleado VARCHAR (13) NOT NULL,
	nombre VARCHAR (30) NOT NULL,
	apellido VARCHAR (30) NOT NULL,
	fecha_nacimiento DATE,
	fecha_ingreso DATE NOT NULL,
	direccion VARCHAR (50),
	codigo_sector INTEGER,
	codigo_ciudad INTEGER,
	telefono_casa VARCHAR (13),
	celular VARCHAR (13),
	codigo_estado INTEGER,
	foto VARCHAR (500),
	FOREIGN KEY(codigo_posicion) REFERENCES posicion(codigo_posicion),
	FOREIGN KEY(codigo_ciudad) REFERENCES ciudad(codigo_ciudad),
	FOREIGN KEY(codigo_departamento) REFERENCES departamento(codigo_departamento),
	FOREIGN KEY(codigo_estado) REFERENCES estado(codigo_estado),
	FOREIGN KEY(codigo_sector) REFERENCES sector(codigo_sector)
);
CREATE TABLE factura (
	numero_factura INTEGER PRIMARY KEY AUTOINCREMENT,
	codigo_tipo_factura INTEGER,
	numero_cliente INTEGER,
	fecha_factura DATE NOT NULL,
	inicio_periodo DATE,
	fin_periodo	DATE,
	numero_servicio INTEGER,
	precio_servicio REAL,
	FOREIGN KEY(codigo_tipo_factura) REFERENCES tipo_factura(codigo_tipo_factura),
	FOREIGN KEY(numero_servicio) REFERENCES servicio(numero_servicio),
	FOREIGN KEY(numero_cliente) REFERENCES cliente(numero_cliente)
);
CREATE TABLE ingreso (
	codigo_ingreso INTEGER PRIMARY KEY AUTOINCREMENT,
	codigo_tipo_ingreso INTEGER,
	numero_factura INTEGER,
	monto_ingreso INTEGER NOT NULL,
	fecha	DATE,
	FOREIGN KEY(codigo_tipo_ingreso) REFERENCES tipo_ingreso(codigo_tipo_ingreso),
	FOREIGN KEY(numero_factura) REFERENCES factura(numero_factura)
);
CREATE TABLE login (
	codigo_login INTEGER PRIMARY KEY AUTOINCREMENT,
	numero_empleado INTEGER,
	alias_usuario VARCHAR (20) NOT NULL,
	clave_usuario VARCHAR (20) NOT NULL,
	codigo_tipo_usuario INTEGER NOT NULL,
	FOREIGN KEY(codigo_tipo_usuario) REFERENCES tipo_usuario(codigo_tipo_usuario),
	FOREIGN KEY(numero_empleado) REFERENCES empleado(numero_empleado)
);
