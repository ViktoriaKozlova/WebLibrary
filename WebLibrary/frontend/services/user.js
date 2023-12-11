async function getUser() {
  const response = await fetch("http://localhost:5263/api/ServiceUser", {
    method: "GET",
  });
  const resulf = await response.json();
  console.log(resulf);
  return resulf;
}
