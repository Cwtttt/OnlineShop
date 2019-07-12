﻿var app = new Vue({
    el: '#app',
    data: {
        loading: false,
        products: []
    },
    methods: {
        getProducts() {
            this.loading = true;
            axios.get('/Admin/products')
                .then(res => {
                    console.log(res);
                    this.products = res.data;
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        }
    },
    computed: {
        formatPrice: function() {
            return "TEST " + this.price;
        }
    }
});