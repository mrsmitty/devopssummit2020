FROM node:12.7-alpine AS build
WORKDIR /app
COPY package.json /app/package.json
RUN npm install
COPY . /app
RUN npm run release

FROM nginx:1.16.0-alpine
COPY --from=build /app/dist/devops-summit /usr/share/nginx/html
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]