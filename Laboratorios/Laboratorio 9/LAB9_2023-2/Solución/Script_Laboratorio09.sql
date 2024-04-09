DROP TABLE IF EXISTS videojuego;
DROP TABLE IF EXISTS desarrolladora;
DROP TABLE IF EXISTS genero;
DROP TABLE IF EXISTS clasificacion_ESRB;
DROP TABLE IF EXISTS pais;
CREATE TABLE pais(
	id_pais INT AUTO_INCREMENT,
    nombre VARCHAR(150),
    PRIMARY KEY (id_pais)
)ENGINE=InnoDB;
CREATE TABLE clasificacion_ESRB(
	id_clasificacion_ESRB CHAR,
    descripcion VARCHAR(200),
    PRIMARY KEY (id_clasificacion_ESRB)
)ENGINE=InnoDB;
CREATE TABLE genero(
	id_genero INT AUTO_INCREMENT,
    nombre VARCHAR(150),
    PRIMARY KEY(id_genero)
)ENGINE=InnoDB;    
CREATE TABLE desarrolladora(
	id_desarrolladora INT AUTO_INCREMENT,
    fid_pais INT,
    nombre VARCHAR(300),
    PRIMARY KEY (id_desarrolladora),
    FOREIGN KEY (fid_pais) REFERENCES pais(id_pais)
)ENGINE=InnoDB;
CREATE TABLE videojuego(
	id_videojuego INT AUTO_INCREMENT,
    fid_desarrolladora INT,
    fid_genero INT,
    fid_clasificacion_ESRB CHAR,
    nombre VARCHAR(300),
    fecha_lanzamiento DATE,
    costo_desarrollo DECIMAL(15,2),
    version_playstation5 TINYINT,
    version_nintendo_switch TINYINT,
    version_xbox_series TINYINT,
    version_PC TINYINT,
    version_smartphone TINYINT,
    material_promocional_PDF LONGBLOB,
    portada LONGBLOB,
    activo TINYINT,
    PRIMARY KEY(id_videojuego),
    FOREIGN KEY(fid_desarrolladora) REFERENCES desarrolladora(id_desarrolladora),
    FOREIGN KEY(fid_genero) REFERENCES genero(id_genero),
    FOREIGN KEY(fid_clasificacion_ESRB) REFERENCES clasificacion_ESRB(id_clasificacion_ESRB)
)ENGINE=InnoDB;
-- Insertando registros
INSERT INTO clasificacion_ESRB(id_clasificacion_ESRB,descripcion) VALUES('E','EVERYONE');
INSERT INTO clasificacion_ESRB(id_clasificacion_ESRB,descripcion) VALUES('T','TEEN');
INSERT INTO clasificacion_ESRB(id_clasificacion_ESRB,descripcion) VALUES('M','MATURE');
INSERT INTO clasificacion_ESRB(id_clasificacion_ESRB,descripcion) VALUES('A','ADULTS ONLY');
INSERT INTO genero(nombre) VALUES('ACCION');
INSERT INTO genero(nombre) VALUES('ARCADE');
INSERT INTO genero(nombre) VALUES('SHOOTER');
INSERT INTO genero(nombre) VALUES('ESTRATEGIA');
INSERT INTO genero(nombre) VALUES('SIMULACIÓN');
INSERT INTO genero(nombre) VALUES('DEPORTE');
INSERT INTO genero(nombre) VALUES('AVENTURA');
INSERT INTO genero(nombre) VALUES('ROL');
INSERT INTO genero(nombre) VALUES('PELEA');
INSERT INTO pais(nombre) VALUES('ESTADOS UNIDOS');
INSERT INTO pais(nombre) VALUES('JAPON');
INSERT INTO desarrolladora(fid_pais,nombre) VALUES(1,'EPIC GAMES');
INSERT INTO desarrolladora(fid_pais,nombre) VALUES(1,'NAUGHTY DOG');
INSERT INTO desarrolladora(fid_pais,nombre) VALUES(2,'CAPCOM CO. LTD');
-- Procedimientos Almacenados
DROP PROCEDURE IF EXISTS LISTAR_GENEROS_TODOS;
DROP PROCEDURE IF EXISTS LISTAR_DESARROLLADORAS_X_NOMBRE;
DROP PROCEDURE IF EXISTS INSERTAR_VIDEOJUEGO;
DROP PROCEDURE IF EXISTS LISTAR_VIDEOJUEGOS_X_NOMBRE;

DELIMITER $
CREATE PROCEDURE LISTAR_GENEROS_TODOS()
BEGIN
	SELECT id_genero, nombre FROM genero ORDER BY nombre ASC;
END$
CREATE PROCEDURE LISTAR_DESARROLLADORAS_X_NOMBRE(
	IN _nombre VARCHAR(300)
)
BEGIN
	SELECT d.id_desarrolladora, p.id_pais, d.nombre as nombre_desarrolladora, p.nombre as pais FROM desarrolladora d INNER JOIN pais p ON d.fid_pais = p.id_pais WHERE d.nombre LIKE CONCAT('%',_nombre,'%');
END$
CREATE PROCEDURE INSERTAR_VIDEOJUEGO(
	OUT _id_videojuego INT,
    IN _fid_desarrolladora INT,
    IN _fid_genero INT,
    IN _fid_clasificacion_ESRB CHAR,
    IN _nombre VARCHAR(300),
    IN _fecha_lanzamiento DATE,
    IN _costo_desarrollo DECIMAL(15,2),
    IN _version_playstation5 TINYINT,
    IN _version_nintendo_switch TINYINT,
    IN _version_xbox_series TINYINT,
    IN _version_PC TINYINT,
    IN _version_smartphone TINYINT,
    IN _material_promocional_PDF LONGBLOB,
    IN _portada LONGBLOB
)
BEGIN
	INSERT INTO videojuego(fid_desarrolladora,fid_genero,fid_clasificacion_ESRB,nombre,fecha_lanzamiento,costo_desarrollo,version_playstation5,version_nintendo_switch,version_xbox_series,version_PC,version_smartphone,material_promocional_PDF,portada,activo) VALUES(_fid_desarrolladora,_fid_genero,_fid_clasificacion_ESRB,_nombre,_fecha_lanzamiento,_costo_desarrollo,_version_playstation5,_version_nintendo_switch,_version_xbox_series,_version_PC,_version_smartphone,_material_promocional_PDF,_portada,1);
    SET _id_videojuego = @@last_insert_id;
END$
CREATE PROCEDURE LISTAR_VIDEOJUEGOS_X_NOMBRE(
	IN _nombre VARCHAR(300)
)
BEGIN
	SELECT v.id_videojuego, d.id_desarrolladora, d.nombre as nombre_desarrolladora, p.id_pais as id_pais_desarrolladora, p.nombre as pais_desarrolladora, g.id_genero, g.nombre as nombre_genero, c.id_clasificacion_ESRB, c.descripcion as tipo_clasificacion, v.nombre as nombre_videojuego, v.fecha_lanzamiento, v.costo_desarrollo, v.version_playstation5, v.version_nintendo_switch, v.version_xbox_series, v.version_PC, v.version_smartphone, v.material_promocional_PDF, v.portada FROM videojuego v INNER JOIN desarrolladora d ON v.fid_desarrolladora = d.id_desarrolladora INNER JOIN pais p ON p.id_pais = d.fid_pais INNER JOIN genero g ON g.id_genero = v.fid_genero INNER JOIN clasificacion_ESRB c ON c.id_clasificacion_ESRB = v.fid_clasificacion_ESRB WHERE v.activo = 1 AND v.nombre LIKE CONCAT('%',_nombre,'%');
END$