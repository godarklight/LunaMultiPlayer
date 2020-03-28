#!/bin/sh
find ../../uhttpsharp -iname *.cs > generate-cs.txt
sed "/.*Compile Include.*/d" -i uhttpsharp.csproj
sed "s/^/    <Compile Include=\"/g" -i generate-cs.txt
sed "s/$/\"\/>/g" -i generate-cs.txt
sed "/AssemblyInfo.cs/d" -i generate-cs.txt
sed "/<ItemGroup>/r generate-cs.txt" -i uhttpsharp.csproj
sed "/.*obj.*/d" -i uhttpsharp.csproj
sed "/.*bin.*/d" -i uhttpsharp.csproj
rm generate-cs.txt
