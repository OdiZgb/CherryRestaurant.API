#!/bin/bash

# Function to start the .NET API project
start_api() {
    cd "C:\Users\odizg\OneDrive\Desktop\Projects\CherryRestaurant\CherryRestaurant.API"
    dotnet run
}

# Function to start the Angular client project
start_client() {
    cd "C:\Users\odizg\OneDrive\Desktop\Projects\CherryRestaurant\CherryRestaurant-Client"
    ng serve
}

# Start both projects in parallel
start_api & 
start_client &

# Wait for both processes to complete
wait