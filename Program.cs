using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QuickType;
public class Program{

    public static async Task Main(String[] args){

    HttpClient client = new HttpClient{BaseAddress = new Uri("https://jsonplaceholder.typicode.com/users")};

   var response =   await client.GetAsync("users");
    
   var content =  await response.Content.ReadAsStringAsync();

    var users = JsonConvert.DeserializeObject<User[]>(content);

    foreach(var item in users){
        System.Console.WriteLine("Nome: " + item.Name);
        System.Console.WriteLine("Email: " +item.Email);
        System.Console.WriteLine("-------------------");
    }

    
    
    }
  }

