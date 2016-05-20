#!/bin/sh

rm *.nupkg

xbuild /t:Build /p:Configuration=Release
nuget pack CopyWith/CopyWith.csproj.nuspec