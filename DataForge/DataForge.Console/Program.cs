using DataForge;
using DataForge.Console;

Console.WriteLine("Random firstname : " + Forge.Person.RandomFirstname());
Console.WriteLine("Random male firstname : " + Forge.Person.RandomFirstname(Genders.Male));
Console.WriteLine("Random female firstname : " + Forge.Person.RandomFirstname("FEMALE"));

Console.WriteLine("Random lastname : " + Forge.Person.RandomLastname());

Console.WriteLine("Random street : " + Forge.Address.RandomStreet());
Console.WriteLine("Random street : " + Forge.Address.RandomStreet(true));

Console.WriteLine("Random Email Addresss without input : " + Forge.Communication.RandomEmailAddress());
Console.WriteLine("Random Email Addresss with input : " + Forge.Communication.RandomEmailAddress("Quinten", "De Clerck"));
Console.WriteLine("Random Email Addresss with single input : " + Forge.Communication.RandomEmailAddress("Quinten"));

Console.WriteLine("Random text : " + "".RandomText());
Console.WriteLine("Random text : " + String.Empty.RandomText(100));


Console.WriteLine("Random converion with pattern : " + "##-##".RandomStringPatternGenerator(ConversionTypes.Numerical));
Console.WriteLine("Random converion with pattern : " + "##-##".RandomStringPatternGenerator(ConversionTypes.Alphabetical));
Console.WriteLine("Random converion with pattern : " + "##-#######".RandomStringPatternGenerator(ConversionTypes.Both));

Console.WriteLine("Random Phone number : " + "+32 ## ## ### ###".RandomStringPatternGenerator(ConversionTypes.Numerical));

Console.WriteLine("Random string based on pattern : " + ForgeUtils.RandomStringPattern("###-#-###", ConversionTypes.Numerical));


ConversionTypes randomEnumValue = ConversionTypes.Numerical.GetRandomEnumValue();
ConversionTypes type = ForgeUtils.GetRandomEnumValue<ConversionTypes>();
Console.WriteLine("Random enum value : " + type);

Person person = new Person().Forge().RuleFor(p => p.FirstName = Forge.Person.RandomFirstname("MALE")).Build();
Console.WriteLine("Person firstname : " + person.FirstName);

Person person1 = new Person().Forge().RuleFor(p => {
    p.FirstName = Forge.Person.RandomFirstname();
    p.LastName = Forge.Person.RandomLastname();
}).Build();


Console.WriteLine($"person 1 : {person1.FirstName} {person1.LastName}");

Person person2 = new Person()
{
    FirstName = Forge.Person.RandomFirstname(),
    LastName = Forge.Person.RandomLastname(),
};

Console.WriteLine($"person 2: {person2.FirstName} {person2.LastName}");

Console.WriteLine("random phone number : " + Forge.Communication.RandomPhoneNumber());
Console.WriteLine("random phone number : " + Forge.Communication.RandomPhoneNumber(true));
Console.WriteLine("random phone number : " + Forge.Communication.RandomPhoneNumber(true, "123", "45"));