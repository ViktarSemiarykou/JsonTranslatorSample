using System;

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
