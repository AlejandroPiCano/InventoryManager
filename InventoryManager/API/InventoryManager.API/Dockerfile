#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["API/InventoryManager.API/InventoryManager.API.csproj", "API/InventoryManager.API/"]
COPY ["Application/InventoryManager.Application/InventoryManager.Application.csproj", "Application/InventoryManager.Application/"]
COPY ["Domain/InventoryManager.Domain/InventoryManager.Domain.csproj", "Domain/InventoryManager.Domain/"]
COPY ["Domain/InventoryManager.Domain.Entities/InventoryManager.Domain.Entities/InventoryManager.Domain.Entities.csproj", "Domain/InventoryManager.Domain.Entities/InventoryManager.Domain.Entities/"]
COPY ["Application/InventoryManager.Application.DTOs/InventoryManager.Application.DTOs/InventoryManager.Application.DTOs.csproj", "Application/InventoryManager.Application.DTOs/InventoryManager.Application.DTOs/"]
COPY ["Infrastructure/InventoryManager.Infrastructure/InventoryManager.Infrastructure.csproj", "Infrastructure/InventoryManager.Infrastructure/"]
RUN dotnet restore "API/InventoryManager.API/InventoryManager.API.csproj"
COPY . .
WORKDIR "/src/API/InventoryManager.API"
RUN dotnet build "InventoryManager.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InventoryManager.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InventoryManager.API.dll"]