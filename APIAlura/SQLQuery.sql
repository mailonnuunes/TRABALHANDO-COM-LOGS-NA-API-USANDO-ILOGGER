CREATE TABLE Usuario (
Id INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(100)
)

CREATE TABLE Pedido (

Id INT IDENTITY(1,1) PRIMARY KEY,
NomeProduto VARCHAR(100),
UsuarioId INT,
FOREIGN KEY (usuarioId) REFERENCES Usuario(Id)
)