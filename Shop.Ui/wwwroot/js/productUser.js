var app = new Vue({
    el: '#app',
    data: {
        orderingQty: null,
        stockModel: {
            id: null,
            productId: null,
            description: null,
            qty: null
        },
        message: "asdasd",
        stockId: null
    },
    watch: {
        stockId: function () {
            this.getStock();
        }
    },
    methods: {
        getStock() {
            axios.get('/stocks/' + this.stockId)
                .then(res => {
                    console.log(res.data);
                    var stock = res.data;
                    this.stockModel = {
                        id: stock.id,
                        productId: stock.productId,
                        description: stock.description,
                        qty: stock.qty
                    };
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                });
        }
    },
    computed: {
        quantityOk: function () {
            if (this.stockModel.qty > this.orderingQty) {
                return true;
            }
            else {
                return false;
            }
        }
    }
})
