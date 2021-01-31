namespace NCC.Models
{
    public class Book
    {

        public int Isbn{get;set;}
        public string Name {get;set;}
        public string Author {get;set;}
        public double Price {get;set;}
        public bool Dollar {get;set;}

        public Book(int Isbn,string name,string author,double price){
            this.Isbn = Isbn;
            this.Name = name;
            this.Author = author;
            this.Price = price;
            this.Dollar = true;
        }

    }
}