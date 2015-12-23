CREATE TABLE [dbo].[People] (
    [Id]        INT           NOT NULL IDENTITY,
    [firstname] NVARCHAR (50) NOT NULL,
    [lastname]  NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

