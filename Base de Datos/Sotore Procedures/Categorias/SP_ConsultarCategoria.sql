USE [PAPELERIA]
GO

/****** Object:  StoredProcedure [dbo].[SP_ConsultarCategoria]    Script Date: 11/14/2016 22:41:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[SP_ConsultarCategoria]
AS
BEGIN
	SET NOCOUNT ON;
	Select	 IdCategoria    As Id,
			 NombreCat      As Categoria,
			 DescripcionCat As Descripcion
    From CATEORIAS
END

GO

