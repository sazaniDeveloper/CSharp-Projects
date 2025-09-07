using Microsoft.Extensions.FileProviders;
using System.Data.SqlClient;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();


app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "StaticFiles")),  
    RequestPath = "/StaticFiles",
    EnableDefaultFiles = true
});


app.UseRouting();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapPost("/", async (HttpRequest request, HttpResponse response) =>
    {
        var form = await request.ReadFormAsync();
        var first_name = form["First_Name"].ToString();
        var last_name = form["Last_Name"].ToString();
        var email = form["Email"].ToString();
        Console.WriteLine(first_name);
        Console.WriteLine(last_name);
        Console.WriteLine(email);
        string connectionString = "Data Source=DESKTOP-JP92FBD\\SQLEXPRESS;Initial Catalog=form_data;Integrated Security=True;Encrypt=False";
        string queryString = "INSERT INTO dbo.users (first_name, last_name, email_address) VALUES (@first_name, @last_name, @email_address)";
       
        try {
            using SqlConnection cnn = new SqlConnection(connectionString);
            await cnn.OpenAsync();
            using (SqlCommand command = new SqlCommand(queryString, cnn))
            {
                command.Parameters.AddWithValue("@first_name", first_name);
                command.Parameters.AddWithValue("@last_name", last_name );
                command.Parameters.AddWithValue("@email_address", email);
                await command.ExecuteNonQueryAsync();
            };
            await cnn.CloseAsync();
            response.Redirect("/StaticFiles/success.html");
        }
        catch(Exception e){
            Console.WriteLine("Error:"+e);
        }
      
    });
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
