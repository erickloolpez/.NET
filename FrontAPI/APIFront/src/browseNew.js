loginPicture.addEventListener('click', () => {
    layoutSection.style.display = 'none';
    planSection.style.display = 'none';
    asideSection.style.display = 'grid';
    planTable.classList.add('active-table');
    suscripcionTable.classList.add('active-table');
    historialTable.classList.add('active-table');
    facturaTable.classList.add('active-table');
})

/*display the tables of each control*/
clienteBtn.addEventListener('click', () => {
    clienteTable.classList.remove('active-table');
    planTable.classList.add('active-table');
    suscripcionTable.classList.add('active-table');
    historialTable.classList.add('active-table');
    facturaTable.classList.add('active-table');
})

planBtn.addEventListener('click', () => {
    planTable.classList.remove('active-table');
    clienteTable.classList.add('active-table');
    suscripcionTable.classList.add('active-table');
    historialTable.classList.add('active-table');
    facturaTable.classList.add('active-table');
})

suscripcionBtn.addEventListener('click', () => {
    suscripcionTable.classList.remove('active-table');
    clienteTable.classList.add('active-table');
    planTable.classList.add('active-table');
    historialTable.classList.add('active-table');
    facturaTable.classList.add('active-table');
})

historialBtn.addEventListener('click', () => {
    historialTable.classList.remove('active-table');
    clienteTable.classList.add('active-table');
    planTable.classList.add('active-table');
    suscripcionTable.classList.add('active-table');
    facturaTable.classList.add('active-table');
})

facturaBtn.addEventListener('click', () => {
    facturaTable.classList.remove('active-table');
    historialTable.classList.add('active-table');
    clienteTable.classList.add('active-table');
    planTable.classList.add('active-table');
    suscripcionTable.classList.add('active-table');

})
