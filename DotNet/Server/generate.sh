#!/bin/sh
find ../../Server -iname "*.cs" > generate-cs.txt
sed "s/^/    <Compile Include=\"/g" -i generate-cs.txt
sed "s/$/\"\/>/g" -i generate-cs.txt
sed "/.*Compile Include.*/d" -i Server.csproj
sed "/<ItemGroup>/r generate-cs.txt" -i Server.csproj
#sed "/.*Resources.Designer.cs.*/d" -i Server.csproj
sed "/.*GroupSystemSender.cs*/d" -i Server.csproj
sed "/.*bin*/d" -i Server.csproj
sed "/.*obj*/d" -i Server.csproj
cp ../../Server/Properties/Resources.resx Properties/Resources.resx
#cp ../../Server/Properties/Resources.Designer.cs Properties/Resources.Designer.cs
sed 's|<value>..\\Resources|<value>..\\..\\..\\Server\\Resources|g' -i Properties/Resources.resx
rm generate-cs.txt
