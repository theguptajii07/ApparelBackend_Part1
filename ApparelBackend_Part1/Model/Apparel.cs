namespace ApparelBackend_Part1.Model
{
    public class Apparel
    {
        public required string Category_Name { get; set; }
        public required string Category_Description { get; set; }
        public required string Category_Sort_Order { get; set; }
        public required int Category_Sections { get; set; }
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public DateTime Updated_At { get; set; } = DateTime.UtcNow;
    }

    public class CategorySection
    {
        public required int Category_Sections { get; set; }
        public required string Section_Name { get; set; }
        public required int Section_Sort_Order { get; set; }
        public bool Section_Visible { get; set; }
        public required int Brand_Id { get; set; }
    }

    public class BrandsSection
    {
        public int Brand_Id { get; set; }
        public required string Brand_Belongings { get; set; }
        public required string Brand_Origin { get; set; }
        public float Brand_Rating { get; set; }
        public int Brand_Total_Products { get; set; }
    }

    public class SectionData
    {
        public required string Section_Name { get; set; }
    }
}
