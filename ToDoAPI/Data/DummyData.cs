using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Models;

namespace ToDoAPI.Data
{
    //dummy data to insert on database
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ToDoContext>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                // Look for any ailments
                if (context.ToDos != null && context.ToDos.Any())
                    return;   // DB has already been seeded

                var todos = GetToDos(context).ToArray();
                context.ToDos.AddRange(todos);
                context.SaveChanges();
            }
        }
        
        public static List<ToDo> GetToDos(ToDoContext db)
        {
            //value
            List<ToDo> todos = new List<ToDo>() {
              new ToDo {DTToDo=new DateTime(2020, 8, 17, 17, 0, 0), title="Project HUT RI 75", desc="Program HUT RI 75 Tahun Merdeka", percent="100%", mark="Done"},
              new ToDo {DTToDo=new DateTime(2020, 8, 20, 17, 0, 0), title="Project Tahun Baru Islam", desc="Project Video Tahun Baru Islam", percent="80%", mark="UnDone"},
              new ToDo {DTToDo=new DateTime(2020, 10, 12, 17, 0, 0), title="Project WEB API 2.1", desc="Project WEB API .Net Core 2.1", percent="70%", mark="UnDone"},
              new ToDo {DTToDo=new DateTime(2020, 10, 28, 17, 0, 0), title="Project ASP .NET", desc="Project ASP .Net KMP with RAD4M", percent="40%", mark="UnDone"},
              new ToDo {DTToDo=new DateTime(2020, 11, 15, 16, 0, 0), title="Project API", desc="Project API collaborate with RAD4M", percent="25%", mark="UnDone"},
            };
            return todos;
        }

 
    }
}
