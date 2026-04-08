namespace Project_Day02;

public class Film
{
    public string Name { get; set; }

    public int Year { get; set; }

    public string Place { get; set; }


    public void PrintAllFilmInfo()
    {

        Console.WriteLine(Name);
        Console.WriteLine(Year);
        Console.WriteLine(Place);

    }


    public int PrintAllFilmInfo(int Year)
    {

        Console.WriteLine(Year);
        return Year; // 這裡回傳的是 int，符合宣告


    }
    public string PrintAllFilmInfo(string Actor)
    {

        Console.WriteLine(Actor);
        return Actor; 


    }



}

