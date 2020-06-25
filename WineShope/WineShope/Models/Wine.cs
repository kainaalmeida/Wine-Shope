namespace WineShope.Models
{
    public class Wine
    {
        public Wine(int id, string name, string model, string price, string rating, string views, string img)
        {
            Id = id;
            Name = name;
            Model = model;
            Price = price;
            Rating = rating;
            Views = views;
            Img = img;
        }

        public int Id { get; }
        public string Name { get; }
        public string Model { get; }
        public string Price { get; }
        public string Rating { get; }
        public string Views { get; }
        public string Img { get; }
    }
}
