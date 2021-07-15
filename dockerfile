FROM microsoft/dotnet:latest
WORKDIR /app
COPY /. /app
RUN dotnet restore
RUN dotnet publish -o /out -c Release
EXPOSE 5000
ENTRYPOINT ["dotnet", "/out/ali_k8s_img_test.dll"]