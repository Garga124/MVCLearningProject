using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", (HttpContext context) => {
//    string html = @"<html><body>
//<h1>Hello World!</h1> 
//<br/>
//Welcome to this new world!
//</body>
//</html>";
//    WriteHtml(context, html);
//});

app.MapGet("/", (HttpContext context) => {
    string html = @$"
<!doctype html>
<html>
<head><title>Html Demo</title></head>
<body>
<h1>Simple Framework</h1>
<br />
<form action = ""/login"" method = ""post"">
<label for=""username"">User Name:</label>
<input type = ""text"" id=""username"" name=""username"" required>
<label for=""password"">Password:</label>
<input type = ""password"" id=""password"" name=""password"" required>
<button type=""submit"">Login</button>
</form>
</body>
</html>
";
    WriteHtml(context, html);
});

app.MapPost("/login", (HttpContext context) =>
{
    var username = context.Request.Form["username"];    
    var password = context.Request.Form["password"];    
    if(username == "Ruhi" && password=="password")
    {
        var html = $@"
<!doctype html>
<html>
<head><title>minihtml</title></head>
<body>
<h1>Simple Framework</h1>
<br/>
Welcome to the Page!
</body>
</html>";
        WriteHtml(context, html);
    }
    else
    {
        string html = @$"
<!doctype html>
<html>
<head><title>Html Demo</title></head>
<body>
<h1>Simple Framework</h1>
<br />
<form action = ""/login"" method = ""post"">
<label for=""username"">User Name:</label>
<input type = ""text"" id=""username"" name=""username"" required>
<label for=""password"">Password:</label>
<input type = ""password"" id=""password"" name=""password"" required>
<button type=""submit"">Login</button>
<br/>
<label style=""color:Red"">Login failed!</label>
</form>
</body>
</html>
";
        WriteHtml(context, html);
    }
}); 

app.Run();

void WriteHtml(HttpContext context, string html)
{
    context.Response.ContentType = MediaTypeNames.Text.Html;
    context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
    context.Response.WriteAsync(html);


}