using BasicSystemDesign.DAL.Entities;
using BasicSystemDesign.Bll.CollectionWrappers;

namespace BasicSystemDesign;

class Program
{
    static void Main()
    {
        var plain = new Plain(1, "AN-225 Mriya", 1500);
        var bird = new Bird(2, "Twitty", 200);
        var crow = new Crow(3, "Itachi", 180);
        var dog = new Dog(4, "Hatiko", 350);
        var cat = new Cat(5, "Thomas", 220);

        var entities = new EntitiesWrapper();
        entities.AddEntity(plain);
        entities.AddEntity(bird);
        entities.AddEntity(crow);
        entities.AddEntity(dog);
        entities.AddEntity(cat);
        
        entities.ShowAll();
    }
}