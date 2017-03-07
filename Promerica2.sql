ALTER PROCEDURE sp_ConsultarClientes
@TipoConsulta int = 0,
@IdCliente varchar (max) = '',
@ResultadoEjecucion int output
AS
Begin
	if (@TipoConsulta = 0)
		Begin
			SELECT * FROM Clientes
		End
	else
		Begin
			SELECT * FROM dbo.Clientes WHERE IdCliente = @IdCliente
		End
	SELECT @ResultadoEjecucion = COUNT (*) FROM dbo.Clientes 
End

Declare
	@T int,
	@R int,
	@id varchar(Max)

SET @T = 1
set @R = 0
set @id = '102420404'

EXEC sp_ConsultarClientes @T, @id,@R Output

Print @R

SE