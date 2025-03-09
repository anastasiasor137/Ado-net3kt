   using Microsoft.AspNetCore.Mvc;

   namespace MyAspNetCoreApp.Controllers
   {
       public class TestController : Controller
       {
           public async Task Text()
           {
               Response.ContentType = "text/plain";
               await Response.WriteAsync("Hello, world!");
           }

           public async Task Html()
           {
               Response.ContentType = "text/html";
               await Response.WriteAsync("Hello, World!This is a paragraph.");
           }

           public async Task Json()
           {
               var obj = new { Name = "John Doe", Age = 30 };
               Response.ContentType = "application/json";
               await Response.WriteAsJsonAsync(obj);
           }

           public async Task File()
           {
               var filePath = "test.txt";
               System.IO.File.WriteAllText(filePath, "This is a test file");
               Response.ContentType = "text/plain";
               await Response.SendFileAsync(filePath);
           }

           public async Task Status()
           {
               Response.StatusCode = 404;
               await Response.WriteAsync("404 Not Found");
           }

           public async Task Cookie()
           {
               Response.Cookies.Append("user", "Answer");
               await Response.WriteAsync("Cookie set");
           }
       }
   }