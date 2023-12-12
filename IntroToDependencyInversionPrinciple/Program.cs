// See https://aka.ms/new-console-template for more information

using ChatServerUltraBultra;
using IntroToDependencyInversionPrinciple.Chat;
using IntroToDependencyInversionPrinciple.OneOfEach;

/* Pause til 11:07
 *
 * 1: Dependency Inversion Principle
 * 2: Skrive om kode som bryter Single Responsibility Principle
 *    ved å innføre interface og snu avhengighetene
 *    = Dependency Injection, en teknikk for å oppnå nevnte prinsipp
 * 3: Rett på Dependency Injection, skriv kjernelogikken og glem detaljene!
 *    Service-klasser
 */

//ChatDemo.Run();


//var examples = OneOfEachService.GetIt();
var chuckNorrisApiDataFetcher = new ChuckNorrisApiDataFetcher();
var directoryDataFetcher = new DirectoryDataFetcher("C:\\");
var service = new OneOfEachService(directoryDataFetcher);
//var service = new OneOfEachService(chuckNorrisApiDataFetcher);
var examples = service.GetIt();
foreach (var example in examples)
{
    Console.WriteLine(example.Description);
}