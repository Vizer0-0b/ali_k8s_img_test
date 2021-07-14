FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

COPY . /app/publish/
EXPOSE 5000
WORKDIR /app/publish/
RUN ln -sf /usr/share/zoneinfo/Asia/Shanghai /etc/localtime
RUN echo 'Asia/Shanghai' >/etc/timezone
ENTRYPOINT ["dotnet", "hellowrold.dll"]