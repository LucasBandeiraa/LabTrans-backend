### Advanced Configuration
É Necessário criar um banco SQL Server e alterar a string de conexão que fica no arquivo appsettings.json a variavel ConnectionStrings.DB_Kognit com as credencias do banco

Por questão de ambiente não foi possível criar um ambiente docker.

### Migrations

Rodar os comandos para criar as Migrations e Atualizar o Banco

ADD-MIGRATION `NOME DA MIGRATION`
UPDATE-DATABASE (para atualizar o banco de dados com as tabelas)


