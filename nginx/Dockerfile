# Usamos la imagen base de nginx:alpine
FROM nginx:alpine

# Copiamos el archivo de configuración de nginx al contenedor
COPY nginx.conf /etc/nginx/conf.d/default.conf
# Exponemos el puerto 8080 del contenedor
EXPOSE 8080

# Comando para iniciar nginx en primer plano
CMD ["nginx", "-g", "daemon off;"]
