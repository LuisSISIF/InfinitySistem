/* Função Validar */
function validar_login() {
    // pegando o valor do nome pelos names
    var login = document.getElementById("login");
    var senha = document.getElementById("senha");


    // verificar se o nome está vazio
    if (login.value == "") {
      alert("Por favor Insira seu Login!");

      // Deixa o input com o focus
      login.focus();
      // retorna a função e não olha as outras linhas
      return;
    }
    if (senha.value == "") {
        alert("Por favor Insira sua senha!");
        senha.focus();
        return;
      }
     
      alert("Bem vindo "+login.value);
      window.location.href = "./home.php";
  }

function validar_lembrar() {
  var login = document.getElementById("login");
  var email = document.getElementById("email");

  if (login.value == "") {
    alert("Por favor Insira seu Login!");
    login.focus();
    return;
  }
  if (email.value == "") {
    alert("E-mail não informado");
    email.focus();
    return;
  }
  alert("Esta função está em desenvolvimento!\nPorém se está vendo essa mensagem significa que seus dados foram validados.\nVocê será redirecionado para página inicial de login!!!")
  window.location.href = "./login-page.php";
}
 //Função Sair do sistema
function logout()
{
var x;
var r=confirm("Realmente quer sair?");
if (r==true)
  {
  x=window.location.href = "./login-page.php";
  }
else
  {
  }
document.getElementById("demo").innerHTML=x;
}
