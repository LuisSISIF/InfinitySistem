<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="global-sistema.css">
    <link rel="stylesheet" href="style-account.css">
    
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
                        <button tip class="btn-lat">Conta</button>
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
            

        <div class="card_user">
            <div class="divinf">
                <div class="foto">
                    <img src="./images/eu.jpg">
                </div>
                <div class="txtinf">
                    <h3>nome do usuário</h3>
                    <span>Função do Usuário</span>
                </div>
            </div>
                <ul class="menuinf_user">
                <li>
                    <a href="#basicinform"><img src="./icones/user.png">Informações Básicas</a>
                </li>
                <li>
                    <a href="#username_section"><img src="./icones/arroba.png">Nome de Usuário</a>
                </li>
                <li>
                    <a href="#password_section"><img src="./icones/password.png">Senha</a>
                </li>
                <li>
                    <a href="#delete_section"><img src="./icones/delete.png">Deletar Conta</a>
                </li>
                </ul>
         </div>

         <div class="colunform">
            <form class="validate">
                <div class="basicinformation" id="basicinform">
                    <div class="sectitle">
                        <h3>Informações Básicas</h3>
                    </div>
                    <div class="card_body">
                        <div class="rowcamp">
                            <div class="nomecamp">
                                <label for="fullname" >Nome Completo:</label>
                            </div>
                            <div>
                                <input type="text" class="inputcamp" id="fullname">
                            </div>
                        </div>

                        <div class="rowcamp">
                            <div class="nomecamp">
                                <label for="fullname" >Telefone:</label>
                            </div>
                            <div>
                                <input type="text" class="inputcamp" id="telefone">
                            </div>
                        </div>

                        <div class="rowcamp">
                            <div class="nomecamp">
                                <label for="fullname" >Email:</label>
                            </div>
                            <div>
                                <input type="text" class="inputcamp" id="email">
                            </div>
                        </div>

                        <div class="rowcamp">
                            <div class="nomecamp">
                                <label for="fullname" >Localização:</label>
                            </div>
                            <div>
                                <input type="text" class="inputcamp" id="estado" placeholder="Estado">
                            </div>
                            <div>
                                <input type="text" class="inputcamp" id="cidade" placeholder="Cidade">
                            </div>
                            
                        </div>

                        <div class="rowcamp">
                            <div class="nomecamp">
                                <label for="fullname" >Endereço:</label>
                            </div>
                            <div>
                                <input type="text" class="inputcamp" id="endereco">
                            </div>
                        </div>

                        <div class="rowcamp">
                            <div class="nomecamp">
                                <label for="fullname" >Codigo Postal:</label>
                            </div>
                            <div>
                                <input type="text" class="inputcamp" id="cep">
                            </div>
                        </div>

                        <div class="rowcamp">
                            <div class="nomecamp">
                                <label for="fullname" >Visão Geral:</label>
                            </div>
                            <div>
                                <textarea style="resize: none" class="txtcamp" id="email"></textarea>
                            </div>
                        </div>

                        <div class="submit">
                            <button type="button" class="submitForm">Salvar</button>
                        </div>
                    </div>
                </div>
            </form>
        </div>

        <div class="colunform">
            <form class="validate">
                <div class="basicinformation" id="username">
                    <div class="sectitle">
                        <h3>Nome de Usuário</h3>
                    </div>
                    <div class="submit">
                        <button type="button" class="submitForm">Salvar</button>
                    </div>
                </div>
            </form>
        </div>

        <div class="colunform">
            <form class="validate">
                <div class="basicinformation" id="password">
                    <div class="sectitle">
                        <h3>Senha</h3>
                    </div>
                    <div class="submit">
                        <button type="button" class="submitForm">Salvar</button>
                    </div>
                </div>
            </form>
        </div>

        <div class="colunform">
            <form class="validate">
                <div class="basicinformation" id="delete-account">
                    <div class="sectitle">
                        <h3>Deletar Conta</h3>
                    </div>
                    <div class="submit">
                        <button type="button" class="submitForm-red">Deletar Conta</button>
                    </div>
                </div>
            </form>
        </div>

        
        <!-- fim da conteiner no div a baixo -->
        </div>
        <script src=./functions.js></script>
    </main>
</body>
</html>