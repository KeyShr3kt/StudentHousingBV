-- Disable foreign key constraints
EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all";

-- Drop all foreign keys
EXEC sp_msforeachtable
"IF OBJECTPROPERTY(object_id(''?''), ''TableHasForeignRef'') = 1
    BEGIN ALTER TABLE ? DROP CONSTRAINT FK_?";

-- Drop all tables
EXEC sp_msforeachtable "DROP TABLE ?";
