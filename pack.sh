#!/bin/sh

xbuild /t:Build /p:Configuration=Release
nuget pack CopyWith/CopyWith.csproj.nuspec