FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 50422
EXPOSE 44308

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["POMABlockchain.Api/POMABlockchain.WebApi.csproj", "POMABlockchain.WebApi/"]
RUN dotnet restore "POMABlockchain.Api/POMABlockchain.WebApi.csproj"
COPY . .
WORKDIR "/src/POMABlockchain.WebApi"
RUN dotnet build "POMABlockchain.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "POMABlockchain.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "POMABlockchain.WebApi.dll"]