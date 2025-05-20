namespace LogSheet_API.DTOs
{
    public class LogSheetDto
    {
        public decimal Id { get; set; }

        public decimal? SolutionId { get; set; }

        public decimal? ClientId { get; set; }

        public decimal? TaskId { get; set; }

        public string? WorkStatus { get; set; }

        public string? LogDescription { get; set; }

        public decimal? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
    

    public class LogSheetDtoByID
    {
        public decimal Id { get; set; }
    }

    public class SaveUpdateLogSheetDto
    {
        public decimal Id { get; set; }

        public decimal? SolutionId { get; set; }

        public decimal? ClientId { get; set; }

        public decimal? TaskId { get; set; }

        public string? WorkStatus { get; set; }

        public string? LogDescription { get; set; }


    }
}
