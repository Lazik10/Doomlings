CREATE TABLE [jointables].[BirthCardIcon]
(
    [Id]                        INT                 NOT NULL IDENTITY,
    [BirthCardId]               INT                 NOT NULL,
    [IconId]                    INT                 NOT NULL,

    CONSTRAINT [PK_BirthCardIcon] PRIMARY KEY ([Id])
)
