using Microsoft.EntityFrameworkCore;

namespace Stone_homework.Storage.Base
{
    public static class Extentions
    {
        public static void DetachAll(this DbContext dbContext)
        => dbContext.ChangeTracker.Entries().ToList()
            .ForEach(e => e.State = EntityState.Detached);
    }
}
