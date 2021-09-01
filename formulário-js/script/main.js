document.getElementById("submit_button").addEventListener("click", () => {
    var nameInput = document.getElementById("name");
    var lastNameInput = document.getElementById("last_name");
    var passwordInput = document.getElementById("password");
    var confirmPasswordInput = document.getElementById("confirm_password");

    if (nameInput.value === "") {
        nameInput.focus();
        window.alert("Informe seu nome!");
    }

    if (lastNameInput.value === "") {
        lastNameInput.focus();
        window.alert("Informe seu sobrenome!");
    }

    if (passwordInput.value === "") {
        passwordInput.focus();
        window.alert("Informe sua senha!");
    }

    if (confirmPasswordInput.value === "") {
        confirmPasswordInput.focus();
        window.alert("Confirme sua senha!");
    }
});