<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style-redefinir.css" />
    <link rel="stylesheet" href="global.css" />
    <title>InfinitySoft - Redefinir Senha</title>
    <link rel="icon" type="image/png" href="logo.png" />
</head>

<body>
    <main class="page">
        <div class="content">
            <div class="title-page">
                <label><h1>Redefinição de Senha: </h1></label>
            </div>
            <form class="inputsForm">
                <div class="inputForm">
                    <img src="./icones/user.png" alt="" />
                    <input type="text" id="login" placeholder="Usuário" />
                </div>

                <div class="inputForm">
                    <img src="./icones/email.png" alt="" />
                    <input type="email" id="email" placeholder="Email" />
                </div>

                <div class="forgetSubmit">
                    <a href="login-page.php" id="forget">Voltar</a>
                    <button type="button" class="submitForm" onclick="validar_lembrar()">Recuperar</div>
                </div>
                
            </form>
        </div>
        <script src="./functions.js"></script>
    </main>
</body>

</html>