# HotChocolateDemo
Small demo for Hot Chocolate with GraphQL
## Run Locally
How to set up your machine locally

### Docker Setup
Run to start:

`docker-compose up -d`

Note: Will download the image if its the first time

Run to end:

`docker-compose down`

or

`docker-compose stop`

## Entity Framework Code First

### Update EF Global Tool
to udpate the EF tool itself:

`dotnet tool update --global dotnet-ef`

### Add Migration

`dotnet ef migrations add AddPlatformToDb`

### Update db
to apply update:

`dotnet ef database update`

## GraphQL

