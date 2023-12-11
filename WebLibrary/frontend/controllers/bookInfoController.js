async function displayBooks() {
  let books = await getBooks();

  let booksTable = document.getElementById("getBookinfos");

  for (let book of books) {
    const { name, language, page, count } = book;
    const row = document.createElement("tr");
    const nameEl = document.createElement("td");
    const languageEl = document.createElement("td");
    const pageEl = document.createElement("td");
    const countEl = document.createElement("td");

    nameEl.classList.add("bookinfo1-element");
    languageEl.classList.add("bookinfo1-element");
    pageEl.classList.add("bookinfo1-element");
    countEl.classList.add("bookinfo1-element");

    nameEl.innerText = name;
    languageEl.innerText = language;
    pageEl.innerText = page;
    countEl.innerText = count;

    row.append(nameEl, languageEl, pageEl, countEl);

    booksTable.append(row);
  }
}

async function displayBookinfos(filter) {
  let books = await getBookinfofilter(filter);

  let booksTable = document.getElementById("getBookinfos");

  for (let book of books) {
    const { name, language, page, count } = book;
    const row = document.createElement("tr");
    const nameEl = document.createElement("td");
    const languageEl = document.createElement("td");
    const pageEl = document.createElement("td");
    const countEl = document.createElement("td");

    nameEl.classList.add("bookinfo1-element");
    languageEl.classList.add("bookinfo1-element");
    pageEl.classList.add("bookinfo1-element");
    countEl.classList.add("bookinfo1-element");

    nameEl.innerText = name;
    languageEl.innerText = language;
    pageEl.innerText = page;
    countEl.innerText = count;

    row.append(nameEl, languageEl, pageEl, countEl);

    booksTable.append(row);
  }
}
// displayBooks();
displayBookinfos(filter);
