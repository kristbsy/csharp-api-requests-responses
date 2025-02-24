namespace exercise.wwwapi.ViewModel;

public record BookViewModel
{
    public string title { get; set; }
    public int numPages { get; set; }
    public string author { get; set; }
    public string genre { get; set; }
}
