CREATE TABLE [dbo].[TBCompromisso] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [assunto]     VARCHAR (250) NOT NULL,
    [telefone]    VARCHAR (250) NOT NULL,
    [data]        DATETIME      NOT NULL,
    [horaInicio]  DATETIME      NOT NULL,
    [horaTermino] DATETIME      NOT NULL,
    [Contato_Id]  INT           NOT NULL,
    [ehRemoto]    BIT           NOT NULL,
    CONSTRAINT [PK_TBCompromisso] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBCompromisso_TBContato] FOREIGN KEY ([Contato_Id]) REFERENCES [dbo].[TBContato] ([Id])
);

