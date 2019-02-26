using System.Runtime.Serialization;



namespace Wholesaler
{
    [DataContract]
    public class LineItem
    {
        [DataMember]
        public string Unit { get; set; }
        [DataMember]
        public double Amount { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}