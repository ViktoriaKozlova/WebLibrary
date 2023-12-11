async function getBook() {
  const response = await fetch("http://localhost:5263/api/ViewBookIssued", {
    method: "GET",
  });
  const resulf = await response.json();
  console.log(resulf);
  return resulf;
}

async function getBook1() {
  const response = await fetch(
    "http://localhost:5263/api/ViewBookReservation",
    {
      method: "GET",
    }
  );
  const resulf = await response.json();
  console.log(resulf);
  return resulf;
}
