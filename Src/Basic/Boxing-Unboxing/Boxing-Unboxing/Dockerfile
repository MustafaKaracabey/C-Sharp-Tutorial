FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Boxing-Unboxing/Boxing-Unboxing.csproj", "Boxing-Unboxing/"]
RUN dotnet restore "Boxing-Unboxing/Boxing-Unboxing.csproj"
COPY . .
WORKDIR "/src/Boxing-Unboxing"
RUN dotnet build "Boxing-Unboxing.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Boxing-Unboxing.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Boxing-Unboxing.dll"]
