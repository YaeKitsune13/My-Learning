static string SearchData(string Token){
    return Token + " This is a Date";
}

var cash = new Dictionary<string,string>{
    {"Token1",SearchData("Token1")},
    {"Token2",SearchData("Token2")}
};

Console.Write("Введите токен (Token1,Token2) : ");string Token = Console.ReadLine();
if (cash.ContainsKey(Token)){
    Console.Write(cash[Token]);
}else{
    Console.Write("Был введён ошибочный токен");
}
