using System;

namespace GoodHands.Domain.Model.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public GiverProfile GiverProfile { get; set; }

    }
}
