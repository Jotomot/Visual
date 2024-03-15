using Flurl.Http;

namespace FlurExercise;

class Program
{
    public static async Task Main(string[] args)
    {
       var result = await "https://jsonplaceholder.typicode.com/posts".GetAsync().ReceiveJson<List<Post>>();

        var selectedPost = result.First(p => p.Id == 30);
        Console.WriteLine(selectedPost.Title);
        Console.WriteLine(selectedPost.Body);

        selectedPost.Title = "test title";
        selectedPost.Body = "test body";
        Console.WriteLine(selectedPost.Title);
        Console.WriteLine(selectedPost.Body);
        



        var postResult = await "https://jsonplaceholder.typicode.com/posts"
            .WithHeaders(new
            {
                header = "value",
                some_Header = "value2"
            }, true)
            .SetQueryParams(new
            {
                postID = 1,
                someValue = "value"
            })
            .PostJsonAsync(selectedPost);
            
           
        Console.WriteLine(postResult.StatusCode);
    }
}