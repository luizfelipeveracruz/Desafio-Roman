USE DesafioRoman_Manha;
GO

SELECT * FROM USUARIO ORDER BY IdUsuario asc;

SELECT * FROM TIPOUSUARIO;

SELECT * FROM TEMA;

SELECT * FROM PROJETO ORDER BY IdProjeto asc;


SELECT COUNT(idUsuario) 'Quantidade de usuários' FROM usuario;
GO
