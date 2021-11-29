USE DesafioRoman_Manha;
GO

INSERT INTO TIPOUSUARIO (TipoUsuario)
VALUES ('Administrador'), ('Professor')
GO

INSERT INTO USUARIO (IdTipoUsuario, NomeUsuario, EmailUsuario, SenhaUsuario)
VALUES (1, 'Saulo', 'saulo@saulo.com', 'Saulo@132' ), (2, 'Lucas', 'lucas@lucas.com', 'Lucas@132')
GO

INSERT INTO TEMA (NomeTema)
VALUES ('Gestão')
GO

INSERT INTO PROJETO (IdTema ,NomeProjeto, DescricaoProjeto)
VALUES (1 ,'Projeto Roman', 'Este projeto tem como finalidade, ensinar sobre gestão empresarial e seus coneceitos.')
GO
