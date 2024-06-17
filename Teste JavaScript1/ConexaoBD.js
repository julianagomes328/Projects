const mysql = require('mysql2/promise');

const connection = await mysql.createConnection({
  host: 'localhost',
  user: 'root',
  password: 'Juju@1234567',
  database: 'teste'
});

const [rows, fields] = await connection.execute('INSERT INTO cadastro_usuario (USUARIO,NOME_COMPLETO, EMAIL, SENHA) VALUES (?, ?, ?)', [usuario,nome, email, senha]);
