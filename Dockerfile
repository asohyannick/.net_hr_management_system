FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

COPY global.json .
COPY Directory.Build.props .
COPY Directory.Packages.props .
COPY nuget.config .
COPY hospital_ms.slnx .

COPY src/hospital_ms.ServiceDefaults/hospital_ms.ServiceDefaults.csproj src/hospital_ms.ServiceDefaults/
COPY src/hospital_ms.Infrastructure/hospital_ms.Infrastructure.csproj src/hospital_ms.Infrastructure/
COPY src/hospital_ms.Core/hospital_ms.Core.csproj src/hospital_ms.Core/
COPY src/hospital_ms.UseCases/hospital_ms.UseCases.csproj src/hospital_ms.UseCases/
COPY src/hospital_ms.Web/hospital_ms.Web.csproj src/hospital_ms.Web/

RUN dotnet restore src/hospital_ms.Web/hospital_ms.Web.csproj

COPY src/hospital_ms.ServiceDefaults/ src/hospital_ms.ServiceDefaults/
COPY src/hospital_ms.Infrastructure/ src/hospital_ms.Infrastructure/
COPY src/hospital_ms.Core/ src/hospital_ms.Core/
COPY src/hospital_ms.UseCases/ src/hospital_ms.UseCases/
COPY src/hospital_ms.Web/ src/hospital_ms.Web/

RUN dotnet publish src/hospital_ms.Web/hospital_ms.Web.csproj \
    -c Release \
    -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app

RUN groupadd --system appgroup && useradd --system --gid appgroup appuser
USER appuser

COPY --from=build /app/publish .

EXPOSE 8080
EXPOSE 8081

ENTRYPOINT ["dotnet", "hospital_ms.Web.dll"]