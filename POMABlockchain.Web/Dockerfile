FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["POMABlockchain.Web/POMABlockchain.Web.csproj", "POMABlockchain.Web/"]
RUN dotnet restore "POMABlockchain.Web/POMABlockchain.Web.csproj"
COPY . .
WORKDIR "/src/POMABlockchain.Web"
RUN dotnet build "POMABlockchain.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "POMABlockchain.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "POMABlockchain.Web.dll"]