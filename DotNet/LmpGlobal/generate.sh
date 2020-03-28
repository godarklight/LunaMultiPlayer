#!/bin/sh
find ../../LmpGlobal -iname *.cs > generate-cs.txt
sed "/.*Compile Include.*/d" -i LmpGlobal.csproj
sed "s/^/    <Compile Include=\"/g" -i generate-cs.txt
sed "s/$/\"\/>/g" -i generate-cs.txt
sed "/<ItemGroup>/r generate-cs.txt" -i LmpGlobal.csproj
rm generate-cs.txt
