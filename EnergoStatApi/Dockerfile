#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["EnergoStatApi/EnergoStat.Api.csproj", "EnergoStatApi/"]
COPY ["Domain/EnergoStatApi.Domain.csproj", "Domain/"]
COPY ["EnergoStatApi.DAL/EnergoStatApi.DAL.csproj", "EnergoStatApi.DAL/"]
RUN dotnet restore "EnergoStatApi/EnergoStat.Api.csproj"
COPY . .
WORKDIR "/src/EnergoStatApi"
RUN dotnet build "EnergoStat.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EnergoStat.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EnergoStat.Api.dll"]