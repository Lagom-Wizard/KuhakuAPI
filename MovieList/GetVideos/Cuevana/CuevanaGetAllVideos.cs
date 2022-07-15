﻿using K_haku.Core.Application.ViewModels.Cuevana;
using PuppeteerSharp;
using ScrapySharp.Html;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Html.Forms;
using K_haku.Core.Application.Helpers;

namespace K_haku.Core.Movie.GetVideos.Cuevana
{
    //https://ww1.cuevana3.me/peliculas
    public class CuevanaGetAllVideos
    {
        /// <summary>
        /// To get All links of movies and languages
        /// </summary>
        /// <param name="movieLinks"></param>
        /// <returns>Languages and Movie Links</returns>

        public List<CuevanaVideoViewModel> MovieVideos(string movieLink)
        {
            ScrapingBrowser browser = new ScrapingBrowser();
            List<string> language = new();
            List<int> languageInt = new();
            List<string> movieLinks = new();

            WebPage webPage = browser.NavigateToPage(new Uri(movieLink));
            var moviePage = webPage.Find("div", By.Class("video")).FirstOrDefault();
            var languageList = moviePage.SelectNodes("//li[@class='open_submenu']/div[2]/ul/li");

            List<CuevanaVideoViewModel> vm = languageList.Select(iLanguage => new CuevanaVideoViewModel
            {
                Language = iLanguage.SelectSingleNode("./span/span").InnerText.Substring(3),
                Link = iLanguage.SelectSingleNode($"//div[@id='{iLanguage.SelectSingleNode(".").Attributes["data-tplayernv"].Value}']/iframe").Attributes["data-src"].Value,
                Type = iLanguage.SelectSingleNode("./span/div").InnerText,
            }).ToList();

            CuevanaVideoViewModel trailer = new();
            trailer.Language= "Unknow";
            trailer.Link = moviePage.SelectSingleNode($"//div[@id='OptY']/iframe").Attributes["data-src"].Value;
            trailer.Type = "Trailer";
            vm.Add(trailer);

            return vm;
        }

        public async Task<string> GetSource(CuevanaVideoViewModel vm)
        {
            if (vm.Type == null || vm.Type == "" || vm.Type == "Trailer")
            {
            
            }
            else
            {

                ScrapingBrowser browser = new ScrapingBrowser();
                WebPage webPage = browser.NavigateToPage(new Uri($"https:{vm.Link}"));
                var vid = webPage.Html;
                var link = vid.SelectSingleNode("//a/@href").Attributes["href"].Value;
                var videoStartPage = await browser.NavigateToPageAsync(new Uri($"https://apialfa.tomatomatela.com/ir/{link}"));
                var form = videoStartPage.Find("form", By.Id("FbAns")).FirstOrDefault();

                SendFormCuevana formCN = new();
                HtmlDocument doc = new HtmlDocument();

                int i = 0;
                string dataFirst = "";
                while (i != 1)
                {
                    var action = form.SelectSingleNode("//form").Attributes["action"].Value;
                    var formData = form.SelectSingleNode("//form/input").Attributes["value"].Value;
                    dataFirst = formCN.Send($"https://apialfa.tomatomatela.com/ir/{action}", $"{formData}");
                    if (!(dataFirst.ToString()).Contains("!DOCTYPE")){
                        i++;
                    }
                    doc.LoadHtml(dataFirst);
                    form = doc.DocumentNode;
                }
                return $"https://tomatomatela.com/details.php?v={dataFirst.Substring(1)}";
            }

            return "VIDEO NOT SUPPORTED";
        }
    }
}
