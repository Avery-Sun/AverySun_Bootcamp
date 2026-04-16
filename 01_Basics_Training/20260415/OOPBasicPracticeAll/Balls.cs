namespace OOPBasicPracticeAll;

public abstract class Balls
{
    public string Name;


    public Balls() { }


    public abstract string GetColor();

    public class ColorScanner
    {

        public void Scan(Balls ball)
        {
            Console.WriteLine($"抽出：{ball.GetColor()}");
        }
    }
}
