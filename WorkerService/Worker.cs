using Microsoft.EntityFrameworkCore;
using WorkerService.DataAccess;

namespace DbWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IHostApplicationLifetime _applicationLifetime;
        public Worker(IServiceScopeFactory scopeFactory, IHostApplicationLifetime applicationLifetime)
        {
            _scopeFactory = scopeFactory;
            _applicationLifetime = applicationLifetime;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            bool keepGoing = true;

            while (keepGoing && !stoppingToken.IsCancellationRequested)
            {
                using var scope = _scopeFactory.CreateScope();
                using var db = scope.ServiceProvider.GetRequiredService<LibraryContext>();

                Console.WriteLine("[L]ist");
                Console.WriteLine("[A]dd");
                Console.WriteLine("[Q]uit");

                Console.Write("Enter an option: ");

                var choice = Console.ReadLine()?.ToUpper() ?? "Q";

                switch (choice)
                {
                    case "L":
                        await ListBooks(db);
                        break;
                    case "A":
                        await AddBook(db);
                        break;
                    default:
                        keepGoing = false;
                        _applicationLifetime.StopApplication();
                        break;
                }
            }
        }
        private static async Task AddBook(LibraryContext db)
        {
            Console.Write("Title: ");
            var title = Console.ReadLine() ?? "";

            Console.Write("Author: ");
            var author = Console.ReadLine() ?? "";

            Console.Write("Year: ");
            int.TryParse(Console.ReadLine() ?? "2000", out int year);

            db.Books.Add(new Book
            {
                Title = title,
                Author = author,
                Year = year
            }
            );
            await db.SaveChangesAsync();
        }
        private static async Task ListBooks(LibraryContext db)
        {
            var books = await db.Books.ToArrayAsync();
            if (books.Length == 0)
                Console.WriteLine("There are no books in the database");
            else
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} by {book.Author} ({book.Year})");
                }
            }
        }
    }
}