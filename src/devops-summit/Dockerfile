FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
RUN apt-get update -yq \
    && apt-get install curl gnupg -yq \
    && curl -sL https://deb.nodesource.com/setup_10.x | bash \
    && apt-get install nodejs -yq
WORKDIR /src/devops-summit
COPY ["devops-summit.csproj", "/src/devops-summit/"]
RUN dotnet restore "devops-summit.csproj"
COPY . .
RUN dotnet build "devops-summit.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "devops-summit.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "devops-summit.dll"]
