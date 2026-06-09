#!/bin/bash
dotnet workload restore
dotnet publish -c Release -f net10.0-android -p:SignAndroidPackage=false
