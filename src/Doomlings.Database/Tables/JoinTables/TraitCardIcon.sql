CREATE TABLE [jointables].[TraitCardIcon]
(
    [Id]                        INT                 NOT NULL IDENTITY,
    [TraitCardId]               INT                 NOT NULL,
    [IconId]                    INT                 NOT NULL,

    CONSTRAINT [PK_TraitCardIcon] PRIMARY KEY ([Id])
)
