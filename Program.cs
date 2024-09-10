using LINQ;

#region DOGS

List<Dog> dogs = new List<Dog>
{
    new() //01
    {
        Name = "Kira",
        Birthday = DateTime.Parse("2019-05-10"),
        Sex = false,
        Breed = "Tacskó",
        Weight = 5.5f,
    },
    new() //02
    {
        Name = "Rex",
        Birthday = DateTime.Parse("2014-04-20"),
        Sex = true,
        Breed = "Németjuhász",
        Weight = 35.2f,
    },
    new() //03
    {
        Name = "Igor",
        Birthday = DateTime.Parse("2017-11-20"),
        Sex = false,
        Breed = "Kaukázusi farkasölő",
        Weight = 95.0f,
    },
    new() //04
    {
        Name = "Thomas Edison",
        Birthday = DateTime.Parse("2001-02-07"),
        Sex = true,
        Breed = "Németjuhász",
        Weight = 40.3f,
    },
    new() //05
    {
        Name = "Princess",
        Birthday = DateTime.Parse("2022-12-24"),
        Sex = false,
        Breed = "Palotapincsi",
        Weight = 4.2f,
    }
};
#endregion

#region Megszámlálás
// 3 évnél öregebb kutyák száma
int haromEvnelIdosebb = 0;
foreach (var dog in dogs)
{
    if (dog.Age >= 3) haromEvnelIdosebb++;
}
Console.WriteLine(haromEvnelIdosebb);

// szukák száma
int szuka = 0;
foreach (var dog in dogs)
{
    if (!dog.Sex) szuka++;
}
Console.WriteLine(szuka);

//LINQ-val
Console.WriteLine("LINQ:");

int linqHaromEvnelIdosebb = dogs.Count(d => d.Age >= 3);
Console.WriteLine(linqHaromEvnelIdosebb);

int linqSzuka = dogs.Count(d => !d.Sex);
Console.WriteLine(linqSzuka);
#endregion