#!/bin/sh
find ../../LmpCommon -iname *.cs > generate-cs.txt
sed "/.*Compile Include.*/d" -i LmpCommon.csproj
sed "s/^/    <Compile Include=\"/g" -i generate-cs.txt
sed "s/$/\"\/>/g" -i generate-cs.txt
sed "/<ItemGroup>/r generate-cs.txt" -i LmpCommon.csproj
rm generate-cs.txt
