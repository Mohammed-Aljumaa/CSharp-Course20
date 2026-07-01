using System;


public class NewsArticle
{
    public string Title { get; }
    public string Content { get; }

    public NewsArticle(string Title, string Content)
    {
        this.Title = Title;
        this.Content = Content;
    }
}

public class NewPublisher
{

    public event EventHandler<NewsArticle> newNewsArticle;


    public void PublishNews(string Titel,string Contant)
    {

        var Artical=new  NewsArticle(Titel, Contant);

        OnNewNewsPublisher(Artical);

    }

    protected virtual void  OnNewNewsPublisher(NewsArticle NewsArticle)
    {

        newNewsArticle?.Invoke(this, NewsArticle);
    }



}


public class NewsSubscribee
{

    public string Name { get; }
    
    public NewsSubscribee(string name)
    {
        this.Name = name;
    }

    public void Subscribe(NewPublisher publisher)
    {

        publisher.newNewsArticle += HandelNewNews;
    }
     public void UnSubscribe(NewPublisher publisher)
    {

        publisher.newNewsArticle -= HandelNewNews;
    }

    public void HandelNewNews(object Sender,NewsArticle article)
    {

          Console.WriteLine($"{Name} received a new news article:");
        Console.WriteLine($"Title: {article.Title}");
        Console.WriteLine($"Content: {article.Content}");
        Console.WriteLine();

    }

    public class Program
    {
        static void Main()
        {
            NewPublisher publisher = new NewPublisher();
            NewsSubscribee subscriber1 = new NewsSubscribee("Subscriber 1");

            subscriber1.Subscribe(publisher);

            NewsSubscribee subscriber2 = new NewsSubscribee("Subscriber 2");
            subscriber2.Subscribe(publisher);

            publisher.PublishNews("Breaking News", "A significant event just happened!");

            publisher.PublishNews("Tech Update", "New gadgets are hitting the market.");

            // Unsubscribe a subscriber (e.g., subscriber1)
            subscriber1.UnSubscribe(publisher);

            publisher.PublishNews("Weather Forecast", "Expect sunny weather for the weekend.");

            // Unsubscribe another subscriber (e.g., subscriber2)
            subscriber2.UnSubscribe(publisher);

            publisher.PublishNews("Final Edition", "Last news update for today.");

            Console.ReadLine();
        }
    }


}