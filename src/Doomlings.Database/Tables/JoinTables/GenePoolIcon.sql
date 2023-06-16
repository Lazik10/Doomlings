CREATE TABLE [jointables].[GenePoolCardIcon]
(
    [Id]                        INT                 NOT NULL IDENTITY,
    [GenePoolCardId]            INT                 NOT NULL,
    [IconId]                    INT                 NOT NULL,

    CONSTRAINT [PK_GenePoolCardIcon] PRIMARY KEY ([Id])
)
