FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY Release App/
WORKDIR /App


COPY assets/images/*.jpg /App/assets/images/
COPY scriptie.db /App/


ENTRYPOINT [ "dotnet", "scriptie.dll" ]