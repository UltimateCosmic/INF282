DROP TABLE IF EXISTS personaje;
DROP TABLE IF EXISTS plataforma;
DROP TABLE IF EXISTS universo;
CREATE TABLE universo(
	id_universo INT AUTO_INCREMENT,
    nombre VARCHAR(200),
    activo TINYINT,
    PRIMARY KEY(id_universo)
)ENGINE=InnoDB;
CREATE TABLE plataforma(
	id_plataforma INT AUTO_INCREMENT,
    nombre VARCHAR(200),
    activa TINYINT,
    PRIMARY KEY(id_plataforma)
)ENGINE=InnoDB;
CREATE TABLE personaje(
	id_personaje INT AUTO_INCREMENT,
    fid_universo INT,
    fid_plataforma_origen INT,
    nombre VARCHAR(100),
    fecha_aparicion DATE,
    peso DECIMAL(10,2),
    velocidad_caminar DECIMAL(10,2),
    velocidad_correr DECIMAL(10,2),
    cantidad_max_saltos INT,
    salto_pared TINYINT,
    adhesion_paredes TINYINT,
    arrastre TINYINT,
    descripcion VARCHAR(4000),
    foto LONGBLOB,
    activo TINYINT,
    PRIMARY KEY(id_personaje),
    FOREIGN KEY(fid_universo) REFERENCES universo(id_universo),
    FOREIGN KEY(fid_plataforma_origen) REFERENCES plataforma(id_plataforma)
)ENGINE=InnoDB;
-- Realizando los inserts
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO SMASH BROS',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO MARIO',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO YOSHI',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO DONKEY KONG',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO LENGEND OF ZELDA',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO METROID',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO KIRBY',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO STAR FOX',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO POKEMON',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO F-ZERO',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO EARTHBOUND',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO ICE CLIMBER',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO FIRE EMBLEM',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO GAME & WATCH',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO KID ICARUS',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO WARIO',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO PIKMIN',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO R.O.B.',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO ANIMAL CROSSING',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO WII FIT',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO PUNCH-OUT!!',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO DUCK HUNT',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO SPLATOON',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO ARMS',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO METAL GEAR',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO SONIC THE HEDGEHOG',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO MEGA MAN',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO PAC-MAN',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO STREET FIGHTER',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO FINAL FANTASY',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO BAYONETTA',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO CASTLEVANIA',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO PERSONA',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO DRAGON QUEST',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO BANJO-KAZOOIE',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO FATAL FURY',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO MINECRAFT',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO TEKKEN',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO KINGDOM HEARTS',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO NINTENDO DS',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO ELECTROPLANKTON',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO BALLOON FIGHT',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO NINTENDOGS',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO MII',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO STREETPASS MII PLAZA',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO TOMODACHI',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO WRECKING CREW',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO PILOTWINGS',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO WII SPORTS',1);
INSERT INTO universo(nombre,activo) VALUES('EL UNIVERSO MIIVERSE',1);
INSERT INTO plataforma(nombre,activa) VALUES('ARCADE',1);
INSERT INTO plataforma(nombre,activa) VALUES('NES',1);
INSERT INTO plataforma(nombre,activa) VALUES('SNES',1);
INSERT INTO plataforma(nombre,activa) VALUES('VIRTUAL BOY',1);
INSERT INTO plataforma(nombre,activa) VALUES('NINTENDO 64',1);
INSERT INTO plataforma(nombre,activa) VALUES('GAMECUBE',1);
INSERT INTO plataforma(nombre,activa) VALUES('WII',1);
INSERT INTO plataforma(nombre,activa) VALUES('WII U',1);
INSERT INTO plataforma(nombre,activa) VALUES('PLAYSTATION',1);
INSERT INTO plataforma(nombre,activa) VALUES('PLAYSTATION 2',1);
INSERT INTO plataforma(nombre,activa) VALUES('PLAYSTATION 3',1);
INSERT INTO plataforma(nombre,activa) VALUES('PLAYSTATION 4',1);
INSERT INTO plataforma(nombre,activa) VALUES('PLAYSTATION 5',1);
INSERT INTO plataforma(nombre,activa) VALUES('GAME & WATCH',1);
INSERT INTO plataforma(nombre,activa) VALUES('GAME BOY',1);
INSERT INTO plataforma(nombre,activa) VALUES('GAME BOY COLOR',1);
INSERT INTO plataforma(nombre,activa) VALUES('GAME BOY ADVANCE',1);
INSERT INTO plataforma(nombre,activa) VALUES('NINTENDO DS',1);
INSERT INTO plataforma(nombre,activa) VALUES('NINTENDO 3DS',1);
INSERT INTO plataforma(nombre,activa) VALUES('NEO GEO MVS',1);
INSERT INTO plataforma(nombre,activa) VALUES('NINTENDO SWITCH',1);
INSERT INTO plataforma(nombre,activa) VALUES('MSX2',1);
-- PROCEDIMIENTOS ALMACENADOS
DROP PROCEDURE IF EXISTS LISTAR_PLATAFORMAS_TODAS;
DROP PROCEDURE IF EXISTS LISTAR_UNIVERSOS_X_NOMBRE;
DROP PROCEDURE IF EXISTS INSERTAR_PERSONAJE;
DROP PROCEDURE IF EXISTS LISTAR_PERSONAJES_X_NOMBRE;
DELIMITER $
CREATE PROCEDURE LISTAR_PLATAFORMAS_TODAS()
BEGIN
	SELECT id_plataforma, nombre FROM plataforma WHERE activa = 1;
END$
CREATE PROCEDURE LISTAR_UNIVERSOS_X_NOMBRE
(
	IN _nombre VARCHAR(200)
)
BEGIN
	SELECT id_universo, nombre FROM universo WHERE activo = 1 AND nombre LIKE CONCAT('%',_nombre,'%');
END$
CREATE PROCEDURE INSERTAR_PERSONAJE(
	OUT _id_personaje INT,
    IN _fid_universo INT,
    IN _fid_plataforma_origen INT,
    IN _nombre VARCHAR(100),
    IN _fecha_aparicion DATE,
    IN _peso DECIMAL(10,2),
    IN _velocidad_caminar DECIMAL(10,2),
    IN _velocidad_correr DECIMAL(10,2),
    IN _cantidad_max_saltos INT,
    IN _salto_pared TINYINT,
    IN _adhesion_paredes TINYINT,
    IN _arrastre TINYINT,
    IN _descripcion VARCHAR(4000),
    IN _foto LONGBLOB
)
BEGIN
	INSERT INTO personaje(fid_universo,fid_plataforma_origen,nombre,fecha_aparicion,peso,velocidad_caminar,velocidad_correr,cantidad_max_saltos,salto_pared,adhesion_paredes,arrastre,descripcion,foto,activo) VALUES(_fid_universo,_fid_plataforma_origen,_nombre,_fecha_aparicion,_peso,_velocidad_caminar,_velocidad_correr,_cantidad_max_saltos,_salto_pared,_adhesion_paredes,_arrastre,_descripcion,_foto,1);
    SET _id_personaje = @@last_insert_id;
END$
CREATE PROCEDURE LISTAR_PERSONAJES_X_NOMBRE(
	_nombre VARCHAR(100)
)
BEGIN
	SELECT pe.id_personaje, u.id_universo, u.nombre as nombre_universo, pl.id_plataforma, pl.nombre as nombre_plataforma, pe.nombre as nombre_personaje, pe.fecha_aparicion, pe.peso, pe.velocidad_caminar, pe.velocidad_correr, pe.cantidad_max_saltos, pe.salto_pared, pe.adhesion_paredes, pe.arrastre, pe.descripcion, pe.foto FROM personaje pe INNER JOIN universo u ON pe.fid_universo = u.id_universo INNER JOIN plataforma pl ON pe.fid_plataforma_origen = pl.id_plataforma WHERE pe.activo = 1 AND pe.nombre LIKE CONCAT('%',_nombre,'%'); 
END$