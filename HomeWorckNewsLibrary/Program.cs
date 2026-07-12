using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorckNewsLibrary
{
    public class Program
    {
        public static void Main()
        {
            Author ivan = new Author("Иван Петров");
            Author anna = new Author("Анна Сидорова");

            Article article1 = ivan.WriteArticle("Новые технологии", "Текст о технологиях...");
            Article article2 = anna.WriteArticle("Погода на неделю", "Будет солнечно...");

            NewsPortal portal = new NewsPortal("Портал статей");

            Console.WriteLine("=== До публикации ===");
            Console.WriteLine($"Статья 1: \"{article1.GetTitle()}\" | Автор: {article1.GetAuthor().GetName()} | Опубликована: {article1.GetIsPublished()}");
            Console.WriteLine($"Статья 2: \"{article2.GetTitle()}\" | Автор: {article2.GetAuthor().GetName()} | Опубликована: {article2.GetIsPublished()}");
            Console.WriteLine($"Всего статей на портале: {portal.GetCountArticle()}");
            Console.WriteLine();

            portal.PublishArticle(article1);
            portal.PublishArticle(article2);
            Console.WriteLine();

            Console.WriteLine("=== После публикации ===");
            Console.WriteLine($"Статья 1 опубликована: {article1.GetIsPublished()}");
            Console.WriteLine($"Статья 2 опубликована: {article2.GetIsPublished()}");
            Console.WriteLine($"Всего статей на портале: {portal.GetCountArticle()}");
            Console.WriteLine();

            Console.WriteLine("--- Опубликованные статьи ---");
            foreach (Article article in portal.GetCopyAllArticles())
            {
                Console.WriteLine($"- \"{article.GetTitle()}\" (автор: {article.GetAuthor().GetName()})");
            }
        }
    }
}
