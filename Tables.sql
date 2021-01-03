CREATE DATABASE bd_Matricula;
/* DROP DATABASE bd_Matricula; */

USE bd_Matricula;

/* DELETE FROM tb_matricula */
CREATE TABLE tb_matricula (

	id_matricula INT IDENTITY(1,1) NOT NULL,
	nombre  VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	dni CHAR(8) NOT NULL,
	nivel VARCHAR(10) NOT NULL, 
	turno VARCHAR(10) NOT NULL,
	grado CHAR(1) NOT NULL,
	seccion CHAR(1) NOT NULL,
	apoderado VARCHAR(120) NOT NULL,
	telefono VARCHAR(20) NOT NULL

	PRIMARY KEY (id_matricula)

);




INSERT INTO tb_matricula VALUES ('Maiky','Talavera Berrocal','12457894','Primaria','Mañana','1','A','Miguel Angel Talavera Castro','995784147');
INSERT INTO tb_matricula VALUES ('Adrian Renato','Talavera Berrocal','21457896','Secundaria','Mañana','6','C','Susan Yesenia Berrocal Santos','994147845');
INSERT INTO tb_matricula VALUES ('Nathaly Yasuri','Vargas Santos','45874147','Primaria','Tarde','4','B','Karen Sotelo Anaya','934754177');



select * from tb_matricula;