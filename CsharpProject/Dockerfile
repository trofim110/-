FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CsharpProject/CsharpProject.csproj", "CsharpProject/"]
RUN dotnet restore "CsharpProject/CsharpProject.csproj"
COPY . .
WORKDIR "/src/CsharpProject"
RUN dotnet build "CsharpProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CsharpProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CsharpProject.dll"]
