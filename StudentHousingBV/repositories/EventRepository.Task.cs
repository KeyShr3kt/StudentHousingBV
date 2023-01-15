using StudentHousingBV.models;
using Task = StudentHousingBV.models.Task;

namespace StudentHousingBV.repositories
{
    public partial class EventRepository
    {
        public List<Task> GetAllTasks()
        {
            return sqlQueryHelper<Task>("SELECT * FROM [TASK]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [TASK].[EventId]",
                new { },
                () => new());
        }
        public List<Task> GetAllTasksForReview()
        {
            return sqlQueryHelper<Task>("SELECT * FROM [Task]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [TASK].[EventId]" +
                " WHERE [TASK].[TotalPrice] IS NOT NULL" +
                " AND [TASK].[IsCompleted] = 0" +
                " AND [TASK].[IsShopping] = 1;",
                new { },
                () => new());
        }

        public List<Task> GetAllTasksWithStatusCompleted()
        {
            return sqlQueryHelper<Task>("SELECT * FROM [Task]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [TASK].[EventId]" +
                " AND [TASK].[IsCompleted] = 1",
                new { },
                () => new());
        }

        public List<Task> GetAllTasksForReviewInBuilding(int buildingId)
        {
            return sqlQueryHelper<Task>("SELECT * FROM [Task]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [TASK].[EventId]" +
                " WHERE [TASK].[TotalPrice] IS NOT NULL" +
                " AND [EVENT].[BuildingId] = @buildingId" +
                " AND [TASK].[IsCompleted] = 0" +
                " AND [TASK].[IsShopping] = 1;",
                new { buildingId },
                () => new());
        }

        public List<Task> GetAllTasksInBuildingIdWithStatusCompleted(int buildingId)
        {
            return sqlQueryHelper<Task>("SELECT * FROM [Task]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [TASK].[EventId]" +
                " WHERE [EVENT].[BuildingId] = @buildingId" +
                " AND [TASK].[IsCompleted] = 1",
                new { buildingId },
                () => new());
        }

        public List<Task> GetAllTasksInBuildingId(int buildingId)
        {
            return sqlQueryHelper<Task>("SELECT * FROM [Task]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [TASK].[EventId]" +
                " WHERE [EVENT].[BuildingId] = @buildingId",
                new { buildingId },
                () => new());
        }

        public void CreateTask(string title, string description, int creatorId, int buildingId)
        {
            sqlNonQueryHelper("INSERT INTO [EVENT]" +
                " ([Title], [Description], [CreatedAt], [CreatorId], [BuildingId])" +
                " VALUES" +
                " (@title, @description, GETDATE(), @creatorId, @buildingId);" +
                " INSERT INTO [TASK]" +
                " ([EventId], [IsShopping])" +
                " VALUES" +
                " (SCOPE_IDENTITY(), 0);",
                new { title, description, creatorId, buildingId });
        }

        public void AddPriceToTask(int id, int price)
        {
            sqlNonQueryHelper("UPDATE [TASK]" +
                " SET TotalPrice = @price" +
                " WHERE EventId = @id;",
                new { id, price });
        }

        public void CreateTaskGrocery(string title, string description, int creatorId, int buildingId)
        {
            sqlNonQueryHelper("INSERT INTO [EVENT]" +
                " ([Title], [Description], [CreatedAt], [CreatorId], [BuildingId])" +
                " VALUES" +
                " (@title, @description, GETDATE(), @creatorId, @buildingId);" +
                " INSERT INTO [TASK]" +
                " ([EventId], [IsShopping], [IsCompleted], [TotalPrice])" +
                " VALUES" +
                " (SCOPE_IDENTITY(), 1, 0, 0);",
                new { title, description, creatorId, buildingId });
        }

        public void MarkTaskIdAsComplete(int id)
        {
            sqlNonQueryHelper("UPDATE [TASK]" +
                " SET [IsCompleted] = 1" +
                " WHERE [EventId] = @id",
                new { id });
        }

        public Task? GetTask(int id)
        {
            return sqlOneHelper<Task>("SELECT TOP 1 * FROM [TASK]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [TASK].[EventId]" +
                " WHERE [TASK].[EventId] = @id",
                new { id },
                () => new());
        }

        public void UpdateTask(int id, string title, string description, int creatorId, int buildingId, bool isShopping, bool isCompleted)
        {
            sqlNonQueryHelper("UPDATE [EVENT]" +
                " SET [Title] = @title, [Description] = @description, [CreatorId] = @creatorId, [BuildingId] = @buildingId" +
                " WHERE [Id] = @id;" +
                "UPDATE [TASK]" +
                " SET [IsShopping] = @isShopping, [IsCompleted] = @isCompleted" +
                " WHERE [TASK].[EventId] = @id",
                new { id, title, description, creatorId, buildingId, isShopping = isShopping ? 1 : 0, isCompleted = isCompleted ? 1 : 0 });
        }

        public void DeleteTask(int id)
        {
            sqlNonQueryHelper("DELETE FROM [TASK]" +
                " WHERE [EventId] = @id; " +
                "DELETE FROM [EVENT]" +
                " WHERE [Id] = @id",
                new { id });
        }
    }
}
