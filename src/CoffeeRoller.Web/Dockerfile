FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CoffeeRoller.Web/CoffeeRoller.Web.csproj", "CoffeeRoller.Web/"]
RUN dotnet restore "CoffeeRoller.Web/CoffeeRoller.Web.csproj"
COPY . .
WORKDIR "/src/CoffeeRoller.Web"
RUN dotnet build "CoffeeRoller.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoffeeRoller.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoffeeRoller.Web.dll"]
