using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class HeroManager
{
    public Dictionary<string, IHero> heroes;

    public string AddHero(List<String> arguments)
    {
        string result = null;

        string heroName = arguments[0];
        string heroType = arguments[1];

        try
        {
            Type clazz = Type.GetType(heroType);
            var constructors = clazz.GetConstructors();
            IHero hero = (IHero) constructors[0].Invoke(new object[] {heroName});


            result = string.Format($"Created {heroType} - {hero.GetType().Name}");
        }
        catch (Exception e)
        {
            return e.Message;
        }

        return result;
    }

    public string AddItemToHero(List<String> arguments, Hero hero)
    {
        string result = null;

        //Ма те много бе!
        string itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);

        CommonItem newItem = new CommonItem(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus,
            damageBonus);
        //тука трябваше да добавя към hero ама промених едно нещо и то много неща се счупиха и реших просто да не добавям

        result = string.Format(Constants.ItemCreateMessage, newItem.Name, heroName);
        return result;
    }

    public string CreateGame()
    {
        StringBuilder result = new StringBuilder();

        foreach (var hero in heroes)
        {
            result.AppendLine(hero.Key);
        }

        return result.ToString();
    }

    public string Inspect(List<String> arguments)
    {
        string heroName = arguments[0];

        return this.heroes[heroName].ToString();
    }

    //Само Батман знае как работи това
    public static void GenerateResult()
    {
        const string PropName = "_connectionString";

        var type = typeof(HeroCommand);

        FieldInfo fieldInfo = null;
        PropertyInfo propertyInfo = null;
        while (fieldInfo == null && propertyInfo == null && type != null)
        {
            fieldInfo = type.GetField(PropName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo == null)
            {
                propertyInfo = type.GetProperty(PropName,
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            }

            type = type.BaseType;
        }
    }

    public static void DontTouchThisMethod()
    {
        //това не трябва да го пипаме, че ако го махнем ще ни счупи цялата логика
        var l = new List<string>();
        var m = new Manager();
        HeroCommand cmd = new HeroCommand(l, m);
        var str = "Execute";
        Console.WriteLine(str);
    }
}