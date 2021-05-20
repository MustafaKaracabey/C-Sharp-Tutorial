FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Polymoprhism-1-Upcasting-Downcasting/Polymoprhism-1-Upcasting-Downcasting.csproj", "Polymoprhism-1-Upcasting-Downcasting/"]
RUN dotnet restore "Polymoprhism-1-Upcasting-Downcasting/Polymoprhism-1-Upcasting-Downcasting.csproj"
COPY . .
WORKDIR "/src/Polymoprhism-1-Upcasting-Downcasting"
RUN dotnet build "Polymoprhism-1-Upcasting-Downcasting.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Polymoprhism-1-Upcasting-Downcasting.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Polymoprhism-1-Upcasting-Downcasting.dll"]
