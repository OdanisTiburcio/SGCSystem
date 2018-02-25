BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `tipo_usuario` (
	`codigo_tipo_usuario`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`descripcion_tipo_usuario`	VARCHAR ( 20 ) NOT NULL
);
INSERT INTO `tipo_usuario` VALUES (1,'ADMINISTRADOR');
INSERT INTO `tipo_usuario` VALUES (2,'EMPLEADO');
CREATE TABLE IF NOT EXISTS `tipo_ingreso` (
	`codigo_tipo_ingreso`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`descripcion_tipo_ingreso`	VARCHAR ( 20 ) NOT NULL
);
INSERT INTO `tipo_ingreso` VALUES (1,'EFECTIVO');
INSERT INTO `tipo_ingreso` VALUES (2,'CHEQUE');
INSERT INTO `tipo_ingreso` VALUES (3,'TARJETA CREDITO');
CREATE TABLE IF NOT EXISTS `tipo_factura` (
	`codigo_tipo_factura`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`descripcion_tipo_factura`	VARCHAR ( 15 ) NOT NULL
);
INSERT INTO `tipo_factura` VALUES (1,'CONTADO');
INSERT INTO `tipo_factura` VALUES (2,'CREDITO');
CREATE TABLE IF NOT EXISTS `servicio` (
	`codigo_servicio`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`descripcion_servicio`	VARCHAR ( 50 ) NOT NULL,
	`precio_servicio`	REAL NOT NULL,
	`dias`	INTEGER,
	`estado`	TEXT
);
INSERT INTO `servicio` VALUES (1,'UN DIA DE USO',40.0,1,'ACTIVO');
CREATE TABLE IF NOT EXISTS `sector` (
	`codigo_sector`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`descripcion_sector`	VARCHAR ( 50 ) NOT NULL
);
INSERT INTO `sector` VALUES (1,'GREGORIO LUPERÓN');
INSERT INTO `sector` VALUES (2,'BUENOS AIRES');
INSERT INTO `sector` VALUES (3,'FRANCISCO DEL ROSARIO SÁNCHEZ');
INSERT INTO `sector` VALUES (4,'LOS REYES');
INSERT INTO `sector` VALUES (5,'LOS REYES II');
INSERT INTO `sector` VALUES (6,'LOS PRADOS');
CREATE TABLE IF NOT EXISTS `reporte_vencidos` (
	`id_reporte`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`mostrar_reporte`	VARCHAR ( 2 )
);
INSERT INTO `reporte_vencidos` VALUES (1,'no');
CREATE TABLE IF NOT EXISTS `posicion` (
	`codigo_posicion`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`descripcion_posicion`	VARCHAR ( 50 ) NOT NULL
);
INSERT INTO `posicion` VALUES (1,'GERENTE GENERAL');
CREATE TABLE IF NOT EXISTS `login` (
	`codigo_login`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`numero_empleado`	INTEGER,
	`alias_usuario`	VARCHAR ( 20 ) NOT NULL,
	`clave_usuario`	VARCHAR ( 20 ) NOT NULL,
	`codigo_tipo_usuario`	INTEGER,
	`codigo_estado`	INTEGER,
	FOREIGN KEY(`numero_empleado`) REFERENCES `empleado`(`numero_empleado`),
	FOREIGN KEY(`codigo_estado`) REFERENCES `estado`(`codigo_estado`),
	FOREIGN KEY(`codigo_tipo_usuario`) REFERENCES `tipo_usuario`(`codigo_tipo_usuario`)
);
INSERT INTO `login` VALUES (1,1,'Cosobo','elvis2018',1,1);
CREATE TABLE IF NOT EXISTS `ingreso` (
	`codigo_ingreso`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`codigo_tipo_ingreso`	INTEGER,
	`numero_factura`	INTEGER,
	`monto_ingreso`	INTEGER NOT NULL,
	`fecha`	DATE,
	`estado`	TEXT,
	FOREIGN KEY(`codigo_tipo_ingreso`) REFERENCES `tipo_ingreso`(`codigo_tipo_ingreso`),
	FOREIGN KEY(`numero_factura`) REFERENCES `cabecera_factura`(`id_factura`)
);
CREATE TABLE IF NOT EXISTS `estado` (
	`codigo_estado`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`descripcion_estado`	VARCHAR ( 15 ) NOT NULL
);
INSERT INTO `estado` VALUES (1,'ACTIVO');
INSERT INTO `estado` VALUES (2,'INACTIVO');
CREATE TABLE IF NOT EXISTS `empleado` (
	`numero_empleado`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`codigo_posicion`	INTEGER,
	`codigo_departamento`	INTEGER,
	`sueldo`	REAL NOT NULL,
	`cedula_empleado`	VARCHAR ( 13 ) NOT NULL,
	`nombre`	VARCHAR ( 30 ) NOT NULL,
	`apellido`	VARCHAR ( 30 ) NOT NULL,
	`fecha_nacimiento`	DATE,
	`fecha_ingreso`	DATE NOT NULL,
	`direccion`	VARCHAR ( 50 ),
	`codigo_sector`	INTEGER,
	`codigo_ciudad`	INTEGER,
	`telefono_casa`	VARCHAR ( 13 ),
	`celular`	VARCHAR ( 13 ),
	`codigo_estado`	INTEGER,
	`foto`	VARCHAR ( 500 ),
	`sexo`	VARCHAR ( 20 ),
	FOREIGN KEY(`codigo_sector`) REFERENCES `sector`(`codigo_sector`),
	FOREIGN KEY(`codigo_ciudad`) REFERENCES `ciudad`(`codigo_ciudad`),
	FOREIGN KEY(`codigo_posicion`) REFERENCES `posicion`(`codigo_posicion`),
	FOREIGN KEY(`codigo_estado`) REFERENCES `estado`(`codigo_estado`),
	FOREIGN KEY(`codigo_departamento`) REFERENCES `departamento`(`codigo_departamento`)
);
INSERT INTO `empleado` VALUES (1,1,1,25000.0,'031-0264953-4','ELVIS','ORTIZ','1/27/2018','1/27/2018','CALLE 2A, ESQUINA 7A ',6,28,'(829)399-5797','(829)399-5797',1,'C:\CGSystem\FotosEmpleados\1.jpg','MASCULINO');
CREATE TABLE IF NOT EXISTS `detalle_factura` (
	`id_detalle`	INTEGER,
	`id_factura`	INTEGER,
	`codigo`	INTEGER,
	`descripcion`	TEXT,
	`precio`	REAL,
	`dias`	INTEGER,
	`cantidad`	INTEGER,
	`total`	REAL,
	`estado`	TEXT
);
CREATE TABLE IF NOT EXISTS `departamento` (
	`codigo_departamento`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`descripcion_departamento`	VARCHAR ( 30 ) NOT NULL
);
INSERT INTO `departamento` VALUES (1,'GERENCIA GENERAL');
CREATE TABLE IF NOT EXISTS `cxc` (
	`id_cxc`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`id_factura`	INTEGER,
	`total_factura`	REAL,
	`restante`	REAL,
	`estado_cxc`	TEXT
);
CREATE TABLE IF NOT EXISTS `cliente` (
	`numero_cliente`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`cedula_cliente`	VARCHAR ( 13 ) NOT NULL,
	`nombre_cliente`	VARCHAR ( 30 ) NOT NULL,
	`apellido_cliente`	VARCHAR ( 30 ) NOT NULL,
	`fecha_nacimiento`	DATE,
	`direccion_cliente`	VARCHAR ( 50 ),
	`codigo_sector`	INTEGER,
	`codigo_ciudad`	INTEGER,
	`telefono`	VARCHAR ( 13 ),
	`inicio_periodo`	DATE,
	`fin_periodo`	DATE,
	`codigo_estado`	INTEGER,
	`foto`	VARCHAR ( 500 ),
	`sexo`	VARCHAR ( 30 ),
	FOREIGN KEY(`codigo_sector`) REFERENCES `sector`(`codigo_sector`),
	FOREIGN KEY(`codigo_ciudad`) REFERENCES `ciudad`(`codigo_ciudad`),
	FOREIGN KEY(`codigo_estado`) REFERENCES `estado`(`codigo_estado`)
);
INSERT INTO `cliente` VALUES (1,'999-9999999-9','VISITANTE','DIARIO','1/1/1900','DESCONOCIDA',1,1,'(999)999-9999','1/1/1900','1/1/9999',1,'C:\CGSystem\FotosClientes\1.jpg','MASCULINO');
CREATE TABLE IF NOT EXISTS `ciudad` (
	`codigo_ciudad`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`descripcion_ciudad`	VARCHAR ( 30 ) NOT NULL
);
INSERT INTO `ciudad` VALUES (1,'AZUA');
INSERT INTO `ciudad` VALUES (2,'BAORUCO');
INSERT INTO `ciudad` VALUES (3,'DAJABÓN');
INSERT INTO `ciudad` VALUES (4,'DISTRITO NACIONAL');
INSERT INTO `ciudad` VALUES (5,'DUARTE');
INSERT INTO `ciudad` VALUES (6,'EL SEIBO');
INSERT INTO `ciudad` VALUES (7,'ELÍAS PIÑA');
INSERT INTO `ciudad` VALUES (8,'ESPAILLAT');
INSERT INTO `ciudad` VALUES (9,'HATO MAYOR');
INSERT INTO `ciudad` VALUES (10,'HERMANAS MIRABAL');
INSERT INTO `ciudad` VALUES (11,'INDEPENDENCIA');
INSERT INTO `ciudad` VALUES (12,'LA ALTAGRACIA');
INSERT INTO `ciudad` VALUES (13,'LA ROMANA');
INSERT INTO `ciudad` VALUES (14,'LA VEGA');
INSERT INTO `ciudad` VALUES (15,'MARÍA TRINIDAD SÁNCHEZ');
INSERT INTO `ciudad` VALUES (16,'MONSEÑOR NOUEL');
INSERT INTO `ciudad` VALUES (17,'MONTE CRISTI');
INSERT INTO `ciudad` VALUES (18,'MONTE PLATA');
INSERT INTO `ciudad` VALUES (19,'PEDERNALES');
INSERT INTO `ciudad` VALUES (20,'PERAVIA');
INSERT INTO `ciudad` VALUES (21,'PUERTO PLATA');
INSERT INTO `ciudad` VALUES (22,'SAMANÁ');
INSERT INTO `ciudad` VALUES (23,'SAN CRISTÓBAL');
INSERT INTO `ciudad` VALUES (24,'SAN JOSÉ DE OCOA');
INSERT INTO `ciudad` VALUES (25,'SAN JUAN');
INSERT INTO `ciudad` VALUES (26,'SAN PEDRO DE MACORÍS');
INSERT INTO `ciudad` VALUES (27,'SÁNCHEZ RAMÍREZ');
INSERT INTO `ciudad` VALUES (28,'SANTIAGO');
INSERT INTO `ciudad` VALUES (29,'SANTIAGO RODRÍGUEZ');
INSERT INTO `ciudad` VALUES (30,'SANTO DOMINGO');
INSERT INTO `ciudad` VALUES (31,'VALVERDE');
CREATE TABLE IF NOT EXISTS `cabecera_factura` (
	`id_factura`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`id_tipo_factura`	INTEGER,
	`id_cliente`	INTEGER,
	`id_empleado`	INTEGER,
	`fecha`	DATE,
	`total`	REAL,
	`estado`	TEXT,
	`dias_sumar`	INTEGER
);
COMMIT;
