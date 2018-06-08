FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app

ENV ASPNETCORE_URLS http://+:50001
EXPOSE 50001

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY *.sln ./
COPY Translator.WebApi/Translator.WebApi.csproj Translator.WebApi/
RUN dotnet restore
COPY . .
WORKDIR /src/Translator.WebApi
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Translator.WebApi.dll"]
