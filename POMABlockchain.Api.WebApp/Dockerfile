FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["POMABlockchain.Api.WebApp/POMABlockchain.Api.WebApp.csproj", "POMABlockchain.Api.WebApp/"]
RUN dotnet restore "POMABlockchain.Api.WebApp/POMABlockchain.Api.WebApp.csproj"
COPY . .
WORKDIR "/src/POMABlockchain.Api.WebApp"
RUN dotnet build "POMABlockchain.Api.WebApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "POMABlockchain.Api.WebApp.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "POMABlockchain.Api.WebApp.dll"]