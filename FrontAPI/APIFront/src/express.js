﻿loginPicture.addEventListener('click', () => {
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

switchButton.addEventListener('change', () => {
    if (switchButton.checked) {
        console.log('hola')
        sedientoPrice.innerHTML = '$200'
        refrescadoPrice.innerHTML = '$400'
        hidratadoPrice.innerHTML = '$600'
        labelPlanS.innerHTML = 'Anual'
        labelPlanR.innerHTML = 'Anual'
        labelPlanH.innerHTML = 'Anual'
    } else {
        sedientoPrice.innerHTML = '$10'
        refrescadoPrice.innerHTML = '$12'
        hidratadoPrice.innerHTML = '$15'
        labelPlanS.innerHTML = 'Mensual'
        labelPlanR.innerHTML = 'Mensual'
        labelPlanH.innerHTML = 'Mensual'
    }
})


btnSediento.addEventListener('click', (event) => {
    event.preventDefault();
    paymentSection.style.display = 'grid';

    if (switchButton.checked) {
        console.log('puto')
        location.hash = `?PLAN-4=${sedientoPrice.textContent}=Sediento-Anual`
        const [id, price, name] = location.hash.split('=')
        paymentInfo.innerHTML = `<strong>Plan:</strong> ${name} <br><strong>Precio:</strong> ${price}`
    } else {
        location.hash = `?PLAN-1=${sedientoPrice.textContent}=Sediento-Mensual`
        const [id, price, name] = location.hash.split('=')
        paymentInfo.innerHTML = `<strong>Plan:</strong> ${name} <br><strong>Precio:</strong> ${price}`
    }

    layoutSection.style.display = 'none';
    planSection.style.display = 'none';
})


btnRefrescado.addEventListener('click', (event) => {
    event.preventDefault();
    paymentSection.style.display = 'grid';

    if (switchButton.checked) {
        location.hash = `?PLAN-5=${refrescadoPrice.textContent}=Refrescado-Anual`
        const [id, price, name] = location.hash.split('=')
        paymentInfo.innerHTML = `<strong>Plan:</strong> ${name} <br><strong>Precio:</strong> ${price}`
    } else {
        location.hash = `?PLAN-2=${refrescadoPrice.textContent}=Refrescado-Mensual`
        const [id, price, name] = location.hash.split('=')
        paymentInfo.innerHTML = `<strong>Plan:</strong> ${name} <br><strong>Precio:</strong> ${price}`
    }

    layoutSection.style.display = 'none';
    planSection.style.display = 'none';
})

btnHidratado.addEventListener('click', (event) => {
    event.preventDefault();
    paymentSection.style.display = 'grid';

    if (switchButton.checked) {
        location.hash = `?PLAN-6=${hidratadoPrice.textContent}=Hidratado-Anual`
        const [id, price, name] = location.hash.split('=')
        paymentInfo.innerHTML = `<strong>Plan:</strong> ${name} <br><strong>Precio:</strong> ${price}`
    } else {
        location.hash = `?PLAN-3=${hidratadoPrice.textContent}=Hidratado-Mensual`
        const [id, price, name] = location.hash.split('=')
        paymentInfo.innerHTML = `<strong>Plan:</strong> ${name} <br><strong>Precio:</strong> ${price}`
    }

    layoutSection.style.display = 'none';
    planSection.style.display = 'none';
})

navTwoLogo.addEventListener('click', () => {
    paymentSection.style.display = 'none';
    layoutSection.style.display = 'flex'
    planSection.style.display ='flex'

    location.hash = ''

})

window.addEventListener('load', () => {
    location.hash = ''
    paymentSection.style.display = 'none'
})
