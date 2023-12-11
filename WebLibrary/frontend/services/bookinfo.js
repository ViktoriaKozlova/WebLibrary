async function getBooks() {
  const response = await fetch("http://localhost:5263/api/ServiceBook", {
    method: "GET",
  });
  const resulf = await response.json();
  console.log(resulf);
  return resulf;
}

async function getBookinfofilter(filter) {
  const response = await fetch(
    "http://localhost:5263/api/ServiceBook/getActive?" +
      new URLSearchParams(filter),
    {
      method: "GET",
    }
  );
  const resulf = await response.json();
  console.log(resulf);
  return resulf;
}
function setupCheckboxHandlers() {
  const checkboxes = document.querySelectorAll("input[type='checkbox']");
  checkboxes.forEach((cb) => {
    cb.onchange = checkboxOnchange;
  });
}

function checkboxOnchange(event) {
  const filterName = event.target.name;
  const checboxId = event.target.id;

  const checkboxes = document.querySelectorAll(
    `input[type='checkbox'][name='${filterName}']`
  );
  checkboxes.forEach((cb) => {
    if (cb.id !== checboxId) {
      cb.checked = false;
    }
  });
}

function setupFormSubmit() {
  const form = document.querySelector("#filter");
  form.onsubmit = async function (event) {
    event.preventDefault();
    const formData = new FormData(event.target);
    const filter = Object.fromEntries(formData);

    // const result = await getViewSpa(filter);
    displayBookinfos(filter);
    // console.log(filter, result);
  };
}

setupCheckboxHandlers();
setupFormSubmit();
