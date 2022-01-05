const express = require ('express');
const router = express.Router();

router.get('/', (req, res) => {
    res.send("Estou nos posts");
})

router.get('/recent', (req, res) => {
    res.send("Estou nos posts recentes");
})

module.exports = router;