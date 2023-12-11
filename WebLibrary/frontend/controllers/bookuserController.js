async function displayBookUserIssued() {
  let books = await getBookIssued();

  let booksTable = document.getElementById("getBookIssued");

  for (let book of books) {
    const { dateStart, dateEnd, bookIdbook, statusIdstatus } = book;
    const row = document.createElement("tr");
    const dateStartEl = document.createElement("td");
    const dateEndEl = document.createElement("td");

    const bookIdbookEl = document.createElement("td");
    const statusIdstatusEl = document.createElement("td");

    dateStartEl.classList.add("bookissued-element");
    dateEndEl.classList.add("bookissued-element");

    bookIdbookEl.classList.add("bookissued-element");
    statusIdstatusEl.classList.add("bookissued-element");

    dateStartEl.innerText = dateStart;
    dateEndEl.innerText = dateEnd;

    bookIdbookEl.innerText = bookIdbook;
    statusIdstatusEl.innerText = statusIdstatus;

    row.append(
      dateStartEl,
      dateEndEl,

      bookIdbookEl,
      statusIdstatusEl
    );

    booksTable.append(row);
  }
}
async function displayBookUserReserv() {
  let books = await getBookReserv();

  let booksTable = document.getElementById("getBookReserv");

  for (let book of books) {
    const { dateReserv, dateEndReserv, use, bookIdbook, statusIdstatus } = book;
    const row = document.createElement("tr");
    const dateReservEl = document.createElement("td");
    const dateEndReservEl = document.createElement("td");
    const useEl = document.createElement("td");
    const bookIdbookEl = document.createElement("td");
    const statusIdstatusEl = document.createElement("td");

    dateReservEl.classList.add("bookreserv-element");
    dateEndReservEl.classList.add("bookreserv-element");
    useEl.classList.add("bookreserv-element");
    bookIdbookEl.classList.add("bookreserv-element");
    statusIdstatusEl.classList.add("bookreserv-element");

    dateReservEl.innerText = dateReserv;
    dateEndReservEl.innerText = dateEndReserv;
    useEl.innerText = use;
    bookIdbookEl.innerText = bookIdbook;
    statusIdstatusEl.innerText = statusIdstatus;

    row.append(
      dateReservEl,
      dateEndReservEl,
      useEl,
      bookIdbookEl,
      statusIdstatusEl
    );

    booksTable.append(row);
  }
}

displayBookUserIssued();
displayBookUserReserv();
