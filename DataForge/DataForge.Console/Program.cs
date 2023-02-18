using DataForge;

Console.WriteLine("Random firstname : " + Forger.RandomFirstname());
Console.WriteLine("Random male firstname : " + Forger.RandomFirstname(DataForgeGenders.Male));
Console.WriteLine("Random female firstname : " + Forger.RandomFirstname(DataForgeGenders.Female));

Console.WriteLine("Random lastname : " + Forger.RandomLastname());

Console.WriteLine("Random Email Addresss without input : " + Forger.RandomEmailAddress());
Console.WriteLine("Random Email Addresss with input : " + Forger.RandomEmailAddress("Quinten", "De Clerck"));
