FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ExportTest/ExportTest.csproj", "ExportTest/"]
RUN dotnet restore "ExportTest/ExportTest.csproj"
COPY . .
WORKDIR "/src/ExportTest"
RUN dotnet build "ExportTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExportTest.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExportTest.dll"]
