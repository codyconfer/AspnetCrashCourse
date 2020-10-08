#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["AspnetCrashCourse/AspnetCrashCourse.csproj", "AspnetCrashCourse/"]
RUN dotnet restore "AspnetCrashCourse/AspnetCrashCourse.csproj"
COPY . .
WORKDIR "/src/AspnetCrashCourse"
RUN dotnet build "AspnetCrashCourse.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspnetCrashCourse.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspnetCrashCourse.dll"]