using EagerLazyLoading;

var context = new AppDbContext();
var repository = new ProductRepository(context);
var service = new ProductService(repository);

Console.WriteLine("Choose Loading Type: (1) Lazy (2) Eager");
var choice = Console.ReadLine();

bool useEagerLoading = choice == "2";
service.DisplayProducts(useEagerLoading);
