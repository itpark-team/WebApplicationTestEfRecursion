namespace WebApplicationTestEfRecursion.Dtos;

public class AuthorSimpleResponseDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public List<ArticleSimpleResponseDto> Articles { get; set; }
}