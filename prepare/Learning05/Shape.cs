public class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return 2;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public Shape(string color)
    {
        _color = color;
    }
}