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
        Sex = true,
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
Console.WriteLine("----------------------------");
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

int eKutya = dogs.Count(d => d.Sex && d.Name.ToLower().Contains('e'));
Console.WriteLine(eKutya);

#endregion
Console.WriteLine("----------------------------");
#region Összegzés
int kutyakOsszEletkor = 0;
foreach (var dog in dogs)
{
    kutyakOsszEletkor += dog.Age;
}
Console.WriteLine(kutyakOsszEletkor);

Console.WriteLine("LINQ");
int linqKutyaOsszKor = dogs.Sum(d => d.Age);
Console.WriteLine(linqKutyaOsszKor);
#endregion
Console.WriteLine("----------------------------");
#region Átlag

float atlagKutyaEletkor = kutyakOsszEletkor / (float)dogs.Count();
Console.WriteLine(atlagKutyaEletkor);

double linqAtlagKutyaEletkor = dogs.Average(d => d.Age);
Console.WriteLine("LINQ");
Console.WriteLine(linqAtlagKutyaEletkor);
#endregion
Console.WriteLine("----------------------------");
#region Szélsőérték
int lnski = 0;
for (int i = 0; i < dogs.Count; i++)
{
    if (dogs[i].Weight > dogs[lnski].Weight)
    {
        lnski = i;
    }
}
Console.WriteLine(dogs[lnski].Weight);

float linqLegnagyobbKutya = dogs.Max(d => d.Weight);
Console.WriteLine(linqLegnagyobbKutya);

Dog linqLegnagyobbKutyaMaxBy = dogs.MaxBy(d => d.Weight);
Console.WriteLine(linqLegnagyobbKutyaMaxBy.Name);

float linqLegkissebbKutya = dogs.Min(d => d.Weight);
Console.WriteLine(linqLegkissebbKutya);

Dog linqLegkissebbKutyaMaxBy = dogs.MinBy(d => d.Weight);
Console.WriteLine(linqLegkissebbKutyaMaxBy.Name);

var linqFirst = dogs.First(d => d.Breed == "Németjuhász");
Console.WriteLine($"Első németjuhász: {linqFirst}");

var linqLast = dogs.Last(d=> d.Breed == "Németjuhász");
Console.WriteLine($"Utolsó németjuhász: {linqLast}");

//var linqSingle = dogs.Single(d => d.Breed == "Németjuhász");
//Console.WriteLine($"Egy németjuhász: {linqSingle}");

var linqFIrstordefaultdogs = dogs.FirstOrDefault(d => d.Breed == "Németjuhász");
Console.WriteLine($"Első németjuhász: {linqFIrstordefaultdogs}");

int[] nums = { 11, 26, 3, 132, 26, 44, 30, 1862, 50 };
var res = nums.First(x => x % 2 == 0);
Console.WriteLine($"Result: {res}");


var linqLastordefaultdogs = dogs.LastOrDefault(d => d.Breed == "Unicorn");
Console.WriteLine($"Találat: {linqLastordefaultdogs is null}");
//dogs.Single();
//dogs.SingleOrDefault();

dogs.Any();

//dogs.Find();
//dogs.FindAll();
//dogs.Contains();

#endregion
Console.WriteLine("----------------------------");