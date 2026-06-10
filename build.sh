#!/bin/bash
set -e

# 1. Задаем переменные окружения, если они еще не заданы
export DOTNET_ROOT=${DOTNET_ROOT:-$HOME/.dotnet}
export PATH=$PATH:$DOTNET_ROOT:$DOTNET_ROOT/tools

# 2. Устанавливаем и восстанавливаем необходимые рабочие нагрузки MAUI
echo "Installing MAUI Android workloads..."
dotnet workload install maui-android

echo "Restoring project workloads..."
dotnet workload restore Score-of-Ratings.csproj

# 3. Запускаем чистую публикацию релиза
echo "Building and publishing APK..."
dotnet publish Score-of-Ratings.csproj -c Release -f net10.0-android /p:AndroidCreatePackagePerAbi=false

echo "Build successful!"
