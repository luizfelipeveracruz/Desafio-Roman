USE DesafioRoman_Manha;
GO

INSERT INTO TIPOUSUARIO (IdTipoUsuario)
VALUES ('Administrador'), ('Professor')
GO

SELECT * FROM TIPOUSUARIO;

INSERT INTO USUARIO (IdTipoUsuario, NomeUsuario, EmailUsuario, SenhaUsuario)
VALUES (1, 'Saulo', 'saulo@saulo.com', 'Saulo@132' ), (2, 'Lucas', 'lucas@lucas.com', 'Lucas@132')
GO

SELECT * FROM USUARIO;

INSERT INTO TEMA (NomeTema)
VALUES ('Gestão')
GO

SELECT * FROM TEMA;

INSERT INTO PROJETO (IdTema ,NomeProjeto, DescricaoProjeto)
VALUES (1 ,'Projeto Roman', 'Este projeto tem como finalidade, ensinar sobre gestão empresarial e seus coneceitos.')
GO

SELECT * FROM PROJETO;
