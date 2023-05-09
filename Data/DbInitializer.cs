using Microsoft.EntityFrameworkCore;

namespace Tutorial.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<TutorialContext>();

                context.Database.EnsureCreated();
            }
        }
}
}
