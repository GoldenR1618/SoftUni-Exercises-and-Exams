namespace Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Reflection;

    public class Reflection
    {
        public static void Main(string[] args)
        {
            //Type Class - Primary way to access metadata.
            //Obtain at compile time if you know it’s name:
            Type myType = typeof(SomeClass);
            //Obtain at run time if the name is unknown:
            Type myType2 = Type.GetType("Reflection.SomeClass");    //You need fully qualified class name as string.
            //Fully qualified class name - Type.FullName
            string fullName = myType.FullName;
            //Class name without the package name - Type.Name
            string simpleName = myType.Name;
            //Obtain base class:
            Type baseType = myType.BaseType;
            //Obtain interfaces - only the interfaces specifically declared implemented by a given class are returned:
            Type[] interfaces = myType.GetInterfaces();
            Console.WriteLine(interfaces[0].FullName);

            //New Instance.
            //CreateInstance - creates an instance of a type by invoking the constructor that best matches the specified arguments.
            Type scType = typeof(SomeClass);
            SomeClass scInstance = (SomeClass)Activator.CreateInstance(scType);     //Инстанциране с базовият конструктор.
            SomeClass scInstanceCapacity = (SomeClass)Activator.CreateInstance(scType, "Ilian", 41);    //Инстанциране със кастъм конструктора.

            //Assembly.
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Type[] allTypes = currentAssembly.GetTypes();       //Тук акумилираме информацията за всички класове в асемблито.
            foreach (var type in allTypes)
            {
                Console.WriteLine(type.FullName);
            }

            //Reflect Fields.
            //Obtain public fields:
            FieldInfo field = scType.GetField("id");   //Конкретно публично поле.
            FieldInfo[] publicFields = scType.GetFields();   //Всички публични полета.
            //Obtain all fields:
            FieldInfo[] allFields = scType.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);    //Изброяваме ги с побитово "или".
            //Get field name, type and attributes:
            string fieldName = field.Name;                      //id
            Type fieldType = field.FieldType;                   //String
            FieldAttributes fieldAttribute = field.Attributes;  //public
            //Field Altering:
            field.SetValue(scInstance, "abc");  //Запис на стойност в едно поле.
            string fieldValue = (string)field.GetValue(scInstance); //Четене на сройността от едно поле.

            //Access Modifiers.
            //Each modifier is a flag bit that is either set or cleared.
            //Check access modifier of a member of the class.
            bool isPrivate = field.IsPrivate;       //private
            bool isPublic = field.IsPublic;         //public
            bool isProtected = field.IsFamily;      //protected
            bool isInternal = field.IsAssembly;     //internal

            //Reflect Constructors.
            //Obtain constructors:
            ConstructorInfo[] publicCtors = scType.GetConstructors();   //Всички публични и нон-протектед.
            //Obtain all non static constructors:
            ConstructorInfo[] allNonStaticCtors = scType.GetConstructors
                (BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            //Obtain  a certain constructor:
            ConstructorInfo constructor = scType.GetConstructor(new Type[] { typeof(string), typeof(int) });
            //Get parameters type:
            ParameterInfo[] parameterTypes = constructor.GetParameters();
            //Instantiating objects using constructor:
            SomeClass scInstance2 = (SomeClass)constructor.Invoke(new object[] { "Ilian", 41});

            //Reflect Methods.
            //Obtain public methods:
            MethodInfo[] publicMethods = scType.GetMethods();
            //Obtain all methods:
            MethodInfo[] allMethods = scType.GetMethods(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            //Obtain certain method:
            MethodInfo stringReturnMethod = scType.GetMethod("StringReturn");
            MethodInfo overloadMethod = scType.GetMethod("StringReturn", new Type[] { typeof(string) });
            //Obtain method parameters and return type:
            ParameterInfo[] stringReturnParameters = stringReturnMethod.GetParameters();  //Връща всички параметри.
            Type returnType = stringReturnMethod.ReturnType;   //Връща ретърн типа.
            //Invoke methods:
            stringReturnMethod.Invoke(scInstance2, new object[] { "Hi!" });

            //Пропъртитата ги извличаме чрез reflect methods, защото пропъртитата са всъщност два метода - get и set.
        }
    }

    public class SomeClass : IComparable<SomeClass>
    {
        private string name;
        private int age;
        public string id;

        public SomeClass()
        {
        }

        public SomeClass(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public int CompareTo(SomeClass other)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine($"{this.Name} -> {this.Age}");
        }

        public string StringReturn(string something)
        {
            return $"{something}";
        }
    }
}
