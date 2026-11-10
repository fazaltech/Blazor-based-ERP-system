document.addEventListener("DOMContentLoaded", () => {
    const form = document.getElementById("login-form");
    const toggle = document.getElementById("show-password");
    const password = document.getElementById("password");
    toggle?.addEventListener("change", () => { password.type = toggle.checked ? "text" : "password"; });
    form?.addEventListener("submit", () => {
        const button = form.querySelector("button[type=submit]");
        button.disabled = true;
        button.textContent = "Signing in…";
    });
});
