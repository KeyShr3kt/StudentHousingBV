using StudentHousingBV.models;

namespace StudentHousingBV.repositories
{
    public partial class EventRepository
    {
        public List<Agreement> GetAllAgreements()
        {
            return sqlQueryHelper<Agreement>("SELECT * FROM [AGREEMENT]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [AGREEMENT].[EventId]",
                new { },
                () => new());
        }

        public Agreement? GetAgreement(int id)
        {
            return sqlOneHelper<Agreement>("SELECT TOP 1 * FROM [AGREEMENT]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [AGREEMENT].[EventId]" +
                " WHERE [AGREEMENT].[EventId] = @id",
                new { id },
                () => new());
        }

        public void CreateAgreement(
            string title,
            string description,
            int creatorId,
            int buildingId,
            DateTime startDateTime,
            DateTime endDateTime
        )
        {
            sqlNonQueryHelper("INSERT INTO [EVENT]" +
                " ([Title], [Description], [CreatedAt], [CreatorId], [BuildingId])" +
                " VALUES" +
                " (@title, @description, GETDATE(), @creatorId, @buildingId);" +
                "INSERT INTO [AGREEMENT]" +
                " ([EventId], [StartDateTime], [EndDateTime], [IsAccepted])" +
                " VALUES" +
                " (SCOPE_IDENTITY(), @startDateTime, @endDateTime, 0);",
                new
                {
                    title,
                    description,
                    creatorId,
                    buildingId,
                    startDateTime = startDateTime.ToString("yyyy-MM-dd H:mm:ss"),
                    endDateTime = endDateTime.ToString("yyyy-MM-dd H:mm:ss")
                });
        }

        public void UpdateAgreement(
            int id,
            string title,
            string description,
            int creatorId,
            int buildingId,
            bool isAccepted
        )
        {
            sqlNonQueryHelper("UPDATE [EVENT]" +
                " SET [Title] = @title, [Description] = @descrpition, [CreatorId] = @creatorId, [BuildingId] = @buildingId" +
                " WHERE [Id] = @id;" +
                "UPDATE [AGREEMENT]" +
                " SET [IsAccepted] = @isAccepted" +
                " WHERE [EventId] = @id",
                new
                {
                    id,
                    title,
                    description,
                    creatorId,
                    buildingId,
                    isAccepted = isAccepted ? 1 : 0
                });
        }

        public List<Agreement> GetAgreementsForBuilding(int buildingId)
        {
            return sqlQueryHelper<Agreement>("SELECT * FROM [AGREEMENT]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [AGREEMENT].[EventId]" +
                " WHERE [EVENT].[BuildingId] = @buildingId",
                new { buildingId },
                () => new());
        }

        public List<Agreement> GetPendingAgreements(int buildingId)
        {
            return sqlQueryHelper<Agreement>("SELECT * FROM [AGREEMENT]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [AGREEMENT].[EventId]" +
                " WHERE [AGREEMENT].[IsAccepted] = 0" +
                " AND [EVENT].[BuildingId] = @buildingId",
                new { buildingId },
                () => new());
        }

        public List<Agreement> GetAcceptedAgreements(int buildingId)
        {
            return sqlQueryHelper<Agreement>("SELECT * FROM [AGREEMENT]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [AGREEMENT].[EventId]" +
                " WHERE [AGREEMENT].[IsAccepted] = 1" +
                " AND [EVENT].[BuildingId] = @buildingId",
                new { buildingId },
                () => new());
        }
    }
}
