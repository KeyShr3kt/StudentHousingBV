using StudentHousingBV.models;

namespace StudentHousingBV.repositories
{
    public partial class EventRepository
    {
        public List<Rule> GetAllRules() {
            return sqlQueryHelper<Rule>("SELECT * FROM [RULE]", new { }, () => new());
        }

        public List<Rule> GetAllRulesInBuildingId(int buildingId)
        {
            return sqlQueryHelper<Rule>("SELECT * FROM [RULE] WHERE [RULE].[BuildingId] == @buildingId",
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
            sqlNonQueryHelper("UPDATE [RULE]" +
                " SET [Title] = @title, [Description] = @description, [CreatorId] = @creatorId, [BuildingId] = @buildingId, [UpdatedAt] = GETDATE()" +
                " WHERE [Id] = @id",
                new { title, description, creatorId, buildingId, id });
        }

        public Rule? GetRule(int id)
        {
            return sqlOneHelper<Rule>("SELECT * FROM [RULE]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [RULE].[Id]" +
                " WHERE [RULE].[Id] = @id",
                new { id },
                () => new());
        }
    }
}
