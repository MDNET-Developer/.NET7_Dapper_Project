namespace DapperRealEstateWebApi.Dtos.CategoryDtos
{
    public class ListCategoryDto
    {

        /*CategoryID int primary key identity(1,1),
--CategoryName nvarchar(55),
--CategoryStatus bit,*/

        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
