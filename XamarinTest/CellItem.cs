using System;
namespace XamarinTest
{
    public class CellItem
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Id { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
        public Double IconSize { get; set; }
        public DateTime CreatedAt { get; set; }

        public CellItem()
        {
        }
    }
}
