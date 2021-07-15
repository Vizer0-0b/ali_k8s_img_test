FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

COPY . /app/publish/

RUN dotnet restore

RUN dotnet publish -o /out -c Release

EXPOSE 5000
WORKDIR /app/publish/
RUN ln -sf /usr/share/zoneinfo/Asia/Shanghai /etc/localtime
RUN echo 'Asia/Shanghai' >/etc/timezone
ENTRYPOINT ["dotnet", "ali_k8s_img_test.dll"]