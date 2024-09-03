#!/usr/bin/env bash
PROJECT_DIR="0-new_project"

if [ ! -d "$PROJECT_DIR" ]; then
    mkdir "$PROJECT_DIR"
fi
cd "$PROJECT_DIR"

dotnet new console -o .