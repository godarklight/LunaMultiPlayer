#!/bin/sh
find ../../Lidgren.Network -iname *.cs > generate-cs.txt
sed "/.*Compile Include.*/d" -i Lidgren.Network.csproj
sed "s/^/    <Compile Include=\"/g" -i generate-cs.txt
sed "s/$/\"\/>/g" -i generate-cs.txt
sed "/<ItemGroup>/r generate-cs.txt" -i Lidgren.Network.csproj
rm generate-cs.txt
