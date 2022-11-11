<?php

function novaConexao($banco = 'teste') {
    $servidor = '127.0.0.1';
    $usuario = 'root';
    $senha =  '';

    $conexao = new mysqli($servidor, $usuario, $senha,$banco)
     
    if($conexao->conect_error) {
        die('Erro: '.$conexao->conect_error);
    }
    return $conexao;
}