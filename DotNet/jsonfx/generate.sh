#!/bin/sh
find ../../jsonfx/src/JsonFx -iname *.cs > generate-cs.txt
sed "/.*Compile Include.*/d" -i jsonfx.csproj
sed "s/^/    <Compile Include=\"/g" -i generate-cs.txt
sed "s/$/\"\/>/g" -i generate-cs.txt
sed "/<ItemGroup>/r generate-cs.txt" -i jsonfx.csproj
sed "/.*NoEmit*/d" -i jsonfx.csproj
rm generate-cs.txt
