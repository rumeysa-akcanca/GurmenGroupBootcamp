
// See https://aka.ms/new-console-template for more information

class Blog
{
    //High Level Class
    IContent content;
    public Blog()
    {
        content = new Post();
    }
    public void Create()
    {
        content.CreatePost(true);
    }
}
