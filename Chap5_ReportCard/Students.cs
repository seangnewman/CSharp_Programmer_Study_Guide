using System;

namespace Chap5_ReportCard
{
    
    class Students
    {

        public event Action<object> GradeAlert;

        public string Name { get; set; }
        public int English { get; set; }
        public int Math { get; set; }
        public int Computer { get; set; }
        public int Marks => English + Math + Computer;
        public string ClassResult { get; set; }

        private int _scores;

        public int Scores
        {
            get { return Marks; }
            set {
                this._scores = value;

              
                    if(GradeAlert != null)
                    {
                      ClassResult = this._scores < 75 ? "F" : "Congratulations on Passing the class!";
                        GradeAlert(this);
                    }
                

            }
        }


        
    }
}
