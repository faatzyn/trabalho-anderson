CREATE TABLE Funcionario (
	CdFuncionario int PRIMARY KEY IDENTITY,
	NmFuncionario varchar(50) NOT NULL,
	DtNascimento date NOT NULL,
	Sexo char(1) NOT NULL,
	DsEstadoCivil char(1) NOT NULL,
	NrRG varchar(9) NOT NULL,
	NrCPF varchar(14) NOT NULL,
	Endereco varchar (100) NOT NULL,
	Cidade varchar (30) NOT NULL,
	CEP varchar (8) NOT NULL,
	Estado varchar (15) NOT NULL,
	NrTelefone varchar(10) NOT NULL,	
	NrCelular varchar(11) NOT NULL,
	Email varchar(100) NOT NULL,
	DsLogin varchar(60) NOT NULL,
	DsSenha varchar(32) NOT NULL,
	Status int NOT NULL
)
GO