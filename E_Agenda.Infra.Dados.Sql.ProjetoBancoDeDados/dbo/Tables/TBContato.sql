CREATE TABLE [dbo].[TBContato] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (200) NOT NULL,
    [Telefone] VARCHAR (25)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

