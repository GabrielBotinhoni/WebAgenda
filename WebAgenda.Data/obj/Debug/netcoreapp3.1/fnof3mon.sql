CREATE TABLE [ErrorLogs] (
    [Id] int NOT NULL IDENTITY,
    [Date] datetime2 NOT NULL,
    [Details] nvarchar(max) NULL,
    [SystemMessage] nvarchar(max) NULL,
    [StackTrace] nvarchar(max) NULL,
    CONSTRAINT [PK_ErrorLogs] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220113193407_ErrorLog', N'3.1.22');

GO

