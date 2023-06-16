CREATE TABLE [icons].[Icons]
(
    [Id]                        INT                 NOT NULL IDENTITY,
    [Name]                      NVARCHAR(50)        NOT NULL,
    [Type]                      INT                 NOT NULL,
    [Image]                     VARBINARY(MAX)      NULL,

    CONSTRAINT [PK_Icons] PRIMARY KEY ([Id]),
)
