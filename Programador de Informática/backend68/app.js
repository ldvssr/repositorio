// A importar o módulo de express.
const express = require ('express');
// A criar uma aplicação de express depois da framework ser importada.
const app = express ();

// Quando um utilizador for à página principal vai receber uma resposta em texto a dizer que está na página principal.
app.get ('/', (req, res) =>
{    
    res.send("Olá, esta é a página principal.");
}
);

app.get ('/gelados', (req, res) =>
{    
    res.send(" 🤣😂 Olá, esta é a página dos gelados do igor.");
}
);

// Servidor agora está a escutar pedidos na porta 3000.
app.listen(3000);

