function validEmail(email) {
    const isValid = email.value.match(
        /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    );
    if (isValid) {
        document.getElementById("mailMessage").innerHTML = "";
    }
    else {
        document.getElementById("mailMessage").innerHTML = "<font color='red'>Email inválido </font>";
    }
}