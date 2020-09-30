'use strict'

const apiClient = require('axios').create({
    baseURL: 'https://apidatav1.ecare.collicare.com/api/collidata/1.0',
    params: {
        key: 'REPLACE_ME',
    }
});

async function runExamples() {
    await listBookings();

    await listInvoices();

    await listClaims();
}

async function listBookings() {
    let { data } = await apiClient.get('/bookings', {
        // Optional query string parameters. See http://apidatav1.ecare.collicare.com/swagger-ui for more.
        params: {
            page: 1,
            size: 10,
            sort: 'order_date:desc'
        }
    });

    let bookings = data.data;

    console.log(`Got ${bookings.length} bookings`);
    console.log('First booking', bookings[0]);
}

async function listInvoices() {
    let { data } = await apiClient.get('/invoices');

    let invoices = data.data;

    console.log(`Got ${invoices.length} invoices`);
    console.log('First invoice', invoices[0]);
}

async function listClaims() {
    let { data } = await apiClient.get('/claims');

    let claims = data.data;

    console.log(`Got ${claims.length} claims`);
    console.log('First claim', claims[0]);
}


runExamples().catch(err => {
    console.error('ERROR!', err.message);
    process.exit(1);
});