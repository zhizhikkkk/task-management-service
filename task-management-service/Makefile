
PROJECT_NAME=task-management-service

up:
	docker-compose up -d

down:
	docker-compose down

build:
	docker-compose build

migrate:
	docker-compose run --rm api dotnet ef database update --project DataAccess --startup-project task-management-service

migrate-add:
	docker-compose run --rm api dotnet ef migrations add $(name) --project DataAccess --startup-project task-management-service

publish:
	git add .
	git commit -m "Deploy project"
	git push origin main

clean:
	docker system prune -f

all: build up migrate
