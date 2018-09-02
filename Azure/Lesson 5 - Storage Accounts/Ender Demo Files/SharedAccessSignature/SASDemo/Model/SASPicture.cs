using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SASDemo.Model
{
	public class SASPicture
    {//Dolev Properties to pass to the view
        public string SimpleLink { get; set; }
		public string SASLink { get; set; }
		public string Name { get; set; }
		public DateTime ValidTo { get; set; }
	}
}