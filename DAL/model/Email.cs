using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
	public class Email:Baseclass
	{
        public string Subject { get; set; }
		public string body { get; set; }
		public string From { get; set; }
	}
}
