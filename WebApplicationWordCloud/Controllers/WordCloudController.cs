using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationWordCloud.Model;

namespace WebApplicationWordCloud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordCloudController : ControllerBase
    {
        //sample data
        private static List<Word> myWordList = 
            new List<Word>() {
                new Word("Japan") ,
                new Word("Greece"),
                new Word("Denmark"),
                new Word("Japan"),
                new Word("Japan"),
                new Word("Greece"),
                new Word("Japan"),
                new Word("Sweden"),
            };




        // GET: api/WordCloud
        [HttpGet]
        public IEnumerable<WordResponse> Get()
        {
            //var responseList = new List<WordResponse>();

            //do some LINQ or a foreach

            var mylist = from word in myWordList
                         group word by word.MyWord
                         into wordGroup
                         orderby wordGroup.Key
                         select new WordResponse(wordGroup.Key, wordGroup.Count());                       


    
            return mylist;
        }

        //// GET: api/WordCloud/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/WordCloud
        [HttpPost]
        public ActionResult<Word> Post([FromBody] Word word)
        {

            myWordList.Add(new Word(word.MyWord));
            return word;
        }

    }
}
