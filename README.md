# Estudando_API

* Fiz esse repositorio acompanhando esse video <https://www.youtube.com/watch?v=VDCkFAwfI-o>
* Lembrando que para que o código funcionasse como no vídeo, foi necessário o seguinte comando:
 ```
dotnet add package Newtonsoft.Json
```

 #### **Explicando o Código:**

O  ``` public static asyn Task Main(String[] args) ``` é como  ```async``` , o que permite o uso de operações assíncronas para evitar o bloqueio da thread principal enquanto aguarda a resposta da API

``` HttpClient client = new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com/users") }; ``` É criada uma instancia da classe ```HttpClient``` que vai ser utilizada pra fazer solicitações http pra url base

``` var respoonde = await cliente.GetAsync("users");``` Uma solicitação GET é feita pra rota "users" no url base definido anteriormente. O resultado da solicitação é armazenado na variavel ```response```

``` var content = await responde.Content.ReadAsStringAsync();``` O conteudo da resposta HTTP é lido como uma string assíncrona e armazenado na variável ```content``` , que geralmente é um document ```Json```

``` var users = JsonConvert.DeserializeObject<User[]>(content);``` O conteudo JSON é desserializado em um array de objetos do tipo ```user``` usando a biblioteca Newtonsoft.Json.

#### **O Código nesse repositório é um simples exemplo de como fazer solicitação HTTP, desserializar Json e exibir os dados.**
