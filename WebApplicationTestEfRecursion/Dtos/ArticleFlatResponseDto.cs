namespace WebApplicationTestEfRecursion.Dtos;

public class ArticleFlatResponseDto
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public int AuthorId { get; set; }

    public string AuthorName { get; set; }

    public int AuthorAge { get; set; }
}