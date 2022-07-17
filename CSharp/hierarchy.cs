Dog miPerrito = new Dog("Canela", AnimalSex.Female, 40.2f, 12.5f, "All American Dog");
Console.WriteLine(miPerrito.getDescription());
//My dog is an All American Dog, it name is Canela, it's 40.2cm tall and weighs 12.5kg.

public enum AnimalSex
{
    Male,
    Female
}

public class Animal
{
    protected string Name;
    protected AnimalSex Sex;
    protected float Height;
    protected float Weight;

    public Animal(string _name, float _height, float _weight, AnimalSex _sex)
    {
        Name = _name;
        Sex = _sex;
        Height = _height;
        Weight = _weight;
    }

    public string getName()
    {
        return Name;
    }

    public void setName(string _name)
    {
        Name = _name;
    }

    public void setHeight(float _height)
    {
        Height = _height;
    }

    public float getHeight()
    {
        return Height;
    }

    public void setWeight(float _weight)
    {
        Weight = _weight;
    }

    public float getWeight()
    {
        return Weight;
    }
}

public class Dog : Animal
{
    private string Race;

    public Dog(string _name, AnimalSex sex, float _height, float _weight, string _race) : base(_name, _height, _weight, sex)
    {
        Race = _race;
    }

    public void setRace(string _race)
    {
        Race = _race;
    }

    public string getRace()
    {
        return Race;
    }

    public string getDescription()
    {
        return $"My dog is an {Race}, it name is {Name}, it's {Height}cm tall and weighs {Weight}kg.";
    }
};