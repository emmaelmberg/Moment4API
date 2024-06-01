using System.ComponentModel.DataAnnotations;
namespace Moment4API.Models;

public class Song {
    public int SongId { get; set; }
    
    [Required]
    public string? Artist { get; set; }

    public string? Title { get; set; }

    public int? Length { get; set; }

    public string? Category { get; set; }
}