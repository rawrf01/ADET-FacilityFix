
function toggleIcon(input) {
  const icon = input.closest('.position-relative').querySelector('.icon-inside');
  if (input.value.trim() !== "") {
    icon.style.opacity = "0";
  } else {
    icon.style.opacity = "1";
  }
}