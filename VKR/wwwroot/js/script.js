function OpenNewTab(pdfName) {
    window.open('/files/' + pdfName);
}
window.clickElementById = (id) => {
    document.getElementById(id).click();
};