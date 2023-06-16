CREATE TABLE [jointables].[SignCardIcon]
(
    [Id]                        INT                 NOT NULL IDENTITY,
    [SignCardId]                INT                 NOT NULL,
    [IconId]                    INT                 NOT NULL,

    CONSTRAINT [PK_SignCardIcon] PRIMARY KEY ([Id])
)
