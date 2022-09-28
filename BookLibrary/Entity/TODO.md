
add Indexer [] for retrieving Attributes by Name

Multi Field Key

extension to aid loading Model classes. 

EntityRepository implements IEntityRepository
    Interface & Implementation takes DbContext in constructor
    Interface defines lookup calls, Class implements. 
    services.AddTransient<IEntityRepository, EntityRepository>(); 

Function implements IFunction
    Interface constructor takes no params
    Generates IEnumerable<EntityClass> function { get; }
    Implementation takes repository as constructor
    services.AddTransient<IFunction, Function>();

_repository.All.GroupBy(r => r.Title).Select(g => new BookReview
    { 
        Title = g.Key,
        Rating = Math.Round(g.Average(r = r.Rating), 2)
    }
)

*Entity classes belong in the DataLayer
*Models belong in the Interface / Service layers
*Use extensions to populate Models on demand only with needed data.