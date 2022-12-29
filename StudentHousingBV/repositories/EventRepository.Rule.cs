using StudentHousingBV.models;

namespace StudentHousingBV.repositories
{
    public partial class EventRepository
    {
        public List<Rule> GetAllRules() {
            return sqlQueryHelper<Rule>("SELECT * FROM [RULE]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [RULE].[EventId]", new { }, () => new());
        }

        public List<Rule> GetAllRulesInBuildingId(int buildingId)
        {
            return sqlQueryHelper<Rule>("SELECT * FROM [RULE]" +
                " WHERE [RULE].[BuildingId] = @buildingId" +
                " JOIN [EVENT] ON [EVENT].[Id] = [RULE].[EventId]",
                new { buildingId },
                () => new());
        }

        public void CreateRule(string title, string description, int creatorId, int buildingId)
        {
            sqlNonQueryHelper("INSERT INTO [EVENT]" +
                " ([Title], [Description], [CreatorId], [BuildingId], [CreatedAt])" +
                " VALUES (@title, @description, @creatorId, GETDATE());" +
                "INSERT INTO [RULE]" +
                " ([EventId], [UpdatedAt])" +
                " VALUES" +
                " (SCOPE_IDENTITY(), GETDATE())",
                new { title, description, creatorId });

        }

        public void UpdateRule(int id, string title, string description, int creatorId, int buildingId)
        {
            sqlNonQueryHelper("UPDATE [EVENT]" +
                " SET [Title] = @title, [Description] = @description, [CreatorId] = @creatorId, [BuildingId] = @buildingId" +
                " WHERE [Id] = @id;" +
                "UPDATE [RULE]" +
                " SET [UpdatedAt] = GETDATE()" +
                " WHERE [EventId] = @id;",
                new { title, description, creatorId, buildingId, id });
        }

        public Rule? GetRule(int id)
        {
            return sqlOneHelper<Rule>("SELECT * FROM [RULE]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [RULE].[EventId]" +
                " WHERE [RULE].[Id] = @id",
                new { id },
                () => new());
        }
    }
}
