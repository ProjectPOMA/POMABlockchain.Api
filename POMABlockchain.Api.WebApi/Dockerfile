FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 50422
EXPOSE 44308


FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["POMABlockchain.Api.WebApi/POMABlockchain.Api.WebApi.csproj", "POMABlockchain.Api.WebApi/"]
RUN dotnet restore "POMABlockchain.Api.WebApi/POMABlockchain.Api.WebApi.csproj"
COPY . .
WORKDIR "/src/POMABlockchain.Api.WebApi"
RUN dotnet build "POMABlockchain.Api.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "POMABlockchain.Api.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "POMABlockchain.Api.WebApi.dll"]