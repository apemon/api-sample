FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY api-sample/api-sample.csproj api-sample/
RUN dotnet restore api-sample/api-sample.csproj
COPY . .
WORKDIR /src/api-sample
RUN dotnet build api-sample.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish api-sample.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "api-sample.dll"]
