using GeradorDeSenhas;

Menu.ShowMenu();
var passwdLength = Convert.ToInt32(Console.ReadLine());

var random = new Random();
var lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
var upperAlphabet = lowerAlphabet.ToUpper();
var numbers = "0123456789";
var specialCharacters = "!@#$%";
var passwd = "";

if (passwdLength < 8)
{
    Console.WriteLine("Senha muito curta! O mínimo é 8 caracteres.");
    Environment.Exit(0);
}

for (var i = 1; i <= (passwdLength - 6); i++)
{
    var indiceLowerAlph = random.Next(lowerAlphabet.Length);
    passwd += lowerAlphabet[indiceLowerAlph];
}

for (int j = 1;  j <= 2; j++)
{
    var indiceSpecialChar = random.Next(specialCharacters.Length);
    passwd += specialCharacters[indiceSpecialChar];
}

for (int k = 1; k <= 2; k++)
{
    var indiceNumber = random.Next(numbers.Length);
    passwd += numbers[indiceNumber];
}

for (int l = 1; l <= 2; l++)
{
    var indiceUpperAlph = random.Next(upperAlphabet.Length);
    passwd += upperAlphabet[indiceUpperAlph];
}

Console.WriteLine($"Sua senha será: {passwd}");