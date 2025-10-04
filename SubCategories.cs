namespace AccountIntelligenceTool.Models
{
    public class SubCategories
    {
        public int id { get; set; }

        public string subCat { get; set; }

        public bool IsAccountLevel { get; set; }

        public bool IsProjectLevel { get; set; }

        public bool IsServiceImprovementLevel { get; set; }
    }
}