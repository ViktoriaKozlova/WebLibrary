async function getBookIssued() {
  const response = await fetch(
    "http://localhost:5263/api/ServiceIssued/getActive?UserIduser=1",
    {
      method: "GET",
    }
  );
  const resulf = await response.json();
  console.log(resulf);
  return resulf;
}

async function getBookReserv() {
  const response = await fetch(
    "http://localhost:5263/api/SeviceReservation/getActive?UserIduser=1",
    {
      method: "GET",
    }
  );
  const resulf = await response.json();
  console.log(resulf);
  return resulf;
}
