using SQLite;

namespace BasicWeatherApp.Models
{
    public class FavoriteLocation
    {
    
        public string Title { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

		public override string ToString()
		{
            return Title;
		}
	}
}
