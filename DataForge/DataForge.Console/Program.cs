using DataForge;
using DataForge.Console;
using DataForge.Extensions;

Console.WriteLine("Random firstname : " + Forge.Person.RandomFirstname());
Console.WriteLine("Random male firstname : " + Forge.Person.RandomFirstname(Genders.Male));
Console.WriteLine("Random female firstname : " + Forge.Person.RandomFirstname("FEMALE"));

Console.WriteLine("Random lastname : " + Forge.Person.RandomLastname());

Console.WriteLine("Random Gender : " + Forge.Person.RandomGender());

Console.WriteLine("Random street : " + Forge.Address.RandomStreet());
Console.WriteLine("Random street : " + Forge.Address.RandomStreet(true));

Console.WriteLine("Random Email Addresss without input : " + Forge.Communication.RandomEmailAddress());
Console.WriteLine("Random Email Addresss with input : " + Forge.Communication.RandomEmailAddress("Quinten", "De Clerck"));
Console.WriteLine("Random Email Addresss with single input : " + Forge.Communication.RandomEmailAddress("Quinten"));

Console.WriteLine("Random text : " + "".GenerateRandomText());
Console.WriteLine("Random text : " + String.Empty.GenerateRandomText(100));

Console.WriteLine("Random Phone number : " + Forge.Communication.RandomPhoneNumber());
Console.WriteLine("Random Phone number : " + Forge.Communication.RandomPhoneNumber("+334 ## ## ## ##"));

Console.WriteLine("Random converion with pattern : " + "##-##".RandomStringPatternGenerator(ConversionTypes.Numerical));
Console.WriteLine("Random converion with pattern : " + "##-##".RandomStringPatternGenerator(ConversionTypes.Alphabetical));
Console.WriteLine("Random converion with pattern : " + "##-#######".RandomStringPatternGenerator(ConversionTypes.Both));

Console.WriteLine("Random Phone number : " + "+32 ## ## ### ###".RandomStringPatternGenerator(ConversionTypes.Numerical));

Console.WriteLine("Random string based on pattern : " + Forge.Utils.RandomStringPattern("###-#-###", ConversionTypes.Numerical));


ConversionTypes randomEnumValue = ConversionTypes.Numerical.GetRandomEnumValue();
ConversionTypes type = Forge.Utils.GetRandomEnumValue<ConversionTypes>();
Console.WriteLine("Random enum value : " + type);

Person person1 = new Person()
{
    FirstName = Forge.Person.RandomFirstname(),
    LastName = Forge.Person.RandomLastname(),
};

Console.WriteLine($"person 2: {person1.FirstName} {person1.LastName}");

Console.WriteLine("random phone number : " + Forge.Communication.RandomPhoneNumber());
Console.WriteLine("random phone number : " + Forge.Communication.RandomPhoneNumber(true));
Console.WriteLine("random phone number : " + Forge.Communication.RandomPhoneNumber(true, "123", "45"));


Console.WriteLine("Random city : " + Forge.Address.RandomCity());

DateTime dt = Forge.DateTime.GenerateRandomDateTimeBetweenYears(1000, 2000);
Console.WriteLine("Random Birthday between the years 1000 & 2000 : " + dt.ToString("dd/MMM/yyyy"));

DateTime dt2 = Forge.DateTime.GenerateRandomDateTimeBetweenAges(10, 27);
Console.WriteLine("Random birthday for between the ages 10 & 27 : " + dt2.ToString("dd/MMM/yyyy"));

Console.WriteLine(new DateTime().GenerateRandomDateTimeBetweenYears(1000, 2000));


List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
int randomElement = numbers.RandomElement();
Console.WriteLine("random collection element : " + randomElement);

Console.WriteLine("random text: " + "".GenerateRandomText(10));

Console.WriteLine("Random text : " + Forge.Text.GenerateRandomText(10));

Console.WriteLine("Random enum value : " + Forge.Utils.GetRandomEnumValue<Genders>());


Console.WriteLine(" --------------- list -----------------");

List<Person> persons = Forge.CreateInstances<Person>(10, p =>
{
    p.FirstName = Forge.Person.RandomFirstname();
    p.LastName = Forge.Person.RandomLastname();
});

Person newPerson = Forge.CreateInstance<Person>(p =>
{
    p.FirstName = Forge.Person.RandomFirstname();
    p.LastName = Forge.Person.RandomLastname();
});

foreach (var person in persons)
{
    Console.WriteLine($"firstname: {person.FirstName}, lastname: {person.LastName}");
}