

namespace Library_management_system
{
    public class Book
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public int Year {  get; set; }
        public override string ToString()
        {
            return $"Book name : {Title} , Author {Author} , Year {Year}";
        }
    }
}
