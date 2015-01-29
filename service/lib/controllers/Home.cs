namespace WebApplication1
{
    using Nancy;
    
    public class Home : NancyModule
    {
        public Home()
        {
            Get["/"] = _ => "Hello World";
        }
    }
}