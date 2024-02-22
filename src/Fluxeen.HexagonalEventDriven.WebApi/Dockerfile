#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Fluxeen.HexagonalEventDriven.WebApi/Fluxeen.HexagonalEventDriven.WebApi.csproj", "Fluxeen.HexagonalEventDriven.WebApi/"]
RUN dotnet restore "Fluxeen.HexagonalEventDriven.WebApi/Fluxeen.HexagonalEventDriven.WebApi.csproj"
COPY . .
WORKDIR "/src/Fluxeen.HexagonalEventDriven.WebApi"
RUN dotnet build "Fluxeen.HexagonalEventDriven.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fluxeen.HexagonalEventDriven.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fluxeen.HexagonalEventDriven.WebApi.dll"]