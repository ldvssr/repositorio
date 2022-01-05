// A importar o módulo de express.
const express = require ('express');
// A criar uma aplicação de express depois da framework ser importada.
const app = express ();
const mongoose = require('mongoose');
// Quando um utilizador for à página principal vai receber uma resposta em texto a dizer que está na página principal.

const postRoute = require ('./routes/posts');

app.use ('/posts', postRoute);

// Métodos: GET, POST, DELETE, PATCH
app.get ('/', (req, res) =>
{    
    res.send("Olá, esta é a página principal.");
});

mongoose.connect('mongodb+srv://licinio:batatas1234@cluster0.mfp3e.mongodb.net/myFirstDatabase?retryWrites=true&w=majority',{useNewUrlParser:true}, () => 
{
    console.log("Conectado à DB");
})

// Servidor agora está a escutar pedidos na porta 3000.
app.listen(3000);

