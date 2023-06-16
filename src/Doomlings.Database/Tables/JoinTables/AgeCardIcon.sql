CREATE TABLE [jointables].[AgeCardIcon]
(
    [Id]                        INT                 NOT NULL IDENTITY,
    [AgeCardId]                 INT                 NOT NULL,
    [IconId]                    INT                 NOT NULL,

    CONSTRAINT [PK_AgeCardIcon] PRIMARY KEY ([Id])
)
