
# Screencast
Projects and real navigation on videos `Planning/...mp4`.

## Cynet - BackEnd / Sql / Docker
https://www.loom.com/share/991a6064e36f41e0ab2d557855901292

## Cynet - FrontEnd / XHR / Sql
https://www.loom.com/share/4cd3e9ad7bd0426c8f79ef5a49592091

# User Interface & Experience
There's some screenshot from pages in React TS / HTML / CSS.
`Planning/uix` from 01 to 04....jpg

# Design & Architecture

## Interface
Base contracts to be injectable and organize code.
`Planning/design/01-Interface.png`

## Entity
Concrete objects that communicates with database, api requests and internal process.
`Planning/design/02-Entity.png`

## Provider
Infrastructure to support extra features inside whole project.
`Planning/design/03-Provider.png`

## Service
Business rules that will be injected on controllers and used on tests.
`Planning/design/04-Service.png`

## Controller
API main manager, based on request/request in our API project.
`Planning/design/05-Controller.png`

# Test (NUnit Project) BackEndTest
Couple scenarios to keep our API project consistent during the development lifecycle.

# Postman (Settings)
Endpoint collections in `Planning/cynet.postman.collection.json`

# ASP.Net Core (Docker) BackEnd

## Go to the project folder
BackEnd folder (.Net API Project)

## Run in CMD/BASH/PS to create an image
docker image build -t cynet-backend:1.0 .

# Run below to create a container
docker run -d -p 5000:5000 cynet-backend:1.0

# Open Swagger on your browser
http://localhost:5000/swagger/index.html