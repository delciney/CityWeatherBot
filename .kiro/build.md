# Como Executar o Build

Quando o usuário pedir para executar o build do projeto, usar o seguinte comando:

```bash
"/mnt/c/Program Files/dotnet/dotnet.exe" build src/CityWeatherBot.Api/CityWeatherBot.Api.csproj
```

## Observações

- O .NET do WSL é a versão 5. Sempre usar o `dotnet.exe` do Windows localizado em `/mnt/c/Program Files/dotnet/dotnet.exe`.
- O diretório de trabalho deve ser `/mnt/c/study/CityWeatherBot`.
