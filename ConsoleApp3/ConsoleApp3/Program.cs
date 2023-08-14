namespace ConsoleApp3
{
    internal class Program
    {
        public class PhotoBook
        {
            private int NumPages { get; set; }

            public PhotoBook()
            {
                NumPages = 16;
            }
            public PhotoBook(int specifyNumber)
            {
                if (specifyNumber<=0)
                {
                    return;
                }
                NumPages = specifyNumber;
            }
            public int GetNumberPages()
            {
                return NumPages;
            }
        }
        public class BigPhotoBook
        {
            private int NumPages { get; set; }
            public BigPhotoBook()
            {
                NumPages = 64;
            }
            public int GetNumberPages()
            {
                return NumPages;
            }
        }
        public static void Main(string[] args)
        {
            PhotoBook defaultBook = new();
            PhotoBook changedBook= new(20);
            BigPhotoBook bigPhotoBook = new();

            int defaultbook = defaultBook.GetNumberPages();
            int changedbook = changedBook.GetNumberPages();
            int bigPhotobook = bigPhotoBook.GetNumberPages();
            Console.WriteLine("default size of bookphoto is "+defaultbook);
            Console.WriteLine("changed size of bookphoto is " + changedbook);
            Console.WriteLine("default size of Bigbookphoto is " + bigPhotobook);
        }
        
    }
}