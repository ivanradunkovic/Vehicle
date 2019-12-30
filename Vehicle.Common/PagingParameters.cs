namespace Vehicle.Common
{
    // Paging parameters class.
    public class PagingParameters : IPagingParameters
    {
        // Paging parameters constructor.
        // <param name="pageNumber">Page number.</param>
        // <param name="pageSize">Page size.</param>
        public PagingParameters(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }


        // Gets or sets page number.
        public int PageNumber { get; set; }

        // Gets or sets page size.
        public int PageSize { get; set; }
    }
}
