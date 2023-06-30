CREATE TABLE [dbo].[TBCategoria] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [titulo] VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_TBCategoria] PRIMARY KEY CLUSTERED ([Id] ASC)
);

