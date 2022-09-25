using HtmlAgilityPack;
using System.Net;
using System;
using System.Drawing;
using System.Drawing.Imaging;

//Notes:
// I have learnt how to scrape the web through the following website -> https://medium.com/c-sharp-progarmming/create-your-own-web-scraper-in-c-in-just-a-few-minutes-c42649adda8
// I am not 100% sure it is possible to scrape information from any website
// from a quick bit of research, i have found out that some website may have security to stop web scraping
// however this reseource may be unreliable so i should take it with a pinch of salt.

HtmlWeb web = new HtmlWeb();
    
    //load a specific website from web
    HtmlDocument doc = web.Load("https://www.averticalworld.co.uk/");
//Console.WriteLine(doc.DocumentNode.InnerHtml);

//retreive nav bar items
var NavItems =
    doc.DocumentNode.SelectNodes("//span[@class='menu-text']");

foreach (var item in NavItems.Distinct().ToList())
{
    string url = "https://www.averticalworld.co.uk/" + item.InnerText.ToLower();

    HtmlDocument tempDoc = web.Load(url);

    if (tempDoc == null) continue;

    var images =
        tempDoc.DocumentNode.SelectNodes("//img");

    foreach (var image in images)
    {
        Console.WriteLine(image.OuterHtml);
    }
}