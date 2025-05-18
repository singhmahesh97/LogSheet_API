using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace LogSheet_API.VMMOdels
{
    public class TransactionalInformation
    {
        public string? TransInformation { get; set; }
        public bool ReturnStatus { get; set; }
        public List<String> ReturnMessage { get; set; }
        public TransactionalInformation() 
        {
            ReturnMessage=new List<String>();
            ReturnStatus = true;
        }
    }
}
