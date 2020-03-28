#!/bin/sh
find ../../CachedQuickLz/CachedQuickLz -iname *.cs > generate-cs.txt
sed "/.*Compile Include.*/d" -i CachedQuickLz.csproj
sed "s/^/    <Compile Include=\"/g" -i generate-cs.txt
sed "s/$/\"\/>/g" -i generate-cs.txt
sed "/<ItemGroup>/r generate-cs.txt" -i CachedQuickLz.csproj
rm generate-cs.txt
