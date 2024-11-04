def SearchTokens(Token : str):
    return(Token + " this i a def func")

cash = {
    "Token1":SearchTokens("Token1"),
    "Token2":SearchTokens("Token2")
}

print(cash[input()])