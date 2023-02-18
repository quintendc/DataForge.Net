using DataForge;

Console.WriteLine("Random firstname : " + Forger.RandomFirstname());
Console.WriteLine("Random male firstname : " + Forger.RandomFirstname(DataForgeGenders.Male));
Console.WriteLine("Random female firstname : " + Forger.RandomFirstname(DataForgeGenders.Female));

Console.WriteLine("Random lastname : " + Forger.RandomLastname());

Console.WriteLine("Random street : " + Forger.RandomStreet());
Console.WriteLine("Random street : " + Forger.RandomStreet(true));

Console.WriteLine("Random Email Addresss without input : " + Forger.RandomEmailAddress());
Console.WriteLine("Random Email Addresss with input : " + Forger.RandomEmailAddress("Quinten", "De Clerck"));
Console.WriteLine("Random Email Addresss with single input : " + Forger.RandomEmailAddress("Quinten"));

Console.WriteLine("Random text : " + "".RandomText());
Console.WriteLine("Random text : " + String.Empty.RandomText(100));


Console.WriteLine("Random converion with pattern : " + "##-##".StringPatternGenerator(ConversionTypes.Numerical));
Console.WriteLine("Random converion with pattern : " + "##-##".StringPatternGenerator(ConversionTypes.Alphabetical));
Console.WriteLine("Random converion with pattern : " + "##-#######".StringPatternGenerator(ConversionTypes.Both));

Console.WriteLine("Random Phone number : " + "+32 ## ## ### ###".StringPatternGenerator(ConversionTypes.Numerical));

Console.WriteLine("Random string based on pattern : " + Forger.RandomStringPattern("###-#-###", ConversionTypes.Numerical));


ConversionTypes randomEnumValue = ConversionTypes.Numerical.GetRandomEnumValue();
ConversionTypes type = ForgerUtils.GetRandomEnumValue<ConversionTypes>();
Console.WriteLine("Random enum value : " + type);