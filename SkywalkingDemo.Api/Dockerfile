#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
RUN ln -sf /usr/share/zoneinfo/Asia/Shanghai /etc/localtime && echo 'Asia/Shanghai' >/etc/timezone

WORKDIR /app

COPY ./publish/ .

EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "SkywalkingDemo.Api.dll"]