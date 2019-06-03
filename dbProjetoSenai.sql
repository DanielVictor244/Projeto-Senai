CREATE DATABASE dbProjetoSenai

GO
USE dbProjetoSenai


GO

CREATE TABLE Aluno
(
codAluno		   INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
RegistroAluno	   VARCHAR(100),
nomeAluno		   VARCHAR(100),
nascimento		   VARCHAR(100),
idade			   VARCHAR(100),
sexo			   VARCHAR(100),
grauInstrucao	   VARCHAR(100),
rua				   VARCHAR(100),
numeroCasa		   VARCHAR(100),
complemento		   VARCHAR(100),
bairro			   VARCHAR(100),
estado			   VARCHAR(100),
cidade			   VARCHAR(100),
cep				   VARCHAR(100),
telCelular		   VARCHAR(100),
identidade		   VARCHAR(100),
cpf				   VARCHAR(100),
email			   VARCHAR(100),
carteiraTrabalho   VARCHAR(100),
serieCartTrabalho  VARCHAR(100),
dataExpCartTrabalho VARCHAR(100),
estadoCartTrabalho VARCHAR(100),
certidaoNumero     VARCHAR(100),
certidaoLivro      VARCHAR(100),
certidaoFolha	   VARCHAR(100),
certidaoEstado	   VARCHAR(100),
certidaoDistrito   VARCHAR(100),
certidaoData	   VARCHAR(100),
certidaoCartorio   VARCHAR(100),
certidaoComarca    VARCHAR(100),
corRaca			   VARCHAR(100),
codPai			   VARCHAR(100),	 
nomePai			   VARCHAR(100),
telCelularPai	   VARCHAR(100),
cpfPai			   VARCHAR(100),
pisPai			   VARCHAR(100),
emailPai		   VARCHAR(100),
codMae			   VARCHAR(100),
nomeMae			   VARCHAR(100),
telCelularMae	   VARCHAR(100),
cpfMae			   VARCHAR(100),
pisMae			   VARCHAR(100),
emailMae	       VARCHAR(100),
codRespFinanceiro  VARCHAR(100),
nomeRespFinanceiro VARCHAR(100),
cpfRespFinanceiro  VARCHAR(100),
cepRespFinanceiro  VARCHAR(100),
ruaRespFinanceiro  VARCHAR(100),
numEndRespFinanceiro VARCHAR(100),
compEndRespFinanceiro VARCHAR(100),
bairroRespFinanceiro VARCHAR(100),
celularRespFinanceiro VARCHAR(100),
telRespFinanceiro VARCHAR(100),
codRespAcademico   VARCHAR(100),
nomeRespAcademico  VARCHAR(100),
telRespAcademico1  VARCHAR(100),
telRespAcademico2  VARCHAR(100),
cpfRespAcademico   VARCHAR(100),
emailRespAcademico VARCHAR(100),
nomeCurso		   VARCHAR(100),
nomeHabilitacao    VARCHAR(100),
codigoTurma		   VARCHAR(100),
tipoMatricula      VARCHAR(100),
statusMatricula	   VARCHAR(100),
categoria		   VARCHAR(100),
articulado         VARCHAR(100),
empresa			   VARCHAR(100),
unidade			   VARCHAR(100),
irmaoRa			   VARCHAR(100),
irmaoNome		   VARCHAR(100),
periodoLetivo	   VARCHAR(100),		
filial             VARCHAR(100),
bolsaParcInicial   VARCHAR(100),
bolsaParcFinal	   VARCHAR(100),
nomeServico		   VARCHAR(100),
dataMatricula	   VARCHAR(100),
codTurma1		   VARCHAR(100),
bolsaNome		   VARCHAR(100),
bolsaDataInicial   VARCHAR(100),
bolsaDataFinal	   VARCHAR(100),
nomeTurma		   VARCHAR(100),
nomeReduzidoTurma  VARCHAR(100),
motivoAlteracao    VARCHAR(100),
dataAlteracao	   VARCHAR(100),
historicoStatus	   VARCHAR(100),
telCelular2		   VARCHAR(100),
cartIdentidadeMae  VARCHAR(100),
cartIdentidadePai  VARCHAR(100),
naturalidadeAluno  VARCHAR(100),
nacionalidadeAluno VARCHAR(100),
nomeInstituicao	   VARCHAR(100),
pcd				   VARCHAR(100), 
auditiva		   VARCHAR(100),
fala			   VARCHAR(100),
visual			   VARCHAR(100),
mental			   VARCHAR(100),
valorBolsa		   VARCHAR(100),
articuladoSesi	   VARCHAR(100),
);
-- DROP TABLE Empresa

CREATE TABLE Usuario
(
codUsuario	INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
email		VARCHAR(100),
senha	    VARCHAR(100),
nome		VARCHAR(100),
tipo	    INT,
);

CREATE TABLE Empresa
(
codEmpresa		   INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
nomeEmpresa		   VARCHAR(100),
cnpj				CHAR(18),
razaoSocial		   VARCHAR(100),
telefone		   CHAR(14),
emailContato	   VARCHAR(100),
cidade			   VARCHAR(100),
estado			   VARCHAR(100),
bairro			   VARCHAR(100),
rua				   VARCHAR(100),
complemento		   VARCHAR(150),
numeroCasa		   VARCHAR(50),
cep				   CHAR (9),
responsavelContrato		VARCHAR(100),
telefoneResponsavel		VARCHAR(100),
);
CREATE TABLE Emprego
(
codEmprego			INT PRIMARY KEY IDENTITY (1,1),
aluno_codAluno		INT,
empresa_codEmpresa	INT,
nomeAluno			VARCHAR(100),
nomeEmpresa			VARCHAR(100),

cpfAluno			VARCHAR(100),
cnpjEmpresa			VARCHAR(100),
idadeAluno			VARCHAR(100),
FOREIGN KEY (empresa_codEmpresa) REFERENCES Empresa (codEmpresa),
FOREIGN KEY (aluno_codAluno) REFERENCES Aluno (codAluno),
);
CREATE TABLE HistoricoEmprego(
codEmpresa	INT PRIMARY KEY IDENTITY (1,1),
aluno_codAluno INT,
empresa_codEmpresa INT,
nomeAluno	VARCHAR(100),
nomeEmpresa VARCHAR(100),
cpfAluno	VARCHAR(100),
cpfEmpresa	VARCHAR(100),
idadeAluno	VARCHAR(100),
FOREIGN KEY (empresa_codEmpresa) REFERENCES Empresa (codEmpresa),
FOREIGN KEY (aluno_codAluno) REFERENCES Aluno(codAluno),
);

CREATE TABLE solicitacaoContrato(
codContrato INT PRIMARY KEY IDENTITY (1,1),
empresa_codEmpresa INT,
nomeEmpresa		VARCHAR(100),
tipoContrato	VARCHAR(100),
FOREIGN KEY (empresa_codEmpresa) REFERENCES Empresa(codEmpresa),
);
CREATE TABLE statusAluno(
codStatus	INT PRIMARY KEY IDENTITY (1,1),
nomeEmpresa VARCHAR(100),
nomeAluno	VARCHAR(100),
statusAluno	VARCHAR(40),
descricao	VARCHAR(255),
dataInicio	char(10),
dataFim		char(10),

);
-- DROP TABLE Empresa
SELECT * FROM Emprego

-- DROP DATABASE dbProjetoSenai
-- USE MASTER 

INSERT INTO Usuario VALUES('diretor@gmail.com','adm123','Administrador','1');
INSERT INTO Empresa VALUES('aaaaaaaaaaa','1234569851255','aaaaaaaaaaaaaa','031999999999','dddddd@gmail.com','Belo Horizonte','Minas Gerais','Sao gabriel','Jose ourial','Apartamento','102','31635874','Vitão','03199999999');
INSERT INTO Usuario (email,senha,nome,tipo) VALUES ('a@gmail.com','123','a',1)

INSERT INTO Usuario (email,senha,nome,tipo) VALUES ('wef@wddw.com','123456','fewefw',1)