
-- Tabela Users
CREATE TABLE IF NOT EXISTS Users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nome TEXT NOT NULL,
    Sobrenome TEXT NOT NULL,
    Email TEXT UNIQUE NOT NULL,
    Senha TEXT NOT NULL,
    TipoUsuario TEXT NOT NULL,
    DataCriacao DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Tabela Alunos
CREATE TABLE IF NOT EXISTS Alunos (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nome TEXT NOT NULL,
    Sobrenome TEXT NOT NULL,
    Email TEXT UNIQUE,
    Telefone TEXT,
    DataNascimento DATE,
    Peso REAL,
    Altura REAL,
    ProfessorId INTEGER,
    DataCriacao DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ProfessorId) REFERENCES Users (Id) ON DELETE SET NULL
);

-- Tabela Exercicios
CREATE TABLE IF NOT EXISTS Exercicios (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nome TEXT NOT NULL,
    Descricao TEXT,
    GrupoMuscular TEXT NOT NULL,
    EquipamentoNecessario TEXT,
    DataCriacao DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Tabela MetodosDeExercicios
CREATE TABLE IF NOT EXISTS MetodosDeExercicios (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nome TEXT NOT NULL,
    Descricao TEXT,
    DataCriacao DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Tabela ExerciciosProntos
CREATE TABLE IF NOT EXISTS ExerciciosProntos (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    ExercicioId INTEGER NOT NULL,
    MetodoId INTEGER NOT NULL,
    Repeticoes INTEGER NOT NULL,
    Cargas REAL,
    DescansoSegundos INTEGER,
    DataCriacao DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ExercicioId) REFERENCES Exercicios (Id) ON DELETE CASCADE,
    FOREIGN KEY (MetodoId) REFERENCES MetodosDeExercicios (Id) ON DELETE CASCADE
);

-- Tabela Treinos
CREATE TABLE IF NOT EXISTS Treinos (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nome TEXT NOT NULL,
    AlunoId INTEGER NOT NULL,
    ProfessorId INTEGER,
    DataInicio DATE,
    DataFim DATE,
    DataCriacao DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (AlunoId) REFERENCES Alunos (Id) ON DELETE CASCADE,
    FOREIGN KEY (ProfessorId) REFERENCES Users (Id) ON DELETE SET NULL
);

-- Tabela AvaliacoesFisicas
CREATE TABLE IF NOT EXISTS AvaliacoesFisicas (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    AlunoId INTEGER NOT NULL,
    Peso REAL,
    Altura REAL,
    PercentualGordura REAL,
    MassaMagra REAL,
    Observacoes TEXT,
    DataAvaliacao DATE DEFAULT CURRENT_DATE,
    DataCriacao DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (AlunoId) REFERENCES Alunos (Id) ON DELETE CASCADE
);

-- Tabela Nutricao
CREATE TABLE IF NOT EXISTS Nutricao (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    AlunoId INTEGER NOT NULL,
    PlanoNutricional TEXT NOT NULL,
    CaloriasDiarias INTEGER,
    Proteinas REAL,
    Carboidratos REAL,
    Gorduras REAL,
    DataCriacao DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (AlunoId) REFERENCES Alunos (Id) ON DELETE CASCADE
);

-- Tabela CicloDeEAS
CREATE TABLE IF NOT EXISTS CicloDeEAS (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    AlunoId INTEGER NOT NULL,
    NomeCiclo TEXT NOT NULL,
    Descricao TEXT,
    DataInicio DATE NOT NULL,
    DataFim DATE NOT NULL,
    Observacoes TEXT,
    DataCriacao DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (AlunoId) REFERENCES Alunos (Id) ON DELETE CASCADE
);
