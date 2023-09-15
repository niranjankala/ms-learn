const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:56466';
// Refer these 
// https://angular.io/guide/build#proxying-to-a-backend-server
// https://medium.com/ngconf/how-to-proxy-http-requests-in-angular-f873183880a4
const PROXY_CONFIG = [
  {
  //   context: [
  //     "/weatherforecast",
  //     // "/api/books/GetBooks",
  //     // "/api/books/AddBook/",
  //     // "/api/books/UpdateBook/",
  //     // "/api/books/DeleteBook/",
  //     // "/api/books/SingleBook/"      
  //  ],
  context: ['/api/**'],
    proxyTimeout: 10000,
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  }
]

module.exports = PROXY_CONFIG;
