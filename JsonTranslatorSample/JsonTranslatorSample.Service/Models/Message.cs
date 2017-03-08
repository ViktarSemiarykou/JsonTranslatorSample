using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTranslatorSample.Service.Models
{
    public class Message
    {
        public int Id { get; set; }
        
        public string Subject { get; set; }
        
        public DateTime Date { get; set; }
        
        public Channel Channel { get; set; }
    }
}
