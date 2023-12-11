async function displayBooks() {
  let books = await getBook();

  let booksTable = document.getElementById("getBook");

  for (let book of books) {
    const {
      nameBook,
      languageBook,
      pageBook,
      countBook,
      genreBook,
      autor,
      autorBithday,
      countIssuedBook,
    } = book;
    const row = document.createElement("tr");
    const nameBookEl = document.createElement("td");
    const languageBookEl = document.createElement("td");
    const pageBookEl = document.createElement("td");
    const countBookEl = document.createElement("td");
    const genreBookEl = document.createElement("td");
    const autorEl = document.createElement("td");
    const autorBithdayEl = document.createElement("td");
    const countIssuedBookEl = document.createElement("td");

    nameBookEl.classList.add("book-element");
    languageBookEl.classList.add("book-element");
    pageBookEl.classList.add("book-element");
    countBookEl.classList.add("book-element");
    genreBookEl.classList.add("book-element");
    autorEl.classList.add("book-element");
    autorBithdayEl.classList.add("book-element");
    countIssuedBookEl.classList.add("book-element");

    nameBookEl.innerText = nameBook;
    languageBookEl.innerText = languageBook;
    pageBookEl.innerText = pageBook;
    countBookEl.innerText = countBook;
    genreBookEl.innerText = genreBook;
    autorEl.innerText = autor;
    autorBithdayEl.innerText = autorBithday;
    countIssuedBookEl.innerText = countIssuedBook;

    row.append(
      nameBookEl,
      languageBookEl,
      pageBookEl,
      countBookEl,
      genreBookEl,
      autorEl,
      autorBithdayEl,
      countIssuedBookEl
    );

    booksTable.append(row);
  }
}

async function displayBooks1() {
  let books = await getBook1();

  let booksTable = document.getElementById("getBook1");

  for (let book of books) {
    const {
      nameBook,
      languageBook,
      pageBook,
      countBook,
      genreBook,
      autor,
      autorBithday,
      countReservationBook,
    } = book;
    const row = document.createElement("tr");
    const nameBookEl = document.createElement("td");
    const languageBookEl = document.createElement("td");
    const pageBookEl = document.createElement("td");
    const countBookEl = document.createElement("td");
    const genreBookEl = document.createElement("td");
    const autorEl = document.createElement("td");
    const autorBithdayEl = document.createElement("td");
    const countReservationBookEl = document.createElement("td");

    nameBookEl.classList.add("book1-element");
    languageBookEl.classList.add("book1-element");
    pageBookEl.classList.add("book1-element");
    countBookEl.classList.add("book1-element");
    genreBookEl.classList.add("book1-element");
    autorEl.classList.add("book1-element");
    autorBithdayEl.classList.add("book1-element");
    countReservationBookEl.classList.add("book1-element");

    nameBookEl.innerText = nameBook;
    languageBookEl.innerText = languageBook;
    pageBookEl.innerText = pageBook;
    countBookEl.innerText = countBook;
    genreBookEl.innerText = genreBook;
    autorEl.innerText = autor;
    autorBithdayEl.innerText = autorBithday;
    countReservationBookEl.innerText = countReservationBook;

    row.append(
      nameBookEl,
      languageBookEl,
      pageBookEl,
      countBookEl,
      genreBookEl,
      autorEl,
      autorBithdayEl,
      countReservationBookEl
    );

    booksTable.append(row);
  }
}
displayBooks();
displayBooks1();
