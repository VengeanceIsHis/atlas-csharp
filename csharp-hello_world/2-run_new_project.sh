#/bin/bash
PROJECT_DIR="2-new_project"

if [ ! -d "$PROJECT_DIR" ]; then
    mkdir "$PROJECT_DIR"
fi
cd "$PROJECT_DIR"

dotnet new console -o .

dotnet restore

dotnet build

dotnet run