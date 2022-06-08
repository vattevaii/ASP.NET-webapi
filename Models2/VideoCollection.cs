namespace asp.net_folder.Models2;

public class VideoCollection
{
   public int Id { get; set; }
   public string? MovieTitle { get; set; }
   public int YearReleased { get; set; }
   public float Rating { get; set; }
   public string? Subject { get; set; }
   public int Length { get; set; }
   public string? Note { get; set; }
   public int FriendId { get; set; }
}