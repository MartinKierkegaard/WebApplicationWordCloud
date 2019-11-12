using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationWordCloud.Model
{
    public class Word
    {
        /// <summary>
        /// The word that the user input
        /// </summary>
        public string MyWord { get; set; }


        public Word(string inputword)
        {
            this.MyWord = inputword;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public Word()
        {

        }
    }
}
