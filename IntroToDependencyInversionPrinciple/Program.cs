// See https://aka.ms/new-console-template for more information

using ChatServerUltraBultra;
using IntroToDependencyInversionPrinciple.Chat;
using IntroToDependencyInversionPrinciple.OneOfEach;

/*
 * Pause til 10:37
 *
 * 1: Dependency Inversion Principle
 * 2: Skrive om kode som bryter Single Responsibility Principle
 *    ved å innføre interface og snu avhengighetene
 *    = Dependency Injection, en teknikk for å oppnå nevnte prinsipp
 * 3: Rett på Dependency Injection, skriv kjernelogikken og glem detaljene!
 *    Service-klasser
 */

var server = new ChatServer();

var client1 = new ChatClient("Per", server);
var client2 = new ChatClient("Pål", server);
var client3 = new ChatClient("Espen", server);

client1.Say("Hello");
// Pål og Espen får beskjed "Per sier Hello"

client2.Say("Hello");
// Per og Espen får beskjed "Pål sier Hello"

client3.Say("Hello");
// Per og Pål får beskjed "Espen sier Hello"

//var examples = OneOfEachService.GetIt();
//foreach (var example in examples)
//{
//    Console.WriteLine(example.Description);
//}