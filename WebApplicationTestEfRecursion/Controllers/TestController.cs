using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationTestEfRecursion.Dtos;

namespace WebApplicationTestEfRecursion.Controllers;

[ApiController]
[Route("test/")]
public class TestController : ControllerBase
{
    private AlexTestJwtDbContext db;

    public TestController(AlexTestJwtDbContext db)
    {
        this.db = db;
    }

    [HttpGet("articles")]
    public List<ArticleFlatResponseDto> GetArticles()
    {
        List<ArticleFlatResponseDto> articles = db.Articles.Select(
            article => new ArticleFlatResponseDto()
            {
                Id = article.Id,
                Title = article.Title,
                Content = article.Content,
                AuthorId = article.AuthorId,
                AuthorName = article.Author.Name,
                AuthorAge = article.Author.Age
            }).ToList();

        return articles;
    }

    [HttpGet("authors")]
    public List<AuthorSimpleResponseDto> GetAuthors()
    {
        List<AuthorSimpleResponseDto> authors = db.Authors.Select(
            author => new AuthorSimpleResponseDto()
            {
                Id = author.Id,
                Name = author.Name,
                Age = author.Age,
                Articles = author.Articles.Select(
                    article => new ArticleSimpleResponseDto()
                    {
                        Id = article.Id,
                        Title = article.Title,
                        Content = article.Content
                    }
                ).ToList()
            }).ToList();

        return authors;
    }
}