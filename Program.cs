using HtmlAgilityPack;

//Notes:
// I have learnt how to scrape the web through the following website -> https://medium.com/c-sharp-progarmming/create-your-own-web-scraper-in-c-in-just-a-few-minutes-c42649adda8
// I am not 100% sure it is possible to scrape information from any website
// from a quick bit of research, i have found out that some website may have security to stop web scraping
// however this reseource may be unreliable so i should take it with a pinch of salt.

HtmlWeb web = new HtmlWeb();
    
    //load a specific website from web
    HtmlDocument doc = web.Load("https://en.wikipedia.org/wiki/Anime");

    //retreive all span elements that have the class 'toctext'
    var HeaderNames =
        doc.DocumentNode.SelectNodes("//span[@class='toctext']");
    
    //loop through headers and print
    foreach (var item in HeaderNames)
    {
        Console.WriteLine(item.InnerText);
    }


