#!/bin/sh
find ../../LunaConfigNode/LunaConfigNode -iname "*.cs" > generate-cs.txt
sed "/.*Compile Include.*/d" -i LunaConfigNode.csproj
sed "s/^/    <Compile Include=\"/g" -i generate-cs.txt
sed "s/$/\"\/>/g" -i generate-cs.txt
sed "/<ItemGroup>/r generate-cs.txt" -i LunaConfigNode.csproj
sed "/.*VesselImplementation.cs.*/d" -i LunaConfigNode.csproj
#echo "using LunaConfigNode.CfgNode;" > VesselImplementation.cs
#cat ../../LunaConfigNode/LunaConfigNode/VesselImplementation.cs >> VesselImplementation.cs
rm generate-cs.txt
