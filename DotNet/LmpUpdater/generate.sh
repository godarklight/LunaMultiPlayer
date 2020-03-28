#!/bin/sh
find ../../LmpUpdater -iname *.cs > generate-cs.txt
sed "/.*Compile Include.*/d" -i LmpUpdater.csproj
sed "s/^/    <Compile Include=\"/g" -i generate-cs.txt
sed "s/$/\"\/>/g" -i generate-cs.txt
sed "/<ItemGroup>/r generate-cs.txt" -i LmpUpdater.csproj
rm generate-cs.txt
