const Sequelize = require('sequelize')
const sequelize = new Sequelize('teste','GOMES','Juju@1234567',
{
    Host:"localhost",
    dialect :'mysql'
}


)
sequelize.autenticate().then(Function()

{
    console.console.log("Conectado com sucesso")
}
).cath(function(erro)
{

    console.log("Falha")
}

   
)


