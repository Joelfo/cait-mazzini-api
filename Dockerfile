FROM mcr.microsoft.com/dotnet/sdk:6.0-jammy AS build
WORKDIR /source
COPY . .
RUN dotnet restore "CaitMazziniApp.csproj" --disable-parallel
RUN dotnet publish "CaitMazziniApp.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0-jammy
WORKDIR /app
COPY --from=build /app ./

EXPOSE 80

ENTRYPOINT ["dotnet", "CaitMazziniApp.dll"]