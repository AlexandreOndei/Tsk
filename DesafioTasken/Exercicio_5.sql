CREATE TABLE CLIENTES(
	CPF VARCHAR(11) PRIMARY KEY,
	NOME VARCHAR(50) NOT NULL,
	IDADE INT NOT NULL
)

CREATE TABLE TELEFONES(
	CPF_CLIENTE VARCHAR(11) PRIMARY KEY FOREIGN KEY REFERENCES CLIENTES(CPF) ON DELETE CASCADE,
	DDD VARCHAR(2) NOT NULL,
	TELEFONE VARCHAR(9) NOT NULL
)