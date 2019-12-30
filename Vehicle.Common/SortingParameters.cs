namespace Vehicle.Common
{
    // Sorting parameters class.
    public class SortingParameters : ISortingParameters
    {
        #region constructor

 
        // Sorting parameters constructor.
        // <param name="sortOrder">Sort order.</param>
        // <param name="sortField">Sort field.</param>
        public SortingParameters(string sortField, string sortOrder)
        {
            this.SortOrder = sortOrder;
            this.SortField = sortField;
        }

        #endregion

        // Gets or sets sort order.

        public string SortOrder { get; set; }

        // Gets or sets sort field.
        public string SortField { get; set; }

    }
}
