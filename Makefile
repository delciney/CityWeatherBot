DOTNET = "/mnt/c/Program Files/dotnet/dotnet.exe"
SLN = api/CityWeatherBot.slnx

build:
	$(DOTNET) build $(SLN)

test:
	$(DOTNET) test $(SLN)

lint:
	$(DOTNET) format $(SLN) --verify-no-changes

lint-fix:
	$(DOTNET) format $(SLN)

restore:
	$(DOTNET) restore $(SLN)

clean:
	$(DOTNET) clean $(SLN)
