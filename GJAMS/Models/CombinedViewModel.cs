namespace GJAMS.Models
{
    public class CombinedViewModel
    {
        public IEnumerable<Table_2> Table_2 { get; set; }
        public IEnumerable<AdmitCard> AdmitCard { get; set; }
        public IEnumerable<Result> Result { get; set; }
       public IEnumerable<AdminTable> AdminTable { get; set; }
        // New properties for counts
        public int TotalTable2Count { get; set; }
        public int TotalResultsCount { get; set; }
        public int TotalAdmitCardsCount { get; set; }
    }
}
