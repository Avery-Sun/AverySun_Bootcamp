using ForPractice_20260407;



var beast = new Animal();
var dog = new Dog("Andy");
var cat = new Cat("Luna");
var sheep=new Sheep("Dolly");

Console.WriteLine(beast.Sound());
Console.WriteLine(dog.Sound());
Console.WriteLine(cat.Sound());
Console.WriteLine(sheep.Sound());
Console.WriteLine();

Animal[] aniamls = { beast, dog, cat, sheep };
foreach (Animal aniaml in aniamls) { 
    Console.WriteLine(aniaml.Sound());
}
Console.WriteLine();
