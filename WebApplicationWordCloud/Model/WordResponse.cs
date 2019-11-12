using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationWordCloud.Model
{





    public class WordResponse
    {

        /// <summary>
        /// the count of this word in the list
        /// </summary>
        public int Sum { get; set; }

        /// <summary>
        /// the word 
        /// </summary>
        public Word Word { get; set; }


        public WordResponse(string inputtext, int count)
            :this(inputtext)
        {
            this.Sum = count;
        }

        public WordResponse(string inputtext)
        {
            this.Word = new Word(inputtext);

        }

        /// <summary>
        /// default constructor
        /// </summary>
        public WordResponse()
        {
            this.Word = new Word();
        }

    }
}
