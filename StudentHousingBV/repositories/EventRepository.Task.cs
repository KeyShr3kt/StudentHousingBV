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
        public List<Task> GetAllTasksWithTotalPriceAndNotCompleted()
        {
            return sqlQueryHelper<Task>("SELECT * FROM [Task]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [TASK].[EventId]" +
                " WHERE [TASK].[TotalPrice] IS NOT NULL" +
                " AND [TASK].[IsCompleted] = 0",
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

        public List<Task> GetAllTasksInBuildingIdWithTotalPriceAndNotCompleted(int buildingId)
        {
            return sqlQueryHelper<Task>("SELECT * FROM [Task]" +
                " JOIN [EVENT] ON [EVENT].[Id] = [TASK].[EventId]" +
                " WHERE [EVENT].[BuildingId] = @buildingId" +
                " AND [TASK].[TotalPrice] != NULL" +
                " AND [TASK].[IsCompleted] = 0",
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

        public void CreateTask(string title, string description, int creatorId, int buildingId, int totalPrice = 0)
        {
            sqlNonQueryHelper("INSERT INTO [EVENT]" +
                " ([Title], [Description], [CreatedAt], [CreatorId], [BuildingId])" +
                " VALUES" +
                " (@title, @description, GETDATE(), @creatorId, @buildingId);" +
                " INSERT INTO [TASK]" +
                " ([EventId], [IsShopping], [IsCompleted], [TotalPrice])" +
                " VALUES" +
                " (SCOPE_IDENTITY(), 0, 0, @totalPrice);",
                new { title, description, creatorId, buildingId, totalPrice });
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
    }
}
