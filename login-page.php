<!DOCTYPE html>
<html lang="pt-br">
  <head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="style-login-page.css" />
    <link rel="stylesheet" href="global.css" />
    <title>InfinitySoft</title>
    <link rel="icon" type="image/png" href="logo.png" />
  </head>

  <body>
    <main class="page">
      <div class="content">
        <div id="div-logo">
          <a href="./index.html" id="back">
            <img src="images/logo.png" />
          </a>
        </div>
        <form class="inputsForm" action="" method="post" name="formulario">
          <div class="inputForm">
            <img src="./icones/user.png" alt="" />
            <input type="text" id="login" placeholder="Usuário"/>
          </div>
          <div class="inputForm">
            <img src="./icones/password.png" alt="" />
            <input type="password" id="senha" placeholder="Senha"/>
          </div>
          <div class="forgetSubmit">
            <a href="recuperar-senha.php" id="forget">Esqueci a Senha</a>
            <button type="button" class="submitForm" onclick="validar_login()">
              Entrar
            </button>
          </div>
        </form>
      </div>
      <script src="./functions.js"></script>
    </main>

  </body>
</html>
