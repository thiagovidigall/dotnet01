#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/services/DBlue.Clientes.API/DBlue.Clientes.API.csproj", "src/services/DBlue.Clientes.API/"]
RUN dotnet restore "src/services/DBlue.Clientes.API/DBlue.Clientes.API.csproj"
COPY . .
WORKDIR "/src/src/services/DBlue.Clientes.API"
RUN dotnet build "DBlue.Clientes.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DBlue.Clientes.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DBlue.Clientes.API.dll"]