FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY Giftcard/Giftcard.csproj Giftcard/
RUN dotnet restore Giftcard/Giftcard.csproj
COPY . .
WORKDIR /src/Giftcard
RUN dotnet build Giftcard.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Giftcard.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Giftcard.dll"]
