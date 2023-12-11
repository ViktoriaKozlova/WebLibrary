async function displayUsers() {
  let users = await getUser();

  let usersTable = document.getElementById("getUser");

  for (let user of users) {
    const { iduser, fullName, email, login, password, bithday } = user;

    const row = document.createElement("tr");
    const iduserEl = document.createElement("td");
    const fullNameEl = document.createElement("td");
    const emailEl = document.createElement("td");
    const loginEl = document.createElement("td");
    const passwordEl = document.createElement("td");
    const bithdayEl = document.createElement("td");

    iduserEl.classList.add("user-element");
    fullNameEl.classList.add("user-element");
    emailEl.classList.add("user-element");
    loginEl.classList.add("user-element");
    passwordEl.classList.add("user-element");
    bithdayEl.classList.add("user-element");

    iduserEl.innerText = iduser;
    fullNameEl.innerText = fullName;
    emailEl.innerText = email;
    loginEl.innerText = login;
    passwordEl.innerText = password;
    bithdayEl.innerText = bithday;

    row.append(iduserEl, fullNameEl, emailEl, loginEl, passwordEl, bithdayEl);

    usersTable.append(row);
  }
}
displayUsers();
