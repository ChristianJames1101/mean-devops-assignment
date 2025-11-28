# STEP 1: Build Angular app
FROM node:18 AS builder
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
RUN npm run build

# STEP 2: Serve using Nginx
FROM nginx:alpine

# Delete default nginx website
RUN rm -rf /usr/share/nginx/html/*

# Copy correct Angular build output folder
COPY --from=builder /app/dist/angular-15-crud/ /usr/share/nginx/html/

# Expose port
EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]
