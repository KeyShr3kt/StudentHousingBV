using StudentHousingBV.models;
using Task = StudentHousingBV.models.Task;

namespace StudentHousingBV.repositories
{
    public partial class EventRepository
    {
        private Dictionary<int, Task> _tasks = new();
        public List<Task> GetAllTasks()
        {
            return _tasks.Values.ToList();
            //return new List<Task> {
            //    new Task(1, "Task1", "Description here", DateTime.Now, 1, 1, false, false),
            //    new Task(2, "Task2", "Description here", DateTime.Now, 1, 1, true, false, 337),
            //    new Task(3, "Task3", "Description here", DateTime.Now, 1, 1, true, false)
            //};
        }
        public List<Task> GetAllTasksWithTotalPriceAndNotCompleted()
        {
            return _tasks.Values.Where(t => t.TotalPrice != null && !t.IsCompleted).ToList();
        }

        public List<Task> GetAllTasksWithStatusCompleted()
        {
            return _tasks.Values.Where(t => t.IsCompleted).ToList();
        }

        public List<Task> GetAllTasksInBuildingIdWithTotalPriceAndNotCompleted(int buildingId)
        {
            // TODO: implement
            return _tasks.Values.Where(t => t.BuildingId == buildingId && t.TotalPrice != null && !t.IsCompleted).ToList();
        }

        public List<Task> GetAllTasksInBuildingIdWithStatusCompleted(int buildingId)
        {
            return _tasks.Values.Where(t => t.BuildingId == buildingId && t.IsCompleted).ToList();
        }

        public List<Task> GetAllTasksInBuildingId(int buildingId)
        {
            return _tasks.Values.Where(t => t.BuildingId == buildingId).ToList();
        }

        public void CreateTask(string title, string description, int creatorId, int buildingId)
        {
            int id = _lastId++;
            Task task = new(id, title, description, DateTime.Now, creatorId, buildingId, false, false);
            _tasks[id] = task;
            _events[id] = task;
        }

        public void MarkTaskIdAsComplete(int id)
        {
            if (_tasks.TryGetValue(id, out Task? task))
            {
                task.IsCompleted = true;
            }
        }

        public Task? GetTask(int id)
        {
            _tasks.TryGetValue(id, out Task? task);
            return task;
        }

        public void UpdateTask(int id, string title, string description, int creatorId, int buildingId, bool isShopping, bool isCompleted)
        {
            if (_tasks.TryGetValue(id, out Task? task))
            {
                task.Title = title;
                task.Description = description;
                task.CreatorId = creatorId;
                task.BuildingId = buildingId;
                task.IsShopping = isShopping;
                task.IsCompleted = isCompleted;
            }
        }
    }
}
