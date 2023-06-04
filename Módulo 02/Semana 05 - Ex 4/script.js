
function validarFormulario(event) {
    event.preventDefault();  // evitar que a página seja recarregada

    var email = document.getElementById("email").value;
    var pwd = document.getElementById("pwd").value;
    var confirm_pwd = document.getElementById("confirm_pwd").value;

    // Verificar se o email tem um formato válido
    var emailRegex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/;
    if (!emailRegex.test(email)) {
        alert("Por favor, insira um email válido.");
        return;
    }

    // Verificar se a senha tem pelo menos 10 caracteres
    if (pwd.length < 10) {
        alert("A senha deve ter pelo menos 10 caracteres.");
        return;
    }

    // Verificar se as senhas correspondem
    if (pwd !== confirm_pwd) {
        alert("As senhas não correspondem.");
        return;
    }

    // Armazenar o usuário na sessionStorage e redirecionar para a página inicial
    sessionStorage.setItem("email", email);
    sessionStorage.setItem("pwd", pwd);

    window.location.href ="home.html";
}
function validarLogin(event) {
    event.preventDefault();  // evitar que a página seja recarregada

    var email = document.getElementById("email").value;
    var pwd = document.getElementById("pwd").value;

    // Pegar os dados do usuário do localStorage
    var storedEmail = sessionStorage.getItem("email");
    var storedPwd = sessionStorage.getItem("pwd");


    // Verificar se o email e a senha correspondem aos armazenados
    if (email === storedEmail && pwd === storedPwd) {
        // Se sim, redirecionar para a página inicial
        window.location.href = "home.html";
    } else {
        // Se não, exibir um alerta
        alert("Usuário não cadastrado ou informações inválidas.");
}
}


