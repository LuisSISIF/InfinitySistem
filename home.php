<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="global-sistema.css">
    <link rel="stylesheet" href="style-home.css">
    
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <main class="page">
        <div class="container">
            <aside class="lat">
                <div class="logo-sistem">
                    <img src="./images/logo.png" alt="">
                </div>
                <div class="menu-lat">

                    <div class="itens-lat">
                        <img src="./icones/real.png" alt="">
                        <button class="btn-lat">Vender</button>
                    </div>

                    <div class="itens-lat">
                        <img src="./icones/equipe.png" alt="">
                        <button class="btn-lat">Funcionários</button>
                    </div>

                    <div class="itens-lat">
                        <img src="./icones/armazem.png" alt="">
                        <button class="btn-lat">Estoque</button>
                    </div>

                    <div class="itens-lat">
                        <img src="./icones/account config.png" alt="">
                        <a href="./account.php"><button class="btn-lat">Conta</button></a>
                    </div>

                    <div class="itens-lat">
                        <img src="./icones/relatorio.png" alt="">
                        <button class="btn-lat">Relatórios</button>
                    </div>

                    <div class="itens-lat">
                        <button class="btn-lat">Teste</button>
                    </div>
                    <div class="itens-lat">
                        <button class="btn-lat">Teste</button>
                    </div>
                    <div class="itens-lat">
                        <button class="btn-lat">Teste</button>
                    </div>
                    <div class="itens-lat">
                        <button class="btn-lat">Teste</button>
                    </div>
                    <div class="itens-lat">
                        <button class="btn-lat">Teste</button>
                    </div>
                    <div class="itens-lat">
                        <button class="btn-lat">Teste</button>
                    </div>
                </div>
                <div class="logout">
                    <img src="./icones/logout.png" alt="">
                    <button class="btn-logout" id="sair" onclick="logout()">Sair</button>
                </div>

                <div class="inform">
                    <?= 
                    date('d/m/Y');?>
                </div>

            </aside>

        </div>
        <script src=./functions.js></script>
    </main>
</body>
</html>