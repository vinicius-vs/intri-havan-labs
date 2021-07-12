/****** Script do comando SelectTopNRows de SSMS  ******/

--Create

Insert into Produto(

Nome 
,Descricao
)

Values(

'Cel545'
,'M'

)

-- Read 

Select

*

From Produto

order by Id desc

-- Update não esquecer o where
--UPDATE Produto

--SET
--Nome = 'oloco'
--,Descricao = 'bixo'
	--WHERE Id > 5

-- Delete

DELETE FROM Produto 
WHERE Descricao = 'M'