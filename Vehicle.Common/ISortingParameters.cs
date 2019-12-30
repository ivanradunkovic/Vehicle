namespace Vehicle.Common
{
 
    // Sorting parameters interface.
 
    public interface ISortingParameters
    {
     
        // Gets or sets sort order.
  
        string SortOrder { get; set; }

     
        // Gets or sets sort field.
   
        string SortField { get; set; }
    }
}
