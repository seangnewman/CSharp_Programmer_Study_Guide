namespace Chap1_ReportCard
{
    class Students
    {
        public string Name { get; set; }
        public int English { get; set; }
        public int Math { get; set; }
        public int Computer { get; set; }
        public int Marks => English + Math + Computer;
    }
}
