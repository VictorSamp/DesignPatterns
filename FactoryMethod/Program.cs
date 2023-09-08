using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;

CardFactory? factory = null;
Console.WriteLine("Digite o tipo de cartão que gostaria de obter:");
string? console = Console.ReadLine();

if (string.IsNullOrEmpty(console))
{
    Console.WriteLine("O tipo do cartão não pode ser vazio.");
    return;
}

switch (console.ToLower())
{
    case "platinum":
        factory = new PlatinumFactory(100000, 1000);
        break;

    case "black":
        factory = new BlackFactory(50000, 500);
        break;

    case "gold":
        factory = new GoldFactory(10000, 0);
        break;

    default:
        Console.WriteLine("O tipo do cartão digitado é inválido.");
        break;
}

CreditCard? card = factory.GetCreditCard();
Console.WriteLine("\nOs detalhes do seu cartão estão abaixo:\n");
Console.WriteLine($"Tipo: {card.Type}\nLimite de crédito: {card.CreditLimit}\nAnuidade: {card.AnnualBilling}");
Console.ReadKey();